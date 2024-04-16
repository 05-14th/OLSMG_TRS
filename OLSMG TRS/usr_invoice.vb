Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC

Public Class usr_invoice
    Inherits UserControl
    Dim addInv As New subForm()
    Dim invForm As New add_invoiceForm

    Sub LoadInvoice()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_invoice a JOIN olsmg_product b ON a.product_name_ref = b.product_name", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                Dim dateWithoutTime As String = dr.GetDateTime("date_issue").ToString("MM/dd/yyyy")
                DataGridView1.Rows.Add(i, dateWithoutTime, dr.Item("total_amount").ToString, dr.Item("cus_name").ToString, dr.Item("employee_name").ToString, dr.Item("product_name_ref").ToString, dr.Item("product_price").ToString, dr.Item("reference_num").ToString)
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
        LoadInvoice()
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addInv_Click(sender As Object, e As EventArgs) Handles btn_addInv.Click
        addInv.subForm_panel.Controls.Clear()
        addInv.Size = New Size(400, 500)
        invForm.Dock = DockStyle.Fill
        addInv.subForm_panel.Controls.Add(invForm)
        addInv.ShowDialog()
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
                Dim dateWithoutTime As String = dr.GetDateTime("date_issue").ToString("MM/dd/yyyy")
                DataGridView1.Rows.Add(i, dateWithoutTime, dr.Item("total_amount").ToString, dr.Item("cus_name").ToString, dr.Item("employee_name").ToString, dr.Item("product_name_ref").ToString, dr.Item("product_price").ToString, dr.Item("reference_num").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub search_emp_Click(sender As Object, e As EventArgs) Handles search_inv.Click
        If search_inv.Text = "Search for invoice" Then
            search_inv.Text = ""
        End If
    End Sub

    Private Sub search_LostFocus(sender As Object, e As EventArgs) Handles search_inv.LostFocus
        search_inv.Text = "Search for invoice"
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search_inv.TextChanged
        LoadTableData($"SELECT * FROM olsmg_invoice a JOIN olsmg_product b ON a.product_name_ref = b.product_name WHERE employee_name LIKE '%{search_inv.Text}%' OR product_name LIKE '%{search_inv.Text}%' OR cus_name LIKE '%{search_inv.Text}%' OR reference_num LIKE '%{search_inv.Text}%'")
    End Sub
End Class
