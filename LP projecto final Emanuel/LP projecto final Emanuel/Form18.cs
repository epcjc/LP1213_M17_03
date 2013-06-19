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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void quartoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quartoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void quartoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.quartoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Quarto' table. You can move, or remove it, as needed.
            this.quartoTableAdapter.Fill(this.database1DataSet.Quarto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                string message = "Confirmar !!";

                var result = MessageBox.Show(message, "Inserção",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.quartoTableAdapter.Insert(textBox1.Text, Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(textBox2.Text));
                    MessageBox.Show("Dados inseridos com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada !!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro !!");
                
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
}
