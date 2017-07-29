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
    public partial class FrmSingerList : Form
    {
        //DataView视图
        DataView dv = new DataView();
        public Form frmEditSong = new Form();
        public FrmSingerList()
        {
            InitializeComponent();
        }
        #region 查询歌手信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //如果两项条件都为空
            if (txtName.Text == "" && Convert.ToInt32(cmbSingerType.SelectedValue) == -1)
            {
                //加载全部歌手信息
                dv.RowFilter = "1=1";
            }
            //如果歌手类别为空
            else if (txtName.Text != "" && Convert.ToInt32(cmbSingerType.SelectedValue) == -1)
            {
                //根据歌手信息筛选信息
                dv.RowFilter = string.Format("singer_name like '%{0}%'", txtName.Text.Trim());
            }
            //如果歌手姓名为空，歌手类别不为空
            else if (txtName.Name == "" && Convert.ToInt32(cmbSingerType.SelectedValue) > 0)
            {
                //根据歌手类别筛选
                dv.RowFilter = string.Format("singertype_id = '{0}'", cmbSingerType.SelectedValue);
            }
            //两项都不为空
            else
            {
                dv.RowFilter = string.Format("singer_name like '%{0}%' and singertype_id = '{1}'", txtName.Text.Trim(), cmbSingerType.SelectedValue);
            }

        }
        #endregion
        #region 生成View视图
        public void GetDataView()
        {
            //查询全部歌手信息
            string sql = "select s_t.singerType_id,s_i.singer_id,singer_name,singer_sex,singertype_name,singer_photo_url,singer_Describe from singer_info s_i inner join singer_type s_t on s_i.singertype_id = s_t.singertype_id";
            DataSet ds = new MyKTV_.DBHelper().GetDataSet(sql);
            //使用DataTable对象生成DataView视图对象
            dv = ds.Tables["temp"].DefaultView;
            //绑定DataGridView数据源
            dgvSingerList.DataSource = dv;
        }
        #endregion
        #region 返回
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 窗体加载事件
        private void FrmSingerList_Load(object sender, EventArgs e)
        {
            dgvSingerList.AutoGenerateColumns = false;
            //加载全部歌手信息
            GetDataView();
            //绑定组合框
            new MyKTV_.DBHelper().BindComboBox(cmbSingerType, "select * from singer_type", "singertype_name", "singertype_id");
        }
        #endregion
        #region 修改歌手信息
        private void tsmiChange_Click(object sender, EventArgs e)
        {
            //获取选中歌手的主键
            if (dgvSingerList.SelectedCells[0] == null)
            {
                HintMessageBox.Warning_hint("请选择歌手!!");
                return;
            }
            FrmEditSinger frmEditSinger = new FrmEditSinger();
            frmEditSinger.singer_id = Convert.ToInt32(dgvSingerList.SelectedCells[0].Value);
            frmEditSinger.ShowDialog();
            GetDataView();//刷新数据
        }
        #endregion
        #region 删除歌手信息
        private void tsmiDelect_Click(object sender, EventArgs e)
        {
            if (dgvSingerList.SelectedCells[0] == null)
            {
                HintMessageBox.Warning_hint("请选择歌手!!");
                return;
            }
            int singer_id = Convert.ToInt32(dgvSingerList.SelectedCells[0].Value);
            if (MessageBox.Show("确定删除姓名为" + dgvSingerList.SelectedCells[1].Value + "的歌手吗？") == DialogResult.OK)
            {
                if (new MyKTV_.DBHelper().ExecuteNonQuery("DELETE singer_info where singer_id = '" + dgvSingerList.SelectedCells[0].Value + "'") > 0)
                {
                    HintMessageBox.Information_hint("删除成功！！");
                    GetDataView();//刷新数据
                }
                else
                {
                    HintMessageBox.Information_hint("删除失败！！");
                }
            }
        }
        #endregion
        #region 用户双击单元格选择歌手
        private void dgvSingerList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmEditSong ==null)
            {
                return;
            }
            frmEditSong.Tag = dgvSingerList.SelectedCells[1].Value;
            this.Close();
        }
        #endregion
    }
}
