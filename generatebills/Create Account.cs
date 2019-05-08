using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogIN;
using Account;

namespace OOSE_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                Account.Account.Store(textBox1.Text, textBox3.Text);
                MessageBox.Show("Your Account Has been Created");
            }
            else
            {
                MessageBox.Show("Please re-enter your password. Make sure it's same in both the boxes");
            } 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            f1.Show();
            this.Hide();

        }
    }
}
