<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_prodForm
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
        Me.prodSup = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.prodPrice = New MetroFramework.Controls.MetroTextBox()
        Me.prodColor = New MetroFramework.Controls.MetroTextBox()
        Me.prodSize = New MetroFramework.Controls.MetroTextBox()
        Me.prodName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btn_deleteProd = New MetroFramework.Controls.MetroButton()
        Me.btn_prodAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.prodSup)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.prodPrice)
        Me.MetroPanel2.Controls.Add(Me.prodColor)
        Me.MetroPanel2.Controls.Add(Me.prodSize)
        Me.MetroPanel2.Controls.Add(Me.prodName)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(459, 382)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'prodSup
        '
        Me.prodSup.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prodSup.FormattingEnabled = True
        Me.prodSup.ItemHeight = 23
        Me.prodSup.Location = New System.Drawing.Point(17, 234)
        Me.prodSup.Name = "prodSup"
        Me.prodSup.Size = New System.Drawing.Size(425, 29)
        Me.prodSup.TabIndex = 13
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 212)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Supplier"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(17, 166)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Price"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 120)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Color"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 73)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Size"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 25)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Product Name"
        '
        'prodPrice
        '
        Me.prodPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prodPrice.Location = New System.Drawing.Point(17, 186)
        Me.prodPrice.MaxLength = 11
        Me.prodPrice.Name = "prodPrice"
        Me.prodPrice.Size = New System.Drawing.Size(425, 23)
        Me.prodPrice.TabIndex = 6
        '
        'prodColor
        '
        Me.prodColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prodColor.Location = New System.Drawing.Point(17, 140)
        Me.prodColor.MaxLength = 255
        Me.prodColor.Name = "prodColor"
        Me.prodColor.Size = New System.Drawing.Size(425, 23)
        Me.prodColor.TabIndex = 4
        '
        'prodSize
        '
        Me.prodSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prodSize.Location = New System.Drawing.Point(17, 94)
        Me.prodSize.MaxLength = 255
        Me.prodSize.Name = "prodSize"
        Me.prodSize.Size = New System.Drawing.Size(425, 23)
        Me.prodSize.TabIndex = 3
        '
        'prodName
        '
        Me.prodName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prodName.Location = New System.Drawing.Point(17, 47)
        Me.prodName.MaxLength = 255
        Me.prodName.Name = "prodName"
        Me.prodName.Size = New System.Drawing.Size(425, 23)
        Me.prodName.TabIndex = 2
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btn_deleteProd)
        Me.MetroPanel1.Controls.Add(Me.btn_prodAdd)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 382)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(459, 34)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btn_deleteProd
        '
        Me.btn_deleteProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deleteProd.Location = New System.Drawing.Point(353, 6)
        Me.btn_deleteProd.Name = "btn_deleteProd"
        Me.btn_deleteProd.Size = New System.Drawing.Size(100, 23)
        Me.btn_deleteProd.TabIndex = 3
        Me.btn_deleteProd.Text = "DELETE"
        '
        'btn_prodAdd
        '
        Me.btn_prodAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prodAdd.Location = New System.Drawing.Point(247, 6)
        Me.btn_prodAdd.Name = "btn_prodAdd"
        Me.btn_prodAdd.Size = New System.Drawing.Size(100, 23)
        Me.btn_prodAdd.TabIndex = 2
        Me.btn_prodAdd.Text = "CONFIRM"
        '
        'add_prodForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "add_prodForm"
        Me.Size = New System.Drawing.Size(459, 416)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents prodPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents prodColor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents prodSize As MetroFramework.Controls.MetroTextBox
    Friend WithEvents prodName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btn_deleteProd As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_prodAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents prodSup As MetroFramework.Controls.MetroComboBox
End Class
