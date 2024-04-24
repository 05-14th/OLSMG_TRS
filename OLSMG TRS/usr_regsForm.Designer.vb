<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_regsForm
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
        Me.fullnameText = New MetroFramework.Controls.MetroTextBox()
        Me.unameText = New MetroFramework.Controls.MetroTextBox()
        Me.emailText = New MetroFramework.Controls.MetroTextBox()
        Me.passText = New MetroFramework.Controls.MetroTextBox()
        Me.cpassText = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cb_roles = New MetroFramework.Controls.MetroComboBox()
        Me.btn_register = New MetroFramework.Controls.MetroButton()
        Me.cnumText = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'fullnameText
        '
        Me.fullnameText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fullnameText.Location = New System.Drawing.Point(15, 24)
        Me.fullnameText.Name = "fullnameText"
        Me.fullnameText.Size = New System.Drawing.Size(329, 23)
        Me.fullnameText.TabIndex = 0
        Me.fullnameText.Text = "Full Name"
        '
        'unameText
        '
        Me.unameText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unameText.Location = New System.Drawing.Point(15, 67)
        Me.unameText.Name = "unameText"
        Me.unameText.Size = New System.Drawing.Size(329, 23)
        Me.unameText.TabIndex = 1
        Me.unameText.Text = "Username"
        '
        'emailText
        '
        Me.emailText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailText.Location = New System.Drawing.Point(15, 108)
        Me.emailText.Name = "emailText"
        Me.emailText.Size = New System.Drawing.Size(329, 23)
        Me.emailText.TabIndex = 2
        Me.emailText.Text = "Email Address"
        '
        'passText
        '
        Me.passText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passText.Location = New System.Drawing.Point(15, 193)
        Me.passText.Name = "passText"
        Me.passText.Size = New System.Drawing.Size(329, 23)
        Me.passText.TabIndex = 3
        Me.passText.Text = "Password"
        '
        'cpassText
        '
        Me.cpassText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cpassText.Location = New System.Drawing.Point(15, 235)
        Me.cpassText.Name = "cpassText"
        Me.cpassText.Size = New System.Drawing.Size(329, 23)
        Me.cpassText.TabIndex = 4
        Me.cpassText.Text = "Confirm Password"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 261)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Role"
        '
        'cb_roles
        '
        Me.cb_roles.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_roles.FormattingEnabled = True
        Me.cb_roles.ItemHeight = 23
        Me.cb_roles.Items.AddRange(New Object() {"Admin", "Employee", "Customer"})
        Me.cb_roles.Location = New System.Drawing.Point(15, 283)
        Me.cb_roles.Name = "cb_roles"
        Me.cb_roles.Size = New System.Drawing.Size(329, 29)
        Me.cb_roles.TabIndex = 6
        '
        'btn_register
        '
        Me.btn_register.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_register.Location = New System.Drawing.Point(15, 318)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(329, 36)
        Me.btn_register.TabIndex = 11
        Me.btn_register.Text = "Register"
        '
        'cnumText
        '
        Me.cnumText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cnumText.Location = New System.Drawing.Point(15, 150)
        Me.cnumText.Name = "cnumText"
        Me.cnumText.Size = New System.Drawing.Size(329, 23)
        Me.cnumText.TabIndex = 12
        Me.cnumText.Text = "Contact Number"
        '
        'usr_regsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cnumText)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.cb_roles)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cpassText)
        Me.Controls.Add(Me.passText)
        Me.Controls.Add(Me.emailText)
        Me.Controls.Add(Me.unameText)
        Me.Controls.Add(Me.fullnameText)
        Me.Name = "usr_regsForm"
        Me.Size = New System.Drawing.Size(363, 389)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fullnameText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents unameText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents emailText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents passText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cpassText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cb_roles As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btn_register As MetroFramework.Controls.MetroButton
    Friend WithEvents cnumText As MetroFramework.Controls.MetroTextBox
End Class
