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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr_inventory))
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.search_prod = New MetroFramework.Controls.MetroTextBox()
        Me.btn_addProd = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.invNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invProdPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.invAction = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.search_prod)
        Me.MetroPanel2.Controls.Add(Me.btn_addProd)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(860, 37)
        Me.MetroPanel2.TabIndex = 10
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'search_prod
        '
        Me.search_prod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_prod.Location = New System.Drawing.Point(611, 7)
        Me.search_prod.Name = "search_prod"
        Me.search_prod.Size = New System.Drawing.Size(240, 23)
        Me.search_prod.TabIndex = 3
        Me.search_prod.Text = "Search for product"
        '
        'btn_addProd
        '
        Me.btn_addProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_addProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addProd.Location = New System.Drawing.Point(3, 3)
        Me.btn_addProd.Name = "btn_addProd"
        Me.btn_addProd.Size = New System.Drawing.Size(114, 31)
        Me.btn_addProd.TabIndex = 2
        Me.btn_addProd.Text = "ADD PRODUCT"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invNumber, Me.invProduct, Me.prodSize, Me.prodColor, Me.invProdPrice, Me.invSupplier, Me.invAction})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(860, 353)
        Me.DataGridView1.TabIndex = 11
        '
        'invNumber
        '
        Me.invNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invNumber.HeaderText = "#"
        Me.invNumber.Name = "invNumber"
        Me.invNumber.ReadOnly = True
        Me.invNumber.Width = 39
        '
        'invProduct
        '
        Me.invProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.invProduct.HeaderText = "Product Name"
        Me.invProduct.Name = "invProduct"
        Me.invProduct.ReadOnly = True
        '
        'prodSize
        '
        Me.prodSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.prodSize.HeaderText = "Size"
        Me.prodSize.Name = "prodSize"
        Me.prodSize.ReadOnly = True
        Me.prodSize.Width = 52
        '
        'prodColor
        '
        Me.prodColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.prodColor.HeaderText = "Color"
        Me.prodColor.Name = "prodColor"
        Me.prodColor.ReadOnly = True
        Me.prodColor.Width = 56
        '
        'invProdPrice
        '
        Me.invProdPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.invProdPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.invProdPrice.HeaderText = "Price"
        Me.invProdPrice.Name = "invProdPrice"
        Me.invProdPrice.ReadOnly = True
        Me.invProdPrice.Width = 56
        '
        'invSupplier
        '
        Me.invSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.invSupplier.HeaderText = "Supplier Name"
        Me.invSupplier.Name = "invSupplier"
        Me.invSupplier.ReadOnly = True
        '
        'invAction
        '
        Me.invAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.invAction.HeaderText = "Action"
        Me.invAction.Image = CType(resources.GetObject("invAction.Image"), System.Drawing.Image)
        Me.invAction.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.invAction.Name = "invAction"
        Me.invAction.ReadOnly = True
        Me.invAction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.invAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.invAction.Width = 62
        '
        'usr_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "usr_inventory"
        Me.Size = New System.Drawing.Size(860, 390)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_addProd As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents search_prod As MetroFramework.Controls.MetroTextBox
    Friend WithEvents invNumber As DataGridViewTextBoxColumn
    Friend WithEvents invProduct As DataGridViewTextBoxColumn
    Friend WithEvents prodSize As DataGridViewTextBoxColumn
    Friend WithEvents prodColor As DataGridViewTextBoxColumn
    Friend WithEvents invProdPrice As DataGridViewTextBoxColumn
    Friend WithEvents invSupplier As DataGridViewTextBoxColumn
    Friend WithEvents invAction As DataGridViewImageColumn
End Class
