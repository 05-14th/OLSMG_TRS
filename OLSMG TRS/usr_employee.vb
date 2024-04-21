Imports MySql.Data.MySqlClient

Public Class usr_employee
    Inherits UserControl
    Dim addEmp As New subForm()
    Dim empForm As New add_empForm
    Dim editEmp As New subForm()
    Dim editEmpForm As New add_empForm

    Sub LoadEmp()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_employee", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("emp_lname").ToString, dr.Item("emp_fname").ToString, dr.Item("emp_mi").ToString, dr.Item("emp_cnum").ToString, dr.Item("emp_position").ToString)
                DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            End While
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
        LoadEmp()
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addEmp_Click(sender As Object, e As EventArgs) Handles btn_addEmp.Click
        addEmp.subForm_panel.Controls.Clear()
        addEmp.Size = New Size(400, 500)
        empForm.mode = 0
        empForm.btn_deleteEmp.Enabled = False
        empForm.Dock = DockStyle.Fill
        addEmp.subForm_panel.Controls.Add(empForm)
        addEmp.ShowDialog()
    End Sub

    Public Sub LoadTableData(query1 As String)
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand(query1, cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("emp_lname").ToString, dr.Item("emp_fname").ToString, dr.Item("emp_mi").ToString, dr.Item("emp_cnum").ToString, dr.Item("emp_position").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub search_emp_Click(sender As Object, e As EventArgs) Handles search_emp.Click
        If search_emp.Text = "Search for employee" Then
            search_emp.Text = ""
        End If
    End Sub

    Private Sub search_LostFocus(sender As Object, e As EventArgs) Handles search_emp.LostFocus
        search_emp.Text = "Search for employee"
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search_emp.TextChanged
        LoadTableData($"SELECT * FROM olsmg_employee WHERE emp_lname LIKE '%{search_emp.Text}%' OR emp_fname LIKE '%{search_emp.Text}%'")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            Dim firstCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim secondCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim thirdCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()

            Try
                cn.Open()
                cm = New MySqlCommand($"SELECT * FROM olsmg_employee WHERE emp_lname = '{firstCellValue}' AND emp_fname='{secondCellValue}' AND emp_mi='{thirdCellValue}'", cn)
                dr = cm.ExecuteReader

                If dr.Read() Then
                    editEmpForm.empLname.Text = dr.Item("emp_lname").ToString()
                    editEmpForm.empFname.Text = dr.Item("emp_fname").ToString()
                    editEmpForm.empMI.Text = dr.Item("emp_mi").ToString()
                    editEmpForm.empCN.Text = dr.Item("emp_cnum").ToString()
                    editEmpForm.empPos.Text = dr.Item("emp_position").ToString()
                    editEmpForm.mode = 1
                    editEmpForm.Lname = firstCellValue
                    editEmpForm.Fname = secondCellValue
                    editEmpForm.Minit = thirdCellValue

                    editEmp.subForm_panel.Controls.Clear()
                    editEmp.Size = New Size(400, 500)
                    editEmpForm.Dock = DockStyle.Fill
                    editEmp.subForm_panel.Controls.Add(editEmpForm)
                    editEmp.ShowDialog()
                Else
                    MessageBox.Show("No data found for the selected product.")
                End If
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
