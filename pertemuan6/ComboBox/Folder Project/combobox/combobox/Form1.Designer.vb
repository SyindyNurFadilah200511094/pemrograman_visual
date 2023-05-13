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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJenjang = New System.Windows.Forms.TextBox()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.cmbProdi = New System.Windows.Forms.ComboBox()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Tan
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Penentuan Biaya Registrasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Program Studi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenjang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Biaya"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bayar"
        '
        'txtJenjang
        '
        Me.txtJenjang.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenjang.Location = New System.Drawing.Point(241, 164)
        Me.txtJenjang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtJenjang.Name = "txtJenjang"
        Me.txtJenjang.Size = New System.Drawing.Size(160, 32)
        Me.txtJenjang.TabIndex = 6
        '
        'txtBiaya
        '
        Me.txtBiaya.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiaya.Location = New System.Drawing.Point(241, 217)
        Me.txtBiaya.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(335, 32)
        Me.txtBiaya.TabIndex = 7
        '
        'txtBayar
        '
        Me.txtBayar.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(241, 273)
        Me.txtBayar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(335, 32)
        Me.txtBayar.TabIndex = 8
        '
        'cmbProdi
        '
        Me.cmbProdi.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProdi.FormattingEnabled = True
        Me.cmbProdi.Location = New System.Drawing.Point(241, 108)
        Me.cmbProdi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbProdi.Name = "cmbProdi"
        Me.cmbProdi.Size = New System.Drawing.Size(269, 34)
        Me.cmbProdi.TabIndex = 9
        '
        'txtKembalian
        '
        Me.txtKembalian.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembalian.Location = New System.Drawing.Point(241, 401)
        Me.txtKembalian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(344, 32)
        Me.txtKembalian.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Kembalian"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(308, 332)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(203, 47)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(647, 502)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtKembalian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbProdi)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.txtJenjang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJenjang As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents cmbProdi As System.Windows.Forms.ComboBox
    Friend WithEvents txtKembalian As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSubmit As Button
End Class
