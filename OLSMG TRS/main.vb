Public Class main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_order_dgv()
    End Sub
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Dispose()
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
End Class
