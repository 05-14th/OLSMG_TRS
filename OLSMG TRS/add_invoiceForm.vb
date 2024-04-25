Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.Collections
Imports Google.Protobuf.WellKnownTypes
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Mysqlx.Notice

Public Class add_invoiceForm
    Public mode As Int32
    Public productName As String
    Public cusName As String
    Public totalAmount As Decimal
    Dim delimiter_ As Char = ","c
    Dim _lname As String
    Dim _fname As String
    Dim _mi As String

    Private Sub sliceText(inputString As String, delimiter As Char)
        Dim result() As String = inputString.Split(delimiter)
        For i As Integer = 0 To result.Length - 1
            result(i) = result(i).Trim()
        Next

        _lname = result(0)
        _fname = result(1)
        _mi = result(2)
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        populateCusComboBox()
        populateEmpComboBox()
        populateProdComboBox()
    End Sub
    Public Sub CloseForm()
        Dim parentForm As Form = TryCast(Me.ParentForm, Form)
        If parentForm IsNot Nothing Then
            ' Close the form
            parentForm.Close()
        End If
    End Sub

    Private Sub btn_invAdd_Click(sender As Object, e As EventArgs) Handles btn_invAdd.Click
        If mode = 0 Then
            addData()
        ElseIf mode = 1 Then
            Update()
        End If
    End Sub

    Sub addData()
        cn.Open()
        Dim selectedDate As DateTime = invDate.Value
        Dim reformatted As String = selectedDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture)

        Dim invInsertCommand As New MySqlCommand("INSERT INTO olsmg_invoice  (`date_issue`, `total_amount`, `cus_name`, `employee_name`, `reference_num`) VALUES (@di, @ta, @cn, @en, @rn)", cn)
        invInsertCommand.Parameters.Add("@di", MySqlDbType.VarChar).Value = reformatted
        invInsertCommand.Parameters.Add("@ta", MySqlDbType.VarChar).Value = invTotalAmount.Text
        invInsertCommand.Parameters.Add("@cn", MySqlDbType.VarChar).Value = invCusName.Text
        invInsertCommand.Parameters.Add("@en", MySqlDbType.VarChar).Value = invEmpName.Text
        invInsertCommand.Parameters.Add("@rn", MySqlDbType.VarChar).Value = invRefNum.Text

        Try
            If invInsertCommand.ExecuteNonQuery() = 1 Then
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim orderInsertCommand As New MySqlCommand("INSERT INTO olsmg_order  (`order_product`, `order_quantity`, `order_ref`) VALUES (@op, @oq, @or)", cn)
                        orderInsertCommand.Parameters.AddWithValue("op", row.Cells(1).Value)
                        orderInsertCommand.Parameters.AddWithValue("oq", row.Cells(2).Value)
                        orderInsertCommand.Parameters.AddWithValue("or", invRefNum.Text)
                        orderInsertCommand.ExecuteNonQuery()
                    End If
                Next
                MsgBox("Data Added Successfully", vbOKOnly + vbInformation, "Data Insertion")
            Else
                MsgBox("Error inserting supplier data", vbOKOnly + vbCritical, "Insertion Error")
            End If
        Catch ex As Exception
            MsgBox("Error adding data: " & ex.Message, vbOKOnly + vbCritical, "Insertion Error")
        Finally
            cn.Close()
            main_form.mainPanel.Controls.Clear()
            Dim myUserInv As New usr_invoice()
            myUserInv.Dock = DockStyle.Fill
            main_form.mainPanel.Controls.Add(myUserInv)
            CloseForm()
        End Try
    End Sub

    Sub Update()
        dr.Close()
        Dim invId As Integer
        Dim getCusIdCommand As New MySqlCommand($"SELECT invoice_id FROM olsmg_invoice WHERE cus_name = '{cusName}' AND product_name_ref = '{productName}' AND total_amount = '{totalAmount}'", cn)
        invId = Convert.ToInt64(getCusIdCommand.ExecuteScalar())

        Dim query As String = "UPDATE olsmg_invoice SET total_amount=@ta, cus_name=@cn, employee_name=@en, product_name_ref=@pnr, reference_num=@rn WHERE invoice_id=@conditionValue"
        Dim command As New MySqlCommand(query, cn)
        command.Parameters.AddWithValue("@ta", invTotalAmount.Text)
        command.Parameters.AddWithValue("@cn", invCusName.Text)
        command.Parameters.AddWithValue("@en", invEmpName.Text)
        command.Parameters.AddWithValue("@rn", invRefNum.Text)
        command.Parameters.AddWithValue("@conditionValue", invId)
        Try
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            If rowsAffected = 1 Then
                MessageBox.Show("Data updated successfully")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserInv As New usr_invoice()
                myUserInv.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserInv)
                CloseForm()
            End If
        End Try
    End Sub

    Sub populateCusComboBox()
        Try
            cn.Open()
            Dim query As String = "SELECT c_lname, c_fname, c_mi FROM olsmg_customer"
            Dim command As New MySqlCommand(query, cn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            invCusName.Items.Clear()
            While reader.Read()
                invCusName.Items.Add($"{reader.GetString("c_lname")}, {reader.GetString("c_fname")}, {reader.GetString("c_mi")}")
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Sub populateEmpComboBox()
        Try
            cn.Open()
            Dim query As String = "SELECT emp_lname, emp_fname, emp_mi FROM olsmg_employee"
            Dim command As New MySqlCommand(query, cn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            invEmpName.Items.Clear()
            While reader.Read()
                invEmpName.Items.Add($"{reader.GetString("emp_lname")}, {reader.GetString("emp_fname")}, {reader.GetString("emp_mi")}")
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Sub populateProdComboBox()
        Try
            cn.Open()
            Dim query As String = "SELECT product_name FROM olsmg_product"
            Dim command As New MySqlCommand(query, cn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            cb_product.Items.Clear()
            While reader.Read()
                cb_product.Items.Add(reader.GetString("product_name"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub DeleteData()
        dr.Close()
        Dim invId As Integer
        Dim getInvIdCommand As New MySqlCommand($"SELECT invoice_id FROM olsmg_invoice WHERE total_amount = '{totalAmount}' AND cus_name = '{cusName}' AND product_name_ref = '{productName}'", cn)
        invId = Convert.ToInt64(getInvIdCommand.ExecuteScalar())

        Dim query As String = "DELETE FROM olsmg_invoice WHERE invoice_id=@conditionValue"
        Dim command As New MySqlCommand(query, cn)
        command.Parameters.AddWithValue("@conditionValue", invId)
        Try
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserInv As New usr_invoice()
                myUserInv.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserInv)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub btn_deleteInv_Click(sender As Object, e As EventArgs) Handles btn_deleteInv.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            DeleteData()
        Else
            CloseForm()
        End If
    End Sub

    Dim sum As Integer = 0
    Private price As Integer = 0

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_product.SelectedIndexChanged
        Try
            cn.Open()
            Dim selectedItem As String = cb_product.SelectedItem.ToString()
            Dim query As String = $"SELECT product_price FROM olsmg_product WHERE product_name = '{selectedItem}'"
            Dim command As New MySqlCommand(query, cn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim exists As Boolean
            If reader.HasRows Then
                While reader.Read()
                    Dim productPrice As Double = reader.GetDouble("product_price")
                    price = productPrice
                    sum = 0
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, selectedItem, 1, productPrice.ToString("0.00"))
                    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                        sum = sum + CInt(DataGridView1.Rows(i).Cells(3).Value)
                    Next
                    invTotalAmount.Text = sum.ToString("0.00")
                End While
            Else
                MessageBox.Show("No rows found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

        Dim sum As Double = 0
        If e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then
            Dim cellValue As Integer
            Try
                If Integer.TryParse(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString(), cellValue) Then
                    Dim result As Integer = cellValue * price
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = result.ToString("0.00")
                    fixCount()
                Else
                    MsgBox("Please enter a valid number value.", vbOKOnly + vbExclamation, "Value Error")
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 1

                End If
            Catch ex As System.NullReferenceException
                MsgBox("Quantity cannot be empty", vbOKOnly + vbExclamation, "Value Error")
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 1
            End Try
        End If

    End Sub

    Private Sub btn_clearProd_Click(sender As Object, e As EventArgs) Handles btn_clearProd.Click
        DataGridView1.Rows.Clear()
        invTotalAmount.Clear()
    End Sub

    Private Sub btn_removeOrder_Click(sender As Object, e As EventArgs) Handles btn_removeOrder.Click
        For Each item As DataGridViewRow In DataGridView1.SelectedRows
            If Not item.IsNewRow Then
                DataGridView1.Rows.RemoveAt(item.Index)
            End If
        Next

        fixCount()
    End Sub

    Private Sub fixCount()
        sum = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim cellValue1 As Double
            If Double.TryParse(row.Cells(3).Value.ToString(), cellValue1) Then
                sum += cellValue1
            End If
            invTotalAmount.Clear()
            invTotalAmount.Text = sum.ToString("0.00")
        Next
    End Sub


    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        For i As Integer = e.RowIndex To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(0).Value = i + 1
        Next
        If DataGridView1.RowCount = 0 Then
            invTotalAmount.Clear()
        End If
    End Sub

End Class
