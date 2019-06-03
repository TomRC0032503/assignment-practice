using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // calculate the area of a rectangle
            try
            {



                double width, height, area;
                width = Convert.ToDouble(textBox2.Text);
                height = Convert.ToDouble(textBox1.Text);
                area = width * height;
                label1.Text = "area = " + area;
            }
            catch
            {
                MessageBox.Show("Please Type in 2 numbers");

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // calculate the area of a triangle
            try
            {
                double Base, height, area;
                Base = Convert.ToDouble(textBox3.Text);
                height = Convert.ToDouble(textBox4.Text);
                area = Base * height / 2;
                label6.Text = "area= " + area;


           }
            catch
            { 
              
    }
}
