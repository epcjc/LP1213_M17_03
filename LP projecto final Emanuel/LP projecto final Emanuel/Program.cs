using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LP_projecto_final_Emanuel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int resposta;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Armazenamento da resposta do utilizador na MessageBox
            //Botão Yes - Valor 6
            //Botão No - Valor 7
            //Botão Cancelar - Valor 2
            resposta = Convert.ToInt32(MessageBox.Show("Pretende continuar?",
      "Mensagem", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
            //Avaliação da resposta dada
            if (resposta == 6)
      MessageBox.Show("Carregou em Sim", "Mensagem", MessageBoxButtons.OK,
      MessageBoxIcon.Information);
            
         else
            
            if (resposta == 7)
      MessageBox.Show("Carregou em Não", "Mensagem", MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        else
            if (resposta == 2)
      MessageBox.Show("Carregou em Cancelar", "Mensagem",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
