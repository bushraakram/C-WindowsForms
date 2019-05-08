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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            string[,] array = new string[3, 3];
            array = Order1.Class1.info();
            textBox1.Text = array[0, 0];
            textBox2.Text = array[0, 1];
            textBox3.Text = array[0, 2];
            textBox4.Text = array[1, 0];
            textBox5.Text = array[1, 1];
            textBox6.Text = array[1, 2];
            textBox7.Text = array[2, 0];
            textBox8.Text = array[2, 1];
            textBox9.Text = array[2, 2];

            double x=Order1.Class1.calculate();
            textBox10.Text = Convert.ToString(x);

 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
