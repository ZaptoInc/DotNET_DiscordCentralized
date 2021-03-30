Imports Newtonsoft.Json

Namespace Core.Discord
    Public Class OauthUrl

        <JsonProperty("url")>
        Private internal_url As String

        <JsonIgnore>
        Property Url As String
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Return internal_url
                End If
            End Get
            Private Set(value As String)
                internal_url = Url
            End Set
        End Property

        Sub New(url As String)
            Me.Url = url
        End Sub
    End Class
End Namespace

