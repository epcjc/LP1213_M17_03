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
    public partial class RelatorioQuarto : Form
    {
        public RelatorioQuarto()
        {
            InitializeComponent();
        }

        private void RelatorioQuarto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Quarto' table. You can move, or remove it, as needed.
         //   this.QuartoTableAdapter.Fill(this.Database1DataSet.Quarto);

            this.reportViewer1.RefreshReport();
        }
    }
}
