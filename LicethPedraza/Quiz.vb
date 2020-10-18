Public Class Quiz
    Private Preguntas As List(Of Pregunta) = New List(Of Pregunta)
    Private PreguntaActual As Integer = 0
    Private RespuestasUsuario(4) As Integer
    Private Contador As Integer

    Private Sub Quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resetear()
    End Sub

    Private Sub DefinirPreguntas()
        PreguntaUno()
        PreguntaDos()
        PreguntaTres()
        PreguntaCuatro()
        PreguntaCinco()
    End Sub
    Private Sub CargarPregunta()
        Dim Pregunta As Pregunta = Preguntas.ToArray()(PreguntaActual)
        Dim Respuestas As Array = Pregunta.Respuestas.ToArray()

        LabelPregunta.Text = Pregunta.Texto
        RadioButton1.Text = Respuestas(0).Texto
        RadioButton2.Text = Respuestas(1).Texto
        RadioButton3.Text = Respuestas(2).Texto
        RadioButton4.Text = Respuestas(3).Texto

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rb = GroupBox1.Controls.OfType(Of RadioButton).
                       FirstOrDefault(Function(w) w.Checked)

        If rb IsNot Nothing Then
            RespuestasUsuario(PreguntaActual) = (Convert.ToInt32(rb.Name.Substring(rb.Name.Length - 1)) - 1)

            If (PreguntaActual < 4) Then
                PreguntaActual = PreguntaActual + 1
                CargarPregunta()
            Else
                EvaluarResultado()
            End If
        End If
    End Sub
    Private Sub EvaluarResultado()
        Dim RespuestasCorrectas As Integer = 0

        For i As Integer = 0 To 4
            Dim Selecciono As Integer = RespuestasUsuario(i)
            Dim Respuesta As Respuesta = Preguntas.ToArray()(i).Respuestas.ToArray()(Selecciono)
            If Respuesta.EsCorrecta Then
                RespuestasCorrectas = RespuestasCorrectas + 1
            End If
        Next

        If RespuestasCorrectas.Equals(5) Then
            MsgBox("¡El estudiante aprobó el examen!")
        Else
            MsgBox($"El estudiante reprobó el examen con una calificación de {RespuestasCorrectas}/5. Al hacer click en aceptar el quiz se puede presentar nuevamente")
        End If

        Resetear()
    End Sub

    Private Sub LabelPregunta_Click(sender As Object, e As EventArgs) Handles LabelPregunta.Click

    End Sub
    Private Sub Resetear()
        PreguntaActual = 0
        RespuestasUsuario = {-1, -1, -1, -1, -1}
        DefinirPreguntas()
        CargarPregunta()
        Contador = 120
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Contador = Contador - 1

        LabelContador.Text = Contador

        If Contador.Equals(0) Then
            Timer1.Enabled = False
            MsgBox("Tiempo Finalizado, el estudiante puede volver a realizar el quiz al dar click en el botón: Aceptar. Este se reiniciará automáticamente")
            Resetear()
        End If
    End Sub
    Private Sub PreguntaUno()
        Dim Respuestas As List(Of Respuesta) = New List(Of Respuesta)
        Respuestas.Add(New Respuesta With {
            .Texto = "Entero",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Real",
            .EsCorrecta = True
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Decimal",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Lógico",
            .EsCorrecta = False
        })
        Preguntas.Add(New Pregunta With {
            .Texto = "¿el tipo de dato que permite almacenar variables con decimales es?",
            .Respuestas = Respuestas
        })
    End Sub
    Private Sub PreguntaDos()
        Dim Respuestas As List(Of Respuesta) = New List(Of Respuesta)
        Respuestas.Add(New Respuesta With {
            .Texto = "Integer",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Boolean",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Double",
            .EsCorrecta = True
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Char",
            .EsCorrecta = False
        })
        Preguntas.Add(New Pregunta With {
            .Texto = "Si se desea almacenar en una variable el valor 4,675 ¿qué tipo de dato se declara la variable?",
            .Respuestas = Respuestas
        })
    End Sub
    Private Sub PreguntaTres()
        Dim Respuestas As List(Of Respuesta) = New List(Of Respuesta)
        Respuestas.Add(New Respuesta With {
            .Texto = "12345",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "12.345",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "True, false",
            .EsCorrecta = True
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Abcd, abc123",
            .EsCorrecta = False
        })
        Preguntas.Add(New Pregunta With {
            .Texto = "El tipo de dato Boolean, ¿Qué tipo de datos almacena?",
            .Respuestas = Respuestas
        })
    End Sub
    Private Sub PreguntaCuatro()
        Dim Respuestas As List(Of Respuesta) = New List(Of Respuesta)
        Respuestas.Add(New Respuesta With {
            .Texto = "Suma, resta, multiplicación y división",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Condicionales",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "<=, >=, <>, ==",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "And, or, not",
            .EsCorrecta = True
        })
        Preguntas.Add(New Pregunta With {
            .Texto = "¿Cuáles son los operadores lógicos?",
            .Respuestas = Respuestas
        })
    End Sub
    Private Sub PreguntaCinco()
        Dim Respuestas As List(Of Respuesta) = New List(Of Respuesta)
        Respuestas.Add(New Respuesta With {
            .Texto = "Condicionales",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Relacionales",
            .EsCorrecta = True
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Aritméticos",
            .EsCorrecta = False
        })
        Respuestas.Add(New Respuesta With {
            .Texto = "Lógicos",
            .EsCorrecta = False
        })
        Preguntas.Add(New Pregunta With {
            .Texto = "Los siguientes símbolos >, <, =,>=, <=, ==, ¿son operadores?",
            .Respuestas = Respuestas
        })
    End Sub
End Class