Imports System.Globalization
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class add_invoiceForm
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

        If invInsertCommand.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted")
        Else
            MessageBox.Show("Error inserting supplier data")
        End If
        cn.Close()
        main_form.mainPanel.Controls.Clear()
        Dim myUserInv As New usr_invoice()
        myUserInv.Dock = DockStyle.Fill
        main_form.mainPanel.Controls.Add(myUserInv)
        CloseForm()
    End Sub
    Sub populateCusComboBox()
        Try
            cn.Open()
            Dim query As String = "SELECT c_lname, c_fname, c_mi FROM olsmg_customer"
            Dim command As New MySqlCommand(query, cn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            invCusName.Items.Clear()
            While reader.Read()
                invCusName.Items.Add($"{reader.GetString("c_lname")} {reader.GetString("c_fname")} {reader.GetString("c_mi")}")
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
                invEmpName.Items.Add($"{reader.GetString("emp_lname")} {reader.GetString("emp_fname")} {reader.GetString("emp_mi")}")
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

End Class
