<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.txtDT = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTenNV = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbNhapThongTin = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.dgvThongTin.Location = New System.Drawing.Point(530, 30)
        Me.dgvThongTin.Name = "dgvThongTin"
        Me.dgvThongTin.Size = New System.Drawing.Size(462, 476)
        Me.dgvThongTin.TabIndex = 3
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
        'txtDC
        '
        Me.txtDC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDC.Location = New System.Drawing.Point(159, 181)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(348, 33)
        Me.txtDC.TabIndex = 6
        Me.txtDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDT
        '
        Me.txtDT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDT.Location = New System.Drawing.Point(159, 133)
        Me.txtDT.Name = "txtDT"
        Me.txtDT.Size = New System.Drawing.Size(182, 33)
        Me.txtDT.TabIndex = 5
        Me.txtDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTenKH
        '
        Me.txtTenKH.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenKH.Location = New System.Drawing.Point(159, 86)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(348, 33)
        Me.txtTenKH.TabIndex = 4
        Me.txtTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Địa chỉ"
        '
        'lblTenNV
        '
        Me.lblTenNV.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenNV.Location = New System.Drawing.Point(6, 136)
        Me.lblTenNV.Name = "lblTenNV"
        Me.lblTenNV.Size = New System.Drawing.Size(100, 29)
        Me.lblTenNV.TabIndex = 14
        Me.lblTenNV.Text = "Điện thoại"
        '
        'txtMaKH
        '
        Me.txtMaKH.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKH.Location = New System.Drawing.Point(159, 37)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(124, 33)
        Me.txtMaKH.TabIndex = 1
        Me.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Mã KH"
        '
        'gbNhapThongTin
        '
        Me.gbNhapThongTin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbNhapThongTin.Controls.Add(Me.btnTim)
        Me.gbNhapThongTin.Controls.Add(Me.btnXoa)
        Me.gbNhapThongTin.Controls.Add(Me.btnSua)
        Me.gbNhapThongTin.Controls.Add(Me.btnThem)
        Me.gbNhapThongTin.Controls.Add(Me.txtEmail)
        Me.gbNhapThongTin.Controls.Add(Me.txtDC)
        Me.gbNhapThongTin.Controls.Add(Me.txtDT)
        Me.gbNhapThongTin.Controls.Add(Me.txtTenKH)
        Me.gbNhapThongTin.Controls.Add(Me.Label6)
        Me.gbNhapThongTin.Controls.Add(Me.Label1)
        Me.gbNhapThongTin.Controls.Add(Me.lblTenNV)
        Me.gbNhapThongTin.Controls.Add(Me.txtMaKH)
        Me.gbNhapThongTin.Controls.Add(Me.Label3)
        Me.gbNhapThongTin.Controls.Add(Me.Label2)
        Me.gbNhapThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNhapThongTin.Location = New System.Drawing.Point(12, 21)
        Me.gbNhapThongTin.Name = "gbNhapThongTin"
        Me.gbNhapThongTin.Size = New System.Drawing.Size(513, 485)
        Me.gbNhapThongTin.TabIndex = 2
        Me.gbNhapThongTin.TabStop = False
        Me.gbNhapThongTin.Text = "Nhập thông tin thành viên"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(159, 235)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(348, 33)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tên khách hàng"
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 527)
        Me.Controls.Add(Me.dgvThongTin)
        Me.Controls.Add(Me.gbNhapThongTin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmKhachHang"
        Me.Text = "frmKhachHang"
        CType(Me.dgvThongTin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNhapThongTin.ResumeLayout(False)
        Me.gbNhapThongTin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvThongTin As System.Windows.Forms.DataGridView
    Friend WithEvents btnTim As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtDC As System.Windows.Forms.TextBox
    Friend WithEvents txtDT As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTenNV As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbNhapThongTin As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
