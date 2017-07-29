namespace MyKTV
{
    partial class FrmEditSong
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
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblPinYin = new System.Windows.Forms.Label();
            this.lblSinger = new System.Windows.Forms.Label();
            this.lblSongType = new System.Windows.Forms.Label();
            this.lblSongFileName = new System.Windows.Forms.Label();
            this.txtPinYin = new System.Windows.Forms.TextBox();
            this.txtSongFileName = new System.Windows.Forms.TextBox();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.cmbSongType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.nudWordCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(23, 32);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(71, 12);
            this.lblSongName.TabIndex = 0;
            this.lblSongName.Text = "*歌曲名称：";
            // 
            // lblPinYin
            // 
            this.lblPinYin.AutoSize = true;
            this.lblPinYin.Location = new System.Drawing.Point(19, 71);
            this.lblPinYin.Name = "lblPinYin";
            this.lblPinYin.Size = new System.Drawing.Size(71, 12);
            this.lblPinYin.TabIndex = 0;
            this.lblPinYin.Text = "*拼音缩写：";
            // 
            // lblSinger
            // 
            this.lblSinger.AutoSize = true;
            this.lblSinger.Location = new System.Drawing.Point(53, 192);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(41, 12);
            this.lblSinger.TabIndex = 0;
            this.lblSinger.Text = "歌手：";
            // 
            // lblSongType
            // 
            this.lblSongType.AutoSize = true;
            this.lblSongType.Location = new System.Drawing.Point(23, 111);
            this.lblSongType.Name = "lblSongType";
            this.lblSongType.Size = new System.Drawing.Size(71, 12);
            this.lblSongType.TabIndex = 0;
            this.lblSongType.Text = "*歌曲类型：";
            // 
            // lblSongFileName
            // 
            this.lblSongFileName.AutoSize = true;
            this.lblSongFileName.Location = new System.Drawing.Point(11, 238);
            this.lblSongFileName.Name = "lblSongFileName";
            this.lblSongFileName.Size = new System.Drawing.Size(83, 12);
            this.lblSongFileName.TabIndex = 0;
            this.lblSongFileName.Text = "*歌曲文件名：";
            // 
            // txtPinYin
            // 
            this.txtPinYin.Location = new System.Drawing.Point(100, 68);
            this.txtPinYin.Name = "txtPinYin";
            this.txtPinYin.Size = new System.Drawing.Size(413, 21);
            this.txtPinYin.TabIndex = 1;
            // 
            // txtSongFileName
            // 
            this.txtSongFileName.Location = new System.Drawing.Point(32, 264);
            this.txtSongFileName.Name = "txtSongFileName";
            this.txtSongFileName.Size = new System.Drawing.Size(382, 21);
            this.txtSongFileName.TabIndex = 2;
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(100, 188);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.ReadOnly = true;
            this.txtSinger.Size = new System.Drawing.Size(314, 21);
            this.txtSinger.TabIndex = 3;
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(100, 29);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(413, 21);
            this.txtSongName.TabIndex = 4;
            this.txtSongName.TextChanged += new System.EventHandler(this.txtSongName_TextChanged);
            // 
            // cmbSongType
            // 
            this.cmbSongType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSongType.FormattingEnabled = true;
            this.cmbSongType.Location = new System.Drawing.Point(100, 108);
            this.cmbSongType.Name = "cmbSongType";
            this.cmbSongType.Size = new System.Drawing.Size(413, 20);
            this.cmbSongType.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(438, 187);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(438, 263);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(438, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(11, 152);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(83, 12);
            this.lblWordCount.TabIndex = 10;
            this.lblWordCount.Text = "*歌曲名字数：";
            // 
            // nudWordCount
            // 
            this.nudWordCount.Location = new System.Drawing.Point(100, 150);
            this.nudWordCount.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudWordCount.Name = "nudWordCount";
            this.nudWordCount.ReadOnly = true;
            this.nudWordCount.Size = new System.Drawing.Size(413, 21);
            this.nudWordCount.TabIndex = 11;
            // 
            // FrmEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 373);
            this.Controls.Add(this.nudWordCount);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSongType);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.txtSinger);
            this.Controls.Add(this.txtSongFileName);
            this.Controls.Add(this.txtPinYin);
            this.Controls.Add(this.lblSongFileName);
            this.Controls.Add(this.lblSongType);
            this.Controls.Add(this.lblSinger);
            this.Controls.Add(this.lblPinYin);
            this.Controls.Add(this.lblSongName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑歌曲信息";
            this.Load += new System.EventHandler(this.FrmEditSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWordCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblPinYin;
        private System.Windows.Forms.Label lblSinger;
        private System.Windows.Forms.Label lblSongType;
        private System.Windows.Forms.Label lblSongFileName;
        private System.Windows.Forms.TextBox txtPinYin;
        private System.Windows.Forms.TextBox txtSongFileName;
        private System.Windows.Forms.TextBox txtSinger;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.ComboBox cmbSongType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.NumericUpDown nudWordCount;
    }
}