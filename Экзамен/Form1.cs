using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "log123" && textBox2.Text == "par123")
            {
                Заказчик z = new Заказчик();
                z.Show();
                this.Hide();
            }

            else
            {
                if(textBox1.Text == textBox2.Text)
                {
                    MessageBox.Show("Логин и пароль не могут быть одинаковыми.", "Внимание");

                    textBox1.Text = "";
                    textBox2.Text = "";

                    i++;
                    if (i >= 3)
                    {
                        button1.Enabled = false;
                        timer1.Start();
                        MessageBox.Show("Вы исчерпали доступное количество попыток. \nПодождите 5 сек.", "Внимание");
                    }
                }

                else
                {
                    Заказчик zk = new Заказчик();
                    zk.Show();
                    this.Hide();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            i = 0;
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
