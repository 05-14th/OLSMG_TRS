<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_employee
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
        Me.search_emp = New MetroFramework.Controls.MetroTextBox()
        Me.btn_addEmp = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.empNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empMI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empCnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.search_emp)
        Me.MetroPanel2.Controls.Add(Me.btn_addEmp)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(882, 37)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'search_emp
        '
        Me.search_emp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_emp.Location = New System.Drawing.Point(633, 7)
        Me.search_emp.Name = "search_emp"
        Me.search_emp.Size = New System.Drawing.Size(240, 23)
        Me.search_emp.TabIndex = 3
        Me.search_emp.Text = "Search for employee"
        '
        'btn_addEmp
        '
        Me.btn_addEmp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_addEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addEmp.Location = New System.Drawing.Point(3, 3)
        Me.btn_addEmp.Name = "btn_addEmp"
        Me.btn_addEmp.Size = New System.Drawing.Size(114, 31)
        Me.btn_addEmp.TabIndex = 2
        Me.btn_addEmp.Text = "ADD EMPLOYEE"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empNum, Me.empLname, Me.empFname, Me.empMI, Me.empCnum, Me.empPosition, Me.empAction})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(882, 319)
        Me.DataGridView1.TabIndex = 5
        '
        'empNum
        '
        Me.empNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.empNum.HeaderText = "#"
        Me.empNum.Name = "empNum"
        Me.empNum.ReadOnly = True
        Me.empNum.Width = 39
        '
        'empLname
        '
        Me.empLname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.empLname.HeaderText = "Last Name"
        Me.empLname.Name = "empLname"
        Me.empLname.ReadOnly = True
        '
        'empFname
        '
        Me.empFname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.empFname.HeaderText = "First Name"
        Me.empFname.Name = "empFname"
        Me.empFname.ReadOnly = True
        '
        'empMI
        '
        Me.empMI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.empMI.HeaderText = "Middle Initial"
        Me.empMI.Name = "empMI"
        Me.empMI.ReadOnly = True
        Me.empMI.Width = 90
        '
        'empCnum
        '
        Me.empCnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.empCnum.HeaderText = "Cellphone Number"
        Me.empCnum.Name = "empCnum"
        Me.empCnum.ReadOnly = True
        Me.empCnum.Width = 109
        '
        'empPosition
        '
        Me.empPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.empPosition.HeaderText = "Position"
        Me.empPosition.Name = "empPosition"
        Me.empPosition.ReadOnly = True
        Me.empPosition.Width = 69
        '
        'empAction
        '
        Me.empAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.empAction.HeaderText = "Action"
        Me.empAction.Name = "empAction"
        Me.empAction.ReadOnly = True
        Me.empAction.Width = 62
        '
        'usr_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "usr_employee"
        Me.Size = New System.Drawing.Size(882, 356)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents search_emp As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_addEmp As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents empNum As DataGridViewTextBoxColumn
    Friend WithEvents empLname As DataGridViewTextBoxColumn
    Friend WithEvents empFname As DataGridViewTextBoxColumn
    Friend WithEvents empMI As DataGridViewTextBoxColumn
    Friend WithEvents empCnum As DataGridViewTextBoxColumn
    Friend WithEvents empPosition As DataGridViewTextBoxColumn
    Friend WithEvents empAction As DataGridViewTextBoxColumn
End Class
