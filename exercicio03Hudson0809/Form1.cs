namespace exercicio03Hudson0809
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            double calc;

            calc = temp + 273.15;

            textBox2.Text = calc.ToString();
        }
    }
}
