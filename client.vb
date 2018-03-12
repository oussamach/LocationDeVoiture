Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class client

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BindingContext(ds, "client").AddNew()
    End Sub

    Private Sub client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim req As String = "select * from dbo.client"
        da = New SqlDataAdapter(req, cn)
        cn.Open()
        da.Fill(ds, "client")
        cn.Close()
        TextBox1.DataBindings.Add("text", ds, "client.id_cl")
        TextBox2.DataBindings.Add("text", ds, "client.nom")
        TextBox3.DataBindings.Add("text", ds, "client.prenom")
        TextBox4.DataBindings.Add("text", ds, "client.num_per")
        DateTimePicker1.DataBindings.Add("text", ds, "client.date_dt")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "client"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.BindingContext(ds, "client").Position = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.BindingContext(ds, "client").EndCurrentEdit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p As Integer = Me.BindingContext(ds, "client").Position
        ds.Tables("client").Rows(p).Delete()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim p As New SqlCommandBuilder(da)
        da.Update(ds, "client")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.BindingContext(ds, "client").Position -= 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.BindingContext(ds, "client").Position += 1
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.BindingContext(ds, "client").Position = ds.Tables("client").Rows.Count - 1
    End Sub
End Class