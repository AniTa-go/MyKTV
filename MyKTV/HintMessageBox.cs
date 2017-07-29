using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyKTV
{
    /// <summary>
    /// 提示窗口类
    /// </summary>
    public static class HintMessageBox
    {
        /// <summary>
        /// 警告提示
        /// </summary>
        /// <param name="hint"></param>
        public static void Warning_hint(string hint)
        {
            MessageBox.Show(hint,"警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        /// <summary>
        /// 询问用户选择提示
        /// </summary>
        /// <param name="hint"></param>
        public static void Question_hint(string hint)
        {
            MessageBox.Show(hint,"请选择",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
        }
        /// <summary>
        /// 出现异常提示
        /// </summary>
        /// <param name="hint"></param>
        public static void Error_hint(string hint)
        {
            MessageBox.Show(hint,"异常提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }
        /// <summary>
        /// 普通提示
        /// </summary>
        /// <param name="hint"></param>
        public static void Information_hint(string hint)
        {
            MessageBox.Show(hint, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
