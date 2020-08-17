Public Class Company

    Private P_id As Int32
    Private P_name As String
    Private P_email As String
    Private P_phone As String
    Private P_lat As String
    Private P_lon As String
    Private P_status As String
    Private P_logo As String
    Private P_address As String
    Public Property address() As String
        Get
            Return P_address
        End Get
        Set(ByVal value As String)
            P_address = value
        End Set
    End Property
    Public Property logo() As String
        Get
            Return P_logo
        End Get
        Set(ByVal value As String)
            P_logo = value
        End Set
    End Property
    Public Property status() As String
        Get
            Return P_status
        End Get
        Set(ByVal value As String)
            P_status = value
        End Set
    End Property
    Public Property lon() As String
        Get
            Return P_lon
        End Get
        Set(ByVal value As String)
            P_lon = value
        End Set
    End Property
    Public Property lat() As String
        Get
            Return P_lat
        End Get
        Set(ByVal value As String)
            P_lat = value
        End Set
    End Property
    Public Property phone() As String
        Get
            Return P_phone
        End Get
        Set(ByVal value As String)
            P_phone = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return P_email
        End Get
        Set(ByVal value As String)
            P_email = value
        End Set
    End Property
    Public Property name() As String
        Get
            Return P_name
        End Get
        Set(ByVal value As String)
            P_name = value
        End Set
    End Property
    Public Property id() As Int32
        Get
            Return P_id
        End Get
        Set(ByVal value As Int32)
            P_id = value
        End Set
    End Property

    Public Sub New(ByVal id As Int32, ByVal name As String, ByVal email As String, ByVal phone As String,
                   ByVal lat As String, ByVal lon As String, ByVal status As String, ByVal address As String, ByVal logo As String)

        Me.id = id
        Me.name = name
        Me.email = email
        Me.phone = phone
        Me.lat = lat
        Me.lon = lon
        Me.status = status
        Me.address = address
        Me.logo = logo
    End Sub

End Class
