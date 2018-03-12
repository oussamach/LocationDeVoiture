Imports System.Data.SqlClient
Public Class voiture

    Private Sub voiture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'remplir combobox
        Dim req As String = "select * from dbo.categorie"
        da = New SqlDataAdapter(req, cn)
        cn.Open()
        da.Fill(ds, "categorie")
        cn.Close()
        ComboBox1.DisplayMember = ds.Tables("categorie").Columns(0).ToString
        ComboBox1.ValueMember = ds.Tables("categorie").Columns(0).ToString
        ComboBox1.DataSource = ds.Tables("categorie")
        'voiture 
        Dim req1 As String = "select * from voiture"
        da = New SqlDataAdapter(req1, cn)
        cn.Open()
        da.Fill(ds, "voiture")
        cn.Close()
        TextBox1.DataBindings.Add("text", ds, "voiture.id_vt")
        TextBox2.DataBindings.Add("text", ds, "voiture.marque")
        TextBox3.DataBindings.Add("text", ds, "voiture.model")
        TextBox4.DataBindings.Add("text", ds, "voiture.prix_1")
        TextBox5.DataBindings.Add("text", ds, "voiture.prix_2")
        TextBox6.DataBindings.Add("text", ds, "voiture.prix_3")
        ComboBox1.DataBindings.Add("text", ds, "voiture.id_cat")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "voiture"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BindingContext(ds, "voiture").AddNew()
        MsgBox("ajouter avec succee")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.BindingContext(ds, "voiture").EndCurrentEdit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p As Integer = Me.BindingContext(ds, "voiture").Position
        ds.Tables("voiture").Rows(p).Delete()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim p As New SqlCommandBuilder(da)
        da.Update(ds, "voiture")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.BindingContext(ds, "voiture").Position = 0
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.BindingContext(ds, "voiture").Position -= 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.BindingContext(ds, "voiture").Position += 1
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.BindingContext(ds, "voiture").Position = ds.Tables("voiture").Rows.Count - 1
    End Sub
End Class