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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "1":
                    label1.Text = "Зима";
                    break;
                case "2":
                    label1.Text = "Зима";
                    break;
                case "3":
                    label1.Text = "Весна";
                    break;
                case "4":
                    label1.Text = "Весна";
                    break;
                case "5":
                    label1.Text = "Весна";
                    break;
                case "6":
                    label1.Text = "Лето";
                    break;
                case "7":
                    label1.Text = "Лето";
                    break;
                case "8":
                    label1.Text = "Лето";
                    break;
                case "9":
                    label1.Text = "Осень";
                    break;
                case "10":
                    label1.Text = "Осень";
                    break;
                case "11":
                    label1.Text = "Осень";
                    break;
                case "12":
                    label1.Text = "Зима";
                    break;
                default:
                    label1.Text = "Месяца с таким номером нет";
                    break;
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
