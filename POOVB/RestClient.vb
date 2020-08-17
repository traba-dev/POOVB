Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class RestClient



    Private HttpVerb As String
    Private EndPoint As String
    Private Response As String

    Public Property ResponseProperty() As String
        Get
            Return Response
        End Get
        Set(ByVal value As String)
            Response = value
        End Set
    End Property


    Public Sub New()
        HttpVerb = "GET"
        EndPoint = String.Empty
        Me.Response = String.Empty
    End Sub



    Public Property EndPointProperty() As String
        Get
            Return EndPoint
        End Get
        Set(ByVal value As String)
            EndPoint = value
        End Set
    End Property
    Public Property HttpVerbProperty() As String
        Get
            Return HttpVerb
        End Get
        Set(ByVal value As String)

            Select Case value
                Case "G"
                    HttpVerb = "GET"
                Case "P"
                    HttpVerb = "POST"
                Case "PU"
                    HttpVerb = "PUT"
                Case Else
                    HttpVerb = "DELETE"
            End Select
        End Set
    End Property



    Public Function Request(Of T)(ByVal objectG As T) As String

        Dim _strResponse As String = String.Empty


        Dim _request As WebRequest = WebRequest.Create(EndPoint)
        _request.Method = Me.HttpVerb
        _request.PreAuthenticate = True
        _request.ContentType = "application/json;charset=utf-8"


        If objectG IsNot Nothing Then
            Dim Json As String = JsonConvert.SerializeObject(objectG)

            Using stremWriter As New StreamWriter(_request.GetRequestStream())
                stremWriter.Write(Json)
                stremWriter.Flush()
            End Using
        End If


        Dim _response As WebResponse = _request.GetResponse()

        Using read As New StreamReader(_response.GetResponseStream())
            If read IsNot Nothing Then
                _strResponse = read.ReadToEnd()
            End If
        End Using

        Me.Response = _strResponse

        Return _strResponse
    End Function




End Class
