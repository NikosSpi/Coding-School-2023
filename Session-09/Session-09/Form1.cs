using CalculatorLibrary;

namespace Session_09
{
    public partial class Form1 : Form
    {
        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcOperation _calcOperation;

        enum CalcOperation
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            RaiseToPower
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrlOne_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 1 ";

            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 2 ";

            if (_value1 == null)
            {
                _value1 = 2;
            }
            else
            {
                _value2 = 2;
            }

        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 3 ";

            if (_value1 == null)
            {
                _value1 = 3;
            }
            else
            {
                _value2 = 3;
            }

        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 4 ";

            if (_value1 == null)
            {
                _value1 = 4;
            }
            else
            {
                _value2 = 4;
            }

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 5 ";

            if (_value1 == null)
            {
                _value1 = 5;
            }
            else
            {
                _value2 = 5;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 6 ";

            if (_value1 == null)
            {
                _value1 = 6;
            }
            else
            {
                _value2 = 6;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 7 ";

            if (_value1 == null)
            {
                _value1 = 7;
            }
            else
            {
                _value2 = 7;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 8 ";

            if (_value1 == null)
            {
                _value1 = 8;
            }
            else
            {
                _value2 = 8;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 9 ";

            if (_value1 == null)
            {
                _value1 = 9;
            }
            else
            {
                _value2 = 9;
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 0 ";

            if (_value1 == null)
            {
                _value1 = 0;
            }
            else
            {
                _value2 = 0;
            }
        }

        private void ctrlEquals_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " = ";

            switch (_calcOperation)
            {
                case CalcOperation.Addition:

                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value2);

                    break;
                case CalcOperation.Subtraction:

                    Subtraction subtraction = new Subtraction();
                    _result = subtraction.Do(_value1, _value2);

                    break;
                case CalcOperation.Multiplication:

                    Multiplication multiplication = new Multiplication();
                    _result = multiplication.Do(_value1, _value2);

                    break;
                case CalcOperation.Division:

                    Division division = new Division();
                    _result = division.Do(_value1, _value2);

                    break;
                case CalcOperation.RaiseToPower:

                    RaiseToPower raiseToPower = new RaiseToPower();
                    _result = raiseToPower.Do(_value1, _value2);

                    break;

                default:
                    break;
            }
            ctrlDisplay.Text += _result;
        }

        private void ctrlAddition_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " + ";
            _calcOperation = CalcOperation.Addition;
        }

        private void ctrlSubtraction_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " - ";
            _calcOperation = CalcOperation.Subtraction;
        }

        private void ctrlMultiplication_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " * ";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void ctrlDevision_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " / ";
            _calcOperation = CalcOperation.Division;
        }

        private void ctrlPower_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " ^ ";
            _calcOperation = CalcOperation.RaiseToPower;
        }
    }
    
}