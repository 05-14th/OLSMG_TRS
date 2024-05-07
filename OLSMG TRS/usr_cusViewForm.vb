Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class usr_cusViewForm
    Public logged_account As String
    Public logged_uname As String
    Dim _infoString As String
    Dim infoString() As String

    Private Sub cusForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        _infoString = txtbox_name.Text
        infoString = _infoString.Split("#"c)
        logged_account = infoString(0)
        logged_uname = infoString(1)
        generateCbDAta()
    End Sub

    Private Sub generateCbDAta()
        Try
            Dim accountName As String


            Dim getUserName As New MySqlCommand($"SELECT  IF(c_mi = '', CONCAT(c_lname, ', ', REPLACE(c_fname, ',', '')), CONCAT(c_lname, ', ', c_fname, ', ', c_mi)) FROM `olsmg_customer` a JOIN `olsmg_users` b ON a.c_cnum = b.user_cnum WHERE user_uname = '{logged_uname}'", cn)
            Dim reader As MySqlDataReader = getUserName.ExecuteReader()

            If reader.Read() Then
                accountName = reader(0).ToString
                Console.WriteLine(accountName)
                Dim command As New MySqlCommand("SELECT * FROM olsmg_invoice a JOIN olsmg_order b ON a.reference_num=b.order_ref WHERE cus_name = @cn", cn)
                command.Parameters.AddWithValue("@cn", accountName)
                reader.Close()
                Dim _reader As MySqlDataReader = command.ExecuteReader()
                Dim uniqueValues As New HashSet(Of String)()

                While _reader.Read()
                    Dim referenceNum As String = _reader.GetString("reference_num")
                    If Not uniqueValues.Contains(referenceNum) Then
                        cb_cusRefNum.Items.Add(referenceNum)
                        uniqueValues.Add(referenceNum)
                    End If

                End While
                _reader.Close()
            End If
        Catch ex As Exception
            MsgBox("Error loading invoices", vbCritical, "Load Error")
        End Try

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Application.Restart()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub cb_cusRefNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cusRefNum.SelectedIndexChanged
        Try

            Dim accountName As String

            Dim getUname As New MySqlCommand($"SELECT  IF(c_mi = '', CONCAT(c_lname, ', ', REPLACE(c_fname, ', ', '')), CONCAT(c_lname, ', ', c_fname, ', ', c_mi)) FROM `olsmg_customer` a JOIN `olsmg_users` b ON a.c_cnum = b.user_cnum WHERE user_uname = '{logged_uname}'", cn)
            Dim reader As MySqlDataReader = getUname.ExecuteReader()

            If reader.Read() Then
                accountName = reader(0).ToString
                DataGridView1.Rows.Clear()
                txt_date_issue.Clear()
                txt_total_amount.Clear()
                txt_emp_name.Clear()

                reader.Close()
                Dim getNameFromInvoice As New MySqlCommand($"SELECT * FROM olsmg_invoice a JOIN olsmg_order b ON a.reference_num=b.order_ref JOIN olsmg_product c ON b.order_product=c.product_name WHERE cus_name = @cn AND reference_num = @rn", cn)
                getNameFromInvoice.Parameters.AddWithValue("@cn", accountName)
                getNameFromInvoice.Parameters.AddWithValue("@rn", cb_cusRefNum.Text)
                dr = getNameFromInvoice.ExecuteReader
                While dr.Read
                    txt_date_issue.Text = DirectCast(dr("date_issue"), DateTime).Date.ToString("MMM/dd/yyyy")
                    txt_total_amount.Text = dr("total_amount").ToString
                    txt_emp_name.Text = dr("employee_name").ToString
                    DataGridView1.Rows.Add(dr.Item("order_product").ToString, dr.Item("order_quantity").ToString, dr.Item("product_price").ToString, dr.Item("product_size").ToString, dr.Item("product_color").ToString)
                End While
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("Error loading orders", vbCritical, "Load Error")
        End Try

    End Sub
    Function NormalizeName(name As String) As String
        Dim lowerCaseName As String = name.ToLower()
        Dim alphabeticName As String = Regex.Replace(lowerCaseName, "[^a-z]", "")

        Return alphabeticName
    End Function

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_date_issue.TextChanged

    End Sub

    Private Sub PrintReceipt(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim _offset As Integer = 70
        Dim offset As Integer = 100
        Dim lineHeight As Single = 30

        Dim refNum As String = cb_cusRefNum.Text
        Dim customerName As String = txtbox_name.Text
        Dim dateIssue As String = txt_date_issue.Text
        Dim empName As String = txt_emp_name.Text
        Dim totalAmount As String = txt_total_amount.Text

        g.DrawString("Reference Number: " & refNum, New Font("Arial", 12), Brushes.Black, startX, startY)
        g.DrawString("Customer Name: " & customerName, New Font("Arial", 12), Brushes.Black, startX, startY + lineHeight)
        g.DrawString("Employee Name: " & empName, New Font("Arial", 12), Brushes.Black, startX, startY + 2 * lineHeight)
        g.DrawString("Total Amount: " & totalAmount, New Font("Arial", 12), Brushes.Black, startX, startY + 3 * lineHeight)
        g.DrawString("Date Issue: " & dateIssue, New Font("Arial", 12), Brushes.Black, startX, startY + 4 * lineHeight)

        startY += offset
        'g.DrawString("Purchase Receipt", New Font("Arial", 18), Brushes.Black, startX + 300, startY + 50)
        g.DrawString("Product", New Font("Arial", 12), Brushes.Black, startX, startY + _offset)
        g.DrawString("Quantity", New Font("Arial", 12), Brushes.Black, startX + 200, startY + _offset)
        g.DrawString("Unit Price", New Font("Arial", 12), Brushes.Black, startX + 300, startY + _offset)
        g.DrawString("Size", New Font("Arial", 12), Brushes.Black, startX + 400, startY + _offset)
        g.DrawString("Color", New Font("Arial", 12), Brushes.Black, startX + 500, startY + _offset)
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim product As String = row.Cells(0).Value.ToString()
            Dim quantity As String = row.Cells(1).Value.ToString()
            Dim unitPrice As String = row.Cells(2).Value.ToString()
            Dim size As String = row.Cells(3).Value.ToString()
            Dim color As String = row.Cells(4).Value.ToString()
            g.DrawString(product, New Font("Arial", 12), Brushes.Black, startX, startY + offset)
            g.DrawString(quantity, New Font("Arial", 12), Brushes.Black, startX + 200, startY + offset)
            g.DrawString(unitPrice, New Font("Arial", 12), Brushes.Black, startX + 300, startY + offset)
            g.DrawString(size, New Font("Arial", 12), Brushes.Black, startX + 400, startY + offset)
            g.DrawString(color, New Font("Arial", 12), Brushes.Black, startX + 500, startY + offset)
            startY += CInt(lineHeight)
        Next
        g.DrawString("@An Official Purchase Receipt", New Font("Arial", 12), Brushes.Black, startX, startY + 900)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf PrintReceipt

        Dim printDialog As New PrintDialog()
        printDialog.Document = pd
        If printDialog.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub
End Class
