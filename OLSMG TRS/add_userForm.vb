Imports MySql.Data.MySqlClient


Public Class add_userForm
    Public state As String
    Public mode As Int32
    Public userName As String
    Public userEmail As String
    Public userContact As String
    Private Sub fullnameText_Click(sender As Object, e As EventArgs) Handles fullnameText.Click
        If fullnameText.Text = "Full Name" Then
            fullnameText.Text = ""
        End If
    End Sub

    Private Sub unameText_Click(sender As Object, e As EventArgs) Handles unameText.Click
        If unameText.Text = "Username" Then
            unameText.Text = ""
        End If
    End Sub

    Private Sub emailText_Click(sender As Object, e As EventArgs) Handles emailText.Click
        If emailText.Text = "Email Address" Then
            emailText.Text = ""
        End If
    End Sub

    Private Sub cnumText_Click(sender As Object, e As EventArgs) Handles cnumText.Click
        If cnumText.Text = "Contact Number" Then
            cnumText.Text = ""
        End If
    End Sub

    Private Sub passText_Click(sender As Object, e As EventArgs) Handles passText.Click
        If passText.Text = "Password" Then
            passText.Text = ""
        End If
    End Sub

    Private Sub cpassText_Click(sender As Object, e As EventArgs) Handles cpassText.Click
        If cpassText.Text = "Confirm Password" Then
            cpassText.Text = ""
        End If
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        register()
    End Sub

    Private Sub add_userForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click

    End Sub

    Private Sub cb_roles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_roles.SelectedIndexChanged

    End Sub

    Private Sub btn_activate_Click(sender As Object, e As EventArgs) Handles btn_activate.Click
        Dim permission As Integer
        permission = MsgBox("Are you sure you want to reactivate this account?", vbYesNo + vbQuestion, "Account Reactivation")
        If permission = vbYes Then
            reactivate()
        End If
    End Sub

    Sub reactivate()
        Try
            dr.Close()
            Dim reactivateAccount As New MySqlCommand("UPDATE olsmg_users SET user_status=@us WHERE user_fullname = @uf AND user_uname = @uu AND user_email = @ue", cn)
            reactivateAccount.Parameters.AddWithValue("@uf", fullnameText.Text)
            reactivateAccount.Parameters.AddWithValue("@uu", unameText.Text)
            reactivateAccount.Parameters.AddWithValue("@ue", emailText.Text)
            reactivateAccount.Parameters.AddWithValue("@us", "Active")
            reactivateAccount.ExecuteNonQuery()
            MsgBox("Account Reactivated Successfully", vbInformation, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim Users As New usr_users()
                Users.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(Users)
                CloseForm()
            End If
        End Try
    End Sub

    Sub approve()
        Try
            dr.Close()
            Dim reactivateAccount As New MySqlCommand("UPDATE olsmg_users SET user_status=@us, user_role=@ur WHERE user_fullname = @uf AND user_uname = @uu AND user_email = @ue", cn)
            reactivateAccount.Parameters.AddWithValue("@uf", fullnameText.Text)
            reactivateAccount.Parameters.AddWithValue("@uu", unameText.Text)
            reactivateAccount.Parameters.AddWithValue("@ue", emailText.Text)
            reactivateAccount.Parameters.AddWithValue("@ur", cb_roles.Text)
            reactivateAccount.Parameters.AddWithValue("@us", "Active")
            reactivateAccount.ExecuteNonQuery()
            MsgBox("Account was Approved", vbInformation, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim Users As New usr_users()
                Users.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(Users)
                CloseForm()
            End If
        End Try
    End Sub

    Sub deactivate()
        Try
            dr.Close()
            Dim deactivateAccount As New MySqlCommand("UPDATE olsmg_users SET user_status=@us WHERE user_fullname = @uf AND user_uname = @uu AND user_email = @ue", cn)
            deactivateAccount.Parameters.AddWithValue("@uf", fullnameText.Text)
            deactivateAccount.Parameters.AddWithValue("@uu", unameText.Text)
            deactivateAccount.Parameters.AddWithValue("@ue", emailText.Text)
            deactivateAccount.Parameters.AddWithValue("@us", "Disabled")
            deactivateAccount.ExecuteNonQuery()
            MsgBox("Account deactivated Successfully", vbInformation, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim Users As New usr_users()
                Users.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(Users)
                CloseForm()
            End If
        End Try
    End Sub

    Sub delete()
        Try
            dr.Close()
            Dim deactivateAccount As New MySqlCommand("DELETE FROM olsmg_users WHERE user_fullname = @uf AND user_uname = @uu AND user_email = @ue", cn)
            deactivateAccount.Parameters.AddWithValue("@uf", fullnameText.Text)
            deactivateAccount.Parameters.AddWithValue("@uu", unameText.Text)
            deactivateAccount.Parameters.AddWithValue("@ue", emailText.Text)
            deactivateAccount.ExecuteNonQuery()
            MsgBox("Account deactivated Successfully", vbInformation, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim Users As New usr_users()
                Users.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(Users)
                CloseForm()
            End If
        End Try
    End Sub

    Sub register()
        Dim message As String
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            If String.IsNullOrEmpty(fullnameText.Text) Or String.IsNullOrEmpty(unameText.Text) Or String.IsNullOrEmpty(emailText.Text) Or String.IsNullOrEmpty(cnumText.Text) Or String.IsNullOrEmpty(passText.Text) Or String.IsNullOrEmpty(cpassText.Text) Then
                MsgBox("Please fill up all the required entries.", vbExclamation, "Incomplete Details")
            ElseIf fullnameText.Text = "Full Name" Or unameText.Text = "Username" Or emailText.Text = "Email Address" Or cnumText.Text = "Contact Number" Or passText.Text = "Password" Or cpassText.Text = "Confirm Password" Then
                MsgBox("Please fill up all the required entries.", vbExclamation, "Incomplete Details")
            ElseIf passText.Text = cpassText.Text Then
                Dim addAccount As New MySqlCommand("INSERT INTO olsmg_users (user_fullname, user_uname, user_email, user_cnum, user_password, user_role, user_status) VALUES (@usrFname, @usrUname, @usrEmail, @usrCnum, @userPass, @userRole, @usrStatus)", cn)
                addAccount.Parameters.AddWithValue("@usrFname", fullnameText.Text)
                addAccount.Parameters.AddWithValue("@usrUname", unameText.Text)
                addAccount.Parameters.AddWithValue("@usrEmail", emailText.Text)
                addAccount.Parameters.AddWithValue("@usrCnum", cnumText.Text)
                addAccount.Parameters.AddWithValue("@userPass", ConvertToMD5(passText.Text))

                If state = "Admin" Then
                    addAccount.Parameters.AddWithValue("@userRole", cb_roles.Text)
                    addAccount.Parameters.AddWithValue("@usrStatus", "Active")
                    message = "Account details added Successfully."
                Else
                    addAccount.Parameters.AddWithValue("@userRole", "Customer")
                    addAccount.Parameters.AddWithValue("@usrStatus", "Pending")
                    message = "Account details added Successfully. Please wait for approval."
                End If
                addAccount.ExecuteNonQuery()
                MsgBox(message, vbInformation, "Success")
                RefreshForm()
            ElseIf passText.Text <> cpassText.Text Then
                MsgBox("Password do not match", vbExclamation, "Inconsistent Details")
            End If
        Catch ex As Exception
            MsgBox($"Registration Failed: {ex.Message}", vbCritical, "Registration Error")
        End Try
    End Sub

    Public Sub CloseForm()
        Dim parentForm As Form = TryCast(Me.ParentForm, Form)
        If parentForm IsNot Nothing Then
            ' Close the form
            parentForm.Close()
        End If
    End Sub

    Private Sub RefreshForm()
        If cn.State <> ConnectionState.Closed Then
            cn.Close()
            If state = "Admin" Then
                main_form.mainPanel.Controls.Clear()
                Dim Users As New usr_users()
                Users.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(Users)
                CloseForm()
            Else
                login_form.mainPanel.Controls.Clear()
                Dim SignIn As New usr_signin()
                SignIn.Dock = DockStyle.Fill
                login_form.mainPanel.Controls.Add(SignIn)
            End If
        End If
    End Sub

    Private Sub btn_disable_Click(sender As Object, e As EventArgs) Handles btn_disable.Click
        Dim permission As Integer
        permission = MsgBox("Are you sure you want to deactivate this account?", vbYesNo + vbExclamation, "Account Deactivation")
        If permission = vbYes Then
            deactivate()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim permission As Integer
        permission = MsgBox("Are you sure you want to delete this account?", vbYesNo + vbCritical, "Account Deletion")
        If permission = vbYes Then
            delete()
        End If
    End Sub

    Private Sub btn_approve_Click(sender As Object, e As EventArgs) Handles btn_approve.Click
        Dim permission As Integer
        permission = MsgBox("Are you sure you want to approve this account?", vbYesNo + vbQuestion, "Account Approval")
        If permission = vbYes Then
            approve()
        End If
    End Sub

End Class
