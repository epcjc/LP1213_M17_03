using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Imagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int tamanho = 0;
        byte[] vector = null;
        if (!FileUploadImagem.HasFile)
        {
            lbStatus.Text = "Não existe nenhum ficheiro selecionado";
            return;
        }
        string nomeFicheiro = FileUploadImagem.PostedFile.FileName;
        string ext = nomeFicheiro.Substring(nomeFicheiro.LastIndexOf("."));
        ext.ToLower();

        string imgTipo = FileUploadImagem.PostedFile.ContentType;

        if (ext != ".jpg" &&
            ext != ".bmp" &&
            ext != ".gif" &&
            ext != ".jpeg" &&
            ext != ".png" &&
            ext != ".tiff")
            lbStatus.Text = "Só são suportados os formatos: jpg/jpeg, bmp, gif, png, tiff";
        tamanho = Int32.Parse(FileUploadImagem.PostedFile.ContentLength.ToString());

        vector = new Byte[tamanho];
        FileUploadImagem.PostedFile.InputStream.Read(vector, 0, tamanho);

        if (GuardaImagem2(TextBoxTitulo.Text.Trim(), vector, tamanho, imgTipo))
            lbStatus.Text = "Imagem enviada.";
        else
            lbStatus.Text = "Erro ao enviar a imagem...";

    }
    bool GuardaImagem2(string Titulo, byte[] vector, int tamanho, string imgTipo)
    {
        try
        {
            System.Data.SqlClient.SqlConnection cnn;
            System.Data.SqlClient.SqlCommand cmd;
            System.Data.SqlClient.SqlParameter param;
            string strSql = "Insert Into Imagem(Imagem,ImagemTitulo,ImagemTipo,ImagemTamanho) " +
                            "Values(@img,@imgTitulo,@imgTipo,@imgTamanho)";
            // ligação à bd
            string connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"|DataDirectory|\\ASPNETDB.MDF\";Integrated Security=True;User Instance=True";
            cnn = new System.Data.SqlClient.SqlConnection(connString);
            // Sql command define
            cmd = new System.Data.SqlClient.SqlCommand(strSql, cnn);
            // preencher parâmetros
            param = new System.Data.SqlClient.SqlParameter("@img", System.Data.SqlDbType.Image);
            param.Value = vector;
            cmd.Parameters.Add(param);

            param = new System.Data.SqlClient.SqlParameter("@imgTitulo", System.Data.SqlDbType.VarChar);
            param.Value = Titulo;
            cmd.Parameters.Add(param);

            param = new System.Data.SqlClient.SqlParameter("@imgTipo", System.Data.SqlDbType.VarChar);
            param.Value = imgTipo;
            cmd.Parameters.Add(param);

            param = new System.Data.SqlClient.SqlParameter("@imgTamanho", System.Data.SqlDbType.BigInt);
            param.Value = tamanho;
            cmd.Parameters.Add(param);
            // abrir ligação
            cnn.Open();
            // execução do comando sql
            cmd.ExecuteNonQuery();
            // fechar a ligação
            cnn.Close();
            lblStatus0.Visible = false;
            return true;
        }
        catch (Exception ex)
        {
            lblStatus0.Text = ex.Message;
            lblStatus0.Visible = true;
            return false;
        }
    }
}