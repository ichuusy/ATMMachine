using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.Instance.Money += Int32.Parse(richTextBox1.Text);
            Class1.Instance.History.Add($"{DateTime.Now.ToLongTimeString()} tarihinde {richTextBox1.Text}TL para yatırma işlemi.");
            BackMenu();
            
        }
        private void BackMenu() 
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
