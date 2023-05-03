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
        Me.txtjari = New System.Windows.Forms.TextBox()
        Me.txtluas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtkeliling = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari - Jari"
        '
        'txtjari
        '
        Me.txtjari.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjari.Location = New System.Drawing.Point(266, 79)
        Me.txtjari.Multiline = True
        Me.txtjari.Name = "txtjari"
        Me.txtjari.Size = New System.Drawing.Size(162, 45)
        Me.txtjari.TabIndex = 1
        '
        'txtluas
        '
        Me.txtluas.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtluas.Location = New System.Drawing.Point(266, 212)
        Me.txtluas.Multiline = True
        Me.txtluas.Name = "txtluas"
        Me.txtluas.Size = New System.Drawing.Size(162, 45)
        Me.txtluas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Luas"
        '
        'txtkeliling
        '
        Me.txtkeliling.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkeliling.Location = New System.Drawing.Point(266, 287)
        Me.txtkeliling.Multiline = True
        Me.txtkeliling.Name = "txtkeliling"
        Me.txtkeliling.Size = New System.Drawing.Size(162, 45)
        Me.txtkeliling.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Keliling"
        '
        'btnhitung
        '
        Me.btnhitung.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnhitung.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhitung.Location = New System.Drawing.Point(276, 148)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(138, 46)
        Me.btnhitung.TabIndex = 6
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(473, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Syindy Nur Fadilah"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 497)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txtkeliling)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtluas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtjari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "LINGKARAN - Syindy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtjari As TextBox
    Friend WithEvents txtluas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtkeliling As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnhitung As Button
    Friend WithEvents Label4 As Label
End Class
