Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enabled = False
        Me.Visible = False
        Form4.Show()
        simpan.Visible = False

    End Sub

    Private Sub Clear()
        txt_bayar.Text = ""
        txt_nis.Text = "----------------------------------------------"
        txt_nama.Text = "----------------------------------------------"
        id_jenisbayar.Text = ""
        txt_nama_jenisbayar.Text = "----------------------------------------------"
        txt_bulan.Text = "----------------------------------------------"
        txt_nominal.Text = "----------------------------------------------"
        id_tahunajar.Text = ""
        txt_tahunajar.Text = "----------------------------------------------"
        txt_ket.Text = "----------------------------------------------"
        txt_kembali.Text = "----------------------------------------------"
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.WindowState = FormWindowState.Normal
        Form1.Show()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        txt_nis.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txt_nama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        id_jenisbayar.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txt_nama_jenisbayar.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txt_bulan.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txt_nominal.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        id_tahunajar.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        txt_tahunajar.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        txt_ket.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nominal As Integer
        Dim bayar As Integer
        Dim kembali As Integer

        nominal = txt_nominal.Text
        bayar = txt_bayar.Text
        kembali = bayar - nominal
        txt_kembali.Text = kembali

        simpan.Visible = True
    End Sub

    Private Sub simpanapi()
        Dim uriString As String = "http://localhost/apiKon/index.php/Welcome/postData/" & id_jenisbayar.Text.Trim & "/" & txt_nis.Text.Trim & "/" & txt_bulan.Text.Trim & "/99/" & id_tahunajar.Text.Trim & "/" & Format(Date.Now, "yyyy-MM-dd").ToString.Trim & "/" & txt_ket.Text.Trim & "/2"
        Dim uri As New Uri(uriString)
        Dim request As HttpWebRequest = HttpWebRequest.Create(uri)
        request.Method = "POST"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim raw As String = read.ReadToEnd()
        Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(raw)
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            buka()
            Dim a As String
            a = "INSERT INTO t_transaksi VALUES('', '" & txt_nama_jenisbayar.Text & "', '" & txt_nominal.Text & "', '" & txt_bayar.Text & "',
				'" & txt_kembali.Text & "', '" & Format(Date.Now, "yyyy-MM-dd").ToString & "', 
				'" & txt_admin.Text & "')"
            con.Execute(a)

            Dim b As String
            b = "INSERT INTO t_pembayaran_online VALUES('', '" & id_jenisbayar.Text & "', '" & txt_nis.Text & "', '" & txt_bulan.Text & "',
				'" & "99" & "', '" & id_tahunajar.Text & "', '" & Format(Date.Now, "yyyy-MM-dd").ToString & "', '" & txt_ket.Text & "', 
				'" & "2" & "')"
            con.Execute(b)
            tutup()

            simpanapi()

            MsgBox("Transaksi Sukses", MsgBoxStyle.Information, "Pemberitahuan")
            Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi")
        End Try
        simpan.Visible = False
    End Sub


End Class