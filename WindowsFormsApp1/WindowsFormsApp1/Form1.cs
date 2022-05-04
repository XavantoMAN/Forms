using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox3.Text);
            float c = Convert.ToInt32(textBox2.Text);
            float d;
            float x1, x2;
            d = (float)Math.Pow(b, 2) - 4 * a * c;
            if (d > 0 && a != 0)
            {
                float sqrt = (float)Math.Sqrt(d);
                x1 = ((-b) + sqrt) / (2 * a);
                x2 = ((-b) - sqrt) / (2 * a);
                label5.Text = $"x1={x1} x2={x2}";
            }
            else if (d == 0 && a != 0)
            {
                x1 = (-b) / (2 * a);
                label5.Text = $"x1={x1}";
            }
            else if (d < 0)
            {
                label5.Text = "Нет корней";
            }
            else if (d > 0 && a == 0)
            {
                float sqrt = (float)Math.Sqrt(d);
                x1 = ((-b) + sqrt) / 2;
                x2 = ((-b) - sqrt) / 2;
                label5.Text = $"x1={x1} x2={x2}";
            }
            else if (d == 0 && a == 0)
            {
                x1 = (-b) / 2;
                label5.Text = $"x1={x1}";
            }
        }
    }
}
