Public Class InicioSesion
    Private IntentosRestantes As Integer = 3
    Private Usuario As String = "admin"
    Private Contrasena As String = "usuario123"
    Private SegundosRestantes As Integer
    Private Oculto As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(TextBoxUsuario.Text) = False And String.IsNullOrEmpty(TextBoxContrasena.Text) = False) Then
            If TextBoxUsuario.Text.Equals(Usuario) And TextBoxContrasena.Text.Equals(Contrasena) Then
                MsgBox("Datos correctos, sesión inicada exitósamente")
                Resetear()
            Else
                MsgBox("Datos incorrectos")

                IntentosRestantes = IntentosRestantes - 1

                LabelIntentosRestantes.Text = IntentosRestantes

                If IntentosRestantes.Equals(0) Then
                    Ocultar()
                    TextBoxUsuario.Text = ""
                    TextBoxContrasena.Text = ""
                    SegundosRestantes = ObtenerSegundos()
                End If
            End If
        Else
                MsgBox("El campo usuario y contraseña son obligatorios")
        End If
    End Sub

    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resetear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SegundosRestantes = SegundosRestantes - 1

        Contador.Text = SegundosRestantes

        If SegundosRestantes.Equals(0) Then
            Timer1.Enabled = False

            If Oculto Then
                Mostrar()
            Else
                MsgBox("Tiempo Finalizado")
                Ocultar()
            End If

            SegundosRestantes = ObtenerSegundos()
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Resetear()
        SegundosRestantes = ObtenerSegundos()
        IntentosRestantes = 3
        Timer1.Enabled = True
        TextBoxUsuario.Text = ""
        TextBoxContrasena.Text = ""
        Mostrar()
        LabelIntentosRestantes.Text = IntentosRestantes
    End Sub
    Private Sub Ocultar()
        TextBoxUsuario.Hide()
        TextBoxContrasena.Hide()
        Label1.Hide()
        Label2.Hide()
        Button1.Hide()
        Oculto = True
    End Sub
    Private Sub Mostrar()
        TextBoxUsuario.Show()
        TextBoxContrasena.Show()
        Label1.Show()
        Label2.Show()
        Button1.Show()
        Oculto = False
        IntentosRestantes = 3
        LabelIntentosRestantes.Text = IntentosRestantes
    End Sub
    Private Function ObtenerSegundos()
        Return 60
    End Function
End Class