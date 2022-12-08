using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_исключения_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static double f(double x)
        {
            try
            {
                if (x == 2) throw new Exception("Логарифм нуля = бесконечности");
                else return Math.Log(Math.Abs(x - 2));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                if (a >= b)
                {
                    MessageBox.Show("Начало должно быть меньше Конца");
                }
                else
                {
                    double h = double.Parse(textBox3.Text);

                    for (double i = a; i <= b; i += h)
                        try
                        {
                            richTextBox1.Text+="y("+i+")="+f(i)+"\n";
                        }
                        catch (Exception ex)
                        {
                            richTextBox1.Text += (ex.Message)+"\n";
                        }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода данных");
            }
        }
    }
}
