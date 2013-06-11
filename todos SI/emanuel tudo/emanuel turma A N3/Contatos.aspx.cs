using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contatos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        Session["Nome"] = TextBox1.Text;
        Session["Morada"] = TextBox2.Text;
        Session["Telefone"] = TextBox3.Text;
        Session["Email"] = TextBox4.Text;
        Session["Sexo"] = RadioButtonList1.SelectedValue;
        Session["Veiculos"] = DropDownList1.SelectedValue;
        Label8.Text = Session["Nome"].ToString();
        Label9.Text = Session["Morada"].ToString();
        Label10.Text = Session["Telefone"].ToString();
        Label11.Text = Session["Email"].ToString();
        Label12.Text = Session["Sexo"].ToString(); 
        Label13.Text = Session["Veiculos"].ToString();

        DropDownList1.Text = Session["Veiculos"].ToString();

    }

protected void  Button3_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex = 2;
}
protected void  Button4_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex = 1;
        TextBox5.Text = Session["Nome"].ToString();
        TextBox6.Text = Session["Morada"].ToString();
        TextBox7.Text = Session["Telefone"].ToString();
        TextBox8.Text = Session["Email"].ToString();
        Session["Sexo"] = RadioButtonList2.SelectedValue;
        Session["Veiculos"] = DropDownList1.SelectedValue;
}
protected void  Button5_Click(object sender, EventArgs e)
{

 MultiView1.ActiveViewIndex = 0;
        Session["Nome"] = TextBox5.Text;
        Session["Morada"] = TextBox6.Text;
        Session["Telefone"] = TextBox7.Text;
        Session["Email"] = TextBox8.Text;
        Session["Sexo"] = RadioButtonList2.SelectedValue;
        Session["Veiculos"] = DropDownList1.SelectedValue;

        Label8.Text = Session["Nome"].ToString();
        Label9.Text = Session["Morada"].ToString();
        Label10.Text = Session["telefone"].ToString();
        Label11.Text = Session["Email"].ToString();
        Label12.Text = Session["Sexo"].ToString();
        Label13.Text = Session["Veiculos"].ToString();
}
}