﻿Imports MySql.Data.MySqlClient

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
        Dim query As String = "SELECT COUNT(*), user_role FROM olsmg_users WHERE user_uname = @unameValue AND user_password = @passValue"
        Dim unameValue As String = userText.Text
        Dim passValue As String = passText.Text
        Dim roles As String

        Try
            cn.Open()
            Dim command As New MySqlCommand(query, cn)
            command.Parameters.AddWithValue("@unameValue", unameValue)
            command.Parameters.AddWithValue("@passValue", passValue)
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If result = 1 And reader.Read() Then
                login_form.hideLogin()
                roles = reader(1).ToString()
                If roles = "Admin" Then
                    main_form.ShowDialog()
                ElseIf roles = "Employee" Then
                    main_form.LoginAsEmployee()
                    main_form.ShowDialog()
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
