
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class usr_suppliers
    Inherits UserControl
    Dim addSup As New subForm()
    Dim supForm As New add_supForm
    Dim editSup As New subForm()
    Dim editSupForm As New add_supForm
    Dim fullAddress As String

    Sub LoadSup()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_supplier a JOIN olsmg_address b ON a.store_address_ref = b.address_num", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                fullAddress = $"{dr.Item("street").ToString}, {dr.Item("barangay").ToString}, {dr.Item("municipality").ToString}, {dr.Item("province").ToString}, {dr.Item("zip_code").ToString}"
                DataGridView1.Rows.Add(i, dr.Item("store_name").ToString, fullAddress, dr.Item("platform").ToString)
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
        LoadSup()
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addSup_Click(sender As Object, e As EventArgs) Handles btn_addSup.Click
        addSup.subForm_panel.Controls.Clear()
        addSup.Size = New Size(400, 500)
        supForm.Dock = DockStyle.Fill
        addSup.subForm_panel.Controls.Add(supForm)
        addSup.ShowDialog()
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
                fullAddress = $"{dr.Item("street").ToString}, {dr.Item("barangay").ToString}, {dr.Item("municipality").ToString}, {dr.Item("province").ToString}, {dr.Item("zip_code").ToString}"
                DataGridView1.Rows.Add(i, dr.Item("store_name").ToString, fullAddress, dr.Item("platform").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub search_emp_Click(sender As Object, e As EventArgs) Handles search_sup.Click
        If search_sup.Text = "Search for supplier" Then
            search_sup.Text = ""
        End If
    End Sub

    Private Sub search_LostFocus(sender As Object, e As EventArgs) Handles search_sup.LostFocus
        search_sup.Text = "Search for supplier"
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search_sup.TextChanged
        LoadTableData($"SELECT * FROM olsmg_supplier a JOIN olsmg_address b ON a.store_address_ref = b.address_num WHERE store_name LIKE '%{search_sup.Text}%' OR platform LIKE '%{search_sup.Text}%'")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            Dim firstCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim thirdCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            Try
                cn.Open()
                cm = New MySqlCommand($"SELECT * FROM olsmg_supplier a JOIN olsmg_address b ON a.store_address_ref = b.address_num WHERE store_name = '{firstCellValue}' AND platform = '{thirdCellValue}'", cn)
                dr = cm.ExecuteReader

                If dr.Read() Then
                    editSupForm.storeName.Text = dr.Item("store_name").ToString()
                    editSupForm.storeStreet.Text = dr.Item("street").ToString()
                    editSupForm.storeBrgy.Text = dr.Item("barangay").ToString()
                    editSupForm.storeMuni.Text = dr.Item("municipality").ToString()
                    editSupForm.storeProv.Text = dr.Item("province").ToString()
                    editSupForm.storeZip.Text = dr.Item("zip_code").ToString()
                    editSupForm.storePlat.Text = dr.Item("platform").ToString()
                    editSupForm.mode = 1
                    editSupForm.store_name = firstCellValue
                    editSupForm.store_platform = thirdCellValue
                    'editSupForm.prodName.Enabled = False
                    editSup.subForm_panel.Controls.Clear()
                    editSup.Size = New Size(400, 500)
                    editSupForm.Dock = DockStyle.Fill
                    editSup.subForm_panel.Controls.Add(editSupForm)
                    editSup.ShowDialog()
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
