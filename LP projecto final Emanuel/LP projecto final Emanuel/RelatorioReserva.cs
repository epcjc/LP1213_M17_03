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
    public partial class RelatorioReserva : Form
    {
        public RelatorioReserva()
        {
            InitializeComponent();
        }

        private void RelatorioReservacs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Reserva' table. You can move, or remove it, as needed.
            this.ReservaTableAdapter.Fill(this.Database1DataSet.Reserva);

            this.reportViewer1.RefreshReport();
        }
    }
}
