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
    public partial class RelatorioUtilizadorescs : Form
    {
        public RelatorioUtilizadorescs()
        {
            InitializeComponent();
        }

        private void RelatorioUtilizadorescs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Utilizadores' table. You can move, or remove it, as needed.
            this.UtilizadoresTableAdapter.Fill(this.Database1DataSet.Utilizadores);

            this.reportViewer1.RefreshReport();
        }
    }
}
