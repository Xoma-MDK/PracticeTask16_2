using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTask16_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int varOne = int.Parse(textBox1.Text);
                int varTwo = int.Parse(textBox2.Text);
                int result = varOne / varTwo;
                textBox3.Text = Convert.ToString(result);

            }

            catch (FormatException)
            {
                textBox3.Text = "Неверный формат";

            }
            catch (DivideByZeroException)
            {
                textBox3.Text = "На 0 делить нельзя!";
            }
            catch {
                textBox3.Text = "Возникла ошибка";
            }
        }
    }
}
