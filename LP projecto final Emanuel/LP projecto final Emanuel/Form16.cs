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
            try
            {

                DateTime datanascimento = new DateTime(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue),
                    Convert.ToInt16(this.comboBox3.SelectedValue));
                this.pagamentoTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text);
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
}
