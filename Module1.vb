Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection("Data Source=(local);Initial Catalog=location_voiture;Integrated Security=True")
    Public ds As New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable
End Module
