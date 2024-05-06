<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usr_cusViewForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr_cusViewForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout = New MetroFramework.Controls.MetroButton()
        Me.lbl_user_account = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cb_cusRefNum = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.l = New MetroFramework.Controls.MetroLabel()
        Me.txt_total_amount = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txt_emp_name = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_cus_name = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_date_issue = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.lbl_user_account)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cb_cusRefNum)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 455)
        Me.Panel1.TabIndex = 0
        '
        'btn_logout
        '
        Me.btn_logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_logout.Location = New System.Drawing.Point(3, 408)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(191, 44)
        Me.btn_logout.TabIndex = 5
        Me.btn_logout.Text = "Logout"
        '
        'lbl_user_account
        '
        Me.lbl_user_account.AutoSize = True
        Me.lbl_user_account.Location = New System.Drawing.Point(3, 146)
        Me.lbl_user_account.Name = "lbl_user_account"
        Me.lbl_user_account.Size = New System.Drawing.Size(39, 13)
        Me.lbl_user_account.TabIndex = 3
        Me.lbl_user_account.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'cb_cusRefNum
        '
        Me.cb_cusRefNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_cusRefNum.FormattingEnabled = True
        Me.cb_cusRefNum.ItemHeight = 23
        Me.cb_cusRefNum.Location = New System.Drawing.Point(3, 211)
        Me.cb_cusRefNum.Name = "cb_cusRefNum"
        Me.cb_cusRefNum.Size = New System.Drawing.Size(191, 29)
        Me.cb_cusRefNum.TabIndex = 1
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 189)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Reference Number"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(612, 455)
        Me.Panel2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product, Me.quantity, Me.unitPrice})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(200, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(412, 455)
        Me.DataGridView1.TabIndex = 2
        '
        'product
        '
        Me.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product.HeaderText = "Product"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 71
        '
        'unitPrice
        '
        Me.unitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.unitPrice.HeaderText = "Unit Price"
        Me.unitPrice.Name = "unitPrice"
        Me.unitPrice.ReadOnly = True
        Me.unitPrice.Width = 78
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.l)
        Me.Panel4.Controls.Add(Me.txt_total_amount)
        Me.Panel4.Controls.Add(Me.MetroLabel5)
        Me.Panel4.Controls.Add(Me.txt_emp_name)
        Me.Panel4.Controls.Add(Me.MetroLabel3)
        Me.Panel4.Controls.Add(Me.txt_cus_name)
        Me.Panel4.Controls.Add(Me.MetroLabel2)
        Me.Panel4.Controls.Add(Me.txt_date_issue)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 455)
        Me.Panel4.TabIndex = 1
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(3, 145)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(87, 19)
        Me.l.TabIndex = 7
        Me.l.Text = "Total Amount"
        '
        'txt_total_amount
        '
        Me.txt_total_amount.Location = New System.Drawing.Point(3, 166)
        Me.txt_total_amount.Name = "txt_total_amount"
        Me.txt_total_amount.ReadOnly = True
        Me.txt_total_amount.Size = New System.Drawing.Size(194, 23)
        Me.txt_total_amount.TabIndex = 6
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 96)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Issued by:"
        '
        'txt_emp_name
        '
        Me.txt_emp_name.Location = New System.Drawing.Point(3, 117)
        Me.txt_emp_name.Name = "txt_emp_name"
        Me.txt_emp_name.ReadOnly = True
        Me.txt_emp_name.Size = New System.Drawing.Size(194, 23)
        Me.txt_emp_name.TabIndex = 4
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 50)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Customer Name"
        '
        'txt_cus_name
        '
        Me.txt_cus_name.Location = New System.Drawing.Point(3, 70)
        Me.txt_cus_name.Name = "txt_cus_name"
        Me.txt_cus_name.ReadOnly = True
        Me.txt_cus_name.Size = New System.Drawing.Size(194, 23)
        Me.txt_cus_name.TabIndex = 2
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 3)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Date Issue"
        '
        'txt_date_issue
        '
        Me.txt_date_issue.Location = New System.Drawing.Point(3, 24)
        Me.txt_date_issue.Name = "txt_date_issue"
        Me.txt_date_issue.ReadOnly = True
        Me.txt_date_issue.Size = New System.Drawing.Size(194, 23)
        Me.txt_date_issue.TabIndex = 0
        '
        'usr_cusViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "usr_cusViewForm"
        Me.Size = New System.Drawing.Size(812, 455)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cb_cusRefNum As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_user_account As Label
    Friend WithEvents btn_logout As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents l As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_total_amount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_emp_name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_cus_name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_date_issue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents unitPrice As DataGridViewTextBoxColumn
End Class
