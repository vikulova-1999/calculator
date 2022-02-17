using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool DoubleTryParseCustom(string textA, out double numA, string textB, out double  numB)
        {
            if (double.TryParse(textA, out numA))
            {
                if (double.TryParse(textB, out numB))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при вводе аргумента - аргумент №2");
                    numA = numB = 0;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ошибка при вводе аргумента - аргумент №1");
                numA = numB = 0;
                return false;
            }
        }

        private static bool IntTryParseCustom(string textA, out int numA, string textB, out int numB)
        {
            if (int.TryParse(textA, out numA))
            {
                if (int.TryParse(textB, out numB))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при вводе аргумента - аргумент №2");
                    numA = numB = 0;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ошибка при вводе аргумента - аргумент №1");
                numA = numB = 0;
                return false;
            }
        }

        private static bool BoolTryParseCustom(string textA, out bool numA, string textB, out bool numB)
        {
            if (bool.TryParse(textA, out numA))
            {
                if (bool.TryParse(textB, out numB))
                {
                    return true;
                }
                else
                {
                    //MessageBox.Show("Ошибка при вводе аргумента - аргумент №2");
                    numA = numB = false;
                    return false;
                }
            }
            else
            {
                //MessageBox.Show("Ошибка при вводе аргумента - аргумент №1");
                numA = numB = false;
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text,out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} + {1} = {2}", a, b, a + b));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} - {1} = {2}", a, b, a - b));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} * {1} = {2}", a, b, a * b));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} / {1} = {2}", a, b, a / b));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} % {1} = {2}", a, b, a % b));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a, b;
            bool bA, bB;
            if (BoolTryParseCustom(textBox1.Text, out bA, textBox2.Text, out bB))
            {
                listBox1.Items.Add(string.Format("{0} & {1} = {2}", bA, bB, bA & bB));
                return;
            }

            if (IntTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} & {1} = {2}", a, b, a & b));
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a, b;
            bool bA, bB;
            if (BoolTryParseCustom(textBox1.Text, out bA, textBox2.Text, out bB))
            {
                listBox1.Items.Add(string.Format("{0} | {1} = {2}", bA, bB, bA | bB));
                return;
            }

            if (IntTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} | {1} = {2}", a, b, a | b));
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a, b;
            bool bA, bB;
            if (BoolTryParseCustom(textBox1.Text, out bA, textBox2.Text, out bB))
            {
                listBox1.Items.Add(string.Format("{0} ^ {1} = {2}", bA, bB, bA ^ bB));
                return;
            }
            if (IntTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} ^ {1} = {2}", a, b, a ^ b));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a;
            bool b;
            if (bool.TryParse(textBox1.Text, out b))
            {
                listBox1.Items.Add(string.Format("~{0} = {1}", b, !b));
            }

            if (int.TryParse(textBox1.Text, out a))
            {
                listBox1.Items.Add(string.Format("~{0} = {1}", a, ~a));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} > {1} = {2}", a, b, a > b));
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} < {1} = {2}", a, b, a < b));
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} >= {1} = {2}", a, b, a >= b));
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} <= {1} = {2}", a, b, a <= b));
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double a, b;
            if (DoubleTryParseCustom(textBox1.Text, out a, textBox2.Text, out b))
            {
                listBox1.Items.Add(string.Format("{0} == {1} = {2}", a, b, a == b));
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox1.Text, out a))
            {
                if (a < 0)
                {
                    listBox1.Items.Add(string.Format("{0} == ^2? = {1}", a, false));
                    return;
                }
                bool isPowerOfTwo = (a != 0) && (a & (a - 1)) == 0;
                listBox1.Items.Add(string.Format("{0} == ^2? = {1}", a, isPowerOfTwo));
            }
            else
            {
                MessageBox.Show("Ошибка при вводе аргумента - аргумент №1");
                return;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBox1.Text, out a))
            {
                listBox1.Items.Add(string.Format("SIN({0}) = {1}", a, Math.Sin(a)));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBox1.Text, out a))
            {
                listBox1.Items.Add(string.Format("TAN({0}) = {1}", a, Math.Tan(a)));
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(textBox1.Text, out a))
            {
                listBox1.Items.Add(string.Format("E^{0}) = {1}", a, Math.Pow(Math.E, a)));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
