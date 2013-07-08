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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Pagamento' table. You can move, or remove it, as needed.
            this.pagamentoTableAdapter.Fill(this.database1DataSet.Pagamento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {


                DateTime data = new DateTime(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue),
                     Convert.ToInt16(this.comboBox3.SelectedValue));
                this.pagamentoTableAdapter.Insert(Convert.ToInt32(this.textBox5.Text,this.textBox4.Text,this.textBox3.Text),Convert.ToDecimal(this.textBox1.Text), this.textBox2.Text, data);
                MessageBox.Show("Inserido com Sucesso");
             }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("erro em ensirrir");
            }
        */
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox1.Text == "")
                errorProvider1.SetError(this.textBox1, "nao pode ser vazio");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox2.Text == "")
                errorProvider1.SetError(this.textBox2, "nao pode ser vazio");
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "RelatorioHotel.chm");
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox6.Text == "")
                errorProvider1.SetError(this.textBox6, "nao pode ser vazio");
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox5.Text == "")
                errorProvider1.SetError(this.textBox5, "nao pode ser vazio");
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox4.Text == "")
                errorProvider1.SetError(this.textBox4, "nao pode ser vazio");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBox3.Text == "")
                errorProvider1.SetError(this.textBox3, "nao pode ser vazio");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form22 frm = new Form22();
            frm.ShowDialog();
        }
}
}
