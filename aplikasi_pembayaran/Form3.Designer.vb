<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_jenis_pembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_jenis_pembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nominal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tahun_ajaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_ajaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.id_tahunajar = New System.Windows.Forms.TextBox()
        Me.id_jenisbayar = New System.Windows.Forms.TextBox()
        Me.txt_kembali = New System.Windows.Forms.TextBox()
        Me.txt_bayar = New System.Windows.Forms.TextBox()
        Me.simpan = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.txt_nominal = New System.Windows.Forms.TextBox()
        Me.txt_tahunajar = New System.Windows.Forms.TextBox()
        Me.txt_bulan = New System.Windows.Forms.TextBox()
        Me.txt_nama_jenisbayar = New System.Windows.Forms.TextBox()
        Me.txt_nis = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_admin = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nis, Me.nama_siswa, Me.id_jenis_pembayaran, Me.nama_jenis_pembayaran, Me.id_bulan, Me.nominal, Me.id_tahun_ajaran, Me.tahun_ajaran, Me.keterangan})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 102)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(794, 169)
        Me.DataGridView1.TabIndex = 0
        '
        'nis
        '
        Me.nis.HeaderText = "NIS"
        Me.nis.Name = "nis"
        '
        'nama_siswa
        '
        Me.nama_siswa.HeaderText = "Nama"
        Me.nama_siswa.Name = "nama_siswa"
        '
        'id_jenis_pembayaran
        '
        Me.id_jenis_pembayaran.HeaderText = "Id Jenis bayar"
        Me.id_jenis_pembayaran.Name = "id_jenis_pembayaran"
        Me.id_jenis_pembayaran.Visible = False
        '
        'nama_jenis_pembayaran
        '
        Me.nama_jenis_pembayaran.HeaderText = "Jenis Pembayaran"
        Me.nama_jenis_pembayaran.Name = "nama_jenis_pembayaran"
        '
        'id_bulan
        '
        Me.id_bulan.HeaderText = "Bulan Ke"
        Me.id_bulan.Name = "id_bulan"
        '
        'nominal
        '
        Me.nominal.HeaderText = "Nominal"
        Me.nominal.Name = "nominal"
        '
        'id_tahun_ajaran
        '
        Me.id_tahun_ajaran.HeaderText = "ID tahun ajaran"
        Me.id_tahun_ajaran.Name = "id_tahun_ajaran"
        Me.id_tahun_ajaran.Visible = False
        '
        'tahun_ajaran
        '
        Me.tahun_ajaran.HeaderText = "Tahun Ajaran"
        Me.tahun_ajaran.Name = "tahun_ajaran"
        '
        'keterangan
        '
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.id_tahunajar)
        Me.GroupBox1.Controls.Add(Me.id_jenisbayar)
        Me.GroupBox1.Controls.Add(Me.txt_kembali)
        Me.GroupBox1.Controls.Add(Me.txt_bayar)
        Me.GroupBox1.Controls.Add(Me.simpan)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.txt_ket)
        Me.GroupBox1.Controls.Add(Me.txt_nominal)
        Me.GroupBox1.Controls.Add(Me.txt_tahunajar)
        Me.GroupBox1.Controls.Add(Me.txt_bulan)
        Me.GroupBox1.Controls.Add(Me.txt_nama_jenisbayar)
        Me.GroupBox1.Controls.Add(Me.txt_nis)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(144, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(854, 586)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'id_tahunajar
        '
        Me.id_tahunajar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.id_tahunajar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.id_tahunajar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_tahunajar.ForeColor = System.Drawing.SystemColors.Control
        Me.id_tahunajar.Location = New System.Drawing.Point(156, 503)
        Me.id_tahunajar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.id_tahunajar.Name = "id_tahunajar"
        Me.id_tahunajar.ReadOnly = True
        Me.id_tahunajar.ShortcutsEnabled = False
        Me.id_tahunajar.Size = New System.Drawing.Size(76, 20)
        Me.id_tahunajar.TabIndex = 13
        Me.id_tahunajar.Visible = False
        '
        'id_jenisbayar
        '
        Me.id_jenisbayar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.id_jenisbayar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.id_jenisbayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_jenisbayar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.id_jenisbayar.Location = New System.Drawing.Point(67, 503)
        Me.id_jenisbayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.id_jenisbayar.Name = "id_jenisbayar"
        Me.id_jenisbayar.ReadOnly = True
        Me.id_jenisbayar.ShortcutsEnabled = False
        Me.id_jenisbayar.Size = New System.Drawing.Size(76, 20)
        Me.id_jenisbayar.TabIndex = 13
        Me.id_jenisbayar.Visible = False
        '
        'txt_kembali
        '
        Me.txt_kembali.Location = New System.Drawing.Point(473, 367)
        Me.txt_kembali.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_kembali.Name = "txt_kembali"
        Me.txt_kembali.ReadOnly = True
        Me.txt_kembali.Size = New System.Drawing.Size(202, 20)
        Me.txt_kembali.TabIndex = 10
        '
        'txt_bayar
        '
        Me.txt_bayar.Location = New System.Drawing.Point(472, 292)
        Me.txt_bayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_bayar.Name = "txt_bayar"
        Me.txt_bayar.Size = New System.Drawing.Size(202, 20)
        Me.txt_bayar.TabIndex = 10
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(417, 401)
        Me.simpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(257, 30)
        Me.simpan.TabIndex = 9
        Me.simpan.Text = "SIMPAN"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(548, 323)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 30)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "bayar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(417, 323)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(196, 322)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.ReadOnly = True
        Me.txt_nama.Size = New System.Drawing.Size(172, 20)
        Me.txt_nama.TabIndex = 8
        '
        'txt_ket
        '
        Me.txt_ket.Location = New System.Drawing.Point(196, 470)
        Me.txt_ket.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.ReadOnly = True
        Me.txt_ket.Size = New System.Drawing.Size(172, 20)
        Me.txt_ket.TabIndex = 8
        '
        'txt_nominal
        '
        Me.txt_nominal.Location = New System.Drawing.Point(196, 442)
        Me.txt_nominal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nominal.Name = "txt_nominal"
        Me.txt_nominal.ReadOnly = True
        Me.txt_nominal.Size = New System.Drawing.Size(172, 20)
        Me.txt_nominal.TabIndex = 8
        '
        'txt_tahunajar
        '
        Me.txt_tahunajar.Location = New System.Drawing.Point(196, 414)
        Me.txt_tahunajar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_tahunajar.Name = "txt_tahunajar"
        Me.txt_tahunajar.ReadOnly = True
        Me.txt_tahunajar.Size = New System.Drawing.Size(172, 20)
        Me.txt_tahunajar.TabIndex = 8
        '
        'txt_bulan
        '
        Me.txt_bulan.Location = New System.Drawing.Point(196, 383)
        Me.txt_bulan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_bulan.Name = "txt_bulan"
        Me.txt_bulan.ReadOnly = True
        Me.txt_bulan.Size = New System.Drawing.Size(172, 20)
        Me.txt_bulan.TabIndex = 8
        '
        'txt_nama_jenisbayar
        '
        Me.txt_nama_jenisbayar.Location = New System.Drawing.Point(196, 350)
        Me.txt_nama_jenisbayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nama_jenisbayar.Name = "txt_nama_jenisbayar"
        Me.txt_nama_jenisbayar.ReadOnly = True
        Me.txt_nama_jenisbayar.Size = New System.Drawing.Size(172, 20)
        Me.txt_nama_jenisbayar.TabIndex = 8
        '
        'txt_nis
        '
        Me.txt_nis.Location = New System.Drawing.Point(196, 292)
        Me.txt_nis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nis.Name = "txt_nis"
        Me.txt_nis.ReadOnly = True
        Me.txt_nis.Size = New System.Drawing.Size(172, 20)
        Me.txt_nis.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(414, 367)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Kembali"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(64, 470)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Keterangan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(414, 292)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 442)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nominal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 414)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tahun Ajaran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 383)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Pembayaran Bulan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 53)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Form Pembayaran"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Input Pembayaran Baru :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 350)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Jenis Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 323)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nama "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 292)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Admin : "
        '
        'txt_admin
        '
        Me.txt_admin.AutoSize = True
        Me.txt_admin.Location = New System.Drawing.Point(59, 22)
        Me.txt_admin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txt_admin.Name = "txt_admin"
        Me.txt_admin.Size = New System.Drawing.Size(10, 13)
        Me.txt_admin.TabIndex = 3
        Me.txt_admin.Text = "-"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.txt_admin)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nominal As TextBox
    Friend WithEvents txt_tahunajar As TextBox
    Friend WithEvents txt_bulan As TextBox
    Friend WithEvents txt_nama_jenisbayar As TextBox
    Friend WithEvents txt_nis As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_bayar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_kembali As TextBox
    Friend WithEvents id_tahunajar As TextBox
    Friend WithEvents id_jenisbayar As TextBox
    Friend WithEvents nis As DataGridViewTextBoxColumn
    Friend WithEvents nama_siswa As DataGridViewTextBoxColumn
    Friend WithEvents id_jenis_pembayaran As DataGridViewTextBoxColumn
    Friend WithEvents nama_jenis_pembayaran As DataGridViewTextBoxColumn
    Friend WithEvents id_bulan As DataGridViewTextBoxColumn
    Friend WithEvents nominal As DataGridViewTextBoxColumn
    Friend WithEvents id_tahun_ajaran As DataGridViewTextBoxColumn
    Friend WithEvents tahun_ajaran As DataGridViewTextBoxColumn
    Friend WithEvents keterangan As DataGridViewTextBoxColumn
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_ket As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents simpan As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_admin As Label
End Class
