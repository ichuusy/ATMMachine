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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1.ObjeVer();
            Class1.Instance.Money = 2500;
            Class1.Instance.Name = "Zeynep Sude Ubuz";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text == "1234" && radioButton1.Checked) 
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
