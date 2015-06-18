Public Class frmQuanLy


    Private Sub frmQuanLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDangNhap.ShowDialog()
        tstTaiKhoan.Text = ID
        Me.CenterToScreen()
    End Sub

    Private Sub tsmQuanLy_Click(sender As Object, e As EventArgs) Handles tsmQuanLy.Click
        frmNhanVien.ShowDialog()
    End Sub


    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        Application.Exit()
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        frmSanPham.ShowDialog()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmKhachHang.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        frmLoaiSanPham.ShowDialog()
    End Sub
End Class