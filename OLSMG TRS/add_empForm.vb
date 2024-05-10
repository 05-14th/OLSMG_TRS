Imports MySql.Data.MySqlClient

Public Class add_empForm
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
    Private Sub btn_empAdd_Click(sender As Object, e As EventArgs) Handles btn_empAdd.Click
        If mode = 0 Then
            Add()
        ElseIf mode = 1 Then
            Update()
        End If
    End Sub

    Sub Add()
        cn.Open()

        Dim empInsertCommand As New MySqlCommand("INSERT INTO olsmg_employee (`emp_lname`, `emp_fname`, `emp_mi`, `emp_cnum`, `emp_position`) VALUES (@el, @ef, @em, @ec, @ep)", cn)
        empInsertCommand.Parameters.Add("@el", MySqlDbType.VarChar).Value = empLname.Text
        empInsertCommand.Parameters.Add("@ef", MySqlDbType.VarChar).Value = empFname.Text
        empInsertCommand.Parameters.Add("@em", MySqlDbType.VarChar).Value = empMI.Text
        empInsertCommand.Parameters.Add("@ec", MySqlDbType.VarChar).Value = empCN.Text
        empInsertCommand.Parameters.Add("@ep", MySqlDbType.VarChar).Value = empPos.Text

        If empInsertCommand.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Inserted")
        Else
            MessageBox.Show("Error inserting supplier data")
        End If
        cn.Close()
        main_form.mainPanel.Controls.Clear()
        Dim myUserEmp As New usr_employee()
        myUserEmp.Dock = DockStyle.Fill
        main_form.mainPanel.Controls.Add(myUserEmp)
        CloseForm()
    End Sub

    Sub Update()
        dr.Close()
        Dim empId As Integer
        Dim getEmpIdCommand As New MySqlCommand($"SELECT emp_id FROM olsmg_employee WHERE emp_lname = '{Lname}' AND emp_fname = '{Fname}' AND emp_mi = '{Minit}'", cn)
        empId = Convert.ToInt64(getEmpIdCommand.ExecuteScalar())

        Dim query As String = "UPDATE olsmg_employee SET emp_lname=@el, emp_fname=@ef, emp_mi=@em, emp_cnum=@ec, emp_position=@ep WHERE emp_id=@conditionValue"
        Dim command As New MySqlCommand(query, cn)
        command.Parameters.AddWithValue("@el", empLname.Text)
        command.Parameters.AddWithValue("@ef", empFname.Text)
        command.Parameters.AddWithValue("@em", empMI.Text)
        command.Parameters.AddWithValue("@ec", empCN.Text)
        command.Parameters.AddWithValue("@ep", empPos.Text)
        command.Parameters.AddWithValue("@conditionValue", empId)
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
                Dim myUserEmp As New usr_employee()
                myUserEmp.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserEmp)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub DeleteData()
        dr.Close()
        Dim empId As Integer
        Dim getEmpIdCommand As New MySqlCommand($"c", cn)
        empId = Convert.ToInt64(getEmpIdCommand.ExecuteScalar())

        Dim query As String = "DELETE FROM olsmg_employee WHERE emp_id=@conditionValue"
        Dim command As New MySqlCommand(query, cn)
        command.Parameters.AddWithValue("@conditionValue", empId)
        Try
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        Finally
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
                main_form.mainPanel.Controls.Clear()
                Dim myUserEmp As New usr_employee()
                myUserEmp.Dock = DockStyle.Fill
                main_form.mainPanel.Controls.Add(myUserEmp)
                CloseForm()
            End If
        End Try
    End Sub

    Private Sub btn_deleteEmp_Click(sender As Object, e As EventArgs) Handles btn_deleteEmp.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            DeleteData()
        Else
            CloseForm()
        End If
    End Sub

    Private Sub empCN_Click(sender As Object, e As EventArgs) Handles empCN.Click

    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles empCN.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub
End Class
