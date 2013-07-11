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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void utilizadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form28_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Utilizadores' table. You can move, or remove it, as needed.
            this.utilizadoresTableAdapter.Fill(this.database1DataSet.Utilizadores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
/*
            try
          {
              this.utilizadoresTableAdapter.Deleteutilizadores(Convert.ToInt16(this.comboBox1.SelectedValue));
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
