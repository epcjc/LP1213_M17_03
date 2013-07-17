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
            this.Validate();
            this.reservaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Quarto2' table. You can move, or remove it, as needed.
            this.quarto2TableAdapter.FillByAndar(this.database1DataSet.Quarto2);
            // TODO: This line of code loads data into the 'database1DataSet.Quarto1' table. You can move, or remove it, as needed.
           this.quarto1TableAdapter.Fill(this.database1DataSet.Quarto1);
            // TODO: This line of code loads data into the 'database1DataSet.Tipos_de_quartos' table. You can move, or remove it, as needed.
            this.tipos_de_quartosTableAdapter.Fill(this.database1DataSet.Tipos_de_quartos);
            // TODO: This line of code loads data into the 'database1DataSet.Tipos_de_quartos' table. You can move, or remove it, as needed.
           this.tipos_de_quartosTableAdapter.Fill(this.database1DataSet.Tipos_de_quartos);
            // TODO: This line of code loads data into the 'database1DataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.database1DataSet.Cliente);
            // TODO: This line of code loads data into the 'database1DataSet.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.database1DataSet.Reserva);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datareserva = new DateTime(Convert.ToInt16(this.comboBox4.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue),
               Convert.ToInt16(this.comboBox3.SelectedValue));
                DateTime datainicio = new DateTime(Convert.ToInt16(this.comboBox8.SelectedValue), Convert.ToInt16(this.comboBox7.SelectedValue),
               Convert.ToInt16(this.comboBox6.SelectedValue));
                DateTime datafim = new DateTime(Convert.ToInt16(this.comboBox11.SelectedValue), Convert.ToInt16(this.comboBox10.SelectedValue),
               Convert.ToInt16(this.comboBox9.SelectedValue));

                this.reservaTableAdapter.Insert(Convert.ToInt32(this.textBox2.Text), datareserva, Convert.ToDateTime(this.comboBox5.SelectedValue), datainicio, datafim,
               Convert.ToInt32(this.textBox7.Text), this.textBox8.Text, this.textBox9.Text);

                MessageBox.Show("Inserido com Sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("erro em ensirrir");
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