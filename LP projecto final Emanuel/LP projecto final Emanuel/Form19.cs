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

        private void quarto2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quarto2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Reserva_quartos1' table. You can move, or remove it, as needed.
            this.reserva_quartos1TableAdapter.Fill(this.database1DataSet.Reserva_quartos1);
            // TODO: This line of code loads data into the 'database1DataSet.Reserva_quartos' table. You can move, or remove it, as needed.
            this.reserva_quartosTableAdapter.Fill(this.database1DataSet.Reserva_quartos);
            // TODO: This line of code loads data into the 'database1DataSet.Quarto2' table. You can move, or remove it, as needed.
            this.quarto2TableAdapter.FillByAndar(this.database1DataSet.Quarto2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "RelatorioHotel.chm");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form18 frm = new Form18();
            frm.ShowDialog();
        }
    }
}
