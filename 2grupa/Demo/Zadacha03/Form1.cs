namespace Zadacha03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = double.Parse(textBox1.Text);
            var b = double.Parse(textBox2.Text);
            label1.Text = $"{a + b}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = double.Parse(textBox1.Text);
            var b = double.Parse(textBox2.Text);
            label1.Text = $"{a - b}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = double.Parse(textBox1.Text);
            var b = double.Parse(textBox2.Text);
            label1.Text = $"{a * b}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var a = double.Parse(textBox1.Text);
            var b = double.Parse(textBox2.Text);
            label1.Text = $"{a / b}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}