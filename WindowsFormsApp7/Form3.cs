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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "1":
                    label1.Text = "Это рабочий день";
                    break;
                case "2":
                    label1.Text = "Это рабочий день";
                    break;
                case "3":
                    label1.Text = "Это рабочий день";
                    break;
                case "4":
                    label1.Text = "Это рабочий день";
                    break;
                case "5":
                    label1.Text = "Это рабочий день";
                    break;
                case "6":
                    label1.Text = "Это суббота";
                    break;
                case "7":
                    label1.Text = "Это воскресенье";
                    break;
                default:
                    label1.Text = "Дня недели с такой цифрой нет";
                    break;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
