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
    public partial class frmServicosPorTipo : Form
    {
        public frmServicosPorTipo()
        {
            InitializeComponent();
        }

        private void frmServicosPorTipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Servicos' table. You can move, or remove it, as needed.
            this.servicosTableAdapter.Fill(this.database1DataSet.Servicos);
            // TODO: This line of code loads data into the 'database1DataSet.TiposServicos' table. You can move, or remove it, as needed.
            this.tiposServicosTableAdapter.Fill(this.database1DataSet.TiposServicos);

        }
    }
}
