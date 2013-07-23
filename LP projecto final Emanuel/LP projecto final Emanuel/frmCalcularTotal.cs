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
    public partial class frmCalcularTotal : Form
    {
        private int id_reserva;
        public DateTime di;

        private double precoNoite;
        private double totalServicos;

        private double Total;

        public int Id_reserva
        {
            get { return id_reserva; }
            set { id_reserva = value; }
        }


        public frmCalcularTotal()
        {
            InitializeComponent();
        }

        private void frmCalcularTotal_Load(object sender, EventArgs e)
        {
            totalServicos = Convert.ToDouble(this.servicosEstadiaTableAdapter.TotalPorReserva(id_reserva));

            this.label2.Text = String.Format("{0:C}", totalServicos);

            this.precoNoiteReservaTableAdapter.Fill(this.database1DataSet.PrecoNoiteReserva, Id_reserva);

            precoNoite =  Convert.ToDouble(database1DataSet.PrecoNoiteReserva.Rows[0][0]);
            this.label4.Text = 
                String.Format("{0:C}", precoNoite);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ndias = (Math.Ceiling((this.dateTimePicker1.Value - di).TotalDays));
           double precoQuartosTotal = precoNoite * Convert.ToInt16(ndias);

            label9.Text = ndias.ToString();

            this.label6.Text = 
                String.Format("{0:C}", precoQuartosTotal);

            Total = totalServicos + precoQuartosTotal;
            this.label11.Text =
                String.Format("{0:C}", Total);

            label4.Visible = true;
            label6.Visible = true;
            label9.Visible = true;

            label11.Visible = true;
            button3.Enabled = true;
            button2.Enabled = true;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reservaTableAdapter.Fechar("Fechada", this.dateTimePicker1.Value, id_reserva);
            this.reservaTableAdapter.SetTotal(Convert.ToDecimal(Total), id_reserva);
            this.Close();
        }
    }
}
