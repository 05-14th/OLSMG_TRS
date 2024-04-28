Imports MySql.Data.MySqlClient

Public Class usr_signin
    Inherits UserControl

    Private Sub userText_Click(sender As Object, e As EventArgs) Handles userText.Click
        If userText.Text = "Username" Then
            userText.Text = ""
        End If
    End Sub

    Private Sub passText_Click(sender As Object, e As EventArgs) Handles passText.Click
        If passText.Text = "Password" Then
            passText.Text = ""
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim query As String = "SELECT COUNT(*), user_role, user_status FROM olsmg_users WHERE user_uname = @unameValue AND user_password = @passValue"
        Dim unameValue As String = userText.Text
        Dim passValue As String = passText.Text
        Dim roles As String
        Dim status As String

        Try
            cn.Open()
            Dim command As New MySqlCommand(query, cn)
            command.Parameters.AddWithValue("@unameValue", unameValue)
            command.Parameters.AddWithValue("@passValue", ConvertToMD5(passValue))
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If result = 1 And reader.Read() Then
                roles = reader(1).ToString()
                status = reader(2).ToString()
                If status = "Active" Then
                    If roles = "Admin" Then
                        login_form.hideLogin()
                        main_form.ShowDialog()
                    ElseIf roles = "Employee" Then
                        login_form.hideLogin()
                        main_form.LoginAsEmployee()
                        main_form.ShowDialog()
                    End If
                ElseIf status = "Pending" Then
                    MsgBox("Your account is being reviewed. Please stay in contact with the administrator.")
                    userText.Text = "Username"
                    passText.Text = "Password"
                End If
            Else
                MsgBox("Please enter a valid account.", vbExclamation, "Invalid Credentials")
                userText.Text = "Username"
                passText.Text = "Password"
            End If
        Catch ex As Exception
            MsgBox($"Error: {ex.Message}", vbCritical, "System Error")
        Finally
            cn.Close()
        End Try
    End Sub
End Class
