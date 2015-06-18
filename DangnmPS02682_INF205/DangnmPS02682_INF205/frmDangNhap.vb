Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmDangNhap
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim chuoiketnoi As String = "workstation id=Assignment.mssql.somee.com;packet size=4096;user id=dangnmps02682_SQLLogin_1;pwd=t3az5aukix;data source=Assignment.mssql.somee.com;persist security info=False;initial catalog=Assignment"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhan_Vien where MaNV='" & txtID.Text & "' and MatKhau='" & txtPassWord.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                frmQuanLy.Show()

                'ID = (tb.Columns.Count = 2)
                Me.Hide()
            Else
                MessageBox.Show("Sai Tài khoản hoặc Mật khẩu")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmWelcome.ShowDialog()
        Me.CenterToScreen()
        txtID.Focus()
    End Sub
End Class