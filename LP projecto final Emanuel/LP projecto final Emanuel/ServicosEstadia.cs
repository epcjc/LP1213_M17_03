using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace LP_projecto_final_Emanuel
{
    class ServicosEstadia
    {
        private DataTable _tabela;
        private double _total;

        public DataTable Tabela
        {
            get { return _tabela; }
        }

        private int id_reserva;

        public int Id_reserva
        {
            get { return id_reserva; }
            set { id_reserva = value; }
        }

        public ServicosEstadia(DataTable t)
        {
            _tabela = new DataTable();
            _tabela = t.Copy();
            _tabela.PrimaryKey = null;
            _tabela.Columns.Remove("id");
            _tabela.Columns.Remove("data");
           
        }

        private Boolean existeServico(int id)
        {
            Boolean existe = false;

            foreach (DataRow r in _tabela.Rows)
            {
                if (Convert.ToInt16(r.ItemArray[1]) == id)
                {
                    existe = true;
                    break;
                }

            }
            return existe;
        }

        public void incrementarQuantidade(int id, int quant, double preco) {
            for (int i = 0; i<_tabela.Rows.Count; i++){
              
                if(Convert.ToInt16(_tabela.Rows[i].ItemArray[1]) == id) {
                  
                    _tabela.Rows[i][2] = Convert.ToInt16(_tabela.Rows[i].ItemArray[2]) + quant;
                    _tabela.Rows[i][3] = Convert.ToInt16(_tabela.Rows[i].ItemArray[3]) + quant * preco;
                    break;
                }

               
            }

            //atualizarTotal()
   
        }     

        public void adicionar(DataGridViewRow d)
        {
            int codServico = Convert.ToInt16(d.Cells[0].Value);
            double preco = Convert.ToDouble(d.Cells[2].Value);


            if (existeServico(codServico))
            {
                incrementarQuantidade(codServico, 1, preco);
            }
            else
            {
                Object[] linha = new object[4];
                linha[0] = id_reserva;
                linha[1] = d.Cells[0].Value;
                linha[2] = 1;
                linha[3] = d.Cells[2].Value;

                _tabela.Rows.Add(linha);
            }
        

        //atualizarTotal()

  
        }

        public void remover(int numLinha) {
            _tabela.Rows.RemoveAt(numLinha);
        }


    }
}
