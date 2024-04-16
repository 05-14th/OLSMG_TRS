<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_userForm
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
        Me.userEmail = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.userCpass = New MetroFramework.Controls.MetroTextBox()
        Me.userPass = New MetroFramework.Controls.MetroTextBox()
        Me.userUname = New MetroFramework.Controls.MetroTextBox()
        Me.userFname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btn_deleteUsr = New MetroFramework.Controls.MetroButton()
        Me.btn_usrAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel2.Controls.Add(Me.userEmail)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.userCpass)
        Me.MetroPanel2.Controls.Add(Me.userPass)
        Me.MetroPanel2.Controls.Add(Me.userUname)
        Me.MetroPanel2.Controls.Add(Me.userFname)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(419, 351)
        Me.MetroPanel2.TabIndex = 6
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 196)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Email"
        '
        'userEmail
        '
        Me.userEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userEmail.Location = New System.Drawing.Point(17, 216)
        Me.userEmail.MaxLength = 255
        Me.userEmail.Name = "userEmail"
        Me.userEmail.Size = New System.Drawing.Size(385, 23)
        Me.userEmail.TabIndex = 11
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(17, 150)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Confirm Password"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 104)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Password"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 57)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Username"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 9)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Full Name"
        '
        'userCpass
        '
        Me.userCpass.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userCpass.Location = New System.Drawing.Point(17, 170)
        Me.userCpass.MaxLength = 255
        Me.userCpass.Name = "userCpass"
        Me.userCpass.Size = New System.Drawing.Size(385, 23)
        Me.userCpass.TabIndex = 6
        '
        'userPass
        '
        Me.userPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userPass.Location = New System.Drawing.Point(17, 124)
        Me.userPass.MaxLength = 255
        Me.userPass.Name = "userPass"
        Me.userPass.Size = New System.Drawing.Size(385, 23)
        Me.userPass.TabIndex = 4
        '
        'userUname
        '
        Me.userUname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userUname.Location = New System.Drawing.Point(17, 78)
        Me.userUname.MaxLength = 255
        Me.userUname.Name = "userUname"
        Me.userUname.Size = New System.Drawing.Size(385, 23)
        Me.userUname.TabIndex = 3
        '
        'userFname
        '
        Me.userFname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userFname.Location = New System.Drawing.Point(17, 31)
        Me.userFname.MaxLength = 255
        Me.userFname.Name = "userFname"
        Me.userFname.Size = New System.Drawing.Size(385, 23)
        Me.userFname.TabIndex = 2
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btn_deleteUsr)
        Me.MetroPanel1.Controls.Add(Me.btn_usrAdd)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 351)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(419, 34)
        Me.MetroPanel1.TabIndex = 5
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btn_deleteUsr
        '
        Me.btn_deleteUsr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deleteUsr.Location = New System.Drawing.Point(313, 6)
        Me.btn_deleteUsr.Name = "btn_deleteUsr"
        Me.btn_deleteUsr.Size = New System.Drawing.Size(100, 23)
        Me.btn_deleteUsr.TabIndex = 3
        Me.btn_deleteUsr.Text = "DELETE"
        '
        'btn_usrAdd
        '
        Me.btn_usrAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_usrAdd.Location = New System.Drawing.Point(207, 6)
        Me.btn_usrAdd.Name = "btn_usrAdd"
        Me.btn_usrAdd.Size = New System.Drawing.Size(100, 23)
        Me.btn_usrAdd.TabIndex = 2
        Me.btn_usrAdd.Text = "CONFIRM"
        '
        'add_userForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "add_userForm"
        Me.Size = New System.Drawing.Size(419, 385)
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
    Friend WithEvents userCpass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userUname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userFname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_deleteUsr As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_usrAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents userEmail As MetroFramework.Controls.MetroTextBox
End Class
