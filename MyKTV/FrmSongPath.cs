using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyKTV
{
    public partial class FrmSongPath : Form
    {
        public string song_path;
        public string singer_photo_path;
        //数据库辅助类
        MyKTV_.DBHelper db = new MyKTV_.DBHelper();
        public FrmSongPath()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongPath_Load(object sender, EventArgs e)
        {
            txtPath.Text = song_path == null ? singer_photo_path : song_path;    
            //根据情况修改窗体标题
            this.Text = song_path ==null ? "修改歌手照片路径" : "修改歌曲资源路径";
            txtPath.Text = song_path + singer_photo_path;
        }
        /// <summary>
        /// 保存修改按钮单击事件
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e">事件参数</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ////如果歌曲路径字符串为空则更改歌手写真路径
            //sql = song_path == string.Empty ? string.Format("update singer_info set singer_photo_url = '{0}'", txtNewPath.Text) : string.Format("update song_info set song_url = '{0}'", txtNewPath.Text);
            //if (db.ExecuteNonQuery(sql)>0)
            //{
            //    HintMessageBox.Information_hint("修改路径成功！！");
            //    this.Close();
            //}
            //else
            //{
            //    HintMessageBox.Information_hint("修改路径失败！！");
            //}
            //需要将数据库中所有的记录查询出来，然后截取路径到文件名。
            //显示修改进度条
            pnlJinDu.Visible = true;
            //清空listview视图
            lvInfo.Items.Clear();
            //sql语句-->查询
            string sql = string.Empty;
            sql = song_path == null ? string.Format("select singer_id,singer_photo_url from singer_info", txtNewPath.Text) : string.Format("select song_id,song_url from song_info", txtNewPath.Text);
            DataSet ds = db.GetDataSet(sql);//获得DataSet对象
            //修改每条记录的绝对路径
            for (int i = 0; i < ds.Tables["temp"].Rows.Count; i++)
            {
                string path = ds.Tables["temp"].Rows[i][1].ToString();//获取记录的路径
                string fileName = path.Substring(path.LastIndexOf("\\")+1);//获取文件名
                int id = Convert.ToInt32(ds.Tables["temp"].Rows[i][0]);//记录的id
                //sql语句 -->更新数据
                string sql_ = singer_photo_path == null ? string.Format("update song_info set song_url = '{0}' where song_id = '{1}'",txtNewPath.Text+fileName, id) : string.Format("update singer_info set singer_photo_url = '{0}' where singer_id = '{1}'", txtNewPath.Text + fileName, id);//更新进行更新操作的sql语句
                //修改数据到数据库                          
                ListViewItem item = new ListViewItem();
                item.Text = path;//修改前的路径
                item.SubItems.Add("-->");
                item.SubItems.Add(txtNewPath.Text + fileName);//修改后的路径
                int result = db.ExecuteNonQuery(sql_);
                item.SubItems.Add(result > 0 ? "修改成功！": "修改失败！！");
                lvInfo.Items.Add(item);               
            }            
        }
        /// <summary>
        /// 浏览文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)//如果用户选中文件
            {              
                txtNewPath.Text = ofd.FileName.Substring(0, ofd.FileName.Length - (ofd.FileName.Substring(ofd.FileName.LastIndexOf("\\")).Length)+1);
            }
        }
        /// <summary>
        /// 修改完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeOk_Click(object sender, EventArgs e)
        {
            pnlJinDu.Visible = false;
        }
    }
}
