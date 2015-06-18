<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Me.dgvThongTin = New System.Windows.Forms.DataGridView()
        Me.gbNhapThongTin = New System.Windows.Forms.GroupBox()
        Me.dtpNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTenNV = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        CType(Me.dgvThongTin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNhapThongTin.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvThongTin
        '
        Me.dgvThongTin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTin.Location = New System.Drawing.Point(530, 20)
        Me.dgvThongTin.Name = "dgvThongTin"
        Me.dgvThongTin.Size = New System.Drawing.Size(462, 476)
        Me.dgvThongTin.TabIndex = 5
        '
        'gbNhapThongTin
        '
        Me.gbNhapThongTin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbNhapThongTin.Controls.Add(Me.dtpNgayLap)
        Me.gbNhapThongTin.Controls.Add(Me.btnTim)
        Me.gbNhapThongTin.Controls.Add(Me.btnXoa)
        Me.gbNhapThongTin.Controls.Add(Me.btnSua)
        Me.gbNhapThongTin.Controls.Add(Me.btnThem)
        Me.gbNhapThongTin.Controls.Add(Me.txtTongTien)
        Me.gbNhapThongTin.Controls.Add(Me.txtMaNV)
        Me.gbNhapThongTin.Controls.Add(Me.txtMaKH)
        Me.gbNhapThongTin.Controls.Add(Me.Label6)
        Me.gbNhapThongTin.Controls.Add(Me.Label1)
        Me.gbNhapThongTin.Controls.Add(Me.lblTenNV)
        Me.gbNhapThongTin.Controls.Add(Me.txtMaHD)
        Me.gbNhapThongTin.Controls.Add(Me.Label3)
        Me.gbNhapThongTin.Controls.Add(Me.Label2)
        Me.gbNhapThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNhapThongTin.Location = New System.Drawing.Point(12, 11)
        Me.gbNhapThongTin.Name = "gbNhapThongTin"
        Me.gbNhapThongTin.Size = New System.Drawing.Size(513, 485)
        Me.gbNhapThongTin.TabIndex = 4
        Me.gbNhapThongTin.TabStop = False
        Me.gbNhapThongTin.Text = "Nhập thông tin thành viên"
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.CalendarFont = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayLap.CustomFormat = "dd-mm-yyyy"
        Me.dtpNgayLap.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayLap.Location = New System.Drawing.Point(257, 187)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(141, 29)
        Me.dtpNgayLap.TabIndex = 16
        Me.dtpNgayLap.Value = New Date(2015, 6, 18, 0, 0, 0, 0)
        '
        'txtTongTien
        '
        Me.txtTongTien.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTongTien.Location = New System.Drawing.Point(226, 238)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(202, 33)
        Me.txtTongTien.TabIndex = 7
        Me.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaNV
        '
        Me.txtMaNV.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNV.Location = New System.Drawing.Point(257, 136)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(141, 33)
        Me.txtMaNV.TabIndex = 5
        Me.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaKH
        '
        Me.txtMaKH.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKH.Location = New System.Drawing.Point(257, 89)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(141, 33)
        Me.txtMaKH.TabIndex = 4
        Me.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Tổng tiền"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ngày lập"
        '
        'lblTenNV
        '
        Me.lblTenNV.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenNV.Location = New System.Drawing.Point(73, 139)
        Me.lblTenNV.Name = "lblTenNV"
        Me.lblTenNV.Size = New System.Drawing.Size(147, 29)
        Me.lblTenNV.TabIndex = 14
        Me.lblTenNV.Text = "Mã nhân viên"
        '
        'txtMaHD
        '
        Me.txtMaHD.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHD.Location = New System.Drawing.Point(257, 40)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(141, 33)
        Me.txtMaHD.TabIndex = 1
        Me.txtMaHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Mã hóa đơn"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Mã khách hàng"
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
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 507)
        Me.Controls.Add(Me.dgvThongTin)
        Me.Controls.Add(Me.gbNhapThongTin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmHoaDon"
        Me.Text = "frmHoaDon"
        CType(Me.dgvThongTin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNhapThongTin.ResumeLayout(False)
        Me.gbNhapThongTin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvThongTin As System.Windows.Forms.DataGridView
    Friend WithEvents gbNhapThongTin As System.Windows.Forms.GroupBox
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtTongTien As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTenNV As System.Windows.Forms.Label
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpNgayLap As System.Windows.Forms.DateTimePicker
End Class
