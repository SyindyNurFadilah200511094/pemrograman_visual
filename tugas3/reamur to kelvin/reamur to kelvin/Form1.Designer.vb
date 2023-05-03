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
        Me.txtreamur = New System.Windows.Forms.TextBox()
        Me.btnkonversi = New System.Windows.Forms.Button()
        Me.txtkelvin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reamur to Kelvin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Reamur"
        '
        'txtreamur
        '
        Me.txtreamur.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreamur.Location = New System.Drawing.Point(237, 223)
        Me.txtreamur.Name = "txtreamur"
        Me.txtreamur.Size = New System.Drawing.Size(199, 30)
        Me.txtreamur.TabIndex = 2
        '
        'btnkonversi
        '
        Me.btnkonversi.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnkonversi.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkonversi.Location = New System.Drawing.Point(276, 282)
        Me.btnkonversi.Name = "btnkonversi"
        Me.btnkonversi.Size = New System.Drawing.Size(132, 47)
        Me.btnkonversi.TabIndex = 3
        Me.btnkonversi.Text = "Konversi"
        Me.btnkonversi.UseVisualStyleBackColor = False
        '
        'txtkelvin
        '
        Me.txtkelvin.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkelvin.Location = New System.Drawing.Point(237, 388)
        Me.txtkelvin.Name = "txtkelvin"
        Me.txtkelvin.Size = New System.Drawing.Size(199, 30)
        Me.txtkelvin.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(301, 347)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kelvin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(473, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Syindy Nur Fadilah"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 498)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtkelvin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnkonversi)
        Me.Controls.Add(Me.txtreamur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Konversi Suhu - Syindy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtreamur As TextBox
    Friend WithEvents btnkonversi As Button
    Friend WithEvents txtkelvin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
