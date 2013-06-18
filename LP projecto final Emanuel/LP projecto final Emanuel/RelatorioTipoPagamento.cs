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
    public partial class RelatorioTipoPagamento : Form
    {
        public RelatorioTipoPagamento()
        {
            InitializeComponent();
        }

        private void RelatorioTipoPagamentocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Tipos_de_pagamento' table. You can move, or remove it, as needed.
            this.Tipos_de_pagamentoTableAdapter.Fill(this.Database1DataSet.Tipos_de_pagamento);

            this.reportViewer1.RefreshReport();
        }
    }
}
