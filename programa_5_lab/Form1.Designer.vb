<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAmenos = New System.Windows.Forms.Button()
        Me.btnAmas = New System.Windows.Forms.Button()
        Me.btnBmenos = New System.Windows.Forms.Button()
        Me.btnBmas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbA = New System.Windows.Forms.Label()
        Me.lbB = New System.Windows.Forms.Label()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAmenos
        '
        Me.btnAmenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmenos.Location = New System.Drawing.Point(82, 32)
        Me.btnAmenos.Name = "btnAmenos"
        Me.btnAmenos.Size = New System.Drawing.Size(75, 44)
        Me.btnAmenos.TabIndex = 0
        Me.btnAmenos.Text = "-"
        Me.btnAmenos.UseVisualStyleBackColor = True
        '
        'btnAmas
        '
        Me.btnAmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmas.Location = New System.Drawing.Point(240, 31)
        Me.btnAmas.Name = "btnAmas"
        Me.btnAmas.Size = New System.Drawing.Size(75, 45)
        Me.btnAmas.TabIndex = 1
        Me.btnAmas.Text = "+"
        Me.btnAmas.UseVisualStyleBackColor = True
        '
        'btnBmenos
        '
        Me.btnBmenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBmenos.Location = New System.Drawing.Point(82, 164)
        Me.btnBmenos.Name = "btnBmenos"
        Me.btnBmenos.Size = New System.Drawing.Size(75, 46)
        Me.btnBmenos.TabIndex = 2
        Me.btnBmenos.Text = "-"
        Me.btnBmenos.UseVisualStyleBackColor = True
        '
        'btnBmas
        '
        Me.btnBmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBmas.Location = New System.Drawing.Point(240, 164)
        Me.btnBmas.Name = "btnBmas"
        Me.btnBmas.Size = New System.Drawing.Size(75, 46)
        Me.btnBmas.TabIndex = 3
        Me.btnBmas.Text = "+"
        Me.btnBmas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "B"
        '
        'lbA
        '
        Me.lbA.AutoSize = True
        Me.lbA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbA.Location = New System.Drawing.Point(181, 44)
        Me.lbA.Name = "lbA"
        Me.lbA.Size = New System.Drawing.Size(25, 25)
        Me.lbA.TabIndex = 6
        Me.lbA.Text = "0"
        '
        'lbB
        '
        Me.lbB.AutoSize = True
        Me.lbB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbB.Location = New System.Drawing.Point(181, 178)
        Me.lbB.Name = "lbB"
        Me.lbB.Size = New System.Drawing.Size(25, 25)
        Me.lbB.TabIndex = 7
        Me.lbB.Text = "0"
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResultado.Location = New System.Drawing.Point(252, 311)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(232, 33)
        Me.lbResultado.TabIndex = 8
        Me.lbResultado.Text = "El resultado es:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Suma"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(389, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Resta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(389, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Multiplicacion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(389, 209)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Division"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(501, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "201907496"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 382)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbResultado)
        Me.Controls.Add(Me.lbB)
        Me.Controls.Add(Me.lbA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBmas)
        Me.Controls.Add(Me.btnBmenos)
        Me.Controls.Add(Me.btnAmas)
        Me.Controls.Add(Me.btnAmenos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAmenos As Button
    Friend WithEvents btnAmas As Button
    Friend WithEvents btnBmenos As Button
    Friend WithEvents btnBmas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbA As Label
    Friend WithEvents lbB As Label
    Friend WithEvents lbResultado As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
End Class
