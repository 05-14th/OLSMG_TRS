Imports MySql.Data.MySqlClient

Public Class DatabaseChecker

    Public Function DatabaseExists(databaseName As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM information_schema.SCHEMATA WHERE SCHEMA_NAME = '{databaseName}'"
        Dim command As New MySqlCommand(query, cn)
        cn.Open()
        Dim result As Object = command.ExecuteScalar()
        Dim exists As Boolean = Convert.ToInt32(result) > 0
        command.Dispose()
        cn.Close()
        Return exists
    End Function

    Public Function TableExists(databaseName As String, tableName As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA = '{databaseName}' AND TABLE_NAME = '{tableName}'"
        Dim command As New MySqlCommand(query, cn)
        cn.Open()
        Dim result As Object = command.ExecuteScalar()
        Dim exists As Boolean = Convert.ToInt32(result) > 0
        command.Dispose()
        cn.Close()
        Return exists
    End Function

End Class
