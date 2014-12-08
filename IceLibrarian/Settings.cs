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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dialog.ShowDialog();
            //folderBrowserDialog1 dialog = new folderBrowserDialog1();

            //dialog.IsFolderPicker = true;

            //dialog.

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }

            this.Focus();

            //textBox1.Text = openFileDialog1.FileName;
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            IceLibrarian.Properties.Settings.Default.Reload();
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            IceLibrarian.Properties.Settings.Default.Save();

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DialogResult confirm = MessageBox.Show(
                    "WARNING!\n\nEnabling 'Aggregate Library' will duplicate every file you import and move them to your Library Directory.\n"
                    +"This feature is for organizing all of your songs into a single directory.\n\n"
                    +"This feature WILL consume your harddrive space, as it creates a copy of every file you import."
                    +"\n\nAre you sure you want to aggregate your library?",
                    "WARNING! Aggregate library notice!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == (System.Windows.Forms.DialogResult.No | System.Windows.Forms.DialogResult.Cancel))
                {
                    checkBox1.Checked = false;
                }
            }
        }
    }
}
