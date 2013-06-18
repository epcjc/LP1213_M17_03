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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Tipos_de_quartos' table. You can move, or remove it, as needed.
            this.tipos_de_quartosTableAdapter.Fill(this.database1DataSet.Tipos_de_quartos);
            // TODO: This line of code loads data into the 'database1DataSet.Quarto' table. You can move, or remove it, as needed.
            this.quartoTableAdapter.Fill(this.database1DataSet.Quarto);
            // TODO: This line of code loads data into the 'database1DataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.database1DataSet.Cliente);

        }
    }
}
