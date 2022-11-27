using CourseFormApp.Exceptions;
using System.Linq.Expressions;

namespace CourseFormApp
{
    public partial class CourseFormApp : Form
    {
        public CourseFormApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // throw new OuerOwnException("Do not Click tkis button!!!");
            var throwExceptionExample = new ThrowExceptionExample();
            try 
            {
                throwExceptionExample.Run();
                MessageBox.Show("A jednak klikn¹³ no !");
            }
            catch ( OuerOwnException ex)
            {
                LogBox.Text += ex.Message + "\r\n";
                LogBox.Text += ex.StackTrace + "\r\n";
            }
            catch (Exception ex)    
            {
                LogBox.Text += ex.Message;
                LogBox.Text += ex.StackTrace;
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void HeightButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your height is :{HeightTexBox.Text}");
        }

        private void Calculate_Click(object sender, EventArgs e)
        {

            double zWynik = 0;
            if (AddRB.Checked == true)
            {
                try
                {
                    zWynik = Double.Parse(XBox.Text) + Double.Parse(YBox.Text);
                    Wynik.Text = Convert.ToString(zWynik);
                }
                catch(FormatException ex)
                {
                    var exceptionMeesage = ("Format Exception caught!\r\n");
                    LogBox.Text += exceptionMeesage;
                    LogBox.Text += ex.Message;
                    LogBox.Text += ex.StackTrace;
                }
                catch(Exception ex)
                {
                    Wynik.Text = "Invalid operation";
                    LogBox.Text += ex.Message;
                    LogBox.Text += ex.StackTrace;
                    LogBox.Text += ex.Source;
                }
                finally
                {
                  //  MessageBox.Show("Fina³");
                }
            } 
            else if (SubRB.Checked == true)
            {
                zWynik = Double.Parse(XBox.Text) - Double.Parse(YBox.Text);
                Wynik.Text = Convert.ToString(zWynik);
            }
            else if (MulRB.Checked == true)
            {
                zWynik = Double.Parse(XBox.Text) * Double.Parse(YBox.Text);
                Wynik.Text = Convert.ToString(zWynik);
            }
            else if (DivRB.Checked == true)
            {
                zWynik = Double.Parse(XBox.Text) / Double.Parse(YBox.Text);
                Wynik.Text = Convert.ToString(zWynik);
            }
            else
            {
                Wynik.Text = Wynik.Text;
            }
        }

        private void CourseFormApp_Load(object sender, EventArgs e)
        {

        }
    }
}