
Namespace Core.Web
    Public Class Headers
        Inherits Dictionary(Of String, String)

        Property AsDictionary As Dictionary(Of String, String)
            Get
                Return Me
            End Get
            Set(value As Dictionary(Of String, String))
                Me.Clear()
                For Each v In value
                    Me.AddValue(v.Key, v.Value)
                Next
            End Set
        End Property

        'Public Function ContainsKey(key As String) As Boolean
        '    Return AsDictionary.ContainsKey(key.ToLower)
        'End Function

        Private Sub AddValue(key As String, value As String)
            Me.Add(key.ToLower, value)
        End Sub

        Sub New(value As Dictionary(Of String, String))
            For Each v In value
                Me.AddValue(v.Key, v.Value)
            Next
        End Sub

        Sub New()

        End Sub
    End Class
End Namespace

