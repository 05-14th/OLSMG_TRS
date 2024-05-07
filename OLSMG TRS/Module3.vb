Imports MySql.Data.MySqlClient

Public Class DatabaseChecker
    Public Function TableExists(databaseName As String, tableName As String) As Boolean
        Try
            Dim query As String = $"SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA = '{databaseName}' AND TABLE_NAME = '{tableName}'"
            Dim command As New MySqlCommand(query, cn)
            cn.Open()
            Dim result As Object = command.ExecuteScalar()
            Dim exists As Boolean = Convert.ToInt32(result) > 0
            command.Dispose()
            cn.Close()
            Return exists
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
