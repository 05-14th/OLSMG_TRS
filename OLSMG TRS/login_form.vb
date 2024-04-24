Public Class login_form
    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToDB()
        showLogin()
    End Sub

    Private Sub showLogin()
        mainPanel.Controls.Clear()
        Dim myUserLogin As New usr_signin()
        myUserLogin.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserLogin)
    End Sub

    Private Sub closeButton_Click_1(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Dispose()
    End Sub

    Public Sub hideLogin()
        Me.Hide()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        mainPanel.Controls.Clear()
        Dim myUserLogin As New usr_signin()
        myUserLogin.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserLogin)
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        mainPanel.Controls.Clear()
        Dim myUserLogin As New usr_regsForm()
        myUserLogin.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserLogin)
    End Sub
End Class