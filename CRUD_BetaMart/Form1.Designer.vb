<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tPabrik = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tStok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tHarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tKategori = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bClear = New System.Windows.Forms.Button()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.tSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tPabrik)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tStok)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tHarga)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tKategori)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Controls.Add(Me.tNama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 384)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(339, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 40)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "BETAMART"
        '
        'tPabrik
        '
        Me.tPabrik.Location = New System.Drawing.Point(173, 334)
        Me.tPabrik.Name = "tPabrik"
        Me.tPabrik.Size = New System.Drawing.Size(199, 23)
        Me.tPabrik.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pabrik"
        '
        'tStok
        '
        Me.tStok.Location = New System.Drawing.Point(173, 237)
        Me.tStok.Name = "tStok"
        Me.tStok.Size = New System.Drawing.Size(199, 23)
        Me.tStok.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stok"
        '
        'tHarga
        '
        Me.tHarga.Location = New System.Drawing.Point(173, 282)
        Me.tHarga.Name = "tHarga"
        Me.tHarga.Size = New System.Drawing.Size(199, 23)
        Me.tHarga.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Harga"
        '
        'tKategori
        '
        Me.tKategori.Location = New System.Drawing.Point(173, 192)
        Me.tKategori.Name = "tKategori"
        Me.tKategori.Size = New System.Drawing.Size(199, 23)
        Me.tKategori.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kategori"
        '
        'bClear
        '
        Me.bClear.Location = New System.Drawing.Point(541, 337)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(134, 29)
        Me.bClear.TabIndex = 2
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(173, 143)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(199, 23)
        Me.tNama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 476)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(776, 201)
        Me.DataGridView1.TabIndex = 1
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(250, 697)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(134, 29)
        Me.bTambah.TabIndex = 11
        Me.bTambah.Text = "Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'bEdit
        '
        Me.bEdit.Location = New System.Drawing.Point(453, 697)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(134, 29)
        Me.bEdit.TabIndex = 12
        Me.bEdit.Text = "Edit"
        Me.bEdit.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(654, 697)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(134, 29)
        Me.bHapus.TabIndex = 13
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'tSearch
        '
        Me.tSearch.Location = New System.Drawing.Point(136, 425)
        Me.tSearch.Name = "tSearch"
        Me.tSearch.Size = New System.Drawing.Size(652, 23)
        Me.tSearch.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Search"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.tSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bClear As Button
    Friend WithEvents tNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tPabrik As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tStok As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tHarga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tKategori As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bHapus As Button
    Friend WithEvents bEdit As Button
    Friend WithEvents bTambah As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tSearch As TextBox
    Friend WithEvents Label6 As Label
End Class
