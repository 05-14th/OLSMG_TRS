Imports MySql.Data.MySqlClient

Public Class usr_inventory
    Inherits UserControl
    Dim addProd As New subForm()
    Dim prodForm As New add_prodForm
    Dim editProd As New subForm()
    Dim editProdForm As New add_prodForm()

    Sub LoadProd()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_supplier a JOIN olsmg_product b ON a.store_num = b.store_number", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("product_name").ToString, dr.Item("product_size").ToString, dr.Item("product_color").ToString, dr.Item("product_price").ToString, dr.Item("product_stocks").ToString, dr.Item("store_name").ToString)
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
        LoadProd()
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addEmp_Click(sender As Object, e As EventArgs) Handles btn_addProd.Click
        addProd.subForm_panel.Controls.Clear()
        addProd.Size = New Size(400, 500)
        prodForm.Dock = DockStyle.Fill
        prodForm.mode = 0
        prodForm.btn_deleteProd.Enabled = False
        addProd.subForm_panel.Controls.Add(prodForm)
        addProd.ShowDialog()
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
                DataGridView1.Rows.Add(i, dr.Item("product_name").ToString, dr.Item("product_size").ToString, dr.Item("product_color").ToString, dr.Item("product_price").ToString, dr.Item("product_stocks").Tostring ,dr.Item("store_name").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub search_emp_Click(sender As Object, e As EventArgs) Handles search_prod.Click
        If search_prod.Text = "Search for product" Then
            search_prod.Text = ""
        End If
    End Sub

    Private Sub search_LostFocus(sender As Object, e As EventArgs) Handles search_prod.LostFocus
        search_prod.Text = "Search for product"
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search_prod.TextChanged
        LoadTableData($"SELECT * FROM olsmg_supplier a JOIN olsmg_product b ON a.store_num = b.store_number WHERE store_name LIKE '%{search_prod.Text}%' OR product_name LIKE '%{search_prod.Text}%'")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            Dim firstCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            Try
                cn.Open()
                cm = New MySqlCommand($"SELECT * FROM olsmg_supplier a JOIN olsmg_product b ON a.store_num = b.store_number WHERE product_name = '{firstCellValue}'", cn)
                dr = cm.ExecuteReader

                If dr.Read() Then
                    editProdForm.prodName.Text = dr.Item("product_name").ToString()
                    editProdForm.prodSize.Text = dr.Item("product_size").ToString()
                    editProdForm.prodColor.Text = dr.Item("product_color").ToString()
                    editProdForm.prodPrice.Text = dr.Item("product_price").ToString()
                    editProdForm.stocksEntry.Text = dr.Item("product_stocks").ToString()
                    editProdForm.prodSup.Text = dr.Item("store_name").ToString()
                    editProdForm.mode = 1
                    editProdForm.productName = firstCellValue
                    editProdForm.prodName.Enabled = False
                    editProd.subForm_panel.Controls.Clear()
                    editProd.Size = New Size(400, 500)
                    editProdForm.Dock = DockStyle.Fill
                    editProd.subForm_panel.Controls.Add(editProdForm)
                    editProd.ShowDialog()
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
