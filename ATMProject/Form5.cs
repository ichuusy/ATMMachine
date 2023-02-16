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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            for (int i = Class1.Instance.History.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(Class1.Instance.History[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label3.Text = Class1.Instance.Name;
            label5.Text = Class1.Instance.Money.ToString();
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(SetTime);
            tmr.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackMenu();
        }
        private void SetTime(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
        }

        private void BackMenu()
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
