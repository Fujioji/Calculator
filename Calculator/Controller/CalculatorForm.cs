using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Model;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // TODO:リスト化して「進む」「戻る」機能追加(ListViewを追加して連動させる、Windows電卓準拠)
        private CalculatorModel _calculatorModel;

        // TODO:メッセージ類の定数化
        const string SEPARATOR = " ";
        const string LOG_MSG_CLICKED = "押下";

        public CalculatorForm()
        {
            InitializeComponent();

            _calculatorModel = new CalculatorModel("0");
            DisplayMain.Text = _calculatorModel.GetLastElementString();

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
            numberClick(sender);
        }

        /// <summary>
        /// 1キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyOne_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// 2キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyTwo_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// 3キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyThree_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// 4キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyFour_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// 5キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyFive_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// 6キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeySix_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// 7キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeySeven_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// 8キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyEight_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// 9キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyNine_Click(object sender, EventArgs e)
        {
            numberClick(sender);
        }

        /// <summary>
        /// +/-キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyPlusMinus_Click(object sender, EventArgs e)
        {
            // TODO:機能追加 プラスマイナス反転(最後の要素が数値であれば-1をかける)
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// .キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberKeyPoint_Click(object sender, EventArgs e)
        {
            // TODO:機能追加 小数点入力(小数点以下は5桁まで)
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// ＋キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorKeyPlus_Click(object sender, EventArgs e)
        {
            operatorClick(sender);
        }

        /// <summary>
        /// －キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorKeyMinus_Click(object sender, EventArgs e)
        {
            operatorClick(sender);
        }

        /// <summary>
        /// ×キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorKeyMultiple_Click(object sender, EventArgs e)
        {
            operatorClick(sender);
        }

        /// <summary>
        /// ÷キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorKeyDivide_Click(object sender, EventArgs e)
        {
            operatorClick(sender);
        }

        /// <summary>
        /// ＝キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionKeyEqual_Click(object sender, EventArgs e)
        {
            var buttonText = ((Button)sender).Text;
            var buttonName = ((Button)sender).Name;
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);

            var result = _calculatorModel.Calculate();

            if (!result)
            {
                var errMsg = "計算時にエラー";
                outPutErrorLog(buttonText, buttonName, errMsg);
                return;
            }

            // ＝は画面表示の都合で付与する
            DisplaySub.Text = _calculatorModel.GetFormula() + SEPARATOR + "＝";

            var lastCalculationResult = _calculatorModel.CalculationResult.ToString();
            DisplayMain.Text = lastCalculationResult;

            _calculatorModel = new CalculatorModel(lastCalculationResult);
        }

        /// <summary>
        /// CEキー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionKeyClearEntry_Click(object sender, EventArgs e)
        {
            // TODO:機能追加 入力中の数値のみ消去(要素1つの初期化)
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// Cキー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionKeyClear_Click(object sender, EventArgs e)
        {
            // TODO:機能追加 入力中の数値、入力済みの数式を消す(全要素の初期化)
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// ☒キー押下イベントハンドラー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionKeyBackSpace_Click(object sender, EventArgs e)
        {
            // TODO:機能追加 入力中の数字を1文字消す
            outPutClickLog(((Button)sender).Text, ((Button)sender).Name);
        }

        /// <summary>
        /// 数字押下汎用メソッド
        /// </summary>
        /// <param name="sender"></param>
        private void numberClick(object sender)
        {
            // TODO:数字クリック時のイベントハンドラーをこのメソッドに集約

            var buttonText = ((Button)sender).Text;
            var buttonName = ((Button)sender).Name;
            outPutClickLog(buttonText, buttonName);

            var result = _calculatorModel.AddNumber((char)buttonText[0]);

            if (!result)
            {
                var errMsg = "数字追加時にエラー";
                outPutErrorLog(buttonText, buttonName, errMsg);
                return;
            }

            DisplayMain.Text = _calculatorModel.GetLastElementString();
        }

        /// <summary>
        /// 演算子押下汎用メソッド
        /// </summary>
        /// <param name="sender"></param>
        private void operatorClick(object sender)
        {
            // TODO:演算子クリック時のイベントハンドラーをこのメソッドに集約

            var buttonText = ((Button)sender).Text;
            var buttonName = ((Button)sender).Name;
            outPutClickLog(buttonText, buttonName);

            // TODO:要素数が3以上の場合に計算する

            var result = _calculatorModel.AddOperator((char)buttonText[0]);

            if (!result)
            {
                var errMsg = "演算子追加時にエラー";
                outPutErrorLog(buttonText, buttonName, errMsg);
                return;
            }

            DisplaySub.Text = _calculatorModel.GetFormula();
        }    

        /// <summary>
        /// 押下ログ出力
        /// </summary>
        /// <param name="argButtonText"></param>
        /// <param name="argControlName"></param>
        private void outPutClickLog(string argButtonText, string argControlName)
        {
            var msg = string.Join(SEPARATOR, LOG_MSG_CLICKED, argButtonText, argControlName);
#if DEBUG
            Console.WriteLine(msg);
#else
            _logger.Info(msg);
#endif
        }

        /// <summary>
        /// エラーログ出力
        /// </summary>
        /// <param name="argButtonText"></param>
        /// <param name="argControlName"></param>
        /// <param name="argErrMsg"></param>
        private void outPutErrorLog(string argButtonText, string argControlName, string argErrMsg)
        {
            // エラーは画面にも出力する
            DisplayMain.Text = argErrMsg;
            var msg = string.Join(SEPARATOR, LOG_MSG_CLICKED, argButtonText, argControlName, argErrMsg);
#if DEBUG
            Console.WriteLine(msg);
#else
            _logger.Error(msg);
#endif
        }
    }
}
