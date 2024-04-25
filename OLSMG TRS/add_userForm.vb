Public Class add_userForm
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

    End Sub

    Private Sub add_userForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click

    End Sub

    Private Sub cb_roles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_roles.SelectedIndexChanged

    End Sub
End Class
