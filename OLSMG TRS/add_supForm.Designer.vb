<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_supForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.storePlat = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.storeZip = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.storeProv = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.storeMuni = New MetroFramework.Controls.MetroTextBox()
        Me.storeBrgy = New MetroFramework.Controls.MetroTextBox()
        Me.storeStreet = New MetroFramework.Controls.MetroTextBox()
        Me.storeName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btn_deleteSup = New MetroFramework.Controls.MetroButton()
        Me.btn_supAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel2.Controls.Add(Me.storePlat)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel2.Controls.Add(Me.storeZip)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel2.Controls.Add(Me.storeProv)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.storeMuni)
        Me.MetroPanel2.Controls.Add(Me.storeBrgy)
        Me.MetroPanel2.Controls.Add(Me.storeStreet)
        Me.MetroPanel2.Controls.Add(Me.storeName)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(357, 354)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(17, 290)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel7.TabIndex = 16
        Me.MetroLabel7.Text = "Platform"
        '
        'storePlat
        '
        Me.storePlat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storePlat.Location = New System.Drawing.Point(17, 312)
        Me.storePlat.MaxLength = 255
        Me.storePlat.Name = "storePlat"
        Me.storePlat.Size = New System.Drawing.Size(323, 23)
        Me.storePlat.TabIndex = 15
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(17, 245)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "Zip Code"
        '
        'storeZip
        '
        Me.storeZip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storeZip.Location = New System.Drawing.Point(17, 265)
        Me.storeZip.MaxLength = 11
        Me.storeZip.Name = "storeZip"
        Me.storeZip.Size = New System.Drawing.Size(323, 23)
        Me.storeZip.TabIndex = 13
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 198)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Province/Area"
        '
        'storeProv
        '
        Me.storeProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storeProv.Location = New System.Drawing.Point(17, 218)
        Me.storeProv.MaxLength = 255
        Me.storeProv.Name = "storeProv"
        Me.storeProv.Size = New System.Drawing.Size(323, 23)
        Me.storeProv.TabIndex = 11
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(17, 152)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Municipality/City"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 106)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Barangay"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 59)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Street"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 11)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Store Name"
        '
        'storeMuni
        '
        Me.storeMuni.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storeMuni.Location = New System.Drawing.Point(17, 172)
        Me.storeMuni.MaxLength = 255
        Me.storeMuni.Name = "storeMuni"
        Me.storeMuni.Size = New System.Drawing.Size(323, 23)
        Me.storeMuni.TabIndex = 6
        '
        'storeBrgy
        '
        Me.storeBrgy.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storeBrgy.Location = New System.Drawing.Point(17, 126)
        Me.storeBrgy.MaxLength = 255
        Me.storeBrgy.Name = "storeBrgy"
        Me.storeBrgy.Size = New System.Drawing.Size(323, 23)
        Me.storeBrgy.TabIndex = 4
        '
        'storeStreet
        '
        Me.storeStreet.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storeStreet.Location = New System.Drawing.Point(17, 80)
        Me.storeStreet.MaxLength = 255
        Me.storeStreet.Name = "storeStreet"
        Me.storeStreet.Size = New System.Drawing.Size(323, 23)
        Me.storeStreet.TabIndex = 3
        '
        'storeName
        '
        Me.storeName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storeName.Location = New System.Drawing.Point(17, 33)
        Me.storeName.MaxLength = 255
        Me.storeName.Name = "storeName"
        Me.storeName.Size = New System.Drawing.Size(323, 23)
        Me.storeName.TabIndex = 2
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btn_deleteSup)
        Me.MetroPanel1.Controls.Add(Me.btn_supAdd)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 354)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(357, 34)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btn_deleteSup
        '
        Me.btn_deleteSup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deleteSup.Location = New System.Drawing.Point(251, 6)
        Me.btn_deleteSup.Name = "btn_deleteSup"
        Me.btn_deleteSup.Size = New System.Drawing.Size(100, 23)
        Me.btn_deleteSup.TabIndex = 3
        Me.btn_deleteSup.Text = "DELETE"
        '
        'btn_supAdd
        '
        Me.btn_supAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_supAdd.Location = New System.Drawing.Point(145, 6)
        Me.btn_supAdd.Name = "btn_supAdd"
        Me.btn_supAdd.Size = New System.Drawing.Size(100, 23)
        Me.btn_supAdd.TabIndex = 2
        Me.btn_supAdd.Text = "CONFIRM"
        '
        'add_supForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "add_supForm"
        Me.Size = New System.Drawing.Size(357, 388)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents storeMuni As MetroFramework.Controls.MetroTextBox
    Friend WithEvents storeBrgy As MetroFramework.Controls.MetroTextBox
    Friend WithEvents storeStreet As MetroFramework.Controls.MetroTextBox
    Friend WithEvents storeName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_deleteSup As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_supAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents storeZip As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents storeProv As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents storePlat As MetroFramework.Controls.MetroTextBox
End Class
