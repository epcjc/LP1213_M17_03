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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void preço_do_quartoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.preço_do_quartoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Quarto1' table. You can move, or remove it, as needed.
            this.quarto1TableAdapter.Fill(this.database1DataSet.Quarto1);
            // TODO: This line of code loads data into the 'database1DataSet.Quarto' table. You can move, or remove it, as needed.
            this.quartoTableAdapter.Fill(this.database1DataSet.Quarto);
            // TODO: This line of code loads data into the 'database1DataSet.Preço_do_quarto' table. You can move, or remove it, as needed.
            this.preço_do_quartoTableAdapter.Fill(this.database1DataSet.Preço_do_quarto);

        }

        private void expr1Label_Click(object sender, EventArgs e)
        {

        }

        private void expr1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void expr2Label_Click(object sender, EventArgs e)
        {

        }

        private void expr2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void expr3Label_Click(object sender, EventArgs e)
        {

        }

        private void expr3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void expr4Label_Click(object sender, EventArgs e)
        {

        }

        private void expr4TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_quartoLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_quartoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipo_quartoLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipo_quartoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void preco_quartoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void preco_quartoTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void andar_quartoLabel_Click(object sender, EventArgs e)
        {

        }

        private void andar_quartoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {

                
               this.preço_do_quartoTableAdapter.Insert(this.textBox1.Text);
                MessageBox.Show("Inserido com Sucesso");
                 
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

