namespace MyKTV
{
    partial class FrmSongPath
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
            this.lblPath = new System.Windows.Forms.Label();
            this.lblNewPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlJinDu = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangeOk = new System.Windows.Forms.Button();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHint = new System.Windows.Forms.Label();
            this.barChange = new System.Windows.Forms.ProgressBar();
            this.newPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlJinDu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(55, 44);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(53, 12);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "原路径：";
            // 
            // lblNewPath
            // 
            this.lblNewPath.AutoSize = true;
            this.lblNewPath.Location = new System.Drawing.Point(55, 201);
            this.lblNewPath.Name = "lblNewPath";
            this.lblNewPath.Size = new System.Drawing.Size(53, 12);
            this.lblNewPath.TabIndex = 0;
            this.lblNewPath.Text = "新路径：";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(123, 41);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(351, 129);
            this.txtPath.TabIndex = 1;
            // 
            // txtNewPath
            // 
            this.txtNewPath.Location = new System.Drawing.Point(123, 198);
            this.txtNewPath.Multiline = true;
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.Size = new System.Drawing.Size(351, 129);
            this.txtNewPath.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(399, 345);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(233, 345);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pnlJinDu
            // 
            this.pnlJinDu.Controls.Add(this.btnCancel);
            this.pnlJinDu.Controls.Add(this.btnChangeOk);
            this.pnlJinDu.Controls.Add(this.lvInfo);
            this.pnlJinDu.Controls.Add(this.lblHint);
            this.pnlJinDu.Controls.Add(this.barChange);
            this.pnlJinDu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJinDu.Location = new System.Drawing.Point(0, 0);
            this.pnlJinDu.Name = "pnlJinDu";
            this.pnlJinDu.Size = new System.Drawing.Size(523, 380);
            this.pnlJinDu.TabIndex = 4;
            this.pnlJinDu.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(420, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消操作";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnChangeOk
            // 
            this.btnChangeOk.Location = new System.Drawing.Point(314, 345);
            this.btnChangeOk.Name = "btnChangeOk";
            this.btnChangeOk.Size = new System.Drawing.Size(75, 23);
            this.btnChangeOk.TabIndex = 3;
            this.btnChangeOk.Text = "修改完成";
            this.btnChangeOk.UseVisualStyleBackColor = true;
            this.btnChangeOk.Click += new System.EventHandler(this.btnChangeOk_Click);
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Path,
            this.Hint,
            this.newPath,
            this.result});
            this.lvInfo.Location = new System.Drawing.Point(12, 47);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(499, 292);
            this.lvInfo.TabIndex = 2;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // Path
            // 
            this.Path.Text = "修改前路径";
            this.Path.Width = 161;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(22, 23);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(65, 12);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "正在修改：";
            // 
            // barChange
            // 
            this.barChange.Location = new System.Drawing.Point(107, 18);
            this.barChange.Name = "barChange";
            this.barChange.Size = new System.Drawing.Size(388, 23);
            this.barChange.TabIndex = 0;
            // 
            // newPath
            // 
            this.newPath.Text = "修改后路径";
            this.newPath.Width = 187;
            // 
            // result
            // 
            this.result.Text = "修改结果";
            this.result.Width = 83;
            // 
            // Hint
            // 
            this.Hint.Text = "  ";
            // 
            // FrmSongPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 380);
            this.Controls.Add(this.pnlJinDu);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblNewPath);
            this.Controls.Add(this.lblPath);
            this.Name = "FrmSongPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置歌曲路径";
            this.Load += new System.EventHandler(this.FrmSongPath_Load);
            this.pnlJinDu.ResumeLayout(false);
            this.pnlJinDu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblNewPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel pnlJinDu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangeOk;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ProgressBar barChange;
        private System.Windows.Forms.ColumnHeader newPath;
        private System.Windows.Forms.ColumnHeader result;
        private System.Windows.Forms.ColumnHeader Hint;
    }
}