Imports MySql.Data.MySqlClient

Public Class usr_order
    Inherits UserControl

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
    End Sub
    Private Sub dgv_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub btn_addOrder_Click(sender As Object, e As EventArgs) Handles btn_addOrder.Click

    End Sub

    Private Sub search_order_Click(sender As Object, e As EventArgs) Handles search_order.Click

    End Sub
End Class
