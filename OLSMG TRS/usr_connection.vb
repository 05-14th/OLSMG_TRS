Public Class usr_connection
    Private Sub adminsetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            My.Settings.olsmgServer = server.Text
            My.Settings.olsmgUsername = user.Text
            My.Settings.olsmgPassword = password.Text
            My.Settings.olsmgDBName = database.Text
            My.Settings.Save()
            MsgBox("Server Configuration saved!", vbInformation, "Success")
            Application.Restart()
        Catch ex As Exception
            MsgBox("Error saving server configuration: " & ex.Message, vbExclamation, "Error")
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim settingsForm As New subForm()
        settingsForm.subForm_panel.Controls.Clear()
        Dim myUserSettings As New usr_settings()
        myUserSettings.Dock = DockStyle.Fill
        settingsForm.Size = New Size(400, 500)
        settingsForm.subForm_panel.Controls.Add(myUserSettings)
        settingsForm.ShowDialog()
    End Sub
End Class
