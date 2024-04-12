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

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        load_order_dgv()
    End Sub

    Private Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        load_inventory_dgv()
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        load_invoice_dgv()
    End Sub
End Class
