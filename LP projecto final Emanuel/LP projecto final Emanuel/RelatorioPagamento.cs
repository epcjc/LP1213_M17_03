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
    public partial class RelatorioPagamento : Form
    {
        public RelatorioPagamento()
        {
            InitializeComponent();
        }

        private void RelatorioPagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Pagamento' table. You can move, or remove it, as needed.
            this.PagamentoTableAdapter.Fill(this.Database1DataSet.Pagamento);

            this.reportViewer1.RefreshReport();
        }
    }
}
