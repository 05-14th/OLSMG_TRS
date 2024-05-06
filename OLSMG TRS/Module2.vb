Imports System.Diagnostics
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class DatabaseManager
    Public Sub BackupDatabase(backupFilePath As String)
        Try
            Dim processStartInfo As New ProcessStartInfo()
            processStartInfo.FileName = "mysqldump"
            processStartInfo.Arguments = $"--user=root --host=localhost --result-file=""{backupFilePath}"" olsmg_db"
            processStartInfo.CreateNoWindow = True
            processStartInfo.UseShellExecute = False
            Process.Start(processStartInfo)
        Catch ex As Exception
            MessageBox.Show("Error backing up database: " & ex.Message)
        End Try
    End Sub

    Private Sub createDatabase()
        Dim connectionString As String = "server=localhost;uid=root;"
        Dim createDatabaseQuery As String = "CREATE DATABASE IF NOT EXISTS olsmg_db;"
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand(createDatabaseQuery, connection)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            'MessageBox.Show("Database created successfully.")
        Catch ex As Exception
            MessageBox.Show("Error creating database: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            command.Dispose()
            connection.Dispose()
        End Try
    End Sub

    Public Sub RestoreDatabase(backupFilePath As String)
        createDatabase()
        Dim connectionString As String = "server=localhost; user id=root; password=; database=olsmg_db"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
        Catch ex As Exception
            Console.WriteLine("Error connecting to MySQL: " & ex.Message)
        End Try

        Dim sql As String = System.IO.File.ReadAllText(backupFilePath)

        Dim command As New MySqlCommand(sql, connection)

        Try
            command.ExecuteNonQuery()
            Console.WriteLine("Database restored successfully")
        Catch ex As Exception
            Console.WriteLine("Error restoring database: " & ex.Message)
        End Try

    End Sub
End Class

