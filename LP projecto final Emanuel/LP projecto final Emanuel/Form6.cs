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
            this.clienteTableAdapter.Insert(
            this.clienteTableAdapter.Insert(this.textBox1.Text,
               this.textBox2.Text, Convert.ToInt32(this.textBox3.Text), Convert.ToInt16(this.listBox1.SelectedValue));

            MessageBox.Show("Inserido novo aluno");
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            

        }
    }
}
