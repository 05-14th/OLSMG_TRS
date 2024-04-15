Public Class usr_customer
    Inherits UserControl
    Dim addCus As New subForm()
    Dim cusForm As New add_cusForm

    Public Sub New()
        InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addCus_Click(sender As Object, e As EventArgs) Handles btn_addCus.Click
        addCus.subForm_panel.Controls.Clear()
        addCus.Size = New Size(400, 500)
        cusForm.Dock = DockStyle.Fill
        addCus.subForm_panel.Controls.Add(cusForm)
        addCus.ShowDialog()
    End Sub

End Class
