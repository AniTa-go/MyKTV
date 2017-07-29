namespace MyKTV
{
    partial class FrmSongList
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSongType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSongList = new System.Windows.Forms.DataGridView();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.song_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songtype_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_play_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "歌曲名：";
            // 
            // lblSongType
            // 
            this.lblSongType.AutoSize = true;
            this.lblSongType.Location = new System.Drawing.Point(296, 25);
            this.lblSongType.Name = "lblSongType";
            this.lblSongType.Size = new System.Drawing.Size(65, 12);
            this.lblSongType.TabIndex = 0;
            this.lblSongType.Text = "歌曲类型：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 21);
            this.txtName.TabIndex = 1;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(359, 21);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(175, 20);
            this.cmbType.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(567, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSongList
            // 
            this.dgvSongList.AllowUserToAddRows = false;
            this.dgvSongList.AllowUserToDeleteRows = false;
            this.dgvSongList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.song_id,
            this.song_name,
            this.songtype_name,
            this.song_url,
            this.song_play_count});
            this.dgvSongList.ContextMenuStrip = this.cmsMenu;
            this.dgvSongList.Location = new System.Drawing.Point(12, 51);
            this.dgvSongList.Name = "dgvSongList";
            this.dgvSongList.ReadOnly = true;
            this.dgvSongList.RowHeadersVisible = false;
            this.dgvSongList.RowTemplate.Height = 23;
            this.dgvSongList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongList.Size = new System.Drawing.Size(642, 371);
            this.dgvSongList.TabIndex = 4;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChange,
            this.tsmiDelete});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmiChange
            // 
            this.tsmiChange.Name = "tsmiChange";
            this.tsmiChange.Size = new System.Drawing.Size(152, 22);
            this.tsmiChange.Text = "修改";
            this.tsmiChange.Click += new System.EventHandler(this.tsmiChange_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // song_id
            // 
            this.song_id.DataPropertyName = "song_id";
            this.song_id.HeaderText = "song_id";
            this.song_id.Name = "song_id";
            this.song_id.ReadOnly = true;
            this.song_id.Visible = false;
            // 
            // song_name
            // 
            this.song_name.DataPropertyName = "song_name";
            this.song_name.HeaderText = "歌曲名";
            this.song_name.Name = "song_name";
            this.song_name.ReadOnly = true;
            // 
            // songtype_name
            // 
            this.songtype_name.DataPropertyName = "songtype_name";
            this.songtype_name.HeaderText = "歌曲类别";
            this.songtype_name.Name = "songtype_name";
            this.songtype_name.ReadOnly = true;
            // 
            // song_url
            // 
            this.song_url.DataPropertyName = "song_url";
            this.song_url.HeaderText = "歌曲存放路径";
            this.song_url.Name = "song_url";
            this.song_url.ReadOnly = true;
            // 
            // song_play_count
            // 
            this.song_play_count.DataPropertyName = "song_play_count";
            this.song_play_count.HeaderText = "点播次数";
            this.song_play_count.Name = "song_play_count";
            this.song_play_count.ReadOnly = true;
            // 
            // FrmSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 434);
            this.Controls.Add(this.dgvSongList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSongType);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌曲查询";
            this.Load += new System.EventHandler(this.FrmSongList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSongType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSongList;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiChange;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn songtype_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_play_count;
    }
}