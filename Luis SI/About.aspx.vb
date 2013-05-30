Imports System.Data
Imports System.Data.SqlClient
Partial Class About
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Dim strSQL As String

        strSQL = "Select imagemID,imagemTitulo from Imagem"
        Dim connString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=""|DataDirectory|\ASPNETDB.MDF"";Integrated Security=True;User Instance=True"
        da = New SqlClient.SqlDataAdapter(strSQL, connString)
        da.Fill(ds)

        ds.Tables(0).Columns.Add("imagem")

        For Each tempRow As DataRow In ds.Tables(0).Rows
            tempRow.Item("imagem") = ("trataImagem.aspx?id=" & tempRow.Item("imagemID"))
        Next
        imgGrid.DataSource = ds
        imgGrid.DataBind()

    End Sub
    Protected Sub Unnamed1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgGrid.SelectedIndexChanged

    End Sub
End Class
