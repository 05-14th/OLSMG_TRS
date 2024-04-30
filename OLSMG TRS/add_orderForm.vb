Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Mysqlx.Notice
Imports Org.BouncyCastle.Crypto.Engines.SM2Engine

Public Class add_orderForm
    Inherits UserControl
    Public mode As Integer
    Public orderProd As String
    Public orderQuantity As Integer
    Public orderRef As String

    Public Sub New()
        InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        populateRefComboBox()
        populateProdComboBox()
    End Sub

    Sub populateProdComboBox()
        Try
            cn.Open()
            Dim query As String = "SELECT product_name FROM olsmg_product"
            Dim command As New MySqlCommand(query, cn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            cb_orderProd.Items.Clear()
            While reader.Read()
                cb_orderProd.Items.Add(reader.GetString("product_name"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Sub populateRefComboBox()
        Try
            cn.Open()
            Dim query As String = "SELECT reference_num FROM olsmg_invoice"
            Dim command As New MySqlCommand(query, cn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            cb_refNum.Items.Clear()
            While reader.Read()
                cb_refNum.Items.Add(reader.GetString("reference_num"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btn_orderAdd_Click(sender As Object, e As EventArgs) Handles btn_orderAdd.Click
        addData()
    End Sub

    Sub addData()
        cn.Open()
        'Dim ref As String =
        Dim orderInsertCommand As New MySqlCommand("INSERT INTO olsmg_order (`order_product`, `order_quantity`, `order_ref`) VALUES (@op, @oq, @or)", cn)
        orderInsertCommand.Parameters.Add("@op", MySqlDbType.VarChar).Value = cb_orderProd.Text
        orderInsertCommand.Parameters.Add("@oq", MySqlDbType.VarChar).Value = quantityText.Text
        orderInsertCommand.Parameters.Add("@or", MySqlDbType.VarChar).Value = cb_refNum.Text

        Try
            If orderInsertCommand.ExecuteNonQuery() = 1 Then
                UpdateAmount("Add")
                Dim selectProdCommand As New MySqlCommand("SELECT product_stocks FROM olsmg_product WHERE product_name=@prodName", cn)
                selectProdCommand.Parameters.AddWithValue("@prodName", cb_orderProd.Text)
                Dim productStock As Integer = 0
                Dim result As Object = selectProdCommand.ExecuteScalar()
                productStock = Convert.ToInt32(result)
                Dim stocksUpdateCommand As New MySqlCommand("UPDATE olsmg_product SET product_stocks=@ps WHERE product_name=@pn", cn)
                stocksUpdateCommand.Parameters.AddWithValue("@ps", productStock - CInt(quantityText.Text))
                stocksUpdateCommand.Parameters.AddWithValue("@pn", cb_orderProd.Text)
                stocksUpdateCommand.ExecuteNonQuery()
                MsgBox("Data Inserted Successfully", vbOKOnly + vbInformation, "Success")
            Else
                MsgBox("Error inserting supplier data", vbOKOnly + vbCritical, "Insertion Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            cn.Close()
            main_form.mainPanel.Controls.Clear()
            Dim myUserOrder As New usr_order()
            myUserOrder.Dock = DockStyle.Fill
            main_form.mainPanel.Controls.Add(myUserOrder)
            CloseForm()
        End Try
    End Sub


    Public Sub CloseForm()
        Dim parentForm As Form = TryCast(Me.ParentForm, Form)
        If parentForm IsNot Nothing Then
            ' Close the form
            parentForm.Close()
        End If
    End Sub

    Private Sub DeleteData()
        dr.Close()
        cn.Open()
        Dim query As String = "DELETE FROM olsmg_order WHERE order_product=@conditionValueA AND order_quantity=@conditionValueB AND order_ref=@conditionValueC"
        Dim command As New MySqlCommand(query, cn)
        UpdateAmount("Delete")
        command.Parameters.AddWithValue("@conditionValueA", orderProd)
        command.Parameters.AddWithValue("@conditionValueB", orderQuantity)
        command.Parameters.AddWithValue("@conditionValueC", orderRef)
        Try
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Data deleted successfully.", vbOKOnly + vbInformation, "Success")
            Else
                MsgBox("Error deleting order data", vbOKOnly + vbCritical, "Deletion Error")
            End If
        Catch ex As Exception
            MsgBox("Error deleting data: " & ex.Message, vbOKOnly + vbCritical, "Deletion Error")
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserOrder As New usr_order()
                myUserOrder.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserOrder)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub UpdateAmount(updateMode As String)
        dr.Close()
        Dim orderId As Integer
        Dim getCusIdCommand As New MySqlCommand($"SELECT invoice_id FROM olsmg_invoice a JOIN olsmg_order b ON a.reference_num = b.order_ref WHERE reference_num = '{cb_refNum.Text}'", cn)
        orderId = Convert.ToInt64(getCusIdCommand.ExecuteScalar())

        Dim currentAmount As Double
        Dim newAmount As Double
        Dim getAmountCommand As New MySqlCommand($"SELECT total_amount FROM olsmg_invoice a JOIN olsmg_order b ON a.reference_num = b.order_ref WHERE reference_num = '{cb_refNum.Text}'", cn)
        currentAmount = Convert.ToDouble(getAmountCommand.ExecuteScalar())
        Console.WriteLine(cb_refNum.Text)
        Console.WriteLine(currentAmount)
        If updateMode = "Add" Then
            newAmount = currentAmount + Double.Parse(totalAmountText.Text)
        ElseIf updateMode = "Delete" Then
            newAmount = currentAmount - Double.Parse(totalAmountText.Text)
        End If

        Dim upQuery As String = "UPDATE olsmg_invoice SET total_amount=@ta WHERE invoice_id=@conditionValue"
        Dim command As New MySqlCommand(upQuery, cn)
        command.Parameters.AddWithValue("@ta", newAmount)
        command.Parameters.AddWithValue("@conditionValue", orderId)
        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error updating data: " & ex.Message, vbOKOnly + vbCritical, "Update Error")
        End Try
    End Sub

    Private Sub btn_deleteOrder_Click(sender As Object, e As EventArgs) Handles btn_deleteOrder.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            DeleteData()
        Else
            CloseForm()
        End If
    End Sub

    Private Sub quantityText_Click(sender As Object, e As EventArgs) Handles quantityText.TextChanged
        updateEntries()
    End Sub

    Sub updateEntries()
        Try
            cn.Open()
            Dim productPrice As Integer
            Dim totalResult As Integer
            Dim getPriceCommand As New MySqlCommand($"SELECT product_price FROM olsmg_product WHERE product_name = '{cb_orderProd.Text}'", cn)
            productPrice = Convert.ToInt64(getPriceCommand.ExecuteScalar())
            totalResult = productPrice * Integer.Parse(quantityText.Text)
            totalAmountText.Text = totalResult.ToString
        Catch ex As Exception
            Dim numericValue As Integer
            If Not Integer.TryParse(quantityText.Text, numericValue) Then
                totalAmountText.Text = 0
            End If
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub cb_orderProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_orderProd.SelectedIndexChanged
        quantityText.Text = ""
        totalAmountText.Text = ""
    End Sub
End Class
