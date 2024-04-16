Public Class usr_users
    Inherits UserControl
    Dim addUser As New subForm()
    Dim userForm As New add_userForm

    Public Sub New()
        InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addUsers_Click(sender As Object, e As EventArgs) Handles btn_addUsers.Click
        addUser.subForm_panel.Controls.Clear()
        addUser.Size = New Size(400, 500)
        userForm.Dock = DockStyle.Fill
        addUser.subForm_panel.Controls.Add(userForm)
        addUser.ShowDialog()
    End Sub
End Class
