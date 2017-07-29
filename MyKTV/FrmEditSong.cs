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
   
    public partial class FrmEditSong : Form
    {
        //数据库辅助类
        MyKTV_.DBHelper db = new MyKTV_.DBHelper();
        public FrmEditSong()
        {
            InitializeComponent();
        }
        public  int song_id;
        #region 查询歌曲信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSingerList frmSinger = new FrmSingerList();
            frmSinger.frmEditSong = this;
            frmSinger.ShowDialog();
            if (this.Tag!=null)
            {
                txtSinger.Text = this.Tag.ToString();
            }            
        }
        #endregion
        #region 选择歌曲
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)//如果选中了文件
            {
                //获取文件的文件名
                txtSongFileName.Text = ofd.FileName;
                //截取文件名
                //txtSongFileName.Text = txtSongFileName.Text.Substring(txtSongFileName.Text.LastIndexOf("\\")+1);
            }
        }
        #endregion
        #region 保存歌曲信息
        private void btnSave_Click(object sender, EventArgs e)
        {
            //非空验证
            if (txtSongName.Text==""||txtPinYin.Text==""||Convert.ToInt32(cmbSongType.SelectedValue)==-1||txtSongFileName.Text =="")
            {
                HintMessageBox.Information_hint("请填写完整带 * 的项!!");
                return;
            }
            //获取用户输入的值
            string songName = txtSongName.Text;
            string pinYin = txtPinYin.Text;
            string songFileName = txtSongFileName.Text;
            int singer =Convert.ToInt32(db.ExecuteScalar(string.Format("select singer_id from dbo.singer_info where singer_Name = '{0}'",txtSinger.Text)));
            int songtype =Convert.ToInt32(cmbSongType.SelectedValue);
            int wordNum =Convert.ToInt32(nudWordCount.Value);
            string sql ="";
            switch (btnSave.Text)
            {
                case "保存":
                    sql = string.Format("insert dbo.song_info values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",songName,pinYin,wordNum,songtype,singer,songFileName,0);
                    break;
                case "保存修改":
                    sql = string.Format("UPDATE [MyKTV].[dbo].[song_info]  SET [song_name] = '{0}',[song_ab] ='{1}',[song_word_count] = '{2}',[songtype_id] = '{3}',[singer_id] = '{4}',[song_url] = '{5}' WHERE song_id='{6}'", songName, pinYin, wordNum, songtype, singer, songFileName,song_id);
                    break;
            }
            if (db.ExecuteNonQuery(sql)>0)
            {
                HintMessageBox.Information_hint(btnSave.Text+"歌曲成功！！");                
            }
            else
            {
                HintMessageBox.Warning_hint(btnSave.Text+ "歌曲失败！！");     
            }
        }
        #endregion
        #region 窗体加载
        private void FrmEditSong_Load(object sender, EventArgs e)
        {
            //绑定组合框
            db.BindComboBox(cmbSongType, "select * from song_type", "songtype_name", "songtype_id");
            if (song_id ==0)
            {
                return;
            }
            //添加信息到文本框中
            btnSave.Text = "保存修改";
            string sql = string.Format("select song_name,song_ab,song_word_count,songtype_id,song_url,singer_name from dbo.song_info,singer_info where song_id = '{0}' and singer_info.singer_id = song_info.singer_id", song_id);
            DataSet ds = db.GetDataSet(sql);

            txtSongName.Text = ds.Tables["temp"].Rows[0][0].ToString();

            txtPinYin.Text = ds.Tables["temp"].Rows[0][1].ToString();

            nudWordCount.Value = Convert.ToInt32(ds.Tables["temp"].Rows[0][2]);

            cmbSongType.SelectedValue = Convert.ToInt32(ds.Tables["temp"].Rows[0][3]);

            txtSongFileName.Text = ds.Tables["temp"].Rows[0][4].ToString();

            txtSinger.Text = ds.Tables["temp"].Rows[0][5].ToString();
        }
        #endregion      
        private void btnClose_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }
        #region 计算输入歌曲名的字数
        private void txtSongName_TextChanged(object sender, EventArgs e)
        {
            nudWordCount.Value = txtSongName.Text.Length;
        }
        #endregion

    }
}
