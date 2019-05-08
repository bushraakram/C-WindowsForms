using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order1;

namespace OOSE_Assignment
{
    public partial class Order_Details : Form
    {
        public Order_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (checkBox1.Checked)
               {
                   
                   Order1.Class1.Store(checkBox1.Text, textBox1.Text, textBox4.Text);
               }
           if (checkBox2.Checked)
           {
              
               Order1.Class1.Store(checkBox2.Text, textBox2.Text, textBox5.Text);
           }
           if (checkBox3.Checked)
           {
              
               Order1.Class1.Store(checkBox3.Text, textBox3.Text, textBox6.Text);
           }
           this.Hide();
           Billing b1 = new Billing();
           b1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
