using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    /// <summary>
    /// 計算クラス
    /// </summary>
    internal class CalculatorModel
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private List<CalculationElement> _calculationElements;

        private decimal _calculationResult;

        public decimal CalculationResult { get { return _calculationResult; } }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="argString"></param>
        internal CalculatorModel(string argString)
        {
            _calculationElements = new List<CalculationElement>();
            CalculationElement initialElement;

            if (argString.Length == 1)
            {
                initialElement = new CalculationElement((char)argString[0], CalculationElement.ElementKind.Number);
            }
            else
            {
                initialElement = new CalculationElement(argString, CalculationElement.ElementKind.Number);
            }

            _calculationElements.Add(initialElement);

            _calculationResult = 0;
        }

        /// <summary>
        /// 最後の要素の文字列取得
        /// </summary>
        /// <returns></returns>
        public string GetLastElementString()
        {
            var lastElement = _calculationElements.Last();
            return lastElement.MyString;
        }

        /// <summary>
        /// 数字追加
        /// </summary>
        /// <param name="argChar"></param>
        /// <returns></returns>
        public bool AddNumber(char argChar)
        {
            var lastElement = _calculationElements.Last();
            var result = true;

            if (lastElement.Kind == CalculationElement.ElementKind.Operator)
            {
                // 前回入力が演算子であれば新規要素として追加
                var nextElement = new CalculationElement(argChar, CalculationElement.ElementKind.Number);
                _calculationElements.Add(nextElement);
            }
            else
            {
                // 前回入力が数字であれば末尾に文字列追加
                result = lastElement.AddNumber(argChar);
            }
            
            return result;
        }

        /// <summary>
        /// 演算子追加
        /// </summary>
        /// <param name="argChar"></param>
        /// <returns></returns>
        public bool AddOperator(char argChar)
        {
            // TODO:このポカよけは削除できる
            switch (argChar)
            {
                case '＋':
                case '－':
                case '×':
                case '÷':
                    break;
                default:
                    return false;
            }

            var lastElement = _calculationElements.Last();
            if (lastElement.Kind == CalculationElement.ElementKind.Operator)
            {
                // 前回入力が演算子であれば入れ替えるために削除
                _calculationElements.Remove(lastElement);
            }

            // TODO:要素数が3以上の場合に計算する

            var newElement = new CalculationElement(argChar, CalculationElement.ElementKind.Operator);
            _calculationElements.Add(newElement);

            return true;
        }

        /// <summary>
        /// 計算
        /// </summary>
        /// <returns></returns>
        public bool Calculate()
        {
            string firstNumStr;
            Decimal firstNum;

            switch (_calculationElements.Count)
            {
                case 1:
                    // 要素が1つであればそのまま計算結果として正常終了
                    firstNumStr = _calculationElements[0].MyString;
                    firstNum = System.Convert.ToDecimal(firstNumStr);
                    _calculationResult = firstNum;
                    return true;
                case 2:
                    // 要素が2つであれば1つ目の数字をコピーして同じ数字同士で演算を行う
                    // Windows標準の電卓の挙動に合わせる
                    firstNumStr = _calculationElements[0].MyString;
                    CalculationElement secondNumElement;

                    if (firstNumStr.Length == 1)
                    {
                        secondNumElement = new CalculationElement((char)firstNumStr[0], CalculationElement.ElementKind.Number);
                    }
                    else
                    {
                        secondNumElement = new CalculationElement(firstNumStr, CalculationElement.ElementKind.Number);
                    }

                    _calculationElements.Add(secondNumElement);
                    break;
                case 3:
                    break;
                default:
                    return false;
            }

            firstNumStr = _calculationElements[0].MyString;
            firstNum = System.Convert.ToDecimal(firstNumStr);
            var secondNumStr = _calculationElements[2].MyString;
            var secondNum = System.Convert.ToDecimal(secondNumStr);
            var nowOperator = _calculationElements[1].MyString;
            decimal result;

            // TODO:演算子の定数化

            switch (nowOperator)
            {
                case "＋":
                    result = firstNum + secondNum;
                    break;
                case "－":
                    result = firstNum - secondNum;
                    break;
                case "×":
                    result = firstNum * secondNum;
                    break;
                case "÷":
                    result = firstNum / secondNum;
                    break;
                default:
                    return false;
            }

            _calculationResult = result;
            return true;
        }

        const string SEPARATOR = " ";

        /// <summary>
        /// 要素を連結した数式取得
        /// </summary>
        /// <returns></returns>
        public string GetFormula()
        {
            var elementsStrings = _calculationElements.Select(x => x.MyString);
            return string.Join(SEPARATOR, elementsStrings);
        }

        /// <summary>
        /// 計算用の要素クラス
        /// </summary>
        private class CalculationElement
        {
            public enum ElementKind
            {
                Number,
                Operator,
                Equal,
                Other
            }

            private ElementKind _kind;
            public ElementKind Kind { get { return _kind; } }

            private string _myString;

            public string MyString { get { return _myString; } }

            /// <summary>
            /// 1文字用コンストラクタ(1文字と確定している時はこちらを使う)
            /// </summary>
            /// <param name="argChar"></param>
            /// <param name="argElementKind"></param>
            public CalculationElement(char argChar, ElementKind argElementKind)
            {
                _myString = argChar.ToString();
                _kind = argElementKind;
            }

            /// <summary>
            /// 文字列用コンストラクタ
            /// </summary>
            /// <param name="argString"></param>
            /// <param name="argElementKind"></param>
            public CalculationElement(string argString, ElementKind argElementKind)
            {
                _myString = argString;
                _kind = argElementKind;
            }

            /// <summary>
            /// 末尾に数字追加
            /// </summary>
            /// <param name="argChar"></param>
            /// <returns></returns>
            public bool AddNumber(char argChar)
            {
                int number;

                if (!int.TryParse(argChar.ToString(), out number))
                {
                    return false;
                }

                if (this._myString.Equals("0"))
                {
                    this._myString = number.ToString();
                }
                else
                {
                    this._myString = this._myString + number.ToString();
                }

                return true;
            }
        }
    }
}
