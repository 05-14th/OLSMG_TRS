<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_suppliers
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
        Me.search_sup = New MetroFramework.Controls.MetroTextBox()
        Me.btn_addSup = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.supNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supSname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supStoreAdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supPlatform = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.search_sup)
        Me.MetroPanel2.Controls.Add(Me.btn_addSup)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(740, 37)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'search_sup
        '
        Me.search_sup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_sup.Location = New System.Drawing.Point(491, 7)
        Me.search_sup.Name = "search_sup"
        Me.search_sup.Size = New System.Drawing.Size(240, 23)
        Me.search_sup.TabIndex = 3
        Me.search_sup.Text = "Search for supplier"
        '
        'btn_addSup
        '
        Me.btn_addSup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_addSup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addSup.Location = New System.Drawing.Point(3, 3)
        Me.btn_addSup.Name = "btn_addSup"
        Me.btn_addSup.Size = New System.Drawing.Size(114, 31)
        Me.btn_addSup.TabIndex = 2
        Me.btn_addSup.Text = "ADD SUPPLIER"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supNum, Me.supSname, Me.supStoreAdd, Me.supPlatform, Me.supplierAction})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(740, 326)
        Me.DataGridView1.TabIndex = 5
        '
        'supNum
        '
        Me.supNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.supNum.HeaderText = "#"
        Me.supNum.Name = "supNum"
        Me.supNum.ReadOnly = True
        Me.supNum.Width = 39
        '
        'supSname
        '
        Me.supSname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.supSname.HeaderText = "Store Name"
        Me.supSname.Name = "supSname"
        Me.supSname.ReadOnly = True
        '
        'supStoreAdd
        '
        Me.supStoreAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.supStoreAdd.HeaderText = "Store Address"
        Me.supStoreAdd.Name = "supStoreAdd"
        Me.supStoreAdd.ReadOnly = True
        '
        'supPlatform
        '
        Me.supPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.supPlatform.HeaderText = "Platform"
        Me.supPlatform.Name = "supPlatform"
        Me.supPlatform.ReadOnly = True
        Me.supPlatform.Width = 70
        '
        'supplierAction
        '
        Me.supplierAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.supplierAction.HeaderText = "Action"
        Me.supplierAction.Name = "supplierAction"
        Me.supplierAction.ReadOnly = True
        Me.supplierAction.Width = 62
        '
        'usr_suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "usr_suppliers"
        Me.Size = New System.Drawing.Size(740, 363)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents search_sup As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_addSup As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents supNum As DataGridViewTextBoxColumn
    Friend WithEvents supSname As DataGridViewTextBoxColumn
    Friend WithEvents supStoreAdd As DataGridViewTextBoxColumn
    Friend WithEvents supPlatform As DataGridViewTextBoxColumn
    Friend WithEvents supplierAction As DataGridViewTextBoxColumn
End Class
