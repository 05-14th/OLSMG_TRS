<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_recovery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr_recovery))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Username = New MetroFramework.Controls.MetroTextBox()
        Me.Password = New MetroFramework.Controls.MetroTextBox()
        Me.Login = New MetroFramework.Controls.MetroButton()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(79, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 228)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Recovery Login"
        '
        'Username
        '
        Me.Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Username.Location = New System.Drawing.Point(26, 257)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(338, 23)
        Me.Username.TabIndex = 2
        Me.Username.Text = "Username"
        '
        'Password
        '
        Me.Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Password.Location = New System.Drawing.Point(26, 286)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(338, 23)
        Me.Password.TabIndex = 3
        Me.Password.Text = "Password"
        '
        'Login
        '
        Me.Login.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login.Location = New System.Drawing.Point(26, 337)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(338, 37)
        Me.Login.TabIndex = 4
        Me.Login.Text = "Sign In"
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Location = New System.Drawing.Point(26, 316)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(105, 15)
        Me.MetroCheckBox1.TabIndex = 5
        Me.MetroCheckBox1.Text = "Show Password"
        Me.MetroCheckBox1.UseVisualStyleBackColor = True
        '
        'usr_recovery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroCheckBox1)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "usr_recovery"
        Me.Size = New System.Drawing.Size(392, 447)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Username As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Login As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroCheckBox1 As MetroFramework.Controls.MetroCheckBox
End Class
