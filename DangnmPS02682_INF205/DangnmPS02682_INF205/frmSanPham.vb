Imports System.Data.SqlClient

Public Class frmSanPham
    Dim Hang() As String
    Dim Cot() As String
    Dim database As New DataTable
    Dim chuoiconnect As String = "workstation id=Assignment.mssql.somee.com;packet size=4096;user id=dangnmps02682_SQLLogin_1;pwd=t3az5aukix;data source=Assignment.mssql.somee.com;persist security info=False;initial catalog=Assignment"

    Private Sub Loaddata()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Chi_Tiet_SP", connect)

        connect.Open()
        Query1.Fill(database)
        dgvThongTin.DataSource = database.DefaultView
    End Sub

    Private Sub frmQuanLyThanhVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Chi_Tiet_SP", connect)
        connect.Open()
        Query1.Fill(database)
        dgvThongTin.DataSource = database.DefaultView
        txtMaSP.Focus()
        Me.CenterToScreen()
    End Sub

    Private Sub dgvThongTin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThongTin.CellClick
        Dim index As Integer = dgvThongTin.CurrentCell.RowIndex
        txtMaSP.Text = dgvThongTin.Item(0, index).Value
        txtTonKho.Text = dgvThongTin.Item(4, index).Value
        txtMaLoai.Text = dgvThongTin.Item(1, index).Value
        txtTenSP.Text = dgvThongTin.Item(2, index).Value
        txtDonGia.Text = dgvThongTin.Item(3, index).Value
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query2 As String = "insert into Chi_Tiet_SP values (@MaSP,@MaLoai,@TenSP,@DonGia,@TonKho)"
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        connect.Open()

        Try
            ExecuteQuery1.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TonKho", txtTonKho.Text)


            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
            MessageBox.Show("Không thêm được!")

        End Try
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Chi_Tiet_SP", connect)
        database.Clear()

        Query3.Fill(database)
        dgvThongTin.DataSource = database.DefaultView
    End Sub


    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Ketnoi1 As New SqlConnection(chuoiconnect)
        Dim Stradd1 As String = "Update Chi_Tiet_SP set TonKho = @TonKho, MaLoai = @MaLoai, TenSP = @TenSP, DonGia = @DonGia where MaSP = @MaSP"
        Dim com As New SqlCommand(Stradd1, Ketnoi1)
        Ketnoi1.Open()
        Try
            com.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            com.Parameters.AddWithValue("@TonKho", txtTonKho.Text)
            com.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            com.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            com.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text)
            com.ExecuteNonQuery()
            Ketnoi1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        database.Clear()
        dgvThongTin.DataSource = database
        dgvThongTin.DataSource = Nothing
        Loaddata()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from Chi_Tiet_SP Where MaSP = @MaSP"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa thành công")
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        dgvThongTin.DataSource = database
        dgvThongTin.DataSource = Nothing
        Loaddata()
    End Sub



    Private Function com() As Object
        Throw New NotImplementedException
    End Function
End Class