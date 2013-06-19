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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.database1DataSet.Reserva);
            // TODO: This line of code loads data into the 'database1DataSet.Pagamento' table. You can move, or remove it, as needed.
            this.pagamentoTableAdapter.Fill(this.database1DataSet.Pagamento);
            // TODO: This line of code loads data into the 'database1DataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.database1DataSet.Cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
