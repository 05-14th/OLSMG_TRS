Imports System.Web.UI

Public Class usr_recovery
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Username_Click(sender As Object, e As EventArgs) Handles Username.Click
        If Username.Text = "Username" Then
            Username.Clear()
        End If
    End Sub

    Private Sub Password_Click(sender As Object, e As EventArgs) Handles Password.Click
        If Password.Text = "Password" Then
            Password.Clear()
            Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If Username.Text = "Admin" And Password.Text = "1c4nf1xher" Then
            Dim parentForm As Form = Me.FindForm()
            If parentForm IsNot Nothing AndAlso TypeOf parentForm Is subForm Then
                Dim form As subForm = DirectCast(parentForm, subForm)
                form.ChangePanelContent(New usr_connection)
            End If
        End If
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox1.CheckedChanged
        If MetroCheckBox1.Checked = True Then
            Password.UseSystemPasswordChar = False
        Else
            Password.UseSystemPasswordChar = True
        End If
    End Sub
End Class
