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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.ShowDialog();
        }

        private void reservaDoQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form16 frm = new Form16();
            frm.ShowDialog();
        }

        private void pesquizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 frm = new Form17();
            frm.ShowDialog();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 frm = new Form18();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form19 frm = new Form19();
            frm.ShowDialog();
        }

        private void pesquizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void pesquizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void tiposDeQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioTipoQuarto frm = new  RelatorioTipoQuarto();
            frm.ShowDialog();
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          RelatorioClientes frm = new RelatorioClientes();
            frm.ShowDialog();
            
        }

        private void pagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioPagamento frm = new RelatorioPagamento();
            frm.ShowDialog();
           
        }

        private void preçoDoQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioPrecoQuarto frm = new RelatorioPrecoQuarto();
            frm.ShowDialog();
            
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioQuarto frm = new RelatorioQuarto();
            frm.ShowDialog();
            
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RelatorioReserva frm = new RelatorioReserva();
            frm.ShowDialog();
        }

        private void tiposDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioTipoPagamento frm = new RelatorioTipoPagamento();
            frm.ShowDialog();
        }
       
    }
}
