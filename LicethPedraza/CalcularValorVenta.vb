Public Class CalcularValorVenta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) = False And NumericUpDown1.Value > 0 And ComboBox1.SelectedIndex > -1 And NumericUpDown2.Value > 0 Then
            Dim PorcentajeIVA As Integer = ObtenerPorcentajeIVA(ComboBox1.SelectedIndex)
            Dim Total As Double = NumericUpDown1.Value * NumericUpDown2.Value
            Dim ValorIVA As Double = ObtenerValorIVA(Total, PorcentajeIVA)

            LabelIVA.Text = FormatoMoneda(ValorIVA)
            LabelTotalNeto.Text = FormatoMoneda(Total)
            LabelTotal.Text = FormatoMoneda(Total + ValorIVA)
        Else
            MsgBox("Todos los campos son requeridos")
        End If
    End Sub
    Private Function ObtenerPorcentajeIVA(Categoria As Integer)
        If Categoria.Equals(0) Then
            Return 15
        ElseIf Categoria.Equals(1) Then
            Return 16
        End If

        Return 19
    End Function
    Private Function ObtenerValorIVA(Total As Double, PorcentajeIVA As Integer)
        Return (Total * PorcentajeIVA) / 100
    End Function
    Private Function FormatoMoneda(Valor As Double)
        Return "$ " + String.Format("{0:n}", Valor)
    End Function
End Class