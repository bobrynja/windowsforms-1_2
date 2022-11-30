using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1_2
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
                int num = Convert.ToInt32(textBox2.Text);
                if ((9 < num && num < 100) || (-9 > num && num > -99))
                {
                    string a = num.ToString();
                    int sum = 0;
                    if (num > 0)
                    {
                        sum = Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]);
                    }
                    else { sum = Convert.ToInt32(a[1]) + Convert.ToInt32(a[2]); };
                    if (sum % 3 == 0) { textBox1.Text = "Сумма цифр кратна 3"; }
                    else textBox1.Text = "Сумма цифр не кратна 3 ";
                }
                else MessageBox.Show("Некорректный ввод данных");
            }
            catch { MessageBox.Show("Некорректный ввод данных"); }
        }

        
    }
}
