using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        // create global variables of string type array to save the titles or name of the tracks and path of the track
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select songs
            OpenFileDialog ofd = new OpenFileDialog();
            //code to select multiple files
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //save the names of the track in files array
                paths = ofd.FileNames; //save the paths of the tracks in path array
                //display the music titles in listbox
                for(int i = 0; i < files.Length; i++)
                {
                    Songs.Items.Add(files[i]); //display songs in listbox
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[Songs.SelectedIndex];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close the App
            this.Close();
        }
    }
}
