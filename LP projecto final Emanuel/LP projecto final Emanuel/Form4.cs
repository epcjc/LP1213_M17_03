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
            // TODO: This line of code loads data into the 'database1DataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.database1DataSet.Cliente);
            // TODO: This line of code loads data into the 'database1DataSet.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.database1DataSet.Reserva);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue));

                MessageBox.Show("Inserido com Sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("erro em ensirrir");
            }
        }
    }
}