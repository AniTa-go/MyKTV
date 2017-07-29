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
    public partial class FrmSongList : Form
    {
        DataView dv = new DataView();
        public FrmSongList()
        {
            InitializeComponent();
        }
        #region 窗口加载
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            //dgv不自动生成列
            dgvSongList.AutoGenerateColumns = false;
            //加载全部信息          
            dv = new MyKTV_.DBHelper().GetDataView("select s_i.song_id,song_name,songtype_name,song_url,song_play_count,s_t.songtype_id from dbo.song_info s_i inner join dbo.song_type s_t on(s_i.songtype_id=s_t.songtype_id)");
            dgvSongList.DataSource = dv;
            //绑定组合框
            new MyKTV_.DBHelper().BindComboBox(cmbType, "select * from song_type","songtype_name","songtype_id");
        }
        #endregion
        #region 查询歌手信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbType.SelectedValue) ==-1)
            {
                dv.RowFilter = "song_name like '%"+txtName.Text+"%'";
            }
            else
            {
                dv.RowFilter = string.Format("song_name like '%{0}%' and songtype_id = '{1}'", txtName.Text, cmbType.SelectedValue);
            }
        }
        #endregion
        #region 修改歌曲记录
        private void tsmiChange_Click(object sender, EventArgs e)
        {
            if (dgvSongList.SelectedCells ==null)
            {
                HintMessageBox.Information_hint("请选择歌曲");
                return;
            }
            FrmEditSong frmEditSong = new FrmEditSong();
            frmEditSong.song_id = Convert.ToInt32( dgvSongList.SelectedCells[0].Value);
            frmEditSong.ShowDialog();
            dv = new MyKTV_.DBHelper().GetDataView("select s_i.song_id,song_name,songtype_name,song_url,song_play_count from dbo.song_info s_i inner join dbo.song_type s_t on(s_i.songtype_id=s_t.songtype_id)");
        }
        #endregion
        #region 删除歌曲记录
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (new MyKTV_.DBHelper().ExecuteNonQuery(string.Format("delete song_info where song_id = '{0}'", dgvSongList.SelectedCells[0].Value)) > 0)
            {
                HintMessageBox.Information_hint("删除成功！！");
                dv = new MyKTV_.DBHelper().GetDataView("select s_i.song_id,song_name,songtype_name,song_url,song_play_count from dbo.song_info s_i inner join dbo.song_type s_t on(s_i.songtype_id=s_t.songtype_id)");
                dgvSongList.DataSource = dv;
            }
            else
            {
                HintMessageBox.Information_hint("删除失败！！");
            }
        }
        #endregion
    }
}
