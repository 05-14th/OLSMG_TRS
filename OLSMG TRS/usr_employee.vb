Imports MySql.Data.MySqlClient

Public Class usr_employee
    Inherits UserControl
    Dim addEmp As New subForm()
    Dim empForm As New add_empForm

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

            End While
            DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
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
End Class
