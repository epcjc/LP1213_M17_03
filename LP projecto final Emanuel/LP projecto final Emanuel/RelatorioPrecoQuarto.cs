﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LP_projecto_final_Emanuel
{
    public partial class RelatorioPrecoQuarto : Form
    {
        public RelatorioPrecoQuarto()
        {
            InitializeComponent();
        }

        private void PrecoQuarto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.Preço_do_quarto' table. You can move, or remove it, as needed.
            this.Preço_do_quartoTableAdapter.Fill(this.Database1DataSet.Preço_do_quarto);

            this.reportViewer1.RefreshReport();
        }
    }
}
