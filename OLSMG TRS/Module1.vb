Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X500
Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public cm1 As New MySqlCommand
    Public dr As MySqlDataReader
    Public dr1 As MySqlDataReader
    Public dt As New DataTable
    Public dt1 As New DataTable
    Public da As MySqlDataAdapter
    Public da1 As MySqlDataAdapter
    Public ds As DataSet
    Dim mainForm As New main_form
    Public Sub ConnectToDB()
        Try
            With cn
                .ConnectionString = "server=localhost; user id=root; password=; database=olsmg_db"
                .Open()
            End With
            cn.Close()
        Catch ex As Exception
            'MsgBox($"{ex.Message}", vbOKOnly, "Connection Error")
        Finally
            cn.Close()
        End Try
    End Sub

    Public Function ConvertToMD5(input As String) As String
        Dim md5Hasher As MD5 = MD5.Create()
        Dim data As Byte() = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()

        For Each b As Byte In data
            sBuilder.Append(b.ToString("x2"))
        Next

        Return sBuilder.ToString()
    End Function
End Module
