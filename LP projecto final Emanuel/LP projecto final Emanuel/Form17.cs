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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);*/

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Preço_do_quarto' table. You can move, or remove it, as needed.
            this.preço_do_quartoTableAdapter.Fill(this.database1DataSet.Preço_do_quarto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "RelatorioHotel.chm");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }
    }
}
