using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using TagLib;

using System.Windows.Forms;

namespace IceLibrarian
{
    [Serializable]
    public struct Library
    {
        public int version;

        public List<string> songfiles;
    }

    public class Song
    {
        private string name;
        private string artist;
        private string album;
        private string filename;

        public string Name { get { return name; } set { if (value == null) { name = "unknown"; } else { name = value; } } }
        public string Artist { get { return artist; } set { if (value == null) { artist = "unknown"; } else { artist = value; } } }
        public string Album { get { return album; } set { if (value == null) { album = "unknown"; } else { album = value; } } }

        public TimeSpan SongLength;
        public int TrackNum;

        public string FilePath;
        public string FullName;
        public string FileName
        {
            get { return filename; }
            set { if (name == "unknown") { filename = value; name = filename; } else { filename = value; } }
        }

        public Tag tag;
        public TagLib.File file;
    }

    public class MusicLibraryEventArgs : EventArgs
    {
        public Song Song { get; set; }
    }

    public delegate void SongAddedEventHandler(object sender, MusicLibraryEventArgs e);
    public delegate void MusicLibraryEventHandler(object sender, MusicLibraryEventArgs e);

    class MusicLibrary
    {
        Main mainForm;

        public List<Song> Songs;
        public List<string> songFiles;

        public List<int> changedTags;

        public event MusicLibraryEventHandler SongAdded;
        public event MusicLibraryEventHandler LibraryRescanned;

        int LibraryVersion = 1;

        public MusicLibrary(Main form)
        {
            mainForm = form;

            Songs = new List<Song>();
            songFiles = new List<string>();
            changedTags = new List<int>();
        }

        public Song GetSong(string name) { return Songs.Find(i => i.FileName == name); }
        public void AddSong(string file)
        {
            if (this.GetSong(file) != null)
                return;

            Song song = GetSongInfoFromFile(file);
            if (song == null) return;
            SongAdded(this, new MusicLibraryEventArgs() { Song = song });
            Songs.Add(song);
            songFiles.Add(file);

            SaveLibrary();
        }

        public void RemoveSong(Song song) { Songs.Remove(song); songFiles.Remove(song.FullName); }

        public Song GetSongInfoFromFile(string fileName)
        {
            TagLib.File file = null;

            try
            {
                file = TagLib.File.Create(fileName);
            }
            catch { }

            if (file == null)
                return null;

            TagLib.Tag tag;

            try
            {
                tag = new TagLib.Id3v2.Tag(file, 0);
            }
            catch { tag = new TagLib.Id3v2.Tag(); }

            Song song = new Song();

            song.Name = tag.Title;
            song.Artist = tag.FirstAlbumArtist;
            song.Album = tag.Album;
            song.TrackNum = (int)tag.Track;
            song.SongLength = file.Properties.Duration;

            string[] split = fileName.Split('\\');

            song.FileName = split[split.Length - 1];
            song.FilePath = fileName.Replace(song.FileName, "");
            song.FullName = fileName;

            song.tag = tag;
            file.Dispose();

            return song;
        }

        public void ProcessFolder(string path)
        {
            Main.status = "Importing folder...";

            string[] files = Directory.GetFiles(path, "*.mp3");

            if (files.Length <= 0) //No files found
                return;

            mainForm.InitProgressBar(files.Length - 1);

            foreach (string s in files)
            {
                AddSong(s);
                mainForm.StepProgressBar();
            }
            Main.status = "";
            LibraryRescanned(this, new MusicLibraryEventArgs());

            SaveLibrary();
        }

        public void ModifySongAttributes(string name, string title = null, string artist = null, string album = null)
        {
            if (title == null && artist == null && album == null) //Wasting time...
                return;

            Song originalSong = GetSong(name);
            Song newSong = originalSong;

            if (title != null && originalSong.Name != title)
                newSong.Name = title;

            if (artist != null && originalSong.Artist != artist)
                newSong.Artist = artist;

            if (album != null && originalSong.Album != album)
                newSong.Album = album;

            int index = Songs.IndexOf(originalSong);

            Songs[index] = newSong;
            if (!changedTags.Contains(index))
                changedTags.Remove(index);

            changedTags.Add(index);
        }

