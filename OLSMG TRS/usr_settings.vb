Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class usr_settings
    Dim dbManager As New DatabaseManager()
    Private Sub btn_dbSave_Click(sender As Object, e As EventArgs) Handles btn_dbSave.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "SQL Backup Files|*.sql"
        saveFileDialog.Title = "Backup Database"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            dbManager.BackupDatabase("olsmg_db.vb")
            MsgBox("Database backed up successfully!", vbInformation, "Success")
            Dim parentForm As Form = Me.FindForm()
            If parentForm IsNot Nothing Then
                parentForm.Close()
            End If
        End If
    End Sub

    Private Sub btn_dbRestore_Click(sender As Object, e As EventArgs) Handles btn_dbRestore.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "SQL Backup Files|*.sql"
        openFileDialog.Title = "Restore Database"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            dbManager.RestoreDatabase("olsmg_db.vb")
            MsgBox("Database restored successfully!", vbInformation, "Success")
            Dim parentForm As Form = Me.FindForm()
            If parentForm IsNot Nothing Then
                parentForm.Close()
            End If
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim dropquery As Integer
        dropquery = MsgBox("Are you sure you want to drop the database?", vbYesNo, "Dropping database")
        If dropquery = vbYes Then
            Try
                cn.Open()
                Dim commandText As String = $"DROP DATABASE {My.Settings.olsmgDBName}"
                Dim command As New MySqlCommand(commandText, cn)
                If command.ExecuteNonQuery() > 0 Then
                    MsgBox("Database dropped successfully.", vbCritical, "Database Deletion")
                    Dim parentForm As Form = Me.FindForm()
                    If parentForm IsNot Nothing Then
                        parentForm.Close()
                    End If
                End If
            Catch ex As Exception
                 MsgBox("No Database found.", vbCritical, "Database Deletion")
            Finally
                cn.Close()
            End Try
        End If
    End Sub
End Class
