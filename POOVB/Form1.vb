Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Empleado As Empleado = New Empleado("Christopher", 26, "503970348", False, "Programador web", 1400000)
        Dim persona As Persona = Empleado
        Dim company As Company = New Company(0, "Gollo", "gollo@gmail.com", "22002200", "3.23432432", "-18.2343243", "A", "Liberia, Costa Rica", "")
        persona.NameProp = "Chris"

        printOut(persona.ToString())
        printOut(persona.Hobbies())

        Dim _RestClient As RestClient = New RestClient()

        _RestClient.EndPointProperty = "https://cwash-cd17c.firebaseapp.com/api/company/register"
        _RestClient.HttpVerbProperty = "P"

        Dim _response As String = String.Empty
        _response = _RestClient.Request(Of Company)(company)
        _response = _RestClient.ResponseProperty

        printOut(_response)


    End Sub

    Sub printOut(ByVal texto As String)
        TextBox1.Text = TextBox1.Text & texto & Environment.NewLine
    End Sub
End Class
