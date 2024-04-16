<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_empForm
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.empPos = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.empCN = New MetroFramework.Controls.MetroTextBox()
        Me.empMI = New MetroFramework.Controls.MetroTextBox()
        Me.empFname = New MetroFramework.Controls.MetroTextBox()
        Me.empLname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btn_deleteEmp = New MetroFramework.Controls.MetroButton()
        Me.btn_empAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel2.Controls.Add(Me.empPos)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.empCN)
        Me.MetroPanel2.Controls.Add(Me.empMI)
        Me.MetroPanel2.Controls.Add(Me.empFname)
        Me.MetroPanel2.Controls.Add(Me.empLname)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(401, 362)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 204)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Position"
        '
        'empPos
        '
        Me.empPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.empPos.FormattingEnabled = True
        Me.empPos.ItemHeight = 23
        Me.empPos.Items.AddRange(New Object() {"Helper", "Delivery Man"})
        Me.empPos.Location = New System.Drawing.Point(17, 226)
        Me.empPos.Name = "empPos"
        Me.empPos.Size = New System.Drawing.Size(367, 29)
        Me.empPos.TabIndex = 11
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(17, 156)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(107, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Contact Number"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 110)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Middle Initial"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 63)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "First Name"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 15)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Last Name"
        '
        'empCN
        '
        Me.empCN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.empCN.Location = New System.Drawing.Point(17, 176)
        Me.empCN.MaxLength = 11
        Me.empCN.Name = "empCN"
        Me.empCN.Size = New System.Drawing.Size(367, 23)
        Me.empCN.TabIndex = 6
        '
        'empMI
        '
        Me.empMI.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.empMI.Location = New System.Drawing.Point(17, 130)
        Me.empMI.MaxLength = 2
        Me.empMI.Name = "empMI"
        Me.empMI.Size = New System.Drawing.Size(367, 23)
        Me.empMI.TabIndex = 4
        '
        'empFname
        '
        Me.empFname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.empFname.Location = New System.Drawing.Point(17, 84)
        Me.empFname.MaxLength = 255
        Me.empFname.Name = "empFname"
        Me.empFname.Size = New System.Drawing.Size(367, 23)
        Me.empFname.TabIndex = 3
        '
        'empLname
        '
        Me.empLname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.empLname.Location = New System.Drawing.Point(17, 37)
        Me.empLname.MaxLength = 255
        Me.empLname.Name = "empLname"
        Me.empLname.Size = New System.Drawing.Size(367, 23)
        Me.empLname.TabIndex = 2
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btn_deleteEmp)
        Me.MetroPanel1.Controls.Add(Me.btn_empAdd)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 362)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(401, 34)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btn_deleteEmp
        '
        Me.btn_deleteEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deleteEmp.Location = New System.Drawing.Point(295, 6)
        Me.btn_deleteEmp.Name = "btn_deleteEmp"
        Me.btn_deleteEmp.Size = New System.Drawing.Size(100, 23)
        Me.btn_deleteEmp.TabIndex = 3
        Me.btn_deleteEmp.Text = "DELETE"
        '
        'btn_empAdd
        '
        Me.btn_empAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_empAdd.Location = New System.Drawing.Point(189, 6)
        Me.btn_empAdd.Name = "btn_empAdd"
        Me.btn_empAdd.Size = New System.Drawing.Size(100, 23)
        Me.btn_empAdd.TabIndex = 2
        Me.btn_empAdd.Text = "CONFIRM"
        '
        'add_empForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "add_empForm"
        Me.Size = New System.Drawing.Size(401, 396)
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
    Friend WithEvents empCN As MetroFramework.Controls.MetroTextBox
    Friend WithEvents empMI As MetroFramework.Controls.MetroTextBox
    Friend WithEvents empFname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents empLname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_deleteEmp As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_empAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents empPos As MetroFramework.Controls.MetroComboBox
End Class
