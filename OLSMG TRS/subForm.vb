Public Class subForm
    Private Sub closeButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Public Sub ChangePanelContent(userControl As UserControl)
        Me.Controls.Clear()
        userControl.Dock = DockStyle.Fill
        Me.Controls.Add(userControl)
    End Sub
End Class