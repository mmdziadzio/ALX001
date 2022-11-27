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
            MessageBox.Show("A jednak klikn¹³ no !");
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
                catch(Exception ex)
                {
                    LogBox.Text = ex.Message;
                    Wynik.Text = "Invalid operation";
                }
                finally
                {
                    MessageBox.Show("Fina³");
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
    }
}