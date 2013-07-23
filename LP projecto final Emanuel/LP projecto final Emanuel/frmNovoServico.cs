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
    public partial class frmNovoServico : Form
    {
        public frmNovoServico()
        {
            InitializeComponent();
        }

        private void frmNovoServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Servicos' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'database1DataSet.TiposServicos' table. You can move, or remove it, as needed.
            this.tiposServicosTableAdapter.Fill(this.database1DataSet.TiposServicos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.servicosTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue),this.textBox1.Text, Convert.ToDecimal(this.textBox2.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            
        }
    }
}
