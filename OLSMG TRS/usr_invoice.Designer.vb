﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_invoice
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr_invoice))
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.Save = New System.Windows.Forms.Button()
        Me.cb_month = New MetroFramework.Controls.MetroComboBox()
        Me.cb_year = New MetroFramework.Controls.MetroComboBox()
        Me.search_inv = New MetroFramework.Controls.MetroTextBox()
        Me.btn_addInv = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.invoiceNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceDataIssure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceTotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceCusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceEmpName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceRefNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceAction = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.Save)
        Me.MetroPanel2.Controls.Add(Me.cb_month)
        Me.MetroPanel2.Controls.Add(Me.cb_year)
        Me.MetroPanel2.Controls.Add(Me.search_inv)
        Me.MetroPanel2.Controls.Add(Me.btn_addInv)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(756, 37)
        Me.MetroPanel2.TabIndex = 11
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(335, 7)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 6
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'cb_month
        '
        Me.cb_month.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_month.FormattingEnabled = True
        Me.cb_month.ItemHeight = 23
        Me.cb_month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cb_month.Location = New System.Drawing.Point(229, 4)
        Me.cb_month.MaximumSize = New System.Drawing.Size(100, 0)
        Me.cb_month.Name = "cb_month"
        Me.cb_month.Size = New System.Drawing.Size(100, 29)
        Me.cb_month.TabIndex = 5
        '
        'cb_year
        '
        Me.cb_year.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_year.FormattingEnabled = True
        Me.cb_year.ItemHeight = 23
        Me.cb_year.Items.AddRange(New Object() {"2030", "2029", "2028", "2027", "2026", "2025", "2024"})
        Me.cb_year.Location = New System.Drawing.Point(123, 4)
        Me.cb_year.MaximumSize = New System.Drawing.Size(100, 0)
        Me.cb_year.Name = "cb_year"
        Me.cb_year.Size = New System.Drawing.Size(100, 29)
        Me.cb_year.TabIndex = 4
        '
        'search_inv
        '
        Me.search_inv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_inv.Location = New System.Drawing.Point(507, 7)
        Me.search_inv.Name = "search_inv"
        Me.search_inv.Size = New System.Drawing.Size(240, 23)
        Me.search_inv.TabIndex = 3
        Me.search_inv.Text = "Search for invoice"
        '
        'btn_addInv
        '
        Me.btn_addInv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_addInv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addInv.Location = New System.Drawing.Point(3, 3)
        Me.btn_addInv.Name = "btn_addInv"
        Me.btn_addInv.Size = New System.Drawing.Size(114, 31)
        Me.btn_addInv.TabIndex = 2
        Me.btn_addInv.Text = "ADD INVOICE"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invoiceNum, Me.invoiceDataIssure, Me.invoiceTotalAmount, Me.invoiceCusName, Me.invoiceEmpName, Me.invoiceRefNum, Me.invoiceAction})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(756, 335)
        Me.DataGridView1.TabIndex = 12
        '
        'invoiceNum
        '
        Me.invoiceNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invoiceNum.HeaderText = "#"
        Me.invoiceNum.Name = "invoiceNum"
        Me.invoiceNum.ReadOnly = True
        Me.invoiceNum.Width = 39
        '
        'invoiceDataIssure
        '
        Me.invoiceDataIssure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invoiceDataIssure.HeaderText = "Date Issue"
        Me.invoiceDataIssure.Name = "invoiceDataIssure"
        Me.invoiceDataIssure.ReadOnly = True
        Me.invoiceDataIssure.Width = 77
        '
        'invoiceTotalAmount
        '
        Me.invoiceTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.invoiceTotalAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.invoiceTotalAmount.HeaderText = "Total Amount"
        Me.invoiceTotalAmount.Name = "invoiceTotalAmount"
        Me.invoiceTotalAmount.ReadOnly = True
        Me.invoiceTotalAmount.Width = 88
        '
        'invoiceCusName
        '
        Me.invoiceCusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.invoiceCusName.HeaderText = "Customer Name"
        Me.invoiceCusName.Name = "invoiceCusName"
        Me.invoiceCusName.ReadOnly = True
        '
        'invoiceEmpName
        '
        Me.invoiceEmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.invoiceEmpName.HeaderText = "Employee Name"
        Me.invoiceEmpName.Name = "invoiceEmpName"
        Me.invoiceEmpName.ReadOnly = True
        '
        'invoiceRefNum
        '
        Me.invoiceRefNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invoiceRefNum.HeaderText = "Reference Number"
        Me.invoiceRefNum.Name = "invoiceRefNum"
        Me.invoiceRefNum.ReadOnly = True
        Me.invoiceRefNum.Width = 112
        '
        'invoiceAction
        '
        Me.invoiceAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invoiceAction.HeaderText = "Action"
        Me.invoiceAction.Image = CType(resources.GetObject("invoiceAction.Image"), System.Drawing.Image)
        Me.invoiceAction.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.invoiceAction.Name = "invoiceAction"
        Me.invoiceAction.ReadOnly = True
        Me.invoiceAction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.invoiceAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.invoiceAction.Width = 62
        '
        'usr_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "usr_invoice"
        Me.Size = New System.Drawing.Size(756, 372)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents search_inv As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_addInv As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents invoiceNum As DataGridViewTextBoxColumn
    Friend WithEvents invoiceDataIssure As DataGridViewTextBoxColumn
    Friend WithEvents invoiceTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents invoiceCusName As DataGridViewTextBoxColumn
    Friend WithEvents invoiceEmpName As DataGridViewTextBoxColumn
    Friend WithEvents invoiceRefNum As DataGridViewTextBoxColumn
    Friend WithEvents invoiceAction As DataGridViewImageColumn
    Friend WithEvents cb_year As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cb_month As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Save As Button
End Class
