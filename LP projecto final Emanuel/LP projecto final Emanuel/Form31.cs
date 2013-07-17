using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LP_projecto_final_Emanuel
{
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, calculo;

     
             n1 = Convert.ToInt32(textBox1.Text); 

             n2 = Convert.ToInt32(textBox2.Text);
        
            calculo = n1 + n2; 

            textBox3.Text = calculo.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, calculo;


            n1 = Convert.ToInt32(textBox1.Text);

            n2 = Convert.ToInt32(textBox2.Text);

            calculo = n1 - n2;

            textBox3.Text = calculo.ToString(); 
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1, n2, calculo;


            n1 = Convert.ToInt32(textBox1.Text);

            n2 = Convert.ToInt32(textBox2.Text);

            calculo = n1 * n2;

            textBox3.Text = calculo.ToString(); 
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1, n2, calculo;


            n1 = Convert.ToInt32(textBox1.Text);

            n2 = Convert.ToInt32(textBox2.Text);

            calculo = n1 / n2;

            textBox3.Text = calculo.ToString(); 
        
        }
    }
}
