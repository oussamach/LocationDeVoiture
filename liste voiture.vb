Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class liste_voiture
    Private Sub liste_voiture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim req As String = "select * from  categorie "
        da = New SqlDataAdapter(req, cn)
        cn.Open()
        da.Fill(ds, "categorie")
        cn.Close()
        ComboBox1.ValueMember = ds.Tables("categorie").Columns(1).ToString
        ComboBox1.DisplayMember = ds.Tables("categorie").Columns(1).ToString
        ComboBox1.DataSource = ds.Tables("categorie")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cn.Open()
        cmd = New SqlCommand("dbo.voiture_categorie", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@nom_cat", SqlDbType.Text).Value = ComboBox1.Text
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "voiture1")
        cn.Close()
        DataGridView1.DataSource = ds.Tables("voiture1")
    End Sub
End Class