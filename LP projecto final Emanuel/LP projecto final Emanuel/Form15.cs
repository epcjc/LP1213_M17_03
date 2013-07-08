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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
                
           {
               this.quarto2TableAdapter.Deletequarto(Convert.ToInt16(this.comboBox1.SelectedValue));
               MessageBox.Show("Eliminado com Sucesso");
               this.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());

           }*/
        }

        private void quarto2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quarto2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Quarto2' table. You can move, or remove it, as needed.
            this.quarto2TableAdapter.FillByAndar(this.database1DataSet.Quarto2);

        }
       
    }
}
