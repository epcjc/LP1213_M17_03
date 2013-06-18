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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Pagamento' table. You can move, or remove it, as needed.
            this.pagamentoTableAdapter.Fill(this.database1DataSet.Pagamento);

        }
    }
}
