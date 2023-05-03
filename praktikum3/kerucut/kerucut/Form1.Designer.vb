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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjari = New System.Windows.Forms.TextBox()
        Me.txttinggi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtluaspermukaan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtvolume = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Terstruktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jari - Jari"
        '
        'txtjari
        '
        Me.txtjari.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjari.Location = New System.Drawing.Point(339, 161)
        Me.txtjari.Name = "txtjari"
        Me.txtjari.Size = New System.Drawing.Size(124, 30)
        Me.txtjari.TabIndex = 2
        '
        'txttinggi
        '
        Me.txttinggi.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttinggi.Location = New System.Drawing.Point(339, 216)
        Me.txttinggi.Name = "txttinggi"
        Me.txttinggi.Size = New System.Drawing.Size(124, 30)
        Me.txttinggi.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tinggi"
        '
        'txtluaspermukaan
        '
        Me.txtluaspermukaan.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtluaspermukaan.Location = New System.Drawing.Point(339, 386)
        Me.txtluaspermukaan.Name = "txtluaspermukaan"
        Me.txtluaspermukaan.Size = New System.Drawing.Size(124, 30)
        Me.txtluaspermukaan.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(115, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Luas Permukaan"
        '
        'txtvolume
        '
        Me.txtvolume.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvolume.Location = New System.Drawing.Point(339, 327)
        Me.txtvolume.Name = "txtvolume"
        Me.txtvolume.Size = New System.Drawing.Size(124, 30)
        Me.txtvolume.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Volume"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(578, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Syindy Nur Fadilah"
        '
        'btnhitung
        '
        Me.btnhitung.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnhitung.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.Location = New System.Drawing.Point(339, 267)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(124, 43)
        Me.btnhitung.TabIndex = 11
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 512)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtluaspermukaan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtvolume)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttinggi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtjari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kaerucut - Syindy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjari As TextBox
    Friend WithEvents txttinggi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtluaspermukaan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtvolume As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnhitung As Button
End Class
