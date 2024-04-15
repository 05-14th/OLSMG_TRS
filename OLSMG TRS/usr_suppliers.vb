
Public Class usr_suppliers
    Inherits UserControl
    Dim addSup As New subForm()
    Dim supForm As New add_supForm

    Public Sub New()
        InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addSup_Click(sender As Object, e As EventArgs) Handles btn_addSup.Click
        addSup.subForm_panel.Controls.Clear()
        addSup.Size = New Size(400, 500)
        supForm.Dock = DockStyle.Fill
        addSup.subForm_panel.Controls.Add(supForm)
        addSup.ShowDialog()
    End Sub
End Class
