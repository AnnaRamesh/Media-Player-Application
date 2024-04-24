namespace MusicPlayerApp
{
    partial class MusicPlayerApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.Songs = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DimGray;
            this.TopPanel.Controls.Add(this.pictureBox4);
            this.TopPanel.Controls.Add(this.pictureBox3);
            this.TopPanel.Controls.Add(this.pictureBox2);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.lblLogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1421, 85);
            this.TopPanel.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.DimGray;
            this.lblLogo.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(112, 27);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(251, 34);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Media Player App";
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.Color.Black;
            this.btnSelectSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSongs.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSongs.ForeColor = System.Drawing.Color.White;
            this.btnSelectSongs.Location = new System.Drawing.Point(1128, 528);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(179, 50);
            this.btnSelectSongs.TabIndex = 2;
            this.btnSelectSongs.Text = "Select Songs";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // Songs
            // 
            this.Songs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Songs.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Songs.FormattingEnabled = true;
            this.Songs.ItemHeight = 24;
            this.Songs.Location = new System.Drawing.Point(1058, 129);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(334, 364);
            this.Songs.TabIndex = 3;
            this.Songs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1058, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Music List";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Dock = System.Windows.Forms.DockStyle.Left;
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(0, 85);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(1033, 535);
            this.axWindowsMediaPlayerMusic.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MusicPlayerApp.Properties.Resources.icons8_music_player_64;
            this.pictureBox4.Location = new System.Drawing.Point(42, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MusicPlayerApp.Properties.Resources.icons8_minimize_50;
            this.pictureBox3.Location = new System.Drawing.Point(1287, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MusicPlayerApp.Properties.Resources.icons8_maximize_50;
            this.pictureBox2.Location = new System.Drawing.Point(1324, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicPlayerApp.Properties.Resources.icons8_close_50;
            this.pictureBox1.Location = new System.Drawing.Point(1361, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1421, 620);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.Songs);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Magneto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectSongs;
        private System.Windows.Forms.ListBox Songs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

