Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class main_form
    Dim invoiceCount As Integer
    Dim inventoryCount As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectToDB()
        load_order_dgv()


    End Sub
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Dim intResponse As Integer
        intResponse = MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion, "Exiting Application")
        If intResponse = vbYes Then
            Me.Dispose()
            login_form.Dispose()
        End If
    End Sub

    Public Sub countData()
        Dim invQuery As String
        Dim inventoryQuery As String
        Try
            cn.Open()
            invQuery = "SELECT COUNT(*) FROM olsmg_invoice"
            inventoryQuery = "SELECT COUNT(*) FROM olsmg_product"
            Dim command As New MySqlCommand(invQuery, cn)
            Dim inventoryCom As New MySqlCommand(inventoryQuery, cn)
            Dim rowCount As Integer = Convert.ToInt32(command.ExecuteScalar())
            Dim _rowCount As Integer = Convert.ToInt32(inventoryCom.ExecuteScalar())
            invoiceCount = rowCount
            inventoryCount = _rowCount
            btn_inventory.Text = $"INVENTORY ({inventoryCount})"
            btn_invoice.Text = $"INVOICE ({invoiceCount})"
        Catch ex As Exception
            MsgBox($"Unable to count data from database. {ex.Message}", vbOKOnly + vbCritical, "Connection Error")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub load_order_dgv()
        mainPanel.Controls.Clear()
        Dim myUserOrder As New usr_order()
        myUserOrder.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserOrder)
    End Sub

    Private Sub load_inventory_dgv()
        mainPanel.Controls.Clear()
        Dim myUserInventory As New usr_inventory()
        myUserInventory.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserInventory)
    End Sub

    Private Sub load_invoice_dgv()
        mainPanel.Controls.Clear()
        Dim myUserInvoice As New usr_invoice()
        myUserInvoice.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserInvoice)
    End Sub

    Private Sub load_customer_dgv()
        mainPanel.Controls.Clear()
        Dim myUserCus As New usr_customer()
        myUserCus.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserCus)
    End Sub

    Private Sub load_employee_dgv()
        mainPanel.Controls.Clear()
        Dim myUserEmp As New usr_employee()
        myUserEmp.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserEmp)
    End Sub
    Private Sub load_supplier_dgv()
        mainPanel.Controls.Clear()
        Dim myUserSupplier As New usr_suppliers()
        myUserSupplier.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUserSupplier)
    End Sub

    Private Sub load_users_dgv()
        mainPanel.Controls.Clear()
        Dim myUser As New usr_users()
        myUser.Dock = DockStyle.Fill
        mainPanel.Controls.Add(myUser)
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        load_order_dgv()
    End Sub

    Private Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        load_inventory_dgv()
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        load_invoice_dgv()
    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        load_customer_dgv()
    End Sub

    Private Sub btn_employee_Click(sender As Object, e As EventArgs) Handles btn_employee.Click
        load_employee_dgv()
    End Sub

    Private Sub btn_suppliers_Click(sender As Object, e As EventArgs) Handles btn_suppliers.Click
        load_supplier_dgv()
    End Sub

    Private Sub btn_users_Click(sender As Object, e As EventArgs) Handles btn_users.Click
        load_users_dgv()
    End Sub

    Public Sub LoginAsEmployee()
        btn_users.Enabled = False
        btn_employee.Enabled = False
        btn_suppliers.Enabled = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
