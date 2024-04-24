Imports System.Globalization
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

        Dim invInsertCommand As New MySqlCommand("INSERT INTO olsmg_invoice  (`date_issue`, `total_amount`, `cus_name`, `employee_name`, `product_name_ref`, `reference_num`) VALUES (@di, @ta, @cn, @en, @pnr, @rn)", cn)
        invInsertCommand.Parameters.Add("@di", MySqlDbType.VarChar).Value = reformatted
        invInsertCommand.Parameters.Add("@ta", MySqlDbType.VarChar).Value = invTotalAmount.Text
        invInsertCommand.Parameters.Add("@cn", MySqlDbType.VarChar).Value = invCusName.Text
        invInsertCommand.Parameters.Add("@en", MySqlDbType.VarChar).Value = invEmpName.Text
        invInsertCommand.Parameters.Add("@pnr", MySqlDbType.VarChar).Value = invProdName.Text
        invInsertCommand.Parameters.Add("@rn", MySqlDbType.VarChar).Value = invRefNum.Text

        Try
            If invInsertCommand.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Inserted")
            Else
                MessageBox.Show("Error inserting supplier data")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
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
        command.Parameters.AddWithValue("@pnr", invProdName.Text)
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
            invProdName.Items.Clear()
            While reader.Read()
                invProdName.Items.Add(reader.GetString("product_name"))
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
End Class
