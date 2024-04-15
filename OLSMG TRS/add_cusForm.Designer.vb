<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_cusForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btn_deleteCus = New MetroFramework.Controls.MetroButton()
        Me.btn_cusAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btn_deleteCus)
        Me.MetroPanel1.Controls.Add(Me.btn_cusAdd)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 340)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(322, 34)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btn_deleteCus
        '
        Me.btn_deleteCus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deleteCus.Location = New System.Drawing.Point(216, 6)
        Me.btn_deleteCus.Name = "btn_deleteCus"
        Me.btn_deleteCus.Size = New System.Drawing.Size(100, 23)
        Me.btn_deleteCus.TabIndex = 3
        Me.btn_deleteCus.Text = "DELETE"
        '
        'btn_cusAdd
        '
        Me.btn_cusAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cusAdd.Location = New System.Drawing.Point(110, 6)
        Me.btn_cusAdd.Name = "btn_cusAdd"
        Me.btn_cusAdd.Size = New System.Drawing.Size(100, 23)
        Me.btn_cusAdd.TabIndex = 2
        Me.btn_cusAdd.Text = "CONFIRM"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.MetroTextBox4)
        Me.MetroPanel2.Controls.Add(Me.MetroTextBox3)
        Me.MetroPanel2.Controls.Add(Me.MetroTextBox2)
        Me.MetroPanel2.Controls.Add(Me.MetroTextBox1)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(322, 340)
        Me.MetroPanel2.TabIndex = 2
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(17, 145)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(107, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Contact Number"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 99)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Middle Initial"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 52)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "First Name"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 4)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Last Name"
        '
        'MetroTextBox4
        '
        Me.MetroTextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextBox4.Location = New System.Drawing.Point(17, 165)
        Me.MetroTextBox4.MaxLength = 11
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.Size = New System.Drawing.Size(288, 23)
        Me.MetroTextBox4.TabIndex = 6
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextBox3.Location = New System.Drawing.Point(17, 119)
        Me.MetroTextBox3.MaxLength = 2
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.Size = New System.Drawing.Size(288, 23)
        Me.MetroTextBox3.TabIndex = 4
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextBox2.Location = New System.Drawing.Point(17, 73)
        Me.MetroTextBox2.MaxLength = 255
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.Size = New System.Drawing.Size(288, 23)
        Me.MetroTextBox2.TabIndex = 3
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextBox1.Location = New System.Drawing.Point(17, 26)
        Me.MetroTextBox1.MaxLength = 255
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.Size = New System.Drawing.Size(288, 23)
        Me.MetroTextBox1.TabIndex = 2
        '
        'add_cusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "add_cusForm"
        Me.Size = New System.Drawing.Size(322, 374)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_deleteCus As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_cusAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
End Class
