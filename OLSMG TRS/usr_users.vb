Imports MySql.Data.MySqlClient

Public Class usr_users
    Inherits UserControl
    Dim addUser As New subForm()
    Dim userForm As New add_userForm
    Dim editUser As New subForm()
    Dim editUserForm As New add_userForm

    Public Sub New()
        InitializeComponent()
        Me.Dock = DockStyle.Fill
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LoadUsers()
    End Sub

    Private Sub FullScreenUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub btn_addUsers_Click(sender As Object, e As EventArgs) Handles btn_addUsers.Click
        addUser.subForm_panel.Controls.Clear()
        addUser.Size = New Size(400, 500)
        userForm.Dock = DockStyle.Fill
        userForm.btn_approve.Hide()
        addUser.subForm_panel.Controls.Add(userForm)
        addUser.ShowDialog()
    End Sub

    Sub LoadUsers()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM olsmg_users", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("user_fullname").ToString, dr.Item("user_uname").ToString, dr.Item("user_email").ToString, dr.Item("user_cnum").ToString, dr.Item("user_role").ToString, dr.Item("user_status").ToString)
                DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub setDefaultButtons()
        editUserForm.btn_register.Visible = True
        editUserForm.btn_disable.Visible = False
        editUserForm.btn_delete.Visible = False
        editUserForm.btn_activate.Visible = False
        editUserForm.btn_confirm.Visible = False
        editUserForm.btn_approve.Visible = False
    End Sub

    Private Sub toggleButtons(register As Boolean, disable As Boolean, delete As Boolean, activate As Boolean, confirm As Boolean, approve As Boolean)
        editUserForm.btn_register.Visible = register
        editUserForm.btn_disable.Visible = disable
        editUserForm.btn_delete.Visible = delete
        editUserForm.btn_activate.Visible = activate
        editUserForm.btn_confirm.Visible = confirm
        editUserForm.btn_approve.Visible = approve
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 AndAlso e.RowIndex >= 0 Then
            Dim firstCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim secondCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            Dim thirdCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            Dim roleCellValue As String = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()

            Try
                cn.Open()
                cm = New MySqlCommand($"SELECT * FROM olsmg_users WHERE user_uname = '{firstCellValue}' AND user_email='{secondCellValue}' OR user_cnum='{thirdCellValue}'", cn)
                dr = cm.ExecuteReader

                If dr.Read() Then
                    If roleCellValue = "Active" Then
                        editUserForm.fullnameText.Text = dr.Item("user_fullname").ToString()
                        editUserForm.unameText.Text = dr.Item("user_uname").ToString()
                        editUserForm.emailText.Text = dr.Item("user_email").ToString()
                        editUserForm.cnumText.Text = dr.Item("user_cnum").ToString()
                        editUserForm.cb_roles.Text = dr.Item("user_role").ToString()
                        editUserForm.mode = 1
                        editUserForm.userName = firstCellValue
                        editUserForm.userEmail = secondCellValue
                        editUserForm.userContact = thirdCellValue
                        editUserForm.passText.Enabled = False
                        editUserForm.cpassText.Enabled = False
                        setDefaultButtons()
                        toggleButtons(False, True, False, False, True, False)
                        editUser.subForm_panel.Controls.Clear()
                        editUser.Size = New Size(400, 500)
                        editUserForm.Dock = DockStyle.Fill
                        editUser.subForm_panel.Controls.Add(editUserForm)
                        editUser.ShowDialog()
                    ElseIf roleCellValue = "Pending" Then
                        editUserForm.fullnameText.Text = dr.Item("user_fullname").ToString()
                        editUserForm.unameText.Text = dr.Item("user_uname").ToString()
                        editUserForm.emailText.Text = dr.Item("user_email").ToString()
                        editUserForm.cnumText.Text = dr.Item("user_cnum").ToString()
                        editUserForm.cb_roles.Text = dr.Item("user_role").ToString()
                        editUserForm.mode = 1
                        editUserForm.userName = firstCellValue
                        editUserForm.userEmail = secondCellValue
                        editUserForm.userContact = thirdCellValue
                        setDefaultButtons()
                        toggleButtons(False, False, True, False, False, True)
                        editUserForm.passText.Enabled = False
                        editUserForm.cpassText.Enabled = False
                        editUser.subForm_panel.Controls.Clear()
                        editUser.Size = New Size(400, 500)
                        editUserForm.Dock = DockStyle.Fill
                        editUser.subForm_panel.Controls.Add(editUserForm)
                        editUser.ShowDialog()
                    ElseIf roleCellValue = "Disabled" Then
                        editUserForm.fullnameText.Text = dr.Item("user_fullname").ToString()
                        editUserForm.unameText.Text = dr.Item("user_uname").ToString()
                        editUserForm.emailText.Text = dr.Item("user_email").ToString()
                        editUserForm.cnumText.Text = dr.Item("user_cnum").ToString()
                        editUserForm.cb_roles.Text = dr.Item("user_role").ToString()
                        editUserForm.mode = 1
                        editUserForm.userName = firstCellValue
                        editUserForm.userEmail = secondCellValue
                        editUserForm.userContact = thirdCellValue
                        editUserForm.passText.Enabled = False
                        editUserForm.cpassText.Enabled = False
                        setDefaultButtons()
                        toggleButtons(False, False, True, True, False, False)
                        editUser.subForm_panel.Controls.Clear()
                        editUser.Size = New Size(400, 500)
                        editUserForm.Dock = DockStyle.Fill
                        editUser.subForm_panel.Controls.Add(editUserForm)
                        editUser.ShowDialog()
                    End If
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
