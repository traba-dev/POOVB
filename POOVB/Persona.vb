Public Class Persona

    Private Name As String
    Private Age As Int32
    Private DNI As String
    Private Marrige As Boolean

    Public Sub New(ByVal Name As String, ByVal Age As Int32, ByVal DNI As String, ByVal Marrige As Boolean)
        Me.Name = Name
        Me.Age = Age
        Me.DNI = DNI
        Me.Marrige = Marrige
    End Sub

    Public Property NameProp() As String
        Get
            Return Me.Name
        End Get
        Set(ByVal value As String)
            Me.Name = value
        End Set
    End Property

    Public Property AgeProp() As Int32
        Get
            Return Me.Age
        End Get
        Set(ByVal value As Int32)
            Me.Age = value
        End Set
    End Property


    Public Property DNIProp() As String
        Get
            Return Me.DNI
        End Get
        Set(ByVal value As String)
            Me.DNI = value
        End Set
    End Property

    Public Property MarrigeProp() As String
        Get
            Return Me.Marrige
        End Get
        Set(ByVal value As String)
            If Me.Age < 18 Then
                Me.Marrige = False
            Else
                Me.Marrige = value
            End If

        End Set
    End Property

    Public Overridable Function ToString() As String
        Return String.Format("El nombre de la persona es {0} y su edad es {1}", Me.Name, Me.Age)
    End Function

    Public Overridable Function Hobbies() As String
        Return String.Format("Mis Hobbies son:")
    End Function

End Class
