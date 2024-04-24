<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr_customer))
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.search_cus = New MetroFramework.Controls.MetroTextBox()
        Me.btn_addCus = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cusNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusMi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusCnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusAction = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.search_cus)
        Me.MetroPanel2.Controls.Add(Me.btn_addCus)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(887, 37)
        Me.MetroPanel2.TabIndex = 3
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'search_cus
        '
        Me.search_cus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_cus.Location = New System.Drawing.Point(638, 7)
        Me.search_cus.Name = "search_cus"
        Me.search_cus.Size = New System.Drawing.Size(240, 23)
        Me.search_cus.TabIndex = 3
        Me.search_cus.Text = "Search for customer"
        '
        'btn_addCus
        '
        Me.btn_addCus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_addCus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addCus.Location = New System.Drawing.Point(3, 3)
        Me.btn_addCus.Name = "btn_addCus"
        Me.btn_addCus.Size = New System.Drawing.Size(114, 31)
        Me.btn_addCus.TabIndex = 2
        Me.btn_addCus.Text = "ADD CUSTOMER"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cusNum, Me.cusLname, Me.cusFname, Me.cusMi, Me.cusCnum, Me.email, Me.cusAction})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(887, 317)
        Me.DataGridView1.TabIndex = 4
        '
        'cusNum
        '
        Me.cusNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cusNum.HeaderText = "#"
        Me.cusNum.Name = "cusNum"
        Me.cusNum.ReadOnly = True
        Me.cusNum.Width = 39
        '
        'cusLname
        '
        Me.cusLname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cusLname.HeaderText = "Last Name"
        Me.cusLname.Name = "cusLname"
        Me.cusLname.ReadOnly = True
        '
        'cusFname
        '
        Me.cusFname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cusFname.HeaderText = "First Name"
        Me.cusFname.Name = "cusFname"
        Me.cusFname.ReadOnly = True
        '
        'cusMi
        '
        Me.cusMi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cusMi.HeaderText = "Middle Initial"
        Me.cusMi.Name = "cusMi"
        Me.cusMi.ReadOnly = True
        Me.cusMi.Width = 90
        '
        'cusCnum
        '
        Me.cusCnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cusCnum.HeaderText = "Contact Number"
        Me.cusCnum.Name = "cusCnum"
        Me.cusCnum.ReadOnly = True
        '
        'email
        '
        Me.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.email.HeaderText = "Email Address"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'cusAction
        '
        Me.cusAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cusAction.HeaderText = "Action"
        Me.cusAction.Image = CType(resources.GetObject("cusAction.Image"), System.Drawing.Image)
        Me.cusAction.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.cusAction.Name = "cusAction"
        Me.cusAction.ReadOnly = True
        Me.cusAction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cusAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cusAction.Width = 62
        '
        'usr_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "usr_customer"
        Me.Size = New System.Drawing.Size(887, 354)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents search_cus As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_addCus As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cusNum As DataGridViewTextBoxColumn
    Friend WithEvents cusLname As DataGridViewTextBoxColumn
    Friend WithEvents cusFname As DataGridViewTextBoxColumn
    Friend WithEvents cusMi As DataGridViewTextBoxColumn
    Friend WithEvents cusCnum As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents cusAction As DataGridViewImageColumn
End Class
