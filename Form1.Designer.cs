namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.URLInputBox = new System.Windows.Forms.TextBox();
            this.RemoveFav = new System.Windows.Forms.Button();
            this.FavSongsTitleLabel = new System.Windows.Forms.Label();
            this.FavBox = new System.Windows.Forms.ListBox();
            this.AddFav = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SongTitleLabel = new System.Windows.Forms.Label();
            this.ArtistTitleLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.MaxTitleLabel = new System.Windows.Forms.Label();
            this.MinTitleLabel = new System.Windows.Forms.Label();
            this.InputTitleLabel = new System.Windows.Forms.Label();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMusicStreamerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.URLInputBox);
            this.panel1.Controls.Add(this.RemoveFav);
            this.panel1.Controls.Add(this.FavSongsTitleLabel);
            this.panel1.Controls.Add(this.FavBox);
            this.panel1.Controls.Add(this.AddFav);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.SongTitleLabel);
            this.panel1.Controls.Add(this.ArtistTitleLabel);
            this.panel1.Controls.Add(this.ArtistLabel);
            this.panel1.Controls.Add(this.MaxTitleLabel);
            this.panel1.Controls.Add(this.MinTitleLabel);
            this.panel1.Controls.Add(this.InputTitleLabel);
            this.panel1.Controls.Add(this.VolumeSlider);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 260);
            this.panel1.TabIndex = 0;
            // 
            // URLInputBox
            // 
            this.URLInputBox.Location = new System.Drawing.Point(90, 29);
            this.URLInputBox.Name = "URLInputBox";
            this.URLInputBox.Size = new System.Drawing.Size(235, 20);
            this.URLInputBox.TabIndex = 23;
            // 
            // RemoveFav
            // 
            this.RemoveFav.Location = new System.Drawing.Point(514, 232);
            this.RemoveFav.Name = "RemoveFav";
            this.RemoveFav.Size = new System.Drawing.Size(100, 25);
            this.RemoveFav.TabIndex = 22;
            this.RemoveFav.Text = "Remove";
            this.RemoveFav.UseVisualStyleBackColor = true;
            this.RemoveFav.Click += new System.EventHandler(this.button2_Click);
            // 
            // FavSongsTitleLabel
            // 
            this.FavSongsTitleLabel.AutoSize = true;
            this.FavSongsTitleLabel.Location = new System.Drawing.Point(428, 32);
            this.FavSongsTitleLabel.Name = "FavSongsTitleLabel";
            this.FavSongsTitleLabel.Size = new System.Drawing.Size(81, 13);
            this.FavSongsTitleLabel.TabIndex = 21;
            this.FavSongsTitleLabel.Text = "Favorite Songs:";
            // 
            // FavBox
            // 
            this.FavBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FavBox.FormattingEnabled = true;
            this.FavBox.Location = new System.Drawing.Point(326, 55);
            this.FavBox.Name = "FavBox";
            this.FavBox.Size = new System.Drawing.Size(288, 173);
            this.FavBox.TabIndex = 20;
            // 
            // AddFav
            // 
            this.AddFav.Location = new System.Drawing.Point(326, 232);
            this.AddFav.Name = "AddFav";
            this.AddFav.Size = new System.Drawing.Size(100, 25);
            this.AddFav.TabIndex = 19;
            this.AddFav.Text = "Add";
            this.AddFav.UseVisualStyleBackColor = true;
            this.AddFav.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(50, 130);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(10, 13);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = " ";
            // 
            // SongTitleLabel
            // 
            this.SongTitleLabel.AutoSize = true;
            this.SongTitleLabel.Location = new System.Drawing.Point(8, 130);
            this.SongTitleLabel.Name = "SongTitleLabel";
            this.SongTitleLabel.Size = new System.Drawing.Size(33, 13);
            this.SongTitleLabel.TabIndex = 15;
            this.SongTitleLabel.Text = "Title: ";
            // 
            // ArtistTitleLabel
            // 
            this.ArtistTitleLabel.AutoSize = true;
            this.ArtistTitleLabel.Location = new System.Drawing.Point(8, 104);
            this.ArtistTitleLabel.Name = "ArtistTitleLabel";
            this.ArtistTitleLabel.Size = new System.Drawing.Size(36, 13);
            this.ArtistTitleLabel.TabIndex = 14;
            this.ArtistTitleLabel.Text = "Artist: ";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(50, 104);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(10, 13);
            this.ArtistLabel.TabIndex = 13;
            this.ArtistLabel.Text = " ";
            // 
            // MaxTitleLabel
            // 
            this.MaxTitleLabel.AutoSize = true;
            this.MaxTitleLabel.Location = new System.Drawing.Point(242, 221);
            this.MaxTitleLabel.Name = "MaxTitleLabel";
            this.MaxTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxTitleLabel.TabIndex = 12;
            this.MaxTitleLabel.Text = "Max";
            // 
            // MinTitleLabel
            // 
            this.MinTitleLabel.AutoSize = true;
            this.MinTitleLabel.Location = new System.Drawing.Point(56, 221);
            this.MinTitleLabel.Name = "MinTitleLabel";
            this.MinTitleLabel.Size = new System.Drawing.Size(24, 13);
            this.MinTitleLabel.TabIndex = 11;
            this.MinTitleLabel.Text = "Min";
            // 
            // InputTitleLabel
            // 
            this.InputTitleLabel.AutoSize = true;
            this.InputTitleLabel.Location = new System.Drawing.Point(3, 32);
            this.InputTitleLabel.Name = "InputTitleLabel";
            this.InputTitleLabel.Size = new System.Drawing.Size(82, 13);
            this.InputTitleLabel.TabIndex = 10;
            this.InputTitleLabel.Text = "Input stream url:";
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.VolumeSlider.Location = new System.Drawing.Point(86, 212);
            this.VolumeSlider.Maximum = 12;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(150, 45);
            this.VolumeSlider.TabIndex = 9;
            this.VolumeSlider.Value = 6;
            this.VolumeSlider.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
           
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(245, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(42, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Lofi";
            this.radioButton3.UseVisualStyleBackColor = true;
            //this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(125, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ambient";
            this.radioButton2.UseVisualStyleBackColor = true;
            //this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Trance";
            this.radioButton1.UseVisualStyleBackColor = true;
            //this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            
            // 
            // playButton
            // 
            this.playButton.Image = global::WindowsFormsApplication1.Properties.Resources.if_button_grey_play_50039;
            this.playButton.Location = new System.Drawing.Point(138, 156);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(50, 50);
            this.playButton.TabIndex = 3;
            this.playButton.TabStop = false;
            this.playButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(156, 140);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMusicStreamerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMusicStreamerToolStripMenuItem
            // 
            this.aboutMusicStreamerToolStripMenuItem.Name = "aboutMusicStreamerToolStripMenuItem";
            this.aboutMusicStreamerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aboutMusicStreamerToolStripMenuItem.Text = "About Music Streamer";
            this.aboutMusicStreamerToolStripMenuItem.Click += new System.EventHandler(this.aboutMusicStreamerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Music Streamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label InputTitleLabel;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label MinTitleLabel;
        private System.Windows.Forms.Label MaxTitleLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMusicStreamerToolStripMenuItem;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SongTitleLabel;
        private System.Windows.Forms.Label ArtistTitleLabel;
        private System.Windows.Forms.Button AddFav;
        private System.Windows.Forms.ListBox FavBox;
        private System.Windows.Forms.Label FavSongsTitleLabel;
        private System.Windows.Forms.Button RemoveFav;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.TextBox URLInputBox;
    }
}

