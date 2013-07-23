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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void reservaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
           
            // TODO: This line of code loads data into the 'database1DataSet.Quarto' table. You can move, or remove it, as needed.
            this.quartoTableAdapter.Fill(this.database1DataSet.Quarto);
            // TODO: This line of code loads data into the 'database1DataSet.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.database1DataSet.Reserva);
            // TODO: This line of code loads data into the 'database1DataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.database1DataSet.Cliente);
           
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservaTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue),
                    null,
                    this.dateTimePicker1.Value,
                    null,
                    null,
                    this.textBox8.Text,
                    "aberta");

                int id_reserva = Convert.ToInt16(this.reservaTableAdapter.UltimoID());
                

                foreach (DataRowView drv in listBox1.SelectedItems)
                {

                    this.reserva_quartosTableAdapter.Insert(id_reserva, Convert.ToInt16(drv[0]));
                }


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("erro a inserir");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form25 frm = new Form25();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 frm = new Form24();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "RelatorioHotel.chm");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}