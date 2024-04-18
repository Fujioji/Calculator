using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public CalculatorForm()
        {
            InitializeComponent();

            var msg = "起動";

#if DEBUG
            Console.WriteLine(msg);
#else
            _logger.Info(msg);
#endif
        }

        /// <summary>
        /// 0キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyZero_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 1キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyOne_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 2キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyTwo_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 3キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyThree_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 4キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyFour_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 5キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyFive_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 6キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeySix_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 7キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeySeven_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 8キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyEight_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 9キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyNine_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// +/-キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyPlusMinus_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// .キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyPoint_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// ＋キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorKeyPlus_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// －キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorKeyMinus_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// ×キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorKeyMultiple_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// ÷キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorKeyDivide_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// ＝キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionKeyEqual_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// CEキー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionKeyClearEntry_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// Cキー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionKeyClear_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// ☒キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionKeyBackSpace_Click(object sender, EventArgs e)
        {
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        const string LOG_MSG_CLICKED = "押下：";

        private void outPutClickLog(string argButtonText, string argControlName)
        {
            var msg = LOG_MSG_CLICKED + argButtonText + " " + argControlName;
#if DEBUG
            Console.WriteLine(msg);
#else
            _logger.Info(msg);
#endif
        }
    }
}
