using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "1":
                    label1.Text = "Понедельник";
                    break;
                case "2":
                    label1.Text = "Вторник";
                    break;
                case "3":
                    label1.Text = "Среда";
                    break;
                case "4":
                    label1.Text = "Четверг";
                    break;
                case "5":
                    label1.Text = "Пятница";
                    break ;
                case "6":
                    label1.Text = "Суббота";
                    break;
                case "7":
                    label1.Text = "Воскресенье";
                    break;
                default:
                    label1.Text = "Дня недели с такой цифрой нет";
                    break;

            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
