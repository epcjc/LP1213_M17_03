using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class trataImagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            string strSql;
            byte[] vector = null;
            DataRow dr;

            strSql = "Select *from imagem Where imagemId=" + Request.QueryString["id"].ToString();
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            da = new SqlDataAdapter(strSql, connString);
            da.Fill(ds);

            dr = ds.Tables[0].Rows[0];

            vector = new Byte[System.Convert.ToInt32(dr["ImagemTamanho"])];
            vector = (byte[])(dr["Imagem"]);
            string conTipo = dr["ImagemTipo"].ToString();

            Response.ContentType = conTipo;
            Response.OutputStream.Write(vector, 0, System.Convert.ToInt32(dr["ImagemTamanho"]));
            Response.End();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}