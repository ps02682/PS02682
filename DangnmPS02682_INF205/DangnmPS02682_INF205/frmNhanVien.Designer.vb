<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbNhapThongTin = New System.Windows.Forms.GroupBox()
        Me.dtpNgayVao = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.txtCuaHang = New System.Windows.Forms.TextBox()
        Me.txtPhanQuyen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblTenNV = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvThongTin = New System.Windows.Forms.DataGridView()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.gbNhapThongTin.SuspendLayout()
        CType(Me.dgvThongTin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbNhapThongTin
        '
        Me.gbNhapThongTin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbNhapThongTin.Controls.Add(Me.dtpNgayVao)
        Me.gbNhapThongTin.Controls.Add(Me.dtpNgaySinh)
        Me.gbNhapThongTin.Controls.Add(Me.btnTim)
        Me.gbNhapThongTin.Controls.Add(Me.btnXoa)
        Me.gbNhapThongTin.Controls.Add(Me.btnSua)
        Me.gbNhapThongTin.Controls.Add(Me.btnThem)
        Me.gbNhapThongTin.Controls.Add(Me.txtCuaHang)
        Me.gbNhapThongTin.Controls.Add(Me.txtPhanQuyen)
        Me.gbNhapThongTin.Controls.Add(Me.Label5)
        Me.gbNhapThongTin.Controls.Add(Me.txtTenNV)
        Me.gbNhapThongTin.Controls.Add(Me.Label6)
        Me.gbNhapThongTin.Controls.Add(Me.Label4)
        Me.gbNhapThongTin.Controls.Add(Me.Label1)
        Me.gbNhapThongTin.Controls.Add(Me.txtPassword)
        Me.gbNhapThongTin.Controls.Add(Me.lblTenNV)
        Me.gbNhapThongTin.Controls.Add(Me.txtMaNV)
        Me.gbNhapThongTin.Controls.Add(Me.Label3)
        Me.gbNhapThongTin.Controls.Add(Me.Label2)
        Me.gbNhapThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNhapThongTin.Location = New System.Drawing.Point(12, 23)
        Me.gbNhapThongTin.Name = "gbNhapThongTin"
        Me.gbNhapThongTin.Size = New System.Drawing.Size(513, 485)
        Me.gbNhapThongTin.TabIndex = 0
        Me.gbNhapThongTin.TabStop = False
        Me.gbNhapThongTin.Text = "Nhập thông tin thành viên"
        '
        'dtpNgayVao
        '
        Me.dtpNgayVao.CalendarFont = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayVao.CustomFormat = "dd-mm-yyyy"
        Me.dtpNgayVao.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayVao.Location = New System.Drawing.Point(364, 182)
        Me.dtpNgayVao.Name = "dtpNgayVao"
        Me.dtpNgayVao.Size = New System.Drawing.Size(141, 29)
        Me.dtpNgayVao.TabIndex = 6
        Me.dtpNgayVao.Value = New Date(2015, 6, 18, 0, 0, 0, 0)
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CalendarFont = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgaySinh.CustomFormat = "dd-mm-yyyy"
        Me.dtpNgaySinh.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySinh.Location = New System.Drawing.Point(364, 41)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(141, 29)
        Me.dtpNgaySinh.TabIndex = 2
        Me.dtpNgaySinh.Value = New Date(2015, 6, 18, 0, 0, 0, 0)
        '
        'txtCuaHang
        '
        Me.txtCuaHang.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuaHang.Location = New System.Drawing.Point(119, 233)
        Me.txtCuaHang.Name = "txtCuaHang"
        Me.txtCuaHang.Size = New System.Drawing.Size(372, 33)
        Me.txtCuaHang.TabIndex = 7
        '
        'txtPhanQuyen
        '
        Me.txtPhanQuyen.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhanQuyen.Location = New System.Drawing.Point(119, 179)
        Me.txtPhanQuyen.Name = "txtPhanQuyen"
        Me.txtPhanQuyen.Size = New System.Drawing.Size(124, 33)
        Me.txtPhanQuyen.TabIndex = 5
        Me.txtPhanQuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(258, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ngày vào làm"
        '
        'txtTenNV
        '
        Me.txtTenNV.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenNV.Location = New System.Drawing.Point(119, 130)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(372, 33)
        Me.txtTenNV.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cửa hàng"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(258, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Ngày sinh"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Phân quyền"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(119, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(124, 33)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTenNV
        '
        Me.lblTenNV.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenNV.Location = New System.Drawing.Point(6, 136)
        Me.lblTenNV.Name = "lblTenNV"
        Me.lblTenNV.Size = New System.Drawing.Size(100, 29)
        Me.lblTenNV.TabIndex = 14
        Me.lblTenNV.Text = "Tên NV"
        '
        'txtMaNV
        '
        Me.txtMaNV.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNV.Location = New System.Drawing.Point(119, 37)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(124, 33)
        Me.txtMaNV.TabIndex = 1
        Me.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Mã NV"
        '
        'dgvThongTin
        '
        Me.dgvThongTin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTin.Location = New System.Drawing.Point(530, 32)
        Me.dgvThongTin.Name = "dgvThongTin"
        Me.dgvThongTin.Size = New System.Drawing.Size(462, 476)
        Me.dgvThongTin.TabIndex = 1
        '
        'btnTim
        '
        Me.btnTim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTim.AutoSize = True
        Me.btnTim.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim.Image = Global.DangnmPS02682_INF205.My.Resources.Resources.Search
        Me.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTim.Location = New System.Drawing.Point(317, 399)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(120, 60)
        Me.btnTim.TabIndex = 11
        Me.btnTim.Text = "Tìm"
        Me.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnXoa.AutoSize = True
        Me.btnXoa.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Image = Global.DangnmPS02682_INF205.My.Resources.Resources.Trash
        Me.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXoa.Location = New System.Drawing.Point(317, 296)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(120, 60)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSua.AutoSize = True
        Me.btnSua.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Image = Global.DangnmPS02682_INF205.My.Resources.Resources.Edit
        Me.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSua.Location = New System.Drawing.Point(58, 399)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(120, 60)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "Sửa"
        Me.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnThem.AutoSize = True
        Me.btnThem.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Image = Global.DangnmPS02682_INF205.My.Resources.Resources.Add
        Me.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThem.Location = New System.Drawing.Point(58, 296)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(120, 60)
        Me.btnThem.TabIndex = 8
        Me.btnThem.Text = "Thêm"
        Me.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 527)
        Me.Controls.Add(Me.dgvThongTin)
        Me.Controls.Add(Me.gbNhapThongTin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmNhanVien"
        Me.Text = "Quản lý thành viên"
        Me.gbNhapThongTin.ResumeLayout(False)
        Me.gbNhapThongTin.PerformLayout()
        CType(Me.dgvThongTin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbNhapThongTin As System.Windows.Forms.GroupBox
    Friend WithEvents txtTenNV As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblTenNV As System.Windows.Forms.Label
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents dgvThongTin As System.Windows.Forms.DataGridView
    Friend WithEvents dtpNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPhanQuyen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpNgayVao As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCuaHang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
