<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.invoiceRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_order = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'invoiceRef
        '
        Me.invoiceRef.HeaderText = "Invoice Reference"
        Me.invoiceRef.Name = "invoiceRef"
        Me.invoiceRef.ReadOnly = True
        '
        'empName
        '
        Me.empName.HeaderText = "Employee Name"
        Me.empName.Name = "empName"
        Me.empName.ReadOnly = True
        '
        'prodOrder
        '
        Me.prodOrder.HeaderText = "Product Ordered"
        Me.prodOrder.Name = "prodOrder"
        Me.prodOrder.ReadOnly = True
        '
        'cusName
        '
        Me.cusName.HeaderText = "Customer Name"
        Me.cusName.Name = "cusName"
        Me.cusName.ReadOnly = True
        '
        'id_no
        '
        Me.id_no.HeaderText = "#"
        Me.id_no.Name = "id_no"
        Me.id_no.ReadOnly = True
        '
        'dgv_order
        '
        Me.dgv_order.AllowUserToAddRows = False
        Me.dgv_order.AllowUserToDeleteRows = False
        Me.dgv_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_no, Me.cusName, Me.prodOrder, Me.empName, Me.invoiceRef})
        Me.dgv_order.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_order.Location = New System.Drawing.Point(0, 0)
        Me.dgv_order.Name = "dgv_order"
        Me.dgv_order.ReadOnly = True
        Me.dgv_order.Size = New System.Drawing.Size(775, 336)
        Me.dgv_order.TabIndex = 8
        '
        'usr_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgv_order)
        Me.Name = "usr_order"
        Me.Size = New System.Drawing.Size(775, 336)
        CType(Me.dgv_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents invoiceRef As DataGridViewTextBoxColumn
    Friend WithEvents empName As DataGridViewTextBoxColumn
    Friend WithEvents prodOrder As DataGridViewTextBoxColumn
    Friend WithEvents cusName As DataGridViewTextBoxColumn
    Friend WithEvents id_no As DataGridViewTextBoxColumn
    Friend WithEvents dgv_order As DataGridView
End Class
