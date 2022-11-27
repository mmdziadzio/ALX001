using System.Text;

namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {
        public StringBuilder EexpressionBuilder { get; set; }

        public double xResult;
        public double yResult;
        public double result;
        public string mark = "";

        public CalculatorForm()
        {
            EexpressionBuilder = new StringBuilder();
            InitializeComponent();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EexpressionBuilder.Append(button.Tag);
            LogBox.Text += button.Tag;

            if (ResultBox.Text == "0")
            {
                if (button.Tag == ",") 
                {
                    ResultBox.Text += button.Tag;
                }
                else
                {
                    ResultBox.Text = "";
                    ResultBox.Text += button.Tag;
                }
            }
            else
            {
                    ResultBox.Text += button.Tag;
            }
        }

        private void Buttons_Function_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EexpressionBuilder.Append(button.Tag);
            LogBox.Text += button.Tag;                 

            if (button.Tag == "sqrt")       
            {
                mark = (string)button.Tag;
            }

            if (button.Tag == "x^2")
            {
                mark = (string)button.Tag;
            }

            if (mark == "")
            {
                xResult = double.Parse(ResultBox.Text);
                mark = (string)button.Tag;
                ResultBox.Text = "0";
                ExpBox.Text = EexpressionBuilder.ToString();
            }
            else if (mark == "+")
            {
                mark = (string)button.Tag;
                yResult = double.Parse(ResultBox.Text);
                result = xResult + yResult;
                xResult = result;
                ResultBox.Text = result.ToString();
                ExpBox.Text = EexpressionBuilder.ToString();

            }
            else if (mark == "-")
            {
                mark = (string)button.Tag;
                yResult = double.Parse(ResultBox.Text);
                result = xResult - yResult;
                xResult = result;
                ResultBox.Text = result.ToString();
                ExpBox.Text = EexpressionBuilder.ToString();
            }
            else if (mark == "*")
            {
                mark = (string)button.Tag;
                yResult = double.Parse(ResultBox.Text);
                result = xResult * yResult;
                xResult = result;
                ResultBox.Text = result.ToString();
                ExpBox.Text = EexpressionBuilder.ToString();
            }
            else if (mark == "/")
            {
                mark = (string)button.Tag;
                yResult = double.Parse(ResultBox.Text);
                result = xResult / yResult;
                xResult = result;
                ResultBox.Text = result.ToString();
                ExpBox.Text = EexpressionBuilder.ToString();
            }
            else if (mark == "=")
            {
                mark = "";
                ResultBox.Text = xResult.ToString();
                EexpressionBuilder.Append(ResultBox.Text);
                EexpressionBuilder.Append("\r\n"); 
                LogBox.Text += button.Tag;
                LogBox.Text += ResultBox.Text;
                ExpBox.Text += EexpressionBuilder.ToString();
                xResult = 0.0;
                ResultBox.Text = "0";
            }
            else if (mark == "sqrt")
            {
                mark = (string)button.Tag;
                yResult = double.Parse(ResultBox.Text);
                result = Math.Sqrt(yResult);
                xResult = result;
                ResultBox.Text = result.ToString();
                ExpBox.Text = EexpressionBuilder.ToString();
            }
            else if (mark == "x^2")
            {
                mark = (string)button.Tag;
                yResult = double.Parse(ResultBox.Text);
                result = yResult * yResult;
                xResult = result;
                ResultBox.Text = result.ToString();
                ExpBox.Text = EexpressionBuilder.ToString();
            }
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            ExpBox.Text += ResultBox.Text;
            LogBox.Text += ResultBox.Text;
            LogBox.Text += "\r\n";
            ResultBox.Text = "0";
            ExpBox.Text += "\r\n";
            EexpressionBuilder.Clear();
            mark = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            LogBox.Text = "";
            ResultBox.Text = "0";
            ExpBox.Text = "";
            EexpressionBuilder.Clear();
            mark = "";
            xResult = 0;
            yResult = 0;
            result = 0;
        }
    }
}