﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr_order))
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.search_order = New MetroFramework.Controls.MetroTextBox()
        Me.btn_addOrder = New MetroFramework.Controls.MetroButton()
        Me.dgv_order = New System.Windows.Forms.DataGridView()
        Me.id_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderAction = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.dgv_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.search_order)
        Me.MetroPanel2.Controls.Add(Me.btn_addOrder)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(775, 37)
        Me.MetroPanel2.TabIndex = 9
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'search_order
        '
        Me.search_order.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_order.Location = New System.Drawing.Point(526, 7)
        Me.search_order.Name = "search_order"
        Me.search_order.Size = New System.Drawing.Size(240, 23)
        Me.search_order.TabIndex = 3
        Me.search_order.Text = "Search for order"
        '
        'btn_addOrder
        '
        Me.btn_addOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_addOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addOrder.Location = New System.Drawing.Point(3, 3)
        Me.btn_addOrder.Name = "btn_addOrder"
        Me.btn_addOrder.Size = New System.Drawing.Size(114, 31)
        Me.btn_addOrder.TabIndex = 2
        Me.btn_addOrder.Text = "ADD ORDER"
        '
        'dgv_order
        '
        Me.dgv_order.AllowUserToAddRows = False
        Me.dgv_order.AllowUserToDeleteRows = False
        Me.dgv_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_no, Me.cusName, Me.prodOrder, Me.invoiceRef, Me.orderAction})
        Me.dgv_order.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_order.Location = New System.Drawing.Point(0, 37)
        Me.dgv_order.Name = "dgv_order"
        Me.dgv_order.ReadOnly = True
        Me.dgv_order.Size = New System.Drawing.Size(775, 299)
        Me.dgv_order.TabIndex = 10
        '
        'id_no
        '
        Me.id_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id_no.HeaderText = "#"
        Me.id_no.Name = "id_no"
        Me.id_no.ReadOnly = True
        Me.id_no.Width = 39
        '
        'cusName
        '
        Me.cusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cusName.HeaderText = "Ordered Product"
        Me.cusName.Name = "cusName"
        Me.cusName.ReadOnly = True
        '
        'prodOrder
        '
        Me.prodOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.prodOrder.HeaderText = "Quantity"
        Me.prodOrder.Name = "prodOrder"
        Me.prodOrder.ReadOnly = True
        Me.prodOrder.Width = 71
        '
        'invoiceRef
        '
        Me.invoiceRef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invoiceRef.HeaderText = "Invoice Reference"
        Me.invoiceRef.Name = "invoiceRef"
        Me.invoiceRef.ReadOnly = True
        Me.invoiceRef.Width = 110
        '
        'orderAction
        '
        Me.orderAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.orderAction.HeaderText = "Action"
        Me.orderAction.Image = CType(resources.GetObject("orderAction.Image"), System.Drawing.Image)
        Me.orderAction.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.orderAction.Name = "orderAction"
        Me.orderAction.ReadOnly = True
        Me.orderAction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.orderAction.Width = 62
        '
        'usr_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgv_order)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "usr_order"
        Me.Size = New System.Drawing.Size(775, 336)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.dgv_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents search_order As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_addOrder As MetroFramework.Controls.MetroButton
    Friend WithEvents dgv_order As DataGridView
    Friend WithEvents id_no As DataGridViewTextBoxColumn
    Friend WithEvents cusName As DataGridViewTextBoxColumn
    Friend WithEvents prodOrder As DataGridViewTextBoxColumn
    Friend WithEvents invoiceRef As DataGridViewTextBoxColumn
    Friend WithEvents orderAction As DataGridViewImageColumn
End Class
