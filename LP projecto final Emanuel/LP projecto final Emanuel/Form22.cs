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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Pagamento1' table. You can move, or remove it, as needed.
           // this.pagamento1TableAdapter.Fill(this.database1DataSet.Pagamento1);
            // TODO: This line of code loads data into the 'database1DataSet.Tipos_de_pagamento' table. You can move, or remove it, as needed.
            this.tipos_de_pagamentoTableAdapter.Fill(this.database1DataSet.Tipos_de_pagamento);
            // TODO: This line of code loads data into the 'database1DataSet.Pagamento' table. You can move, or remove it, as needed.
            this.pagamentoTableAdapter.Fill(this.database1DataSet.Pagamento);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 frm = new Form16();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "RelatorioHotel.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form27 frm = new Form27();
            frm.ShowDialog();
        }
    }
}
