namespace MyKTV
{
    partial class FrmAdmin
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmi_singerManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddsinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchSinger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchSong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetResourcesPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSingerPhotoPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelper = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_singerManage,
            this.tsmiSongManage,
            this.tsmiSetResourcesPath,
            this.tsmiHelper});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(736, 25);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmi_singerManage
            // 
            this.tsmi_singerManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddsinger,
            this.tsmiSearchSinger,
            this.tsmiExit});
            this.tsmi_singerManage.Name = "tsmi_singerManage";
            this.tsmi_singerManage.Size = new System.Drawing.Size(83, 21);
            this.tsmi_singerManage.Text = "歌手管理(&S)";
            // 
            // tsmiAddsinger
            // 
            this.tsmiAddsinger.Name = "tsmiAddsinger";
            this.tsmiAddsinger.Size = new System.Drawing.Size(163, 22);
            this.tsmiAddsinger.Text = "新增歌手(&N)";
            this.tsmiAddsinger.Click += new System.EventHandler(this.tsmiAddsinger_Click);
            // 
            // tsmiSearchSinger
            // 
            this.tsmiSearchSinger.Name = "tsmiSearchSinger";
            this.tsmiSearchSinger.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchSinger.Text = "查询歌手信息(&S)";
            this.tsmiSearchSinger.Click += new System.EventHandler(this.tsmiSearchSinger_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(163, 22);
            this.tsmiExit.Text = "退出(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiSongManage
            // 
            this.tsmiSongManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddSong,
            this.tsmiSearchSong});
            this.tsmiSongManage.Name = "tsmiSongManage";
            this.tsmiSongManage.Size = new System.Drawing.Size(86, 21);
            this.tsmiSongManage.Text = "歌曲管理(&O)";
            // 
            // tsmiAddSong
            // 
            this.tsmiAddSong.Name = "tsmiAddSong";
            this.tsmiAddSong.Size = new System.Drawing.Size(163, 22);
            this.tsmiAddSong.Text = "新增歌曲(&N)";
            this.tsmiAddSong.Click += new System.EventHandler(this.tsmiAddSong_Click);
            // 
            // tsmiSearchSong
            // 
            this.tsmiSearchSong.Name = "tsmiSearchSong";
            this.tsmiSearchSong.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchSong.Text = "查询歌曲信息(&S)";
            this.tsmiSearchSong.Click += new System.EventHandler(this.tsmiSearchSong_Click);
            // 
            // tsmiSetResourcesPath
            // 
            this.tsmiSetResourcesPath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSingerPhotoPath,
            this.tsmiSongPath});
            this.tsmiSetResourcesPath.Name = "tsmiSetResourcesPath";
            this.tsmiSetResourcesPath.Size = new System.Drawing.Size(108, 21);
            this.tsmiSetResourcesPath.Text = "设置资源路径(&R)";
            // 
            // tsmiSingerPhotoPath
            // 
            this.tsmiSingerPhotoPath.Name = "tsmiSingerPhotoPath";
            this.tsmiSingerPhotoPath.Size = new System.Drawing.Size(163, 22);
            this.tsmiSingerPhotoPath.Text = "歌手照片路径(&S)";
            this.tsmiSingerPhotoPath.Click += new System.EventHandler(this.tsmiSingerPhotoPath_Click);
            // 
            // tsmiSongPath
            // 
            this.tsmiSongPath.Name = "tsmiSongPath";
            this.tsmiSongPath.Size = new System.Drawing.Size(163, 22);
            this.tsmiSongPath.Text = "歌曲路径(&O)";
            this.tsmiSongPath.Click += new System.EventHandler(this.tsmiSongPath_Click);
            // 
            // tsmiHelper
            // 
            this.tsmiHelper.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelper.Name = "tsmiHelper";
            this.tsmiHelper.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelper.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "关于我们(&A)";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 517);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmAdmin";
            this.Text = "管理歌曲信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_singerManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddsinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchSinger;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchSong;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetResourcesPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiSingerPhotoPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelper;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}