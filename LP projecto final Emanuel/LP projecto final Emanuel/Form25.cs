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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Reserva' table. You can move, or remove it, as needed.
            //this.reservaTableAdapter.Fill(this.database1DataSet.Reserva);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
                
           {
               this.reservaTableAdapter.Deletereserva(Convert.ToInt16(this.comboBox1.SelectedValue));
               MessageBox.Show("Eliminado com Sucesso");
               this.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());

           }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "RelatorioHotel.chm");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
