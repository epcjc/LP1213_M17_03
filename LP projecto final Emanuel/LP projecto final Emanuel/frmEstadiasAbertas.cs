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
    public partial class frmEstadiasAbertas : Form
    {
        private int id_reserva;
        private DateTime di;

        public frmEstadiasAbertas()
        {
            InitializeComponent();
        }

        private void frmEstadiasAbertas_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'database1DataSet.Estadias' table. You can move, or remove it, as needed.
            this.estadiasTableAdapter.FillByAbertas(this.database1DataSet.Estadias);

            this.estadiasDataGridView.Columns[4].DefaultCellStyle.Format = "C2";
            
        }

        private void estadiasDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTest;

            hitTest = estadiasDataGridView.HitTest(e.X, e.Y);

            if (e.Button == MouseButtons.Right)
            {
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {

                    this.contextMenuStrip1.Show(estadiasDataGridView, e.Location, ToolStripDropDownDirection.BelowRight);


                    int linhaSelecionada = hitTest.RowIndex;

                    DataGridViewRow dgv = this.estadiasDataGridView.Rows[linhaSelecionada];

                    id_reserva = Convert.ToInt16(dgv.Cells[0].Value);
                    di = Convert.ToDateTime(dgv.Cells[2].Value);


              

                }
            }
        }

        private void verServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicosEstadia frm = new frmServicosEstadia();
            frm.Id_reserva = id_reserva; 
            frm.ShowDialog();
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCalcularTotal frm = new frmCalcularTotal();
                frm.Id_reserva = id_reserva;
                frm.di = di;
                frm.ShowDialog();

                this.Close();
            }
            catch
            {
            }
            
        }
    }
}
