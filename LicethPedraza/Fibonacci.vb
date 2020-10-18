Public Class Fibonacci
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Maximo As Integer = Convert.ToInt32(NumericUpDown1.Value)
        Dim Resultado As String = "0"

        If Maximo > 0 Then
            Dim Fibonacci(Maximo - 1) As Long

            For i As Integer = 0 To Maximo - 1
                If i < 2 Then
                    Fibonacci(i) = i
                Else
                    Fibonacci(i) = (Fibonacci(i - 2) + Fibonacci(i - 1))
                End If
            Next

            Resultado = String.Join(", ", Fibonacci)
        End If

        MsgBox(Resultado, MsgBoxStyle.Information, "Resultado de Fibonacci")
    End Sub
End Class