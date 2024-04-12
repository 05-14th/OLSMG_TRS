<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.closeButton = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_order = New MetroFramework.Controls.MetroButton()
        Me.btn_inventory = New MetroFramework.Controls.MetroButton()
        Me.btn_invoice = New MetroFramework.Controls.MetroButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.btn_users = New System.Windows.Forms.Label()
        Me.btn_customers = New System.Windows.Forms.Label()
        Me.btn_suppliers = New System.Windows.Forms.Label()
        Me.btn_employee = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.closeButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 80)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 53)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "OLS MG TRS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'closeButton
        '
        Me.closeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeButton.AutoSize = True
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(904, 9)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(16, 15)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_employee)
        Me.Panel2.Controls.Add(Me.btn_suppliers)
        Me.Panel2.Controls.Add(Me.btn_customers)
        Me.Panel2.Controls.Add(Me.btn_users)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(932, 36)
        Me.Panel2.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btn_order
        '
        Me.btn_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_order.Location = New System.Drawing.Point(3, 6)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(230, 61)
        Me.btn_order.TabIndex = 0
        Me.btn_order.Text = "ORDER (0)"
        '
        'btn_inventory
        '
        Me.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inventory.Location = New System.Drawing.Point(3, 73)
        Me.btn_inventory.Name = "btn_inventory"
        Me.btn_inventory.Size = New System.Drawing.Size(230, 61)
        Me.btn_inventory.TabIndex = 1
        Me.btn_inventory.Text = "INVENTORY (0)"
        '
        'btn_invoice
        '
        Me.btn_invoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoice.Location = New System.Drawing.Point(3, 140)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(230, 61)
        Me.btn_invoice.TabIndex = 2
        Me.btn_invoice.Text = "INVOICE (0)"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_invoice)
        Me.Panel3.Controls.Add(Me.btn_inventory)
        Me.Panel3.Controls.Add(Me.btn_order)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(236, 423)
        Me.Panel3.TabIndex = 3
        '
        'mainPanel
        '
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(236, 116)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(696, 423)
        Me.mainPanel.TabIndex = 5
        '
        'btn_users
        '
        Me.btn_users.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_users.AutoSize = True
        Me.btn_users.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_users.Location = New System.Drawing.Point(877, 10)
        Me.btn_users.Name = "btn_users"
        Me.btn_users.Size = New System.Drawing.Size(43, 16)
        Me.btn_users.TabIndex = 0
        Me.btn_users.Text = "Users"
        '
        'btn_customers
        '
        Me.btn_customers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_customers.AutoSize = True
        Me.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customers.Location = New System.Drawing.Point(612, 10)
        Me.btn_customers.Name = "btn_customers"
        Me.btn_customers.Size = New System.Drawing.Size(71, 16)
        Me.btn_customers.TabIndex = 1
        Me.btn_customers.Text = "Customers"
        '
        'btn_suppliers
        '
        Me.btn_suppliers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_suppliers.AutoSize = True
        Me.btn_suppliers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suppliers.Location = New System.Drawing.Point(705, 10)
        Me.btn_suppliers.Name = "btn_suppliers"
        Me.btn_suppliers.Size = New System.Drawing.Size(64, 16)
        Me.btn_suppliers.TabIndex = 2
        Me.btn_suppliers.Text = "Suppliers"
        '
        'btn_employee
        '
        Me.btn_employee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_employee.AutoSize = True
        Me.btn_employee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_employee.Location = New System.Drawing.Point(785, 10)
        Me.btn_employee.Name = "btn_employee"
        Me.btn_employee.Size = New System.Drawing.Size(69, 16)
        Me.btn_employee.TabIndex = 3
        Me.btn_employee.Text = "Employee"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 539)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closeButton As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btn_order As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_inventory As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_invoice As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents mainPanel As Panel
    Friend WithEvents btn_users As Label
    Friend WithEvents btn_suppliers As Label
    Friend WithEvents btn_customers As Label
    Friend WithEvents btn_employee As Label
End Class
