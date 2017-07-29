namespace MyKTV
{
    partial class FrmEditSinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditSinger));
            this.lblNam = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoCom = new System.Windows.Forms.RadioButton();
            this.cmbSingerType = new System.Windows.Forms.ComboBox();
            this.picSingerPhoto = new System.Windows.Forms.PictureBox();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSingerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(30, 77);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(47, 12);
            this.lblNam.TabIndex = 0;
            this.lblNam.Text = "*姓名：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(36, 138);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "*歌手类型：";
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Location = new System.Drawing.Point(12, 260);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(65, 12);
            this.lblDescribe.TabIndex = 0;
            this.lblDescribe.Text = "歌手描述：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 21);
            this.txtName.TabIndex = 1;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(143, 136);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 2;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(196, 136);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoCom
            // 
            this.rdoCom.AutoSize = true;
            this.rdoCom.Location = new System.Drawing.Point(249, 136);
            this.rdoCom.Name = "rdoCom";
            this.rdoCom.Size = new System.Drawing.Size(47, 16);
            this.rdoCom.TabIndex = 2;
            this.rdoCom.TabStop = true;
            this.rdoCom.Text = "组合";
            this.rdoCom.UseVisualStyleBackColor = true;
            // 
            // cmbSingerType
            // 
            this.cmbSingerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSingerType.FormattingEnabled = true;
            this.cmbSingerType.Location = new System.Drawing.Point(131, 194);
            this.cmbSingerType.Name = "cmbSingerType";
            this.cmbSingerType.Size = new System.Drawing.Size(190, 20);
            this.cmbSingerType.TabIndex = 3;
            // 
            // picSingerPhoto
            // 
            this.picSingerPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picSingerPhoto.Image")));
            this.picSingerPhoto.Location = new System.Drawing.Point(359, 25);
            this.picSingerPhoto.Name = "picSingerPhoto";
            this.picSingerPhoto.Size = new System.Drawing.Size(144, 161);
            this.picSingerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSingerPhoto.TabIndex = 4;
            this.picSingerPhoto.TabStop = false;
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(108, 257);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(406, 139);
            this.txtDescribe.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(392, 192);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(324, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(428, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmEditSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 443);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.picSingerPhoto);
            this.Controls.Add(this.cmbSingerType);
            this.Controls.Add(this.rdoCom);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblNam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditSinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑歌手信息";
            this.Load += new System.EventHandler(this.rdoCombination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSingerPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoCom;
        private System.Windows.Forms.ComboBox cmbSingerType;
        private System.Windows.Forms.PictureBox picSingerPhoto;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}