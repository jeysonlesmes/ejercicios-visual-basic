Public Class CalcularIMC
    Private Sub CalcularBtn_Click(sender As Object, e As EventArgs) Handles CalcularBtn.Click
        Dim imc As Double

        If Peso.Value > 0 And Altura.Value > 0 Then
            imc = Peso.Value / (Altura.Value * Altura.Value)

            Resultado.Text = $"Su IMC es de: {imc}"
        Else
            MsgBox("El peso y la altura deben ser mayores de 0")
        End If
    End Sub
End Class
