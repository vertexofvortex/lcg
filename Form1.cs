using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Value_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void Value_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void Value_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void Value_k_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int a, b, c, k, result = 0, firstResult, period = 0;
            bool isEnd = false;
            Result.Clear();

            if (
                int.TryParse(Value_a.Text, out a) && int.TryParse(Value_b.Text, out b) && int.TryParse(Value_c.Text, out c) && int.TryParse(Value_k.Text, out k)
                )
            {

                firstResult = (a * k + b) % c;

                for (int i = 0; i < Count.Value; i++)
                {
                    result = (a * k + b) % c;
                    k = result;
                    Result.AppendText(Convert.ToString(result) + ", ");
                }
                Result.AppendText("...");

                int.TryParse(Value_a.Text, out a);
                int.TryParse(Value_b.Text, out b);
                int.TryParse(Value_c.Text, out c);
                int.TryParse(Value_k.Text, out k);

                while (!isEnd)
                {
                    period++;
                    result = (a * k + b) % c;
                    k = result;

                    if ((result == firstResult) && (period > 2))
                    {
                        isEnd = true;
                        period -= 1;
                    }
                }
                PeriodBox.AppendText(Convert.ToString(period));
            }
            else
            {
                Result.AppendText("Одно или несколько из введённых начальных значений не являются целыми числами.");
            }
        }

        private void Count_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
