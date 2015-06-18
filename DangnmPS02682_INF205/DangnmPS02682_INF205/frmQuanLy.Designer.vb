<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLy
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTaiKhoan = New System.Windows.Forms.ToolStripMenuItem()
        Me.tstTaiKhoan = New System.Windows.Forms.ToolStripTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tsmQuanLy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AccountToolStripMenuItem, Me.HelpToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.tsmTaiKhoan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(683, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmQuanLy, Me.ToolStripSeparator1, Me.tsmExit})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(113, 25)
        Me.FileToolStripMenuItem.Text = "Hệ thống"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Bold)
        Me.AccountToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(117, 25)
        Me.AccountToolStripMenuItem.Text = "Sản phẩm"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Bold)
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(165, 25)
        Me.HelpToolStripMenuItem.Text = "Loại sản phẩm"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Bold)
        Me.KháchHàngToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(147, 25)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'tsmTaiKhoan
        '
        Me.tsmTaiKhoan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstTaiKhoan})
        Me.tsmTaiKhoan.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Bold)
        Me.tsmTaiKhoan.ForeColor = System.Drawing.Color.Blue
        Me.tsmTaiKhoan.Name = "tsmTaiKhoan"
        Me.tsmTaiKhoan.Size = New System.Drawing.Size(126, 25)
        Me.tsmTaiKhoan.Text = "Tài Khoản"
        '
        'tstTaiKhoan
        '
        Me.tstTaiKhoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tstTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tstTaiKhoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tstTaiKhoan.ForeColor = System.Drawing.Color.White
        Me.tstTaiKhoan.Name = "tstTaiKhoan"
        Me.tstTaiKhoan.ReadOnly = True
        Me.tstTaiKhoan.Size = New System.Drawing.Size(100, 16)
        Me.tstTaiKhoan.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DangnmPS02682_INF205.My.Resources.Resources.ad
        Me.PictureBox1.Location = New System.Drawing.Point(12, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(659, 288)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'tsmQuanLy
        '
        Me.tsmQuanLy.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmQuanLy.Image = Global.DangnmPS02682_INF205.My.Resources.Resources._15
        Me.tsmQuanLy.Name = "tsmQuanLy"
        Me.tsmQuanLy.Size = New System.Drawing.Size(191, 22)
        Me.tsmQuanLy.Text = "Quản lý nhân viên"
        '
        'tsmExit
        '
        Me.tsmExit.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tsmExit.Image = Global.DangnmPS02682_INF205.My.Resources.Resources._5
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.tsmExit.Size = New System.Drawing.Size(191, 22)
        Me.tsmExit.Text = "Exit"
        '
        'frmQuanLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(683, 343)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuanLy"
        Me.Text = "Quản lý"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmTaiKhoan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tsmQuanLy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tstTaiKhoan As System.Windows.Forms.ToolStripTextBox
End Class
