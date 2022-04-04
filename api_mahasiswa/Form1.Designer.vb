<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txt_pencarian = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dg_mahasiswa = New System.Windows.Forms.DataGridView()
        Me.npm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_prodi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_jurusan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_npm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kelas = New System.Windows.Forms.TextBox()
        CType(Me.dg_mahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(138, 192)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(450, 20)
        Me.txt_pencarian.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Pencarian"
        '
        'dg_mahasiswa
        '
        Me.dg_mahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.npm, Me.nama, Me.jurusan, Me.prodi, Me.kelas})
        Me.dg_mahasiswa.Location = New System.Drawing.Point(138, 226)
        Me.dg_mahasiswa.Name = "dg_mahasiswa"
        Me.dg_mahasiswa.Size = New System.Drawing.Size(544, 212)
        Me.dg_mahasiswa.TabIndex = 42
        '
        'npm
        '
        Me.npm.HeaderText = "Npm"
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
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(469, 152)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(55, 30)
        Me.btn_delete.TabIndex = 41
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(393, 152)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(55, 30)
        Me.btn_update.TabIndex = 40
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(320, 152)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(55, 30)
        Me.btn_insert.TabIndex = 39
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(208, 152)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(55, 30)
        Me.btn_cancel.TabIndex = 38
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(138, 152)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(54, 30)
        Me.btn_add.TabIndex = 37
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Kelas"
        '
        'txt_prodi
        '
        Me.txt_prodi.Location = New System.Drawing.Point(139, 92)
        Me.txt_prodi.Name = "txt_prodi"
        Me.txt_prodi.Size = New System.Drawing.Size(450, 20)
        Me.txt_prodi.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Prodi"
        '
        'txt_jurusan
        '
        Me.txt_jurusan.Location = New System.Drawing.Point(139, 66)
        Me.txt_jurusan.Name = "txt_jurusan"
        Me.txt_jurusan.Size = New System.Drawing.Size(450, 20)
        Me.txt_jurusan.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Jurusan"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(139, 40)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(450, 20)
        Me.txt_nama.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nama"
        '
        'txt_npm
        '
        Me.txt_npm.Location = New System.Drawing.Point(139, 12)
        Me.txt_npm.Name = "txt_npm"
        Me.txt_npm.Size = New System.Drawing.Size(125, 20)
        Me.txt_npm.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Npm"
        '
        'txt_kelas
        '
        Me.txt_kelas.Location = New System.Drawing.Point(139, 118)
        Me.txt_kelas.Name = "txt_kelas"
        Me.txt_kelas.Size = New System.Drawing.Size(125, 20)
        Me.txt_kelas.TabIndex = 45
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 450)
        Me.Controls.Add(Me.txt_kelas)
        Me.Controls.Add(Me.txt_pencarian)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dg_mahasiswa)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_prodi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_jurusan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_npm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Mahasiswa"
        CType(Me.dg_mahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dg_mahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_prodi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_jurusan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_npm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents npm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prodi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_kelas As System.Windows.Forms.TextBox

End Class
