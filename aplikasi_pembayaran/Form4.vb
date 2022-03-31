Public Class Form4
    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        If MessageBox.Show("yakin membatalkan Login?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Form3.Close()
            Me.Close()
        End If
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            buka()
            Dim a As String
            a = "select * from t_user where username ='" & txt_username.Text & "' ANd password = '" & txt_password.Text & "' "

            rec.Open(a, con)

            If Not rec.EOF Then
                MsgBox("Login Berhasil", MessageBoxIcon.Information)
                Form3.Visible = True
                Form3.Enabled = True
                Form3.txt_admin.Text = txt_username.Text
                Me.Close()
            Else
                MsgBox("Username atau Password Salah")
                txt_username.Text = ""
                txt_password.Text = ""
                txt_username.Select()
            End If
            tutup()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try
    End Sub

End Class

