<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_inventory
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.invNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invProdPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invPlatform = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invNumber, Me.invProduct, Me.invProdPrice, Me.invSupplier, Me.invPlatform})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(860, 390)
        Me.DataGridView1.TabIndex = 0
        '
        'invNumber
        '
        Me.invNumber.HeaderText = "#"
        Me.invNumber.Name = "invNumber"
        Me.invNumber.ReadOnly = True
        '
        'invProduct
        '
        Me.invProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.invProduct.HeaderText = "Product Name"
        Me.invProduct.Name = "invProduct"
        Me.invProduct.ReadOnly = True
        Me.invProduct.Width = 550
        '
        'invProdPrice
        '
        Me.invProdPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.invProdPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.invProdPrice.HeaderText = "Product Price"
        Me.invProdPrice.Name = "invProdPrice"
        Me.invProdPrice.ReadOnly = True
        Me.invProdPrice.Width = 96
        '
        'invSupplier
        '
        Me.invSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invSupplier.HeaderText = "Supplier Name"
        Me.invSupplier.Name = "invSupplier"
        Me.invSupplier.ReadOnly = True
        Me.invSupplier.Width = 101
        '
        'invPlatform
        '
        Me.invPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.invPlatform.HeaderText = "Platform"
        Me.invPlatform.Name = "invPlatform"
        Me.invPlatform.ReadOnly = True
        '
        'usr_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "usr_inventory"
        Me.Size = New System.Drawing.Size(860, 390)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents invNumber As DataGridViewTextBoxColumn
    Friend WithEvents invProduct As DataGridViewTextBoxColumn
    Friend WithEvents invProdPrice As DataGridViewTextBoxColumn
    Friend WithEvents invSupplier As DataGridViewTextBoxColumn
    Friend WithEvents invPlatform As DataGridViewTextBoxColumn
End Class
