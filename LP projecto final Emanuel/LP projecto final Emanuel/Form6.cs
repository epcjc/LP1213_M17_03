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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime datanascimento = new DateTime(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue),
                Convert.ToInt16(this.comboBox3.SelectedValue));

           this.clienteTableAdapter.Insert(this.textBox1.Text,
               this.textBox2.Text, Convert.ToInt32(this.textBox3.Text),this.textBox8.Text,datanascimento,
               Convert.ToInt32(this.textBox5.Text),Convert.ToInt32(this.textBox7.Text), null);

            MessageBox.Show("Inserido novo Cliente");
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
