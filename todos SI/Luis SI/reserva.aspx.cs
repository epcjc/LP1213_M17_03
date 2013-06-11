using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reserva : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         MultiView1.ActiveViewIndex = 1;
        Session["Nome"] = TextBox1.Text;
        Session["Morada"] = TextBox2.Text;
        Session["Telefone"] = TextBox3.Text;
        Session["Email"] = TextBox4.Text;
        Session["Sexo"] = RadioButtonList1.SelectedValue;
        Session["Nº de quarto"] = DropDownList1.SelectedValue;
        Session["Nº de Adultos"] = DropDownList2.SelectedValue;
        Session["Nº de Crianças"] = DropDownList7.SelectedValue;
        Session["Andar do Quarto"] = DropDownList3.SelectedValue;
        /* Session["Checkin"] = DropDownList4;DropDownList5;DropDownList6.SelectedValue;
         Session["Checkou"] = DropDownList8;DropDownList9;DropDownList10.SelectedValue;*/

        Label12.Text = Session["Nome"].ToString();
        Label13.Text = Session["Morada"].ToString();
        Label14.Text = Session["Telefone"].ToString();
        Label15.Text = Session["Email"].ToString();
        Label16.Text = Session["Sexo"].ToString(); 
        Label17.Text = Session["Nº de quarto"].ToString();
        Label18.Text = Session["Nº de Adultos"].ToString();
        Label19.Text = Session["Nº de Crianças"].ToString();
        Label20.Text = Session["Andar do Quarto"].ToString();
       /* Label21.Text = Session["Checkin"].ToString();
        Label22.Text = Session["Checkou"].ToString();*/


        DropDownList1.Text = Session["Nº de Quarto"].ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        TextBox5.Text = Session["Nome"].ToString();
        TextBox6.Text = Session["Morada"].ToString();
        TextBox7.Text = Session["Telefone"].ToString();
        TextBox8.Text = Session["Email"].ToString();
        Session["Sexo"] = RadioButtonList2.SelectedValue;
        Session["Nº de quarto"] = DropDownList1.SelectedValue;
        Session["Nº de Adultos"] = DropDownList2.SelectedValue;
        Session["Nº de Crianças"] = DropDownList7.SelectedValue;
        Session["Andar do Quarto"] = DropDownList3.SelectedValue;
        /* Session["Checkin"] = DropDownList4;DropDownList5;DropDownList6.SelectedValue;
         Session["Checkou"] = DropDownList8;DropDownList9;DropDownList10.SelectedValue;*/
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["Nome"] = TextBox1.Text;
        Session["Morada"] = TextBox2.Text;
        Session["Telefone"] = TextBox3.Text;
        Session["Email"] = TextBox4.Text;
        Session["Sexo"] = RadioButtonList1.SelectedValue;
        Session["Nº de quarto"] = DropDownList1.SelectedValue;
        Session["Nº de Adultos"] = DropDownList2.SelectedValue;
        Session["Nº de Crianças"] = DropDownList7.SelectedValue;
        Session["Andar do Quarto"] = DropDownList3.SelectedValue;
        /* Session["Checkin"] = DropDownList4;DropDownList5;DropDownList6.SelectedValue;
         Session["Checkou"] = DropDownList8;DropDownList9;DropDownList10.SelectedValue;*/

        Label12.Text = Session["Nome"].ToString();
        Label13.Text = Session["Morada"].ToString();
        Label14.Text = Session["Telefone"].ToString();
        Label15.Text = Session["Email"].ToString();
        Label16.Text = Session["Sexo"].ToString();
        Label17.Text = Session["Nº de quarto"].ToString();
        Label18.Text = Session["Nº de Adultos"].ToString();
        Label19.Text = Session["Nº de Crianças"].ToString();
        Label20.Text = Session["Andar do Quarto"].ToString();
        /* Label21.Text = Session["Checkin"].ToString();
         Label22.Text = Session["Checkou"].ToString();*/
    }
}