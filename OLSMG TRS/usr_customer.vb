Imports MySql.Data.MySqlClient

Public Class usr_customer
    Inherits UserControl
    Dim addCus As New subForm()
    Dim cusForm As New add_cusForm
    Dim editCus As New subForm()
    Dim editCusForm As New add_cusForm

    Sub LoadCus()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_customer", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("c_lname").ToString, dr.Item("c_fname").ToString, dr.Item("c_mi").ToString, dr.Item("c_cnum").ToString, dr.Item("c_email").ToString)
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
        LoadCus()
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addCus_Click(sender As Object, e As EventArgs) Handles btn_addCus.Click
        addCus.subForm_panel.Controls.Clear()
        addCus.Size = New Size(400, 500)
        cusForm.Dock = DockStyle.Fill
        cusForm.mode = 0
        cusForm.btn_deleteCus.Enabled = False
        addCus.subForm_panel.Controls.Add(cusForm)
        addCus.ShowDialog()
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
                DataGridView1.Rows.Add(i, dr.Item("c_lname").ToString, dr.Item("c_fname").ToString, dr.Item("c_mi").ToString, dr.Item("c_cnum").ToString, dr.Item("c_email").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub search_cus_Click(sender As Object, e As EventArgs) Handles search_cus.Click
        If search_cus.Text = "Search for customer" Then
            search_cus.Text = ""
        End If
    End Sub

    Private Sub search_LostFocus(sender As Object, e As EventArgs) Handles search_cus.LostFocus
        search_cus.Text = "Search for customer"
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search_cus.TextChanged
        LoadTableData($"SELECT * FROM olsmg_customer WHERE c_lname LIKE '%{search_cus.Text}%' OR c_fname LIKE '%{search_cus.Text}%'")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            Dim firstCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim secondCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim thirdCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()

            Try
                cn.Open()
                cm = New MySqlCommand($"SELECT * FROM olsmg_customer WHERE c_lname = '{firstCellValue}' AND c_fname='{secondCellValue}' AND c_mi='{thirdCellValue}'", cn)
                dr = cm.ExecuteReader

                If dr.Read() Then
                    editCusForm.c_lname.Text = dr.Item("c_lname").ToString()
                    editCusForm.c_fname.Text = dr.Item("c_fname").ToString()
                    editCusForm.c_mi.Text = dr.Item("c_mi").ToString()
                    editCusForm.c_cn.Text = dr.Item("c_cnum").ToString()
                    editCusForm.emailText.Text = dr.Item("c_email").ToString()
                    editCusForm.mode = 1
                    editCusForm.Lname = firstCellValue
                    editCusForm.Fname = secondCellValue
                    editCusForm.Minit = thirdCellValue

                    editCus.subForm_panel.Controls.Clear()
                    editCus.Size = New Size(400, 500)
                    editCusForm.Dock = DockStyle.Fill
                    editCus.subForm_panel.Controls.Add(editCusForm)
                    editCus.ShowDialog()
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
