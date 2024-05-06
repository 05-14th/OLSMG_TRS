Imports MySql.Data.MySqlClient

Public Class usr_cusViewForm
    Public logged_account As String

    Private Sub cusForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_user_account.Text = logged_account
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        lbl_user_account.Text = Nothing
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        End
    End Sub


End Class
