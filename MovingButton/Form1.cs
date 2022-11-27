namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var randomInt = random.NextInt64(1, 250);
            var randomInt2 = random.NextInt64(1, 250);
           //var randomDouble = random.NextDouble();
            RandomButton.Top = (int)randomInt;
            RandomButton.Left = (int)randomInt2;
        }
    }
}