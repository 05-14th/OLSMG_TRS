<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_orderForm
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btn_deleteOrder = New MetroFramework.Controls.MetroButton()
        Me.btn_orderAdd = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.totalAmountText = New MetroFramework.Controls.MetroTextBox()
        Me.cb_orderProd = New MetroFramework.Controls.MetroComboBox()
        Me.cb_refNum = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.quantityText = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btn_deleteOrder)
        Me.MetroPanel1.Controls.Add(Me.btn_orderAdd)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 216)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(365, 34)
        Me.MetroPanel1.TabIndex = 8
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btn_deleteOrder
        '
        Me.btn_deleteOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deleteOrder.Location = New System.Drawing.Point(259, 6)
        Me.btn_deleteOrder.Name = "btn_deleteOrder"
        Me.btn_deleteOrder.Size = New System.Drawing.Size(100, 23)
        Me.btn_deleteOrder.TabIndex = 3
        Me.btn_deleteOrder.Text = "DELETE"
        '
        'btn_orderAdd
        '
        Me.btn_orderAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_orderAdd.Location = New System.Drawing.Point(153, 6)
        Me.btn_orderAdd.Name = "btn_orderAdd"
        Me.btn_orderAdd.Size = New System.Drawing.Size(100, 23)
        Me.btn_orderAdd.TabIndex = 2
        Me.btn_orderAdd.Text = "CONFIRM"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.totalAmountText)
        Me.Panel1.Controls.Add(Me.cb_orderProd)
        Me.Panel1.Controls.Add(Me.cb_refNum)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.quantityText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 216)
        Me.Panel1.TabIndex = 9
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(11, 108)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel3.TabIndex = 18
        Me.MetroLabel3.Text = "Total Amount"
        '
        'totalAmountText
        '
        Me.totalAmountText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalAmountText.Location = New System.Drawing.Point(11, 130)
        Me.totalAmountText.Name = "totalAmountText"
        Me.totalAmountText.ReadOnly = True
        Me.totalAmountText.Size = New System.Drawing.Size(340, 23)
        Me.totalAmountText.TabIndex = 17
        '
        'cb_orderProd
        '
        Me.cb_orderProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_orderProd.FormattingEnabled = True
        Me.cb_orderProd.ItemHeight = 23
        Me.cb_orderProd.Location = New System.Drawing.Point(11, 32)
        Me.cb_orderProd.Name = "cb_orderProd"
        Me.cb_orderProd.Size = New System.Drawing.Size(340, 29)
        Me.cb_orderProd.TabIndex = 16
        '
        'cb_refNum
        '
        Me.cb_refNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_refNum.FormattingEnabled = True
        Me.cb_refNum.ItemHeight = 23
        Me.cb_refNum.Location = New System.Drawing.Point(11, 179)
        Me.cb_refNum.Name = "cb_refNum"
        Me.cb_refNum.Size = New System.Drawing.Size(340, 29)
        Me.cb_refNum.TabIndex = 15
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(11, 157)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel4.TabIndex = 14
        Me.MetroLabel4.Text = "Reference Number"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(11, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel2.TabIndex = 12
        Me.MetroLabel2.Text = "Quantity"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel1.TabIndex = 11
        Me.MetroLabel1.Text = "Ordered Product"
        '
        'quantityText
        '
        Me.quantityText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quantityText.Location = New System.Drawing.Point(11, 82)
        Me.quantityText.Name = "quantityText"
        Me.quantityText.Size = New System.Drawing.Size(340, 23)
        Me.quantityText.TabIndex = 9
        '
        'add_orderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "add_orderForm"
        Me.Size = New System.Drawing.Size(365, 250)
        Me.MetroPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_deleteOrder As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_orderAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cb_refNum As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents quantityText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cb_orderProd As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents totalAmountText As MetroFramework.Controls.MetroTextBox
End Class
