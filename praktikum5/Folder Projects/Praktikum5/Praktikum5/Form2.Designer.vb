<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Keterangan = New System.Windows.Forms.Label()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Syindy Nur Fadilah"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(63, 114)
        Me.txtKeterangan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(355, 22)
        Me.txtKeterangan.TabIndex = 10
        '
        'Keterangan
        '
        Me.Keterangan.AutoSize = True
        Me.Keterangan.Location = New System.Drawing.Point(60, 95)
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Size = New System.Drawing.Size(82, 17)
        Me.Keterangan.TabIndex = 9
        Me.Keterangan.Text = "Keterangan"
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(63, 46)
        Me.txtUmur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(283, 22)
        Me.txtUmur.TabIndex = 8
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(351, 46)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(67, 30)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Umur"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(477, 204)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Keterangan)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Kategori Usia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Keterangan As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
End Class
