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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        #region 窗体加载
        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region 打开新增歌手窗体
        private void tsmiAddsinger_Click(object sender, EventArgs e)
        {
            FrmEditSinger frmEditSinger = new FrmEditSinger();
            frmEditSinger.MdiParent = this;//设置为子窗体
            frmEditSinger.Show();//打开窗体
        }
        #endregion
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//关闭应用程序
        }
        #region 查询歌手信息
        private void tsmiSearchSinger_Click(object sender, EventArgs e)
        {
            FrmSingerList frmSingerList = new FrmSingerList();
            frmSingerList.MdiParent = this;
            frmSingerList.Show();
        }
        #endregion
        #region 新增歌曲记录
        private void tsmiAddSong_Click(object sender, EventArgs e)
        {
            FrmEditSong frmEditSong = new FrmEditSong();
            frmEditSong.ShowDialog();//以模式对话框打开编辑歌曲信息菜单
        }
        #endregion
        #region 查询歌曲信息
        private void tsmiSearchSong_Click(object sender, EventArgs e)
        {
            FrmSongList frmSongList = new FrmSongList();
            frmSongList.Show();
        }
        #endregion
        //设置歌手写真路径
        private void tsmiSingerPhotoPath_Click(object sender, EventArgs e)
        {
            FrmSongPath frmSongPath = new FrmSongPath();
            string singer_photo_url = new MyKTV_.DBHelper().ExecuteScalar("select singer_photo_url from singer_info").ToString();
            frmSongPath.singer_photo_path = singer_photo_url.Substring(0,singer_photo_url.Length - singer_photo_url.Substring(singer_photo_url.LastIndexOf("\\")).Length+1);
            frmSongPath.Show();
        }
        /// <summary>
        /// 设置歌曲路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSongPath_Click(object sender, EventArgs e)
        {
            FrmSongPath frmSongPath = new FrmSongPath();
            string songPath = new MyKTV_.DBHelper().ExecuteScalar("select song_url from song_info").ToString();
            int songPathLength = songPath.Length;//路径总长度
            int filePathLength = songPath.Substring(songPath.LastIndexOf("\\")).Length;//文件名长度
            frmSongPath.song_path = songPath.Substring(0,songPathLength - filePathLength+1);//去掉文件名后的路径
            frmSongPath.Show();
        }
    }
}
