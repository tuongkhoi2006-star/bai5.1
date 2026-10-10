Public Class Form1

    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        Dim hopLe As Boolean = True

        'Tên đăng nhập không được để trống
        If String.IsNullOrWhiteSpace(txtTenDangNhap.Text) Then
            epCheck.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!")
            hopLe = False
        Else
            epCheck.SetError(txtTenDangNhap, String.Empty)
        End If

        'Mật khẩu không được để trống
        If String.IsNullOrWhiteSpace(txtMatKhau.Text) Then
            epCheck.SetError(txtMatKhau, "Mật khẩu không được để trống!")
            hopLe = False
        Else
            epCheck.SetError(txtMatKhau, String.Empty)
        End If

        'Mật khẩu nhập lại phải khớp
        If txtXacNhanMatKhau.Text <> txtMatKhau.Text Then
            epCheck.SetError(txtXacNhanMatKhau, "Mật khẩu nhập lại không khớp!")
            hopLe = False
        Else
            epCheck.SetError(txtXacNhanMatKhau, String.Empty)
        End If

        'Tuổi tính từ ngày sinh phải >= 18
        Dim tuoi As Integer = DateTime.Today.Year - dtpNgaySinh.Value.Year
        If dtpNgaySinh.Value.Date > DateTime.Today.AddYears(-tuoi) Then
            tuoi -= 1
        End If
        If tuoi < 18 Then
            epCheck.SetError(dtpNgaySinh, "Bạn phải từ 18 tuổi trở lên!")
            hopLe = False
        Else
            epCheck.SetError(dtpNgaySinh, String.Empty)
        End If

        'Phải đồng ý điều khoản dịch vụ
        If Not chkDongY.Checked Then
            epCheck.SetError(chkDongY, "Bạn phải đồng ý với điều khoản dịch vụ!")
            hopLe = False
        Else
            epCheck.SetError(chkDongY, String.Empty)
        End If

        If hopLe Then
            MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        txtTenDangNhap.Clear()
        txtMatKhau.Clear()
        txtXacNhanMatKhau.Clear()
        dtpNgaySinh.Value = DateTime.Today
        radNam.Checked = True
        chkDongY.Checked = False
        epCheck.Clear()
        txtTenDangNhap.Focus()
    End Sub

End Class
