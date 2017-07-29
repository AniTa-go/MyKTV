namespace MyKTV
{
    partial class FrmSingerList
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
            this.dgvSingerList = new System.Windows.Forms.DataGridView();
            this.singer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelect = new System.Windows.Forms.ToolStripMenuItem();
            this.singer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singertype_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_photo_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSingerType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbSingerType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerList)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSingerList
            // 
            this.dgvSingerList.AllowUserToAddRows = false;
            this.dgvSingerList.AllowUserToDeleteRows = false;
            this.dgvSingerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSingerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.singer_id,
            this.singer_name,
            this.singer_sex,
            this.singertype_name,
            this.singer_photo_url,
            this.singer_Describe});
            this.dgvSingerList.ContextMenuStrip = this.cmsMenu;
            this.dgvSingerList.Location = new System.Drawing.Point(12, 66);
            this.dgvSingerList.Name = "dgvSingerList";
            this.dgvSingerList.ReadOnly = true;
            this.dgvSingerList.RowHeadersVisible = false;
            this.dgvSingerList.RowTemplate.Height = 23;
            this.dgvSingerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSingerList.Size = new System.Drawing.Size(679, 391);
            this.dgvSingerList.TabIndex = 0;
            this.dgvSingerList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSingerList_CellContentDoubleClick);
            // 
            // singer_id
            // 
            this.singer_id.ContextMenuStrip = this.cmsMenu;
            this.singer_id.DataPropertyName = "singer_id";
            this.singer_id.HeaderText = "singer_id";
            this.singer_id.Name = "singer_id";
            this.singer_id.ReadOnly = true;
            this.singer_id.Visible = false;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChange,
            this.tsmiDelect});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiChange
            // 
            this.tsmiChange.Name = "tsmiChange";
            this.tsmiChange.Size = new System.Drawing.Size(100, 22);
            this.tsmiChange.Text = "修改";
            this.tsmiChange.Click += new System.EventHandler(this.tsmiChange_Click);
            // 
            // tsmiDelect
            // 
            this.tsmiDelect.Name = "tsmiDelect";
            this.tsmiDelect.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelect.Text = "删除";
            this.tsmiDelect.Click += new System.EventHandler(this.tsmiDelect_Click);
            // 
            // singer_name
            // 
            this.singer_name.DataPropertyName = "singer_name";
            this.singer_name.HeaderText = "歌手姓名";
            this.singer_name.Name = "singer_name";
            this.singer_name.ReadOnly = true;
            // 
            // singer_sex
            // 
            this.singer_sex.DataPropertyName = "singer_sex";
            this.singer_sex.HeaderText = "性别";
            this.singer_sex.Name = "singer_sex";
            this.singer_sex.ReadOnly = true;
            // 
            // singertype_name
            // 
            this.singertype_name.DataPropertyName = "singertype_name";
            this.singertype_name.HeaderText = "类别";
            this.singertype_name.Name = "singertype_name";
            this.singertype_name.ReadOnly = true;
            // 
            // singer_photo_url
            // 
            this.singer_photo_url.DataPropertyName = "singer_photo_url";
            this.singer_photo_url.HeaderText = "写真存储路径";
            this.singer_photo_url.Name = "singer_photo_url";
            this.singer_photo_url.ReadOnly = true;
            // 
            // singer_Describe
            // 
            this.singer_Describe.DataPropertyName = "singer_Describe";
            this.singer_Describe.HeaderText = "简介";
            this.singer_Describe.Name = "singer_Describe";
            this.singer_Describe.ReadOnly = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "歌手姓名：";
            // 
            // lblSingerType
            // 
            this.lblSingerType.AutoSize = true;
            this.lblSingerType.Location = new System.Drawing.Point(282, 30);
            this.lblSingerType.Name = "lblSingerType";
            this.lblSingerType.Size = new System.Drawing.Size(65, 12);
            this.lblSingerType.TabIndex = 2;
            this.lblSingerType.Text = "歌手类型：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 21);
            this.txtName.TabIndex = 3;
            // 
            // cmbSingerType
            // 
            this.cmbSingerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSingerType.FormattingEnabled = true;
            this.cmbSingerType.Location = new System.Drawing.Point(353, 26);
            this.cmbSingerType.Name = "cmbSingerType";
            this.cmbSingerType.Size = new System.Drawing.Size(155, 20);
            this.cmbSingerType.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(514, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(595, 25);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmSingerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 469);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSingerType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSingerType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvSingerList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSingerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询歌手信息";
            this.Load += new System.EventHandler(this.FrmSingerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerList)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSingerList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSingerType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbSingerType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiChange;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn singertype_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_photo_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_Describe;
    }
}