        public void ApplyTags()
        {
            if (changedTags.Count <= 0)
                return;

            Main.status = "Applying changes to Tag data...";

            mainForm.InitProgressBar(changedTags.Count - 1);

            foreach (int i in changedTags)
            {
                Song s = Songs[i];

                s.file = TagLib.File.Create(s.FullName);

                s.file.Tag.Album = s.Album;
                s.file.Tag.AlbumArtists = new string[1] {s.Artist};
                s.file.Tag.Title = s.Name;

                s.file.Save();
                s.file.Dispose();

                mainForm.StepProgressBar();
            }

            changedTags.Clear();

            Main.status = "";

            SaveLibrary();
        }

        //protected virtual void OnSongAdded(MusicLibraryEventArgs e) { SongAdded(this, e); }

        public void ReprocessSongFiles()
        {
            if (songFiles.Count <= 0)
                return;

            Main.status = "Loading library...";

            mainForm.InitProgressBar(songFiles.Count - 1);

            Songs.Clear();

            List<string> badFiles = new List<string>();

            foreach (string file in songFiles)
            {
                Song song = GetSongInfoFromFile(file);
                if (song == null) { badFiles.Add(file); continue; }
                Songs.Add(song);
                mainForm.StepProgressBar();
            }

            if (badFiles.Count > 0)
            {
                MessageBox.Show("Failed to import " + badFiles.Count + " files!\nSome items may not be added to your library list.\n\nThis generally happens when a file has been moved or renamed.\nYou'll have to re-import your missing files.\n\nSorry about that :(", "Failed to open files!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (string file in badFiles) { Songs.Remove(GetSong(file)); songFiles.Remove(file); } 
            }

            LibraryRescanned(this, new MusicLibraryEventArgs());

            Main.status = "";

            SaveLibrary();
        }

        public void Init()
        {
            ImportSongfilesDat(IceLibrarian.Properties.Settings.Default.LibraryDirectory);
        }

        public void Shutdown()
        {
            Main.status = "Saving library...";
            ApplyTags();
            SaveLibrary();
        }

        public void SaveLibrary() { ExportSongfilesDat(IceLibrarian.Properties.Settings.Default.LibraryDirectory); }

        public void ExportSongfilesDat(string folderPath)
        {
            Main.status = "Exporting library data...";

            Library lib = new Library();

            lib.version = LibraryVersion;
            lib.songfiles = songFiles;

            IFormatter format = new BinaryFormatter();
            Stream fileStream = new FileStream(folderPath + "\\icelibrary.dat", FileMode.Create, FileAccess.ReadWrite, FileShare.None);

            format.Serialize(fileStream, lib);

            fileStream.Close();

            Main.status = "";
        }

        public void ImportSongfilesDat(string folderPath)
        {
            Main.status = "Importing library data...";

            string[] files = Directory.GetFiles(folderPath);
            string libraryFile = files.ToList<string>().Find(i => i.EndsWith("icelibrary.dat"));

            if (libraryFile == null)
                return;

            IFormatter formatter = new BinaryFormatter();
            Stream fileStream = new FileStream(libraryFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            Library lib = (Library)formatter.Deserialize(fileStream);

            fileStream.Close();

            if (lib.version > LibraryVersion)
            {
                //library is newer than we can handle
            }

            songFiles = lib.songfiles;

            ReprocessSongFiles();

            Main.status = "";
        }

        public void SetFilename(Song song, string newFilename)
        {
            string oldFile = song.FullName;
            string ext = oldFile.Split('.').Last<string>();

            string newFile = song.FilePath + newFilename + "." + ext;

            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                newFile = newFile.Replace(""+c, "");
            }
            
            System.IO.File.Move(oldFile, newFile);

            this.RemoveSong(song);
            this.AddSong(newFile);

            ReprocessSongFiles();
        }
    }
}
