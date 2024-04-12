Imports MySql.Data.MySqlClient
Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public cm1 As New MySqlCommand
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public dt1 As New DataTable
    Public da As MySqlDataAdapter
    Public da1 As MySqlDataAdapter
    Public ds As DataSet
    Function ConnectToDB() As Boolean
        Try
            With cn
                .ConnectionString = "server=localhost; user id=root; password=; database=rcss_db"
                .Open()
            End With
            cn.Close()
            Return True

        Catch ex As Exception
            Return False

        End Try
    End Function
End Module
