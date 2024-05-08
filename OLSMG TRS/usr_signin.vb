Imports MySql.Data.MySqlClient

Public Class usr_signin
    Inherits UserControl
    Dim dbChecker As New DatabaseChecker()

    Private Sub userSignIn(sender As Object, e As EventArgs) Handles Me.Load
        If dbChecker.TableExists("olsmg_db", "olsmg_users") = False Then
            MsgBox("Error with the database please contact the administrator for maintenance.", vbCritical, "Database Error")
            disableLogin()
        ElseIf dbChecker.TableExists("olsmg_db", "olsmg_customer") = False Then
            MsgBox("Error with the database please contact the administrator for maintenance.", vbCritical, "Database Error")
            disableLogin()
        ElseIf dbChecker.TableExists("olsmg_db", "olsmg_address") = False Then
            MsgBox("Error with the database please contact the administrator for maintenance.", vbCritical, "Database Error")
            disableLogin()
        ElseIf dbChecker.TableExists("olsmg_db", "olsmg_employee") = False Then
            MsgBox("Error with the database please contact the administrator for maintenance.", vbCritical, "Database Error")
            disableLogin()
        ElseIf dbChecker.TableExists("olsmg_db", "olsmg_invoice") = False Then
            MsgBox("Error with the database please contact the administrator for maintenance.", vbCritical, "Database Error")
            disableLogin()
        ElseIf dbChecker.TableExists("olsmg_db", "olsmg_order") = False Then
            MsgBox("Error with the database please contact the administrator for maintenance.", vbCritical, "Database Error")
            disableLogin()
        ElseIf dbChecker.TableExists("olsmg_db", "olsmg_product") = False Then
            MsgBox("Error with the database please contact the administrator for maintenance.", vbCritical, "Database Error")
            disableLogin()
        ElseIf dbChecker.TableExists("olsmg_db", "olsmg_supplier") = False Then
            MsgBox("Error with the database please contact the administrator for maintenance.", vbCritical, "Database Error")
            disableLogin()
        End If

        '
    End Sub

    Private Sub disableLogin()
        userText.Enabled = False
        passText.Enabled = False
        btn_login.Enabled = False
        login_form.btn_register.Enabled = False
    End Sub

    Private Sub userText_Click(sender As Object, e As EventArgs) Handles userText.Click
        If userText.Text = "Username" Then
            userText.Text = ""
        End If
    End Sub

    Private Sub passText_Click(sender As Object, e As EventArgs) Handles passText.Click
        If passText.Text = "Password" Then
            passText.Text = ""
            passText.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim query As String = "SELECT COUNT(*), user_role, user_status, user_fullname, user_uname FROM olsmg_users WHERE user_uname = @unameValue AND user_password = @passValue"
        Dim unameValue As String = userText.Text
        Dim passValue As String = passText.Text
        Dim roles As String
        Dim status As String
        Dim fullname As String
        Dim username As String

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
                fullname = reader(3).ToString()
                username = reader(4).ToString

                If status = "Active" Then
                    If roles = "Admin" Then
                        login_form.hideLogin()
                        main_form.signedUser = $"Signed in as {fullname}"
                        reader.Close()
                        main_form.ShowDialog()
                    ElseIf roles = "Employee" Then
                        login_form.hideLogin()
                        main_form.Settings.Visible = False
                        main_form.LoginAsEmployee()
                        main_form.signedUser = $"Signed in as {fullname}"
                        reader.Close()
                        main_form.ShowDialog()
                    ElseIf roles = "Customer" Then
                        login_form.hideLogin()
                        Dim usrCtrl As New usr_cusViewForm
                        usrCtrl.Dock = DockStyle.Fill
                        usrCtrl.txtbox_name.Text = $"{fullname}#{username}"
                        reader.Close()
                        subForm.subForm_panel.Controls.Add(usrCtrl)
                        subForm.FormBorderStyle = FormBorderStyle.None ' Set border style to none
                        subForm.WindowState = FormWindowState.Maximized
                        subForm.ShowDialog()
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim settingsForm As New subForm()
        settingsForm.subForm_panel.Controls.Clear()
        Dim adminAuth As New usr_recovery()
        adminAuth.Dock = DockStyle.Fill
        settingsForm.Size = New Size(400, 500)
        settingsForm.subForm_panel.Controls.Add(adminAuth)
        login_form.Hide()
        settingsForm.ShowDialog()
    End Sub

    Private Sub showPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        If showPass.Checked = True Then
            passText.UseSystemPasswordChar = False
        Else
            passText.UseSystemPasswordChar = True
        End If
    End Sub
End Class
