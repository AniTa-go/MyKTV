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
    public partial class FrmEditSinger : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public FrmEditSinger() { InitializeComponent(); }                         
        //数据库辅助类
        MyKTV_.DBHelper db = new MyKTV_.DBHelper();
        //需要编辑信息的歌手记录的主键
        public int singer_id;
        string photoPath;
        #region 浏览歌手写真
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)//如果用户选中文件
            {
                //获取选中图片的绝对路径加载到图片框中
                picSingerPhoto.Image = Image.FromFile(System.IO.Path.GetFullPath(ofd.FileName));
                photoPath = ofd.FileName;
            }
        }
        #endregion
        #region 窗体加载
        private void rdoCombination_Load(object sender, EventArgs e)
        {
            //性别默认选中男
            rdoMale.Checked = true;
            //绑定组合框
            db.BindComboBox(cmbSingerType, "select * from singer_type", "singertype_name", "singertype_id");
            //如果不是通过修改歌手信息启动的该窗体,就提前结束该方法
            if (singer_id ==0)
            {
                return;
            }
            btnAdd.Text = "修改";
            string sql = string.Format("select singer_name,singertype_id,singer_sex,singer_photo_url,singer_Describe from dbo.singer_info where singer_id = '{0}'", singer_id);
            //添加歌手信息到信息编辑框内
            DataSet ds = db.GetDataSet(sql);
            txtName.Text = ds.Tables["temp"].Rows[0][0].ToString();
            cmbSingerType.SelectedValue = Convert.ToInt32(ds.Tables["temp"].Rows[0][1]);
            switch (ds.Tables["temp"].Rows[0][2].ToString())
            {
                case "男":
                    rdoMale.Checked = true;
                    break;
                case "女":
                    rdoFemale.Checked = true;
                    break;
                case "组合":
                    rdoCom.Checked = true;
                    break;
            }
            photoPath = ds.Tables["temp"].Rows[0][3].ToString();//写真图片的储存路径
            if (photoPath!=string.Empty)//当路径不为空时
            {
                picSingerPhoto.Image = Image.FromFile(photoPath);
            }           
            txtDescribe.Text = ds.Tables["temp"].Rows[0][4].ToString();
        }
        #endregion
        #region 添加歌手信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //非空验证
            if (txtName.Text ==""||Convert.ToInt32(cmbSingerType.SelectedValue)== -1)
            {
                HintMessageBox.Warning_hint("请填写完整带*项的信息!!");
                return;
            }
            //获取性别
            string sex;
            if (rdoMale.Checked == true)
            {
                sex = rdoMale.Text;
            }
            else if (rdoFemale.Checked == true)
            {
                sex = rdoFemale.Text;
            }
            else
            {
                sex = rdoCom.Text;
            }
            //获取用户输入的值
            string name = txtName.Text.Trim();//获取歌手姓名
            int singerType = Convert.ToInt32(cmbSingerType.SelectedValue);//歌手类型          
            photoPath = photoPath =="" ? System.IO.Path.GetFullPath(ofd.FileName): photoPath;//歌手写真的路径          
            string describe = txtDescribe.Text.Trim();//歌手简介
            //sql语句
            string sql = string.Empty;
            switch (btnAdd.Text.Trim())
            {
                case "添加":
                    //执行数据库插入操作的sql语句
                     sql = string.Format("insert singer_info values('{0}','{1}','{2}','{3}','{4}')", name, singerType, sex, photoPath, describe);                                                                 
                    break;
                case "修改":
                     sql = string.Format("update dbo.singer_info set singer_name = '{0}',singertype_id = '{1}',singer_sex = '{2}',singer_photo_url = '{3}',singer_Describe = '{4}' where singer_id = '{5}'",name,singerType,sex,photoPath,describe,singer_id);                   
                    break;
            }
            if (db.ExecuteNonQuery(sql) > 0)
            {
                HintMessageBox.Information_hint(btnAdd.Text.Trim()+"歌手信息成功！！");
            }
            else
            {
                HintMessageBox.Warning_hint(btnAdd.Text.Trim()+"失败！！");
            }           
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗口
        }
    }
}
