<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr_users))
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.search_user = New MetroFramework.Controls.MetroTextBox()
        Me.btn_addUsers = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.userNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userFullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userUname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userAction = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.search_user)
        Me.MetroPanel2.Controls.Add(Me.btn_addUsers)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(752, 37)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'search_user
        '
        Me.search_user.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_user.Location = New System.Drawing.Point(503, 7)
        Me.search_user.Name = "search_user"
        Me.search_user.Size = New System.Drawing.Size(240, 23)
        Me.search_user.TabIndex = 3
        Me.search_user.Text = "Search for user"
        '
        'btn_addUsers
        '
        Me.btn_addUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_addUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addUsers.Location = New System.Drawing.Point(3, 3)
        Me.btn_addUsers.Name = "btn_addUsers"
        Me.btn_addUsers.Size = New System.Drawing.Size(114, 31)
        Me.btn_addUsers.TabIndex = 2
        Me.btn_addUsers.Text = "ADD USER"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userNum, Me.userFullname, Me.userUname, Me.userEmail, Me.cnum, Me.roles, Me.status, Me.userAction})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(752, 338)
        Me.DataGridView1.TabIndex = 5
        '
        'userNum
        '
        Me.userNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.userNum.HeaderText = "#"
        Me.userNum.Name = "userNum"
        Me.userNum.ReadOnly = True
        Me.userNum.Width = 39
        '
        'userFullname
        '
        Me.userFullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.userFullname.HeaderText = "Full Name"
        Me.userFullname.Name = "userFullname"
        Me.userFullname.ReadOnly = True
        '
        'userUname
        '
        Me.userUname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.userUname.HeaderText = "Username"
        Me.userUname.Name = "userUname"
        Me.userUname.ReadOnly = True
        '
        'userEmail
        '
        Me.userEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.userEmail.HeaderText = "Email"
        Me.userEmail.Name = "userEmail"
        Me.userEmail.ReadOnly = True
        '
        'cnum
        '
        Me.cnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cnum.HeaderText = "Contact Number"
        Me.cnum.Name = "cnum"
        Me.cnum.ReadOnly = True
        '
        'roles
        '
        Me.roles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.roles.HeaderText = "Roles"
        Me.roles.Name = "roles"
        Me.roles.ReadOnly = True
        Me.roles.Width = 59
        '
        'status
        '
        Me.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 62
        '
        'userAction
        '
        Me.userAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.userAction.HeaderText = "Action"
        Me.userAction.Image = CType(resources.GetObject("userAction.Image"), System.Drawing.Image)
        Me.userAction.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.userAction.Name = "userAction"
        Me.userAction.ReadOnly = True
        Me.userAction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.userAction.Width = 62
        '
        'usr_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "usr_users"
        Me.Size = New System.Drawing.Size(752, 375)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents search_user As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_addUsers As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents userNum As DataGridViewTextBoxColumn
    Friend WithEvents userFullname As DataGridViewTextBoxColumn
    Friend WithEvents userUname As DataGridViewTextBoxColumn
    Friend WithEvents userEmail As DataGridViewTextBoxColumn
    Friend WithEvents cnum As DataGridViewTextBoxColumn
    Friend WithEvents roles As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents userAction As DataGridViewImageColumn
End Class
