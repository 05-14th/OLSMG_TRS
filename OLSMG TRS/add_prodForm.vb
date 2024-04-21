Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class add_prodForm
    Public productName As String
    Public mode As Int16
    Public Sub New()
        InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        populateComboBox()
    End Sub

    Public Sub CloseForm()
        Dim parentForm As Form = TryCast(Me.ParentForm, Form)
        If parentForm IsNot Nothing Then
            ' Close the form
            parentForm.Close()
        End If
    End Sub
    Private Sub btn_prodAdd_Click(sender As Object, e As EventArgs) Handles btn_prodAdd.Click
        If mode = 0 Then
            AddData()
        ElseIf mode = 1 Then
            Update()
        End If
    End Sub

    Sub AddData()
        cn.Open()
        Dim supId As Integer
        Dim getSupplierIdCommand As New MySqlCommand($"SELECT store_num FROM olsmg_supplier WHERE store_name = '{prodSup.Text}'", cn)
        supId = Convert.ToInt64(getSupplierIdCommand.ExecuteScalar())

        Dim productInsertCommand As New MySqlCommand("INSERT INTO olsmg_product (`product_name`, `product_size`, `product_color`, `product_price`, `store_number`) VALUES (@pn, @ps, @pc, @pp, @st)", cn)
        productInsertCommand.Parameters.Add("@pn", MySqlDbType.VarChar).Value = prodName.Text
        productInsertCommand.Parameters.Add("@ps", MySqlDbType.VarChar).Value = prodSize.Text
        productInsertCommand.Parameters.Add("@pc", MySqlDbType.VarChar).Value = prodColor.Text
        productInsertCommand.Parameters.Add("@pp", MySqlDbType.Decimal).Value = prodPrice.Text
        productInsertCommand.Parameters.Add("@st", MySqlDbType.Int64).Value = supId

        Try
            If productInsertCommand.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Inserted")
            Else
                MessageBox.Show("Error inserting supplier data")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserProduct As New usr_inventory()
                myUserProduct.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserProduct)
                CloseForm()
            End If
        End Try


    End Sub

    Sub Update()
        dr.Close()
        Dim supId As Integer
        Dim getSupplierIdCommand As New MySqlCommand($"SELECT store_num FROM olsmg_supplier WHERE store_name = '{prodSup.Text}'", cn)
        supId = Convert.ToInt64(getSupplierIdCommand.ExecuteScalar())

        Dim query As String = "UPDATE olsmg_product SET product_size=@ps, product_color=@pc, product_price=@pr, store_number=@sn WHERE product_name=@conditionValue"
        Dim command As New MySqlCommand(query, cn)
        command.Parameters.AddWithValue("@ps", prodSize.Text)
        command.Parameters.AddWithValue("@pc", prodColor.Text)
        command.Parameters.AddWithValue("@pr", prodPrice.Text)
        command.Parameters.AddWithValue("@sn", supId)
        command.Parameters.AddWithValue("@conditionValue", productName)
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
                Dim myUserProduct As New usr_inventory()
                myUserProduct.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserProduct)
                CloseForm()
            End If
        End Try
    End Sub

    Sub populateComboBox()
        Try
            cn.Open()
            Dim query As String = "SELECT store_name FROM olsmg_supplier"
            Dim command As New MySqlCommand(query, cn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            prodSup.Items.Clear()
            While reader.Read()
                prodSup.Items.Add(reader.GetString("store_name"))
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
        Dim query As String = "DELETE FROM olsmg_product WHERE product_name=@conditionValue"
        Dim command As New MySqlCommand(query, cn)
        command.Parameters.AddWithValue("@conditionValue", productName)
        Try
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserProduct As New usr_inventory()
                myUserProduct.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserProduct)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub btn_deleteProd_Click(sender As Object, e As EventArgs) Handles btn_deleteProd.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            DeleteData()
        Else
            CloseForm()
        End If
    End Sub
End Class
