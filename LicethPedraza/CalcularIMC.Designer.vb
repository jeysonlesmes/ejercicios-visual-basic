﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcularIMC
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
        Me.Peso = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Altura = New System.Windows.Forms.NumericUpDown()
        Me.CalcularBtn = New System.Windows.Forms.Button()
        Me.Resultado = New System.Windows.Forms.Label()
        CType(Me.Peso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Altura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Peso
        '
        Me.Peso.DecimalPlaces = 2
        Me.Peso.Location = New System.Drawing.Point(138, 152)
        Me.Peso.Name = "Peso"
        Me.Peso.Size = New System.Drawing.Size(120, 22)
        Me.Peso.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Peso (Kg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(452, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Altura (m)"
        '
        'Altura
        '
        Me.Altura.DecimalPlaces = 2
        Me.Altura.Location = New System.Drawing.Point(455, 151)
        Me.Altura.Name = "Altura"
        Me.Altura.Size = New System.Drawing.Size(120, 22)
        Me.Altura.TabIndex = 3
        '
        'CalcularBtn
        '
        Me.CalcularBtn.Location = New System.Drawing.Point(341, 210)
        Me.CalcularBtn.Name = "CalcularBtn"
        Me.CalcularBtn.Size = New System.Drawing.Size(75, 23)
        Me.CalcularBtn.TabIndex = 4
        Me.CalcularBtn.Text = "Calcular IMC"
        Me.CalcularBtn.UseVisualStyleBackColor = True
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.ForeColor = System.Drawing.Color.Red
        Me.Resultado.Location = New System.Drawing.Point(290, 312)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(0, 17)
        Me.Resultado.TabIndex = 5
        '
        'CalcularIMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.CalcularBtn)
        Me.Controls.Add(Me.Altura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Peso)
        Me.Name = "CalcularIMC"
        Me.Text = "Calcular IMC"
        CType(Me.Peso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Altura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Peso As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Altura As NumericUpDown
    Friend WithEvents CalcularBtn As Button
    Friend WithEvents Resultado As Label
End Class
