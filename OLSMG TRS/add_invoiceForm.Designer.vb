<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_invoiceForm
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
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.invDate = New System.Windows.Forms.DateTimePicker()
        Me.invCusName = New MetroFramework.Controls.MetroComboBox()
        Me.invEmpName = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.invRefNum = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.invTotalAmount = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btn_deleteInv = New MetroFramework.Controls.MetroButton()
        Me.btn_invAdd = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btn_clearProd = New MetroFramework.Controls.MetroButton()
        Me.btn_removeOrder = New MetroFramework.Controls.MetroButton()
        Me.cb_product = New MetroFramework.Controls.MetroComboBox()
        Me.orderNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.invDate)
        Me.MetroPanel2.Controls.Add(Me.invCusName)
        Me.MetroPanel2.Controls.Add(Me.invEmpName)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel2.Controls.Add(Me.invRefNum)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.invTotalAmount)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(295, 405)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'invDate
        '
        Me.invDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.invDate.Location = New System.Drawing.Point(18, 63)
        Me.invDate.Name = "invDate"
        Me.invDate.Size = New System.Drawing.Size(260, 20)
        Me.invDate.TabIndex = 18
        '
        'invCusName
        '
        Me.invCusName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.invCusName.FormattingEnabled = True
        Me.invCusName.ItemHeight = 23
        Me.invCusName.Location = New System.Drawing.Point(18, 155)
        Me.invCusName.Name = "invCusName"
        Me.invCusName.Size = New System.Drawing.Size(260, 29)
        Me.invCusName.TabIndex = 16
        '
        'invEmpName
        '
        Me.invEmpName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.invEmpName.FormattingEnabled = True
        Me.invEmpName.ItemHeight = 23
        Me.invEmpName.Location = New System.Drawing.Point(18, 206)
        Me.invEmpName.Name = "invEmpName"
        Me.invEmpName.Size = New System.Drawing.Size(260, 29)
        Me.invEmpName.TabIndex = 15
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(17, 86)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "Reference Number"
        '
        'invRefNum
        '
        Me.invRefNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.invRefNum.Location = New System.Drawing.Point(17, 107)
        Me.invRefNum.MaxLength = 255
        Me.invRefNum.Name = "invRefNum"
        Me.invRefNum.ReadOnly = True
        Me.invRefNum.Size = New System.Drawing.Size(260, 23)
        Me.invRefNum.TabIndex = 13
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(17, 184)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(107, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Employee Name"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 133)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Customer Name"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 238)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Total Amount"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 38)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Date Issue"
        '
        'invTotalAmount
        '
        Me.invTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.invTotalAmount.Location = New System.Drawing.Point(18, 260)
        Me.invTotalAmount.MaxLength = 11
        Me.invTotalAmount.Name = "invTotalAmount"
        Me.invTotalAmount.ReadOnly = True
        Me.invTotalAmount.Size = New System.Drawing.Size(260, 23)
        Me.invTotalAmount.TabIndex = 3
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btn_deleteInv)
        Me.MetroPanel1.Controls.Add(Me.btn_invAdd)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 405)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(806, 34)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btn_deleteInv
        '
        Me.btn_deleteInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deleteInv.Location = New System.Drawing.Point(700, 6)
        Me.btn_deleteInv.Name = "btn_deleteInv"
        Me.btn_deleteInv.Size = New System.Drawing.Size(100, 23)
        Me.btn_deleteInv.TabIndex = 3
        Me.btn_deleteInv.Text = "DELETE"
        '
        'btn_invAdd
        '
        Me.btn_invAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_invAdd.Location = New System.Drawing.Point(594, 6)
        Me.btn_invAdd.Name = "btn_invAdd"
        Me.btn_invAdd.Size = New System.Drawing.Size(100, 23)
        Me.btn_invAdd.TabIndex = 2
        Me.btn_invAdd.Text = "CONFIRM"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(295, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 405)
        Me.Panel1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderNum, Me.orderName, Me.orderAmount, Me.orderUnitPrice, Me.stocks})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 366)
        Me.DataGridView1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Controls.Add(Me.btn_clearProd)
        Me.Panel2.Controls.Add(Me.btn_removeOrder)
        Me.Panel2.Controls.Add(Me.cb_product)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(511, 39)
        Me.Panel2.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel1.TabIndex = 9
        Me.MetroLabel1.Text = "Add Product:"
        '
        'btn_clearProd
        '
        Me.btn_clearProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clearProd.Location = New System.Drawing.Point(400, 5)
        Me.btn_clearProd.Name = "btn_clearProd"
        Me.btn_clearProd.Size = New System.Drawing.Size(104, 29)
        Me.btn_clearProd.TabIndex = 8
        Me.btn_clearProd.Text = "Clear"
        '
        'btn_removeOrder
        '
        Me.btn_removeOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_removeOrder.Location = New System.Drawing.Point(290, 5)
        Me.btn_removeOrder.Name = "btn_removeOrder"
        Me.btn_removeOrder.Size = New System.Drawing.Size(104, 29)
        Me.btn_removeOrder.TabIndex = 7
        Me.btn_removeOrder.Text = "Remove"
        '
        'cb_product
        '
        Me.cb_product.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_product.FormattingEnabled = True
        Me.cb_product.ItemHeight = 23
        Me.cb_product.Location = New System.Drawing.Point(99, 5)
        Me.cb_product.Name = "cb_product"
        Me.cb_product.Size = New System.Drawing.Size(185, 29)
        Me.cb_product.TabIndex = 6
        '
        'orderNum
        '
        Me.orderNum.HeaderText = "#"
        Me.orderNum.Name = "orderNum"
        '
        'orderName
        '
        Me.orderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.orderName.HeaderText = "Product"
        Me.orderName.Name = "orderName"
        Me.orderName.ReadOnly = True
        '
        'orderAmount
        '
        Me.orderAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.orderAmount.HeaderText = "Quantity"
        Me.orderAmount.Name = "orderAmount"
        Me.orderAmount.Width = 71
        '
        'orderUnitPrice
        '
        Me.orderUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.orderUnitPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.orderUnitPrice.HeaderText = "Price"
        Me.orderUnitPrice.Name = "orderUnitPrice"
        Me.orderUnitPrice.ReadOnly = True
        Me.orderUnitPrice.Width = 56
        '
        'stocks
        '
        Me.stocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.stocks.HeaderText = "Stocks"
        Me.stocks.Name = "stocks"
        Me.stocks.ReadOnly = True
        Me.stocks.Width = 65
        '
        'add_invoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "add_invoiceForm"
        Me.Size = New System.Drawing.Size(806, 439)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents invTotalAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_deleteInv As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_invAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents invCusName As MetroFramework.Controls.MetroComboBox
    Friend WithEvents invEmpName As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents invRefNum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents invDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_clearProd As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_removeOrder As MetroFramework.Controls.MetroButton
    Friend WithEvents cb_product As MetroFramework.Controls.MetroComboBox
    Friend WithEvents orderNum As DataGridViewTextBoxColumn
    Friend WithEvents orderName As DataGridViewTextBoxColumn
    Friend WithEvents orderAmount As DataGridViewTextBoxColumn
    Friend WithEvents orderUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents stocks As DataGridViewTextBoxColumn
End Class
