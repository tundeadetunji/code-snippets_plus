Imports Newtonsoft.Json.Linq

Public Class Serializer
    Private _json As String

    Public Property json As String
        Get
            Return _json
        End Get
        Private Set(ByVal value As String)
            _json = value
        End Set
    End Property

    Public Sub New(ByVal json As String)
        Me.json = json
    End Sub

    Public Function keys() As List(Of String)
        Return JObject.Parse(json).Properties().[Select](Function(p) p.Name).ToList()
    End Function

    Public Function snippet(ByVal key As String) As String
        Dim value As String = CStr(JObject.Parse(json)(key))
        Return value
    End Function
End Class
