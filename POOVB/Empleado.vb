Public Class Empleado : Inherits Persona

    Private Puesto As String
    Private Salario As Decimal
    Public Property SalarioProperty() As Decimal
        Get
            Return Salario
        End Get
        Set(ByVal value As Decimal)
            Salario = value
        End Set
    End Property
    Public Property PuestoProperty() As String
        Get
            Return Puesto
        End Get
        Set(ByVal value As String)
            Puesto = value
        End Set
    End Property

    Public Sub New(ByVal Name As String, ByVal Age As Int32, ByVal DNI As String, ByVal Marrige As Boolean,
                   ByVal Puesto As String, ByVal Salario As Decimal)
        MyBase.New(Name, Age, DNI, Marrige)
        Me.Puesto = Puesto
        Me.Salario = Salario
    End Sub

    Public Overrides Function toString() As String
        Return MyBase.ToString() & String.Format(" Trabaja en el puesto de {0} y su salario es {1}", Me.Puesto, Me.Salario)
    End Function

    Public Overrides Function Hobbies() As String
        Return MyBase.Hobbies() & String.Format(" jugar Playstation y ver Anime")
    End Function

End Class
