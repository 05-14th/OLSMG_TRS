Imports MySql.Data.MySqlClient

Public Class usr_inventory
    Inherits UserControl
    Dim addProd As New subForm()
    Dim prodForm As New add_prodForm

    Sub LoadProd()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_supplier a JOIN olsmg_product b ON a.store_num = b.store_number", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("product_name").ToString, dr.Item("product_size").ToString, dr.Item("product_color").ToString, dr.Item("product_price").ToString, dr.Item("store_name").ToString)

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
                DataGridView1.Rows.Add(i, dr.Item("product_name").ToString, dr.Item("product_size").ToString, dr.Item("product_color").ToString, dr.Item("product_price").ToString, dr.Item("store_name").ToString)
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
End Class
