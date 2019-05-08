using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Account;
using LogIN;

namespace OOSE_Assignment
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LogIN.Class1.Verification(textBox1.Text, textBox2.Text) == true)
            {
                this.Hide();
                Order_Details o1 = new Order_Details();
                o1.Show();

            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
