<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_invoice
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.invoiceNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceDataIssure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceTotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceCusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceEmpName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invoiceRefNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invoiceNum, Me.invoiceDataIssure, Me.invoiceTotalAmount, Me.invoiceCusName, Me.invoiceEmpName, Me.invoiceProdName, Me.invoiceRefNum})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(756, 372)
        Me.DataGridView1.TabIndex = 0
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
        Me.invoiceDataIssure.Width = 83
        '
        'invoiceTotalAmount
        '
        Me.invoiceTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.invoiceTotalAmount.DefaultCellStyle = DataGridViewCellStyle1
        Me.invoiceTotalAmount.HeaderText = "Total Amount"
        Me.invoiceTotalAmount.Name = "invoiceTotalAmount"
        Me.invoiceTotalAmount.ReadOnly = True
        Me.invoiceTotalAmount.Width = 95
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
        'invoiceProdName
        '
        Me.invoiceProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.invoiceProdName.HeaderText = "Product Name"
        Me.invoiceProdName.Name = "invoiceProdName"
        Me.invoiceProdName.ReadOnly = True
        '
        'invoiceRefNum
        '
        Me.invoiceRefNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invoiceRefNum.HeaderText = "Reference Number"
        Me.invoiceRefNum.Name = "invoiceRefNum"
        Me.invoiceRefNum.ReadOnly = True
        Me.invoiceRefNum.Width = 112
        '
        'usr_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "usr_invoice"
        Me.Size = New System.Drawing.Size(756, 372)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents invoiceNum As DataGridViewTextBoxColumn
    Friend WithEvents invoiceDataIssure As DataGridViewTextBoxColumn
    Friend WithEvents invoiceTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents invoiceCusName As DataGridViewTextBoxColumn
    Friend WithEvents invoiceEmpName As DataGridViewTextBoxColumn
    Friend WithEvents invoiceProdName As DataGridViewTextBoxColumn
    Friend WithEvents invoiceRefNum As DataGridViewTextBoxColumn
End Class
