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
        Me.fullnameText = New MetroFramework.Controls.MetroTextBox()
        Me.unameText = New MetroFramework.Controls.MetroTextBox()
        Me.emailText = New MetroFramework.Controls.MetroTextBox()
        Me.passText = New MetroFramework.Controls.MetroTextBox()
        Me.cpassText = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cb_roles = New MetroFramework.Controls.MetroComboBox()
        Me.btn_register = New MetroFramework.Controls.MetroButton()
        Me.cnumText = New MetroFramework.Controls.MetroTextBox()
        Me.btn_approve = New MetroFramework.Controls.MetroButton()
        Me.btn_disable = New MetroFramework.Controls.MetroButton()
        Me.btn_confirm = New MetroFramework.Controls.MetroButton()
        Me.btn_delete = New MetroFramework.Controls.MetroButton()
        Me.btn_activate = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'fullnameText
        '
        Me.fullnameText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fullnameText.Location = New System.Drawing.Point(20, 17)
        Me.fullnameText.Name = "fullnameText"
        Me.fullnameText.Size = New System.Drawing.Size(300, 23)
        Me.fullnameText.TabIndex = 0
        Me.fullnameText.Text = "Full Name"
        '
        'unameText
        '
        Me.unameText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unameText.Location = New System.Drawing.Point(20, 60)
        Me.unameText.Name = "unameText"
        Me.unameText.Size = New System.Drawing.Size(300, 23)
        Me.unameText.TabIndex = 1
        Me.unameText.Text = "Username"
        '
        'emailText
        '
        Me.emailText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailText.Location = New System.Drawing.Point(20, 101)
        Me.emailText.Name = "emailText"
        Me.emailText.Size = New System.Drawing.Size(300, 23)
        Me.emailText.TabIndex = 2
        Me.emailText.Text = "Email Address"
        '
        'passText
        '
        Me.passText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passText.Location = New System.Drawing.Point(20, 186)
        Me.passText.Name = "passText"
        Me.passText.Size = New System.Drawing.Size(300, 23)
        Me.passText.TabIndex = 3
        Me.passText.Text = "Password"
        '
        'cpassText
        '
        Me.cpassText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cpassText.Location = New System.Drawing.Point(20, 228)
        Me.cpassText.Name = "cpassText"
        Me.cpassText.Size = New System.Drawing.Size(300, 23)
        Me.cpassText.TabIndex = 4
        Me.cpassText.Text = "Confirm Password"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(20, 254)
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
        Me.cb_roles.Location = New System.Drawing.Point(20, 276)
        Me.cb_roles.Name = "cb_roles"
        Me.cb_roles.Size = New System.Drawing.Size(300, 29)
        Me.cb_roles.TabIndex = 6
        '
        'btn_register
        '
        Me.btn_register.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_register.Location = New System.Drawing.Point(20, 311)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(300, 36)
        Me.btn_register.TabIndex = 11
        Me.btn_register.Text = "Register"
        '
        'cnumText
        '
        Me.cnumText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cnumText.Location = New System.Drawing.Point(20, 143)
        Me.cnumText.Name = "cnumText"
        Me.cnumText.Size = New System.Drawing.Size(300, 23)
        Me.cnumText.TabIndex = 12
        Me.cnumText.Text = "Contact Number"
        '
        'btn_approve
        '
        Me.btn_approve.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approve.Location = New System.Drawing.Point(20, 311)
        Me.btn_approve.Name = "btn_approve"
        Me.btn_approve.Size = New System.Drawing.Size(300, 36)
        Me.btn_approve.TabIndex = 13
        Me.btn_approve.Text = "Approve"
        Me.btn_approve.Visible = False
        '
        'btn_disable
        '
        Me.btn_disable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_disable.Location = New System.Drawing.Point(20, 353)
        Me.btn_disable.Name = "btn_disable"
        Me.btn_disable.Size = New System.Drawing.Size(300, 36)
        Me.btn_disable.TabIndex = 14
        Me.btn_disable.Text = "Disable"
        Me.btn_disable.Visible = False
        '
        'btn_confirm
        '
        Me.btn_confirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_confirm.Location = New System.Drawing.Point(20, 311)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(300, 36)
        Me.btn_confirm.TabIndex = 15
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Location = New System.Drawing.Point(20, 353)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(300, 36)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.Visible = False
        '
        'btn_activate
        '
        Me.btn_activate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_activate.Location = New System.Drawing.Point(20, 311)
        Me.btn_activate.Name = "btn_activate"
        Me.btn_activate.Size = New System.Drawing.Size(300, 36)
        Me.btn_activate.TabIndex = 17
        Me.btn_activate.Text = "Activate"
        Me.btn_activate.Visible = False
        '
        'add_userForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_activate)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_disable)
        Me.Controls.Add(Me.btn_approve)
        Me.Controls.Add(Me.cnumText)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.cb_roles)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.cpassText)
        Me.Controls.Add(Me.passText)
        Me.Controls.Add(Me.emailText)
        Me.Controls.Add(Me.unameText)
        Me.Controls.Add(Me.fullnameText)
        Me.Name = "add_userForm"
        Me.Size = New System.Drawing.Size(334, 425)
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
    Friend WithEvents btn_approve As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_disable As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_confirm As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_delete As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_activate As MetroFramework.Controls.MetroButton
End Class
