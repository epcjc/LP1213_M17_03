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
    public partial class frmServicosEstadia : Form
    {
        private int id_reserva;

        private int linhaServicoRemover;

        public int Id_reserva
        {
            get { return id_reserva; }
            set { id_reserva = value; }
        }

        private DataGridViewRow dgvSeleccionada;

        private ServicosEstadia servicos;

        public frmServicosEstadia()
        {
            InitializeComponent();
        }

        private void frmServicosEstadia_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet.Servicos' table. You can move, or remove it, as needed.
            this.servicosTableAdapter.Fill(this.database1DataSet.Servicos);
            // TODO: This line of code loads data into the 'database1DataSet.TiposServicos' table. You can move, or remove it, as needed.
            this.tiposServicosTableAdapter.Fill(this.database1DataSet.TiposServicos);

            this.servicosEstadiaTableAdapter.FillByIdReserva(this.database1DataSet.ServicosEstadia, Id_reserva);

            servicos = new ServicosEstadia(this.database1DataSet.ServicosEstadia);

            servicos.Id_reserva = Id_reserva;
            this.dataGridView2.DataSource = servicos.Tabela;


            this.dataGridView2.Columns[3].DefaultCellStyle.Format = "C2";

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTest;

            hitTest = dataGridView1.HitTest(e.X, e.Y);

            if (e.Button == MouseButtons.Right)
            {
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {

                    this.contextMenuStrip1.Show(dataGridView1, e.Location, ToolStripDropDownDirection.BelowRight);


                    int linhaSelecionada = hitTest.RowIndex;

                    dgvSeleccionada = this.dataGridView1.Rows[linhaSelecionada];

                    //int id_reserva = Convert.ToInt16(dgv.Cells[0].Value);

                }
            }
        }

        private void adicionarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servicos.adicionar(dgvSeleccionada);

            this.dataGridView2.DataSource = servicos.Tabela;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.servicosEstadiaTableAdapter.EliminarPorReserva(Id_reserva);
                foreach (DataRow r in servicos.Tabela.Rows)
                {
                    this.servicosEstadiaTableAdapter.Insert(id_reserva, Convert.ToInt16(r.ItemArray[1]),
                        null,
                        Convert.ToInt16(r.ItemArray[2]),
                        Convert.ToInt16(r.ItemArray[3]));
                }
                this.Close();
            }
            catch {
                MessageBox.Show("Erro a guardar");
            }
            
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servicos.remover(linhaServicoRemover);

            this.dataGridView2.DataSource = servicos.Tabela;
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTest;

            hitTest = dataGridView2.HitTest(e.X, e.Y);

            if (e.Button == MouseButtons.Right)
            {
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {

                    this.contextMenuStrip2.Show(dataGridView2, e.Location, ToolStripDropDownDirection.BelowRight);

                    linhaServicoRemover = hitTest.RowIndex;

                    //DataGridViewRow dgv = this.dataGridView1.Rows[hitTest.RowIndex];

                    //idServicoRemover = Convert.ToInt16(dgv.Cells[1].Value);

                }
            }
        }
    }
}
