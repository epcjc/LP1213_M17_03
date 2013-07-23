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
    public partial class frmTiposDeQuartos : Form
    {
        public frmTiposDeQuartos()
        {
            InitializeComponent();
        }

        private void tipos_de_quartosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipos_de_quartosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void frmTiposDeQuartos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Tipos_de_quartos' table. You can move, or remove it, as needed.
            this.tipos_de_quartosTableAdapter.Fill(this.database1DataSet.Tipos_de_quartos);

        }
    }
}
