Imports MySql.Data.MySqlClient

Public Class add_cusForm
    Inherits UserControl

    Public mode As Int16
    Public Fname As String
    Public Lname As String
    Public Minit As String

    Public Sub CloseForm()
        Dim parentForm As Form = TryCast(Me.ParentForm, Form)
        If parentForm IsNot Nothing Then
            ' Close the form
            parentForm.Close()
        End If
    End Sub
    Private Sub btn_cusAdd_Click(sender As Object, e As EventArgs) Handles btn_cusAdd.Click
        If mode = 0 Then
            addData()
        ElseIf mode = 1 Then
            Update()
        End If
    End Sub

    Sub addData()
        cn.Open()

        Dim cusInsertCommand As New MySqlCommand("INSERT INTO olsmg_customer (`c_lname`, `c_fname`, `c_mi`, `c_cnum`) VALUES (@cl, @cf, @cm, @cc)", cn)
        cusInsertCommand.Parameters.Add("@cl", MySqlDbType.VarChar).Value = c_lname.Text
        cusInsertCommand.Parameters.Add("@cf", MySqlDbType.VarChar).Value = c_fname.Text
        cusInsertCommand.Parameters.Add("@cm", MySqlDbType.VarChar).Value = c_mi.Text
        cusInsertCommand.Parameters.Add("@cc", MySqlDbType.VarChar).Value = c_cn.Text

        Try
            If cusInsertCommand.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Inserted")
            Else
                MessageBox.Show("Error inserting supplier data")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            cn.Close()
            main_form.mainPanel.Controls.Clear()
            Dim myUserCus As New usr_customer()
            myUserCus.Dock = DockStyle.Fill
            main_form.mainPanel.Controls.Add(myUserCus)
            CloseForm()
        End Try
    End Sub

    Sub Update()
        dr.Close()
        Dim cusId As Integer
        Dim getCusIdCommand As New MySqlCommand($"SELECT c_id FROM olsmg_customer WHERE c_lname = '{Lname}' AND c_fname = '{Fname}' AND c_mi = '{Minit}'", cn)
        cusId = Convert.ToInt64(getCusIdCommand.ExecuteScalar())

        Dim query As String = "UPDATE olsmg_customer SET c_lname=@cl, c_fname=@cf, c_mi=@cm, c_cnum=@cc WHERE c_id=@conditionValue"
        Dim command As New MySqlCommand(query, cn)
        command.Parameters.AddWithValue("@cl", c_lname.Text)
        command.Parameters.AddWithValue("@cf", c_fname.Text)
        command.Parameters.AddWithValue("@cm", c_mi.Text)
        command.Parameters.AddWithValue("@cc", c_cn.Text)
        command.Parameters.AddWithValue("@conditionValue", cusId)
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
                Dim myUserCus As New usr_customer()
                myUserCus.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserCus)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub DeleteData()
        dr.Close()
        Dim cusId As Integer
        Dim getCusIdCommand As New MySqlCommand($"SELECT c_id FROM olsmg_customer WHERE c_lname = '{Lname}' AND c_fname = '{Fname}' AND c_mi = '{Minit}'", cn)
        cusId = Convert.ToInt64(getCusIdCommand.ExecuteScalar())

        Dim query As String = "DELETE FROM olsmg_customer WHERE c_id=@conditionValue"
        Dim command As New MySqlCommand(query, cn)
        command.Parameters.AddWithValue("@conditionValue", cusId)
        Try
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserCus As New usr_customer()
                myUserCus.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserCus)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub btn_deleteCus_Click(sender As Object, e As EventArgs) Handles btn_deleteCus.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            DeleteData()
        Else
            CloseForm()
        End If

    End Sub
End Class
