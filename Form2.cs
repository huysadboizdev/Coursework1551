using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1551
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void choice_Click(object sender, EventArgs e)
        {
            string huy = "Welcome " + textBox1.Text + " to the Olympic";
            MessageBox.Show(huy);
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            frm3 = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string huy = "Welcome " + textBox1.Text + " to the Olympic";
            MessageBox.Show(huy);
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
            frm4 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string huy = "Welcome " + textBox1.Text + " to the Olympic";
            MessageBox.Show(huy);
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            frm5 = null;
            this.Show();
        }
    }
}
