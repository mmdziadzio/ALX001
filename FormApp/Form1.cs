namespace HardCoded

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardCoddetButton = new Button();
            HardCoddetButton.Parent = this;
            HardCoddetButton.Top = 12;
            HardCoddetButton.Left = 12;
            HardCoddetButton.Text = "HardCoddetButton";
            HardCoddetButton.Width = 500;
            HardCoddetButton.Click += new System.EventHandler(SayHallo);
            HardCoddetButton.Click += new System.EventHandler(ExtendedButton);

        }

        private void SayHallo(Object sender, EventArgs args)
        {
            MessageBox.Show("Hello World");
        }

        private void ExtendedButton(Object sender, EventArgs args)
        {
            HardCoddetButton.Width += 10;
        }
    }
}