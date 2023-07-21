<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtTgl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJns_kostum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNPS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtUkuran = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Harga = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(562, 156)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 32)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(562, 73)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(125, 32)
        Me.btnSubmit.TabIndex = 37
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(562, 113)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 32)
        Me.btnClear.TabIndex = 36
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtTgl
        '
        Me.txtTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgl.Location = New System.Drawing.Point(295, 200)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Size = New System.Drawing.Size(199, 24)
        Me.txtTgl.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(164, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Tanggal Sewa"
        '
        'txtJns_kostum
        '
        Me.txtJns_kostum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJns_kostum.Location = New System.Drawing.Point(295, 160)
        Me.txtJns_kostum.Name = "txtJns_kostum"
        Me.txtJns_kostum.Size = New System.Drawing.Size(199, 24)
        Me.txtJns_kostum.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Jns Kostum"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(295, 117)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(199, 24)
        Me.txtNama.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(164, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nama"
        '
        'txtNPS
        '
        Me.txtNPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPS.Location = New System.Drawing.Point(295, 77)
        Me.txtNPS.Name = "txtNPS"
        Me.txtNPS.Size = New System.Drawing.Size(199, 24)
        Me.txtNPS.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "NPS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 27
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(167, 320)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(797, 243)
        Me.dgvData.TabIndex = 26
        '
        'txtUkuran
        '
        Me.txtUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUkuran.Location = New System.Drawing.Point(295, 241)
        Me.txtUkuran.Name = "txtUkuran"
        Me.txtUkuran.Size = New System.Drawing.Size(199, 24)
        Me.txtUkuran.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(164, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Ukuran"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(295, 279)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(199, 24)
        Me.txtHarga.TabIndex = 42
        '
        'Harga
        '
        Me.Harga.AutoSize = True
        Me.Harga.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harga.Location = New System.Drawing.Point(164, 279)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(52, 20)
        Me.Harga.TabIndex = 41
        Me.Harga.Text = "Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Syindy Nur Fadilah - 200511094"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(997, 651)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Harga)
        Me.Controls.Add(Me.txtUkuran)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTgl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtJns_kostum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNPS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTgl As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJns_kostum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNPS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtUkuran As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Harga As Label
    Friend WithEvents Label8 As Label
End Class
