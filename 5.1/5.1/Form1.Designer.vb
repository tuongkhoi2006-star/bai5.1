<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        grpCaNhan = New GroupBox()
        lblTenDangNhap = New Label()
        txtTenDangNhap = New TextBox()
        lblMatKhau = New Label()
        txtMatKhau = New TextBox()
        lblXacNhan = New Label()
        txtXacNhanMatKhau = New TextBox()
        grpBoSung = New GroupBox()
        lblNgaySinh = New Label()
        dtpNgaySinh = New DateTimePicker()
        lblGioiTinh = New Label()
        radNam = New RadioButton()
        radNu = New RadioButton()
        chkDongY = New CheckBox()
        btnDangKy = New Button()
        btnLamMoi = New Button()
        epCheck = New ErrorProvider(components)
        grpCaNhan.SuspendLayout()
        grpBoSung.SuspendLayout()
        CType(epCheck, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpCaNhan
        ' 
        grpCaNhan.Controls.Add(lblTenDangNhap)
        grpCaNhan.Controls.Add(txtTenDangNhap)
        grpCaNhan.Controls.Add(lblMatKhau)
        grpCaNhan.Controls.Add(txtMatKhau)
        grpCaNhan.Controls.Add(lblXacNhan)
        grpCaNhan.Controls.Add(txtXacNhanMatKhau)
        grpCaNhan.Location = New Point(28, 32)
        grpCaNhan.Margin = New Padding(6, 6, 6, 6)
        grpCaNhan.Name = "grpCaNhan"
        grpCaNhan.Padding = New Padding(6, 6, 6, 6)
        grpCaNhan.Size = New Size(687, 331)
        grpCaNhan.TabIndex = 0
        grpCaNhan.TabStop = False
        grpCaNhan.Text = "Thông tin cá nhân"
        ' 
        ' lblTenDangNhap
        ' 
        lblTenDangNhap.AutoSize = True
        lblTenDangNhap.Location = New Point(28, 75)
        lblTenDangNhap.Margin = New Padding(6, 0, 6, 0)
        lblTenDangNhap.Name = "lblTenDangNhap"
        lblTenDangNhap.Size = New Size(179, 32)
        lblTenDangNhap.TabIndex = 0
        lblTenDangNhap.Text = "Tên đăng nhập:"
        ' 
        ' txtTenDangNhap
        ' 
        txtTenDangNhap.Location = New Point(279, 68)
        txtTenDangNhap.Margin = New Padding(6, 6, 6, 6)
        txtTenDangNhap.Name = "txtTenDangNhap"
        txtTenDangNhap.Size = New Size(368, 39)
        txtTenDangNhap.TabIndex = 1
        ' 
        ' lblMatKhau
        ' 
        lblMatKhau.AutoSize = True
        lblMatKhau.Location = New Point(28, 160)
        lblMatKhau.Margin = New Padding(6, 0, 6, 0)
        lblMatKhau.Name = "lblMatKhau"
        lblMatKhau.Size = New Size(120, 32)
        lblMatKhau.TabIndex = 2
        lblMatKhau.Text = "Mật khẩu:"
        ' 
        ' txtMatKhau
        ' 
        txtMatKhau.Location = New Point(279, 154)
        txtMatKhau.Margin = New Padding(6, 6, 6, 6)
        txtMatKhau.Name = "txtMatKhau"
        txtMatKhau.Size = New Size(368, 39)
        txtMatKhau.TabIndex = 3
        txtMatKhau.UseSystemPasswordChar = True
        ' 
        ' lblXacNhan
        ' 
        lblXacNhan.AutoSize = True
        lblXacNhan.Location = New Point(28, 245)
        lblXacNhan.Margin = New Padding(6, 0, 6, 0)
        lblXacNhan.Name = "lblXacNhan"
        lblXacNhan.Size = New Size(224, 32)
        lblXacNhan.TabIndex = 4
        lblXacNhan.Text = "Xác nhận mật khẩu:"
        ' 
        ' txtXacNhanMatKhau
        ' 
        txtXacNhanMatKhau.Location = New Point(279, 239)
        txtXacNhanMatKhau.Margin = New Padding(6, 6, 6, 6)
        txtXacNhanMatKhau.Name = "txtXacNhanMatKhau"
        txtXacNhanMatKhau.Size = New Size(368, 39)
        txtXacNhanMatKhau.TabIndex = 5
        txtXacNhanMatKhau.UseSystemPasswordChar = True
        ' 
        ' grpBoSung
        ' 
        grpBoSung.Controls.Add(lblNgaySinh)
        grpBoSung.Controls.Add(dtpNgaySinh)
        grpBoSung.Controls.Add(lblGioiTinh)
        grpBoSung.Controls.Add(radNam)
        grpBoSung.Controls.Add(radNu)
        grpBoSung.Controls.Add(chkDongY)
        grpBoSung.Location = New Point(28, 384)
        grpBoSung.Margin = New Padding(6, 6, 6, 6)
        grpBoSung.Name = "grpBoSung"
        grpBoSung.Padding = New Padding(6, 6, 6, 6)
        grpBoSung.Size = New Size(687, 331)
        grpBoSung.TabIndex = 1
        grpBoSung.TabStop = False
        grpBoSung.Text = "Thông tin bổ sung"
        ' 
        ' lblNgaySinh
        ' 
        lblNgaySinh.AutoSize = True
        lblNgaySinh.Location = New Point(28, 75)
        lblNgaySinh.Margin = New Padding(6, 0, 6, 0)
        lblNgaySinh.Name = "lblNgaySinh"
        lblNgaySinh.Size = New Size(126, 32)
        lblNgaySinh.TabIndex = 0
        lblNgaySinh.Text = "Ngày sinh:"
        ' 
        ' dtpNgaySinh
        ' 
        dtpNgaySinh.Format = DateTimePickerFormat.Short
        dtpNgaySinh.Location = New Point(279, 68)
        dtpNgaySinh.Margin = New Padding(6, 6, 6, 6)
        dtpNgaySinh.Name = "dtpNgaySinh"
        dtpNgaySinh.Size = New Size(368, 39)
        dtpNgaySinh.TabIndex = 1
        ' 
        ' lblGioiTinh
        ' 
        lblGioiTinh.AutoSize = True
        lblGioiTinh.Location = New Point(28, 160)
        lblGioiTinh.Margin = New Padding(6, 0, 6, 0)
        lblGioiTinh.Name = "lblGioiTinh"
        lblGioiTinh.Size = New Size(110, 32)
        lblGioiTinh.TabIndex = 2
        lblGioiTinh.Text = "Giới tính:"
        ' 
        ' radNam
        ' 
        radNam.AutoSize = True
        radNam.Checked = True
        radNam.Location = New Point(279, 156)
        radNam.Margin = New Padding(6, 6, 6, 6)
        radNam.Name = "radNam"
        radNam.Size = New Size(96, 36)
        radNam.TabIndex = 3
        radNam.TabStop = True
        radNam.Text = "Nam"
        radNam.UseVisualStyleBackColor = True
        ' 
        ' radNu
        ' 
        radNu.AutoSize = True
        radNu.Location = New Point(409, 156)
        radNu.Margin = New Padding(6, 6, 6, 6)
        radNu.Name = "radNu"
        radNu.Size = New Size(77, 36)
        radNu.TabIndex = 4
        radNu.Text = "Nữ"
        radNu.UseVisualStyleBackColor = True
        ' 
        ' chkDongY
        ' 
        chkDongY.AutoSize = True
        chkDongY.Location = New Point(28, 245)
        chkDongY.Margin = New Padding(6, 6, 6, 6)
        chkDongY.Name = "chkDongY"
        chkDongY.Size = New Size(410, 36)
        chkDongY.TabIndex = 5
        chkDongY.Text = "Tôi đồng ý với điều khoản dịch vụ"
        chkDongY.UseVisualStyleBackColor = True
        ' 
        ' btnDangKy
        ' 
        btnDangKy.Location = New Point(176, 747)
        btnDangKy.Margin = New Padding(6, 6, 6, 6)
        btnDangKy.Name = "btnDangKy"
        btnDangKy.Size = New Size(186, 64)
        btnDangKy.TabIndex = 2
        btnDangKy.Text = "Đăng Ký"
        btnDangKy.UseVisualStyleBackColor = True
        ' 
        ' btnLamMoi
        ' 
        btnLamMoi.Location = New Point(399, 747)
        btnLamMoi.Margin = New Padding(6, 6, 6, 6)
        btnLamMoi.Name = "btnLamMoi"
        btnLamMoi.Size = New Size(186, 64)
        btnLamMoi.TabIndex = 3
        btnLamMoi.Text = "Làm Mới"
        btnLamMoi.UseVisualStyleBackColor = True
        ' 
        ' epCheck
        ' 
        epCheck.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(743, 843)
        Controls.Add(grpCaNhan)
        Controls.Add(grpBoSung)
        Controls.Add(btnDangKy)
        Controls.Add(btnLamMoi)
        Margin = New Padding(6, 6, 6, 6)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Đăng Ký Tài Khoản"
        grpCaNhan.ResumeLayout(False)
        grpCaNhan.PerformLayout()
        grpBoSung.ResumeLayout(False)
        grpBoSung.PerformLayout()
        CType(epCheck, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpCaNhan As GroupBox
    Friend WithEvents lblTenDangNhap As Label
    Friend WithEvents txtTenDangNhap As TextBox
    Friend WithEvents lblMatKhau As Label
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents lblXacNhan As Label
    Friend WithEvents txtXacNhanMatKhau As TextBox
    Friend WithEvents grpBoSung As GroupBox
    Friend WithEvents lblNgaySinh As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents lblGioiTinh As Label
    Friend WithEvents radNam As RadioButton
    Friend WithEvents radNu As RadioButton
    Friend WithEvents chkDongY As CheckBox
    Friend WithEvents btnDangKy As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents epCheck As ErrorProvider

End Class
