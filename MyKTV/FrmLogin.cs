using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmLogin : Form
    {
        //数据库辅助类
        MyKTV_.DBHelper db = new MyKTV_.DBHelper();
        public FrmLogin() { InitializeComponent(); }       
        #region 登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //非空验证
            if (txtUserName.Text =="")
            {
                HintMessageBox.Warning_hint("请输入账户姓名!!");
                return;
            }
            else if(txtPwd.Text =="")
            {
                HintMessageBox.Warning_hint("请输入账户密码!!");
                return;
            }
            //sql语句
            string sql = string.Format("select COUNT(*) from admin_info where admin_name = '{0}' and admin_pwd = '{1}'",txtUserName.Text.Trim(),txtPwd.Text.Trim());
            if (db.ExecuteScalar(sql) == null)
            {
                return;
            }
            if ((int)db.ExecuteScalar(sql)>0)
            {
                HintMessageBox.Information_hint("登录成功!!");
                FrmAdmin admin = new FrmAdmin();
                admin.Show();//显示后台管理主窗体
                this.Hide();//隐藏登录窗体
            }
            else
            {
                HintMessageBox.Information_hint("用户名或密码错误！！");
            }
        }
        #endregion
        private void btnCancel_Click(object sender, EventArgs e) { Application.Exit(); }//退出程序       
    }
}
