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
    public partial class Form30 : Form
    {
        float cambio;
        public Form30()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float moeda = float.Parse(textBox1.Text);
            float result = moeda * cambio;
            this.textBox2.Text = result.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.cambio = 0.9796f;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.cambio = 0.6274f;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.cambio = 120.22f;
        }
    }
}
