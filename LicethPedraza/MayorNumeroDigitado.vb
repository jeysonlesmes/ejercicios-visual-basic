Public Class MayorNumeroDigitado
    Private Numeros As List(Of Integer) = New List(Of Integer)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Numeros.Count > 0 Then
            Dim ArrayNumeros As Array = Numeros.ToArray()
            Dim NumeroMayor As Integer = 0

            For i As Integer = 0 To Numeros.Count - 1
                If ArrayNumeros(i) > NumeroMayor Then
                    NumeroMayor = ArrayNumeros(i)
                End If
            Next

            MsgBox($"El número mayor es: {NumeroMayor}")
        Else
            MsgBox("Debe ingresar al menos un número")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Numeros.Add(Convert.ToInt32(NumericUpDown1.Value))
        NumericUpDown1.Value = 0

        NumerosAgregados.Text = String.Join(", ", Numeros.ToArray())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NumerosAgregados.Text = ""
        Numeros = New List(Of Integer)
        NumericUpDown1.Value = 0
    End Sub
End Class