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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.Instance.Money -= Int32.Parse(richTextBox1.Text);
            Class1.Instance.History.Add($"{DateTime.Now.ToLongTimeString()} tarihinde {richTextBox1.Text}TL para çekme işlemi.");
            BackMenu();
        }
        private void BackMenu()
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackMenu();
        }
    }
}
