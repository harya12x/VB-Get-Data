﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.npm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(97, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(720, 262)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mahasiswa"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.npm, Me.nama, Me.jurusan, Me.prodi, Me.kelas})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 85)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(671, 122)
        Me.DataGridView1.TabIndex = 3
        '
        'npm
        '
        Me.npm.HeaderText = "NPM"
        Me.npm.Name = "npm"
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        '
        'jurusan
        '
        Me.jurusan.HeaderText = "Jurusan"
        Me.jurusan.Name = "jurusan"
        '
        'prodi
        '
        Me.prodi.HeaderText = "Prodi"
        Me.prodi.Name = "prodi"
        '
        'kelas
        '
        Me.kelas.HeaderText = "Kelas"
        Me.kelas.Name = "kelas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 609)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents npm As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents jurusan As DataGridViewTextBoxColumn
    Friend WithEvents prodi As DataGridViewTextBoxColumn
    Friend WithEvents kelas As DataGridViewTextBoxColumn
End Class
