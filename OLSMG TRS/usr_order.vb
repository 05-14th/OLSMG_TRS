Imports Google.Protobuf.Reflection
Imports MySql.Data.MySqlClient

Public Class usr_order
    Inherits UserControl
    Dim addOrder As New subForm()
    Dim orderForm As New add_orderForm
    Dim editOrder As New subForm()
    Dim editOrderForm As New add_orderForm

    Sub LoadOrder()
        Try
            Dim i As Integer = 0
            dgv_order.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_order", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dgv_order.Rows.Add(i, dr.Item("order_product").ToString, dr.Item("order_quantity").ToString, dr.Item("order_ref").ToString)
            End While
            dgv_order.Sort(dgv_order.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LoadOrder()
        dgv_order.Sort(dgv_order.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Public Sub LoadTableData(query1 As String)
        Try
            Dim i As Integer = 0
            dgv_order.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand(query1, cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dgv_order.Rows.Add(i, dr.Item("order_product").ToString, dr.Item("order_quantity").ToString, dr.Item("order_ref").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub btn_addOrder_Click(sender As Object, e As EventArgs) Handles btn_addOrder.Click
        addOrder.subForm_panel.Controls.Clear()
        addOrder.Size = New Size(376, 439)
        orderForm.Dock = DockStyle.Fill
        'orderForm.mode = 0
        orderForm.btn_deleteOrder.Enabled = False
        addOrder.subForm_panel.Controls.Add(orderForm)
        addOrder.ShowDialog()
    End Sub

    Private Sub search_order_Click(sender As Object, e As EventArgs) Handles search_order.Click
        If search_order.Text = "Search for order" Then
            search_order.Text = ""
        End If
    End Sub

    Private Sub search_order_Input(sender As Object, e As EventArgs) Handles search_order.TextChanged
        LoadTableData($"SELECT * FROM olsmg_order WHERE order_product LIKE '%{search_order.Text}%' OR order_ref LIKE '%{search_order.Text}%'")
    End Sub

    Private Sub dgv_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_order.CellContentClick
        If e.ColumnIndex = dgv_order.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            Dim firstCellValue As String = dgv_order.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim secondCellValue As String = dgv_order.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim thirdCellValue As String = dgv_order.Rows(e.RowIndex).Cells(3).Value.ToString()
            editOrderForm.cb_orderProd.Text = firstCellValue
            editOrderForm.quantityText.Text = secondCellValue
            Try
                cn.Open()
                cm1 = New MySqlCommand($"SELECT * FROM olsmg_product a JOIN olsmg_order b ON a.product_name = b.order_product WHERE order_product = '{firstCellValue}' AND order_quantity='{secondCellValue}' AND order_ref='{thirdCellValue}'", cn)
                dr1 = cm1.ExecuteReader
                If dr1.Read() Then
                    editOrderForm.totalAmountText.Text = Double.Parse(dr1.Item("product_price").ToString) * Integer.Parse(editOrderForm.quantityText.Text)
                End If

            Catch ex As Exception
                MsgBox("Error:" & ex.Message, vbOKOnly + vbCritical, "Insertion Error")
            Finally
                dr1.Close()
                cn.Close()
            End Try
            editOrderForm.cb_refNum.Text = thirdCellValue
            editOrderForm.mode = 1
            editOrderForm.btn_orderAdd.Visible = False
            editOrderForm.cb_orderProd.Enabled = False
            editOrderForm.cb_refNum.Enabled = False
            editOrderForm.quantityText.Enabled = False

            editOrderForm.orderProd = firstCellValue
            editOrderForm.orderQuantity = secondCellValue
            editOrderForm.orderRef = thirdCellValue
            editOrder.subForm_panel.Controls.Clear()
            editOrder.Size = New Size(400, 500)
            editOrderForm.Dock = DockStyle.Fill
            editOrder.subForm_panel.Controls.Add(editOrderForm)
            editOrder.ShowDialog()

        End If
    End Sub
End Class
