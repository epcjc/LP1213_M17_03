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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void tipos_de_pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipos_de_pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form26_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Tipos_de_pagamento' table. You can move, or remove it, as needed.
            this.tipos_de_pagamentoTableAdapter.Fill(this.database1DataSet.Tipos_de_pagamento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
           {
               this.tipos_de_pagamentoTableAdapter.Deletetipos_de_pagamento(Convert.ToInt16(this.comboBox1.SelectedValue));
               MessageBox.Show("Eliminado com Sucesso");
               this.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());

           }*/
        }
    }
}
