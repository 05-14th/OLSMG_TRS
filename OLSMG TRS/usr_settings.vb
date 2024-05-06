Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class usr_settings
    Dim dbManager As New DatabaseManager()
    Private Sub btn_dbSave_Click(sender As Object, e As EventArgs) Handles btn_dbSave.Click
        'Dim saveFileDialog As New SaveFileDialog()
        'SaveFileDialog.Filter = "SQL Backup Files|*.sql"
        'SaveFileDialog.Title = "Backup Database"
        'If saveFileDialog.ShowDialog() = DialogResult.OK Then
        dbManager.BackupDatabase("olsmg_db.vb")
        MsgBox("Database backed up successfully!", vbInformation, "Success")
        'End If
    End Sub

    Private Sub btn_dbRestore_Click(sender As Object, e As EventArgs) Handles btn_dbRestore.Click
        'Dim openFileDialog As New OpenFileDialog()
        'OpenFileDialog.Filter = "SQL Backup Files|*.sql"
        'OpenFileDialog.Title = "Restore Database"
        'If openFileDialog.ShowDialog() = DialogResult.OK Then
        dbManager.RestoreDatabase("olsmg_db.vb")
        MsgBox("Database restored successfully!", vbInformation, "Success")
        'End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        cn.Open()
        Dim commandText As String = $"DROP DATABASE olsmg_db"
        Dim command As New MySqlCommand(commandText, cn)
        command.ExecuteNonQuery()
        command.Dispose()
        cn.Close()
        cn.Dispose()
    End Sub
End Class
