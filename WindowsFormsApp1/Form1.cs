using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double _accumulator = 0.0;
        private string _pendingOperator = null;
        private bool _isNewEntry = true;

        public Form1()
        {
            InitializeComponent();
        }

        private string DisplayText
        {
            get => NumScreen.Text;
            set => NumScreen.Text = value;
        }

        // 숫자 버튼 처리
        private void Digit_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            var digit = btn.Text;

            if (_isNewEntry || DisplayText == "0" || DisplayText == "Error")
            {
                DisplayText = digit;
                _isNewEntry = false;
            }
            else
            {
                DisplayText += digit;
            }
        }

        // 소수점
        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (_isNewEntry || DisplayText == "Error")
            {
                DisplayText = "0.";
                _isNewEntry = false;
                return;
            }

            if (!DisplayText.Contains("."))
                DisplayText += ".";
        }

        // 연산자 
        private void Operator_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            ApplyPendingOperation();
            _pendingOperator = btn.Text;
            _isNewEntry = true;
        }

        // 이퀄 처리
        private void EqualBtn_Click(object sender, EventArgs e)
        {
            ApplyPendingOperation();
            _pendingOperator = null;
            _isNewEntry = true;
        }

        private void ApplyPendingOperation()
        {
            if (!double.TryParse(DisplayText, NumberStyles.Float, CultureInfo.InvariantCulture, out double current))
            {
                if (!double.TryParse(DisplayText, out current))
                {
                    DisplayText = "Error";
                    _isNewEntry = true;
                    return;
                }
            }

            if (_pendingOperator == null)
            {
                _accumulator = current;
                return;
            }

            double result = _accumulator;
            switch (_pendingOperator)
            {
                case "+":
                    result = _accumulator + current;
                    break;
                case "-":
                    result = _accumulator - current;
                    break;
                case "x":
                case "×":
                    result = _accumulator * current;
                    break;
                case "÷":
                case "/":
                    if (Math.Abs(current) < double.Epsilon)
                    {
                        DisplayText = "Error";
                        _accumulator = 0;
                        _pendingOperator = null;
                        _isNewEntry = true;
                        return;
                    }
                    result = _accumulator / current;
                    break;
                default:
                    result = current;
                    break;
            }

            _accumulator = result;
            DisplayText = result.ToString(CultureInfo.InvariantCulture);
            _isNewEntry = true;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            _accumulator = 0.0;
            _pendingOperator = null;
            _isNewEntry = true;
            DisplayText = "0";
        }

        // CE (CE는 현재 입력만 초기화)
        private void CEBtn_Click(object sender, EventArgs e)
        {
            DisplayText = "0";
            _isNewEntry = true;
        }

        // 지우기
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (_isNewEntry || DisplayText == "Error")
            {
                DisplayText = "0";
                _isNewEntry = true;
                return;
            }

            if (DisplayText.Length <= 1)
            {
                DisplayText = "0";
                _isNewEntry = true;
            }
            else
            {
                DisplayText = DisplayText.Substring(0, DisplayText.Length - 1);
            }
        }

        // ± 전환
        private void SwitchPM_Click(object sender, EventArgs e)
        {
            if (DisplayText == "Error") return;
            if (DisplayText.StartsWith("-"))
                DisplayText = DisplayText.Substring(1);
            else if (DisplayText != "0")
                DisplayText = "-" + DisplayText;
        }

        private void PercentBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(DisplayText, NumberStyles.Float, CultureInfo.InvariantCulture, out double current))
            {
                if (!double.TryParse(DisplayText, out current))
                {
                    DisplayText = "Error";
                    _isNewEntry = true;
                    return;
                }
            }

            double result;
            if (_pendingOperator != null)
                result = _accumulator * current / 100.0;
            else
                result = current / 100.0;

            DisplayText = result.ToString(CultureInfo.InvariantCulture);
            _isNewEntry = true;
        }

        // 1/x
        private void OneOverXBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(DisplayText, NumberStyles.Float, CultureInfo.InvariantCulture, out double current))
            {
                DisplayText = "Error";
                return;
            }

            if (Math.Abs(current) < double.Epsilon)
            {
                DisplayText = "Error";
                return;
            }

            DisplayText = (1.0 / current).ToString(CultureInfo.InvariantCulture);
            _isNewEntry = true;
        }

        // x^2
        private void SqrBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(DisplayText, NumberStyles.Float, CultureInfo.InvariantCulture, out double current))
            {
                DisplayText = "Error";
                return;
            }

            DisplayText = (current * current).ToString(CultureInfo.InvariantCulture);
            _isNewEntry = true;
        }

        // √x
        private void RootBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(DisplayText, NumberStyles.Float, CultureInfo.InvariantCulture, out double current))
            {
                DisplayText = "Error";
                return;
            }

            if (current < 0)
            {
                DisplayText = "Error";
                return;
            }

            DisplayText = Math.Sqrt(current).ToString(CultureInfo.InvariantCulture);
            _isNewEntry = true;
        }
    }
}
