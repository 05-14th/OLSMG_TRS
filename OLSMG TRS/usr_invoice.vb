Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math.EC
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Globalization

Public Class usr_invoice
    Inherits UserControl
    Dim addInv As New subForm()
    Dim invForm As New add_invoiceForm
    Dim editInv As New subForm()
    Dim editInvForm As New add_invoiceForm

    Sub LoadInvoice()
        Try
            Dim i As Integer = 0

            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_invoice", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                Dim dateWithoutTime As String = dr.GetDateTime("date_issue").ToString("MM/dd/yyyy")
                DataGridView1.Rows.Add(i, dateWithoutTime, dr.Item("total_amount").ToString, dr.Item("cus_name").ToString, dr.Item("employee_name").ToString, dr.Item("reference_num").ToString)
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
        addInv.Size = New Size(806, 439)
        invForm.Dock = DockStyle.Fill
        invForm.mode = 0
        invForm.invRefNum.Text = GenerateReferenceNumber().ToString

        invForm.btn_deleteInv.Enabled = False
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
                DataGridView1.Rows.Add(i, dateWithoutTime, dr.Item("total_amount").ToString, dr.Item("cus_name").ToString, dr.Item("employee_name").ToString, dr.Item("reference_num").ToString)
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
        LoadTableData($"SELECT * FROM olsmg_invoice WHERE employee_name LIKE '%{search_inv.Text}%' OR cus_name LIKE '%{search_inv.Text}%' OR reference_num LIKE '%{search_inv.Text}%'")
    End Sub

    Function GenerateReferenceNumber() As String
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim referenceNumber As String = "REF#" & timestamp
        Return referenceNumber
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            Dim refNumValue As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()


            Try
                cn.Open()
                cm = New MySqlCommand($"SELECT * FROM olsmg_invoice WHERE reference_num='{refNumValue}'", cn)
                dr = cm.ExecuteReader

                If dr.Read() Then
                    editInvForm.invTotalAmount.Text = dr.Item("total_amount").ToString()
                    editInvForm.invCusName.Text = dr.Item("cus_name").ToString()
                    editInvForm.invEmpName.Text = dr.Item("employee_name").ToString()
                    editInvForm.invRefNum.Text = dr.Item("reference_num").ToString()
                    dr.Close()
                    editInvForm.mode = 1
                    editInvForm.productName = refNumValue
                    Try
                        Dim i As Integer = 0
                        Dim prodTotalPrice As Double
                        editInvForm.DataGridView1.Rows.Clear()

                        cm = New MySqlCommand($"SELECT * FROM olsmg_invoice a JOIN olsmg_order b ON a.reference_num = b.order_ref JOIN olsmg_product c ON b.order_product = c.product_name WHERE reference_num='{refNumValue}'", cn)

                        dr1 = cm.ExecuteReader
                        While dr1.Read
                            i += 1
                            prodTotalPrice = Double.Parse(dr1.Item("product_price").ToString) * Integer.Parse(dr1.Item("order_quantity").ToString)
                            editInvForm.DataGridView1.Rows.Add(i, dr1.Item("order_product").ToString, dr1.Item("order_quantity").ToString, prodTotalPrice.ToString("0.00"))
                        End While
                        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                        dr1.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try

                    editInvForm.invDate.Enabled = False
                    editInv.subForm_panel.Controls.Clear()
                    editInvForm.Dock = DockStyle.Fill
                    editInv.subForm_panel.Controls.Add(editInvForm)
                    editInv.ShowDialog()
                Else
                    MessageBox.Show("No data found for the selected product.")
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub SaveToExcelFilteredByYear(dataGridView As DataGridView, yearPicker As DateTimePicker)


    End Sub

    Private Sub cb_generateReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_year.SelectedIndexChanged
        Dim selectedYearName As String = cb_year.SelectedItem.ToString()
        Dim selectedYear As Integer = DateTime.ParseExact(selectedYearName, "yyyy", CultureInfo.CurrentCulture).Year
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim rowDate As Date = Convert.ToDateTime(row.Cells(1).Value)
            If rowDate.Year = selectedYear Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub cb_month_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_month.SelectedIndexChanged
        Dim selectedMonthName As String = cb_month.SelectedItem.ToString()
        Dim selectedMonthNumber As Integer = DateTime.ParseExact(selectedMonthName, "MMMM", CultureInfo.CurrentCulture).Month
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim rowDate As Date = Convert.ToDateTime(row.Cells(1).Value)
            If rowDate.Month = selectedMonthNumber Then
                row.Visible = True
            Else
                row.Visible = False
            End If

        Next
    End Sub

    Private Sub ExportToExcel(ByVal dgv As DataGridView, ByVal fileName As String)
        Dim excelApp As New Excel.Application()
        Dim excelWorkBook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim excelWorkSheet As Excel.Worksheet = CType(excelWorkBook.Worksheets(1), Excel.Worksheet)

        ' Export headers
        For i As Integer = 0 To dgv.Columns.Count - 2
            excelWorkSheet.Cells(1, i + 1) = dgv.Columns(i).HeaderText
        Next

        ' Export data
        For i As Integer = 0 To dgv.Rows.Count - 1
            For j As Integer = 0 To dgv.Columns.Count - 2
                excelWorkSheet.Cells(i + 2, j + 1) = dgv.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        excelWorkBook.SaveAs(fileName)
        excelWorkBook.Close()
        excelApp.Quit()

        ReleaseObject(excelApp)
        ReleaseObject(excelWorkBook)
        ReleaseObject(excelWorkSheet)
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
            saveFileDialog.FileName = "ExportedData.xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ExportToExcel(DataGridView1, saveFileDialog.FileName)
                MsgBox("Excel exported successfully", vbInformation, "Success")
            End If
        Catch ex As Exception
            MsgBox("Unknown Error: " & ex.Message, vbCritical, "Failed")
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

    End Sub

End Class
