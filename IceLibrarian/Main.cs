using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IceLibrarian
{
    public partial class Main : Form
    {
        MusicLibrary musicLibrary;
        Settings settings;

        public static string status = "Ready";
        public static int libcount, changecount;

        public Main()
        {
            InitializeComponent();

            Init();
        }

        void Init()
        {
            settings = new Settings();

            musicLibrary = new MusicLibrary(this);

            musicLibrary.SongAdded += new MusicLibraryEventHandler(musicLibrary_SongAdded);
            musicLibrary.LibraryRescanned += new MusicLibraryEventHandler(musicLibrary_LibraryRescanned);
            listView1.KeyDown += new KeyEventHandler(Main_KeyDown);
            listView1.AllowDrop = true;
            listView1.DragDrop += new DragEventHandler(listView1_DragDrop);
            listView1.DragEnter += new DragEventHandler(listView1_DragEnter);
            listView1.DragOver += new DragEventHandler(listView1_DragEnter);
            listView1.DoubleClick += new EventHandler(listView1_DoubleClick);

            titleText.KeyDown += new KeyEventHandler(AttributeChanged);
            artistText.KeyDown += new KeyEventHandler(AttributeChanged);
            albumText.KeyDown += new KeyEventHandler(AttributeChanged);

            this.FormClosing += new FormClosingEventHandler(Main_FormClosing);

            musicLibrary.Init();
        }

        void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicLibrary.Shutdown();
        }

        void listView1_DoubleClick(object sender, EventArgs e)
        {
            Song song = musicLibrary.GetSong(listView1.SelectedItems[0].Text);

            if (song == null)
                return;

            System.Diagnostics.Process.Start(@song.FullName);
        }

        void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.WaveAudio, false))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        void listView1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show(e.Data.ToString());
        }

        void AttributeChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == titleText)
                {
                    if (listView1.SelectedItems.Count != 1) //Can't modify multiple titles, nor can you modify nothing
                        return;

                    musicLibrary.ModifySongAttributes(listView1.SelectedItems[0].Text, titleText.Text);
                }

                if (sender == artistText)
                {
                    foreach (ListViewItem i in listView1.SelectedItems)
                    {
                        musicLibrary.ModifySongAttributes(i.Text, null, artistText.Text);
                    }
                }

                if (sender == albumText)
                {
                    foreach (ListViewItem i in listView1.SelectedItems)
                    {
                        musicLibrary.ModifySongAttributes(i.Text, null, null, albumText.Text);
                    }
                }

                RefreshSongList();

                label1.Focus();
            }
        }

        void musicLibrary_LibraryRescanned(object sender, MusicLibraryEventArgs e)
        {
            RefreshSongList();
        }

        void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listView1.SelectedItems.Count <= 0)
                    return;

                InitProgressBar(listView1.SelectedItems.Count - 1);
                status = "Removing items...";

                foreach (ListViewItem i in listView1.SelectedItems)
                {
                    StepProgressBar();
                    Song song = musicLibrary.GetSong(i.Text);
                    musicLibrary.RemoveSong(song);
                }
                status = "";

                RefreshSongList();
            }

            if (e.KeyCode == Keys.F5)
            {
                RefreshSongList();
            }
        }

        void musicLibrary_SongAdded(object sender, MusicLibraryEventArgs e)
        {
            listView1.Items.Add(CreateListItem(e.Song));
        }

        private void importFileToolStripMenuItem_Click(object sender, EventArgs e) { openFileDialog1.ShowDialog(); musicLibrary.AddSong(openFileDialog1.FileName); }

        public void RefreshSongList()
        {
            status = "Refreshing song list...";

            listView1.Items.Clear();

            foreach (Song s in musicLibrary.Songs)
            {
                listView1.Items.Add(CreateListItem(s));
            }
        }

        public ListViewItem CreateListItem(Song song)
        {
            string[] strings = new string[6] { song.FileName, song.Name, (song.SongLength > TimeSpan.FromHours(1)) ? song.SongLength.ToString(@"hh\:mm\:ss") : song.SongLength.ToString(@"mm\:ss"), song.Artist, song.Album, song.TrackNum.ToString() };
            ListViewItem item = new ListViewItem(strings);
            return item;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(settings.IsDisposed)
                settings = new Settings();

            settings.Show();
        }

        private void importFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr =  folderBrowserDialog1.ShowDialog();
            this.Focus();

            if(dr == DialogResult.OK)
                musicLibrary.ProcessFolder(folderBrowserDialog1.SelectedPath);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicLibrary.Shutdown();
            this.Close();
        }

        //Update Song Information Panel
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems.Count > 1)
                {
                    titleText.Enabled = false;
                    filenameText.Enabled = false;
                    filenameText.Text = "[Multiple]";
                    titleText.Text = "[Multiple]";
                    trackNumTextbox.Text = "[Multiple";
                    trackNumTextbox.Enabled = false;

                    bool artistMatch = true;
                    bool albumMatch = true;

                    string lastArtist = "", lastAlbum = "";

                    foreach (ListViewItem i in listView1.SelectedItems)
                    {
                        Song song = musicLibrary.GetSong(i.Text);

                        if (artistMatch)
                        {
                            if (song.Artist == lastArtist)
                            {
                                lastArtist = song.Artist;
                                //continue;
                            }
                            else if (lastArtist == "")
                            {
                                lastArtist = song.Artist;
                                //continue;
                            }
                            else
                            {
                                artistMatch = false;
                            }
                        }

                        if (albumMatch)
                        {
                            if (song.Album == lastAlbum)
                            {
                                lastAlbum = song.Album;
                                //continue;
                            }
                            else if (lastAlbum == "")
                            {
                                lastAlbum = song.Album;
                                //continue;
                            }
                            else
                            {
                                albumMatch = false;
                            }
                        }
                    }

                    if (artistMatch)
                        artistText.Text = lastArtist;
                    else
                        artistText.Text = "[Multiple]";

                    if (albumMatch)
                        albumText.Text = lastAlbum;
                    else
                        albumText.Text = "[Multiple]";
                }
                else
                {
                    string item = listView1.SelectedItems[0].Text;
                    Song song = musicLibrary.GetSong(item);

                    filenameText.Enabled = false;
                    filenameText.Text = song.FileName;
                    titleText.Enabled = true;
                    titleText.Text = song.Name;
                    artistText.Text = song.Artist;
                    albumText.Text = song.Album;
                    trackNumTextbox.Enabled = true;
                    trackNumTextbox.Text = ""+song.TrackNum;
                }
            }
            
        }

        private void applyTagChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicLibrary.ApplyTags();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            libcount = musicLibrary.Songs.Count;
            changecount = musicLibrary.changedTags.Count;

            this.Text = "IceLibrarian - " + libcount + " songs";

            if (statusLabel.Text != status)
                statusLabel.Text = status;

            librarycountLabel.Text = libcount + " items in library";
            librarychangedLabel.Text = changecount + " items changed";

            if (status == "")
                status = "Ready";
        }

        public void InitProgressBar(int iterations)
        {
            progressStatusBar.Visible = true;
            progressStatusBar.Maximum = iterations;
            progressStatusBar.Value = 0;
        }

        public void UninitProgressBar()
        {
            progressStatusBar.Visible = false;
            progressStatusBar.Maximum = 100;
            progressStatusBar.Value = 0;
        }

        public void StepProgressBar()
        {
            progressStatusBar.PerformStep();

            if (progressStatusBar.Value >= progressStatusBar.Maximum)
            {
                UninitProgressBar();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void generateFileNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem i in listView1.SelectedItems)
                {
                    Song song = musicLibrary.GetSong(i.Text);
                    musicLibrary.SetFilename(song, song.Artist + " - " + song.Name);
                }
            }
        }
    }
}
