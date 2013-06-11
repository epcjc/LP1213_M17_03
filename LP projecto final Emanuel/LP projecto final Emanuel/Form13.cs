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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void quartoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quartoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Quarto' table. You can move, or remove it, as needed.
            this.quartoTableAdapter.Fill(this.database1DataSet.Quarto);

        }
    }
}
