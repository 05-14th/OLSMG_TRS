Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Notice
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class add_supForm
    Dim locId As String
    Public mode As Int16
    Public store_name As String
    Public store_platform As String
    Public Sub CloseForm()
        Dim parentForm As Form = TryCast(Me.ParentForm, Form)
        If parentForm IsNot Nothing Then
            ' Close the form
            parentForm.Close()
        End If
    End Sub

    Private Sub btn_supAdd_Click(sender As Object, e As EventArgs) Handles btn_supAdd.Click
        If mode = 0 Then
            AddData()
        ElseIf mode = 1 Then
            Update()
        End If
    End Sub

    Sub AddData()
        Try

            cn.Open()

            Dim addressInsertCommand As New MySqlCommand("INSERT INTO olsmg_address (`street`, `barangay`, `municipality`, `province`, `zip_code`) VALUES (@strt, @brgy, @muni, @prov, @zip)", cn)
            addressInsertCommand.Parameters.Add("@strt", MySqlDbType.VarChar).Value = storeStreet.Text
            addressInsertCommand.Parameters.Add("@brgy", MySqlDbType.VarChar).Value = storeBrgy.Text
            addressInsertCommand.Parameters.Add("@muni", MySqlDbType.VarChar).Value = storeMuni.Text
            addressInsertCommand.Parameters.Add("@prov", MySqlDbType.VarChar).Value = storeProv.Text
            addressInsertCommand.Parameters.Add("@zip", MySqlDbType.Int64).Value = storeZip.Text

            If addressInsertCommand.ExecuteNonQuery() = 1 Then
                Dim addressId As Integer
                Dim getAddressIdCommand As New MySqlCommand("SELECT LAST_INSERT_ID()", cn)
                addressId = Convert.ToInt32(getAddressIdCommand.ExecuteScalar())

                Dim supplierInsertCommand As New MySqlCommand("INSERT INTO olsmg_supplier (`store_name`, `store_address_ref`, `platform`) VALUES (@sn, @sar, @plat)", cn)
                supplierInsertCommand.Parameters.Add("@sn", MySqlDbType.VarChar).Value = storeName.Text
                supplierInsertCommand.Parameters.Add("@sar", MySqlDbType.Int64).Value = addressId
                supplierInsertCommand.Parameters.Add("@plat", MySqlDbType.VarChar).Value = storePlat.Text

                If supplierInsertCommand.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Data Inserted")
                Else
                    MessageBox.Show("Error inserting supplier data")
                End If
            Else
                MessageBox.Show("Error inserting address data")
            End If
            cn.Close()
            main_form.mainPanel.Controls.Clear()
            Dim myUserSupplier As New usr_suppliers()
            myUserSupplier.Dock = DockStyle.Fill
            main_form.mainPanel.Controls.Add(myUserSupplier)
            CloseForm()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Sub Update()
        dr.Close()
        Try
            Dim addNum As Integer
            Dim getAddressIdCommand As New MySqlCommand($"SELECT address_num FROM olsmg_supplier a JOIN olsmg_address b ON a.store_address_ref = b.address_num WHERE a.store_name = '{store_name}' AND a.platform = '{store_platform}'", cn)
            addNum = Convert.ToInt64(getAddressIdCommand.ExecuteScalar())

            Dim query As String = "UPDATE olsmg_address a JOIN olsmg_supplier b ON a.address_num = b.store_address_ref SET street=@st, municipality=@mn, barangay=@br, province=@pr, zip_code=@zc WHERE address_num=@conditionValue"
            Dim updateAddressCommand As New MySqlCommand(query, cn)
            updateAddressCommand.Parameters.AddWithValue("@st", storeStreet.Text)
            updateAddressCommand.Parameters.AddWithValue("@mn", storeMuni.Text)
            updateAddressCommand.Parameters.AddWithValue("@br", storeBrgy.Text)
            updateAddressCommand.Parameters.AddWithValue("@pr", storeProv.Text)
            updateAddressCommand.Parameters.AddWithValue("@zc", storeZip.Text)
            updateAddressCommand.Parameters.AddWithValue("@conditionValue", addNum)
            Dim rowsAffected As Integer = updateAddressCommand.ExecuteNonQuery()
            If rowsAffected = 1 Then
                Dim supId As Integer
                Dim getSupplierIdCommand As New MySqlCommand($"SELECT store_num FROM olsmg_supplier a JOIN olsmg_address b ON a.store_address_ref = b.address_num WHERE a.store_name = '{store_name}' AND a.platform = '{store_platform}'", cn)
                supId = Convert.ToInt64(getSupplierIdCommand.ExecuteScalar())

                Dim _query As String = "UPDATE olsmg_supplier SET store_name=@sn, platform=@pf WHERE store_num=@conditionValue"
                Dim updateSupplierCommand As New MySqlCommand(_query, cn)
                updateSupplierCommand.Parameters.AddWithValue("@sn", storeName.Text)
                updateSupplierCommand.Parameters.AddWithValue("@pf", storePlat.Text)
                updateSupplierCommand.Parameters.AddWithValue("@conditionValue", supId)
                Dim _rowsAffected As Integer = updateSupplierCommand.ExecuteNonQuery()

                If updateSupplierCommand.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Data updated successfully")
                Else
                    MessageBox.Show("Error inserting supplier data")
                End If
            Else
                MessageBox.Show("Error updating address data")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserSupplier As New usr_suppliers()
                myUserSupplier.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserSupplier)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub DeleteData()
        dr.Close()
        Try
            Dim supId As Integer
            Dim getSupIdCommand As New MySqlCommand($"SELECT store_num FROM olsmg_supplier WHERE store_name = '{store_name}' AND platform = '{store_platform}'", cn)
            supId = Convert.ToInt64(getSupIdCommand.ExecuteScalar())
            Dim addrNum As Integer
            Dim getAddrNumCommand As New MySqlCommand($"SELECT address_num FROM olsmg_supplier a JOIN olsmg_address b ON a.store_address_ref = b.address_num WHERE a.store_name = '{store_name}' AND a.platform = '{store_platform}'", cn)
            addrNum = Convert.ToInt64(getAddrNumCommand.ExecuteScalar())
            Dim _query As String = "DELETE FROM olsmg_supplier WHERE store_num=@conditionValue1"
            Dim _command As New MySqlCommand(_query, cn)
            _command.Parameters.AddWithValue("@conditionValue1", supId)
            If _command.ExecuteNonQuery() = 1 Then
                Dim query As String = "DELETE FROM olsmg_address WHERE address_num=@conditionValue"
                Dim command As New MySqlCommand(query, cn)
                command.Parameters.AddWithValue("@conditionValue", addrNum)
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Data deleted successfully.")
                Else
                    MessageBox.Show("Error deleting data")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserSup As New usr_suppliers()
                myUserSup.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserSup)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub btn_deleteSup_Click(sender As Object, e As EventArgs) Handles btn_deleteSup.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            DeleteData()
        Else
            CloseForm()
        End If
    End Sub
End Class
