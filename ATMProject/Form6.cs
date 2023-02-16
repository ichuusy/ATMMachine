using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label3.Text = Class1.Instance.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackMenu();
        }
        private void BackMenu()
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BackMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Logout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.Instance.History.Add($"{DateTime.Now.ToLongTimeString()} tarihinde {Class1.Instance.Name} adından {richTextBox1.Text} adına değişim.");
            Class1.Instance.Name = richTextBox1.Text.ToString();
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
