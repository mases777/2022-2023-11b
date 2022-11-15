using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = double.Parse(textBox1.Text);
            var area = Math.PI * r * r;
            label3.Text = $"{area:f2}";
            label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var r = double.Parse(textBox1.Text);
            var perimeter = 2 * Math.PI * r;
            label3.Text = $"{perimeter:f2}";
            label3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
