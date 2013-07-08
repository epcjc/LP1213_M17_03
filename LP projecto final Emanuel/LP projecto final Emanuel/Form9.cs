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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
                
            {
                this.preço_do_quartoTableAdapter.Deletepreço_do_quarto(Convert.ToInt16(this.comboBox1.SelectedValue));
                MessageBox.Show("Eliminado com Sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }*/
        }

        private void preço_do_quartoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.preço_do_quartoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void preço_do_quartoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.preço_do_quartoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Preço_do_quarto' table. You can move, or remove it, as needed.
            this.preço_do_quartoTableAdapter.Fill(this.database1DataSet.Preço_do_quarto);

        }
    }
}
