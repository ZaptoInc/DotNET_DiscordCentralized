Imports Flurl
Imports Flurl.Http

Namespace Core
    Public Class TopGGAPI
#Region "Internal Objects"
        Private Token As String = Nothing

        Private BaseURL As String = "https://top.gg/api"
#End Region
#Region "New"
        Sub New()

        End Sub

        Sub New(token As String)
            Me.Token = token
        End Sub
#End Region

#Region "Internal Functions"
        Private Function GetAuthToken() As String
            Return Token
        End Function
#End Region

#Region "Public Functions"
        Public Async Function GetUserAsync(ByVal id As ULong) As Task(Of TopGG.User)
            Dim raw = Await GetRawUserAsync(id)
            Return raw.AsObject
        End Function

        Public Async Function GetRawUserAsync(ByVal id As ULong) As Task(Of Web.Response(Of TopGG.User))
            Dim request As IFlurlRequest = BaseURL.AppendPathSegments("users", id).WithHeader("authorization", GetAuthToken())
            Dim web As New WebClient(request)
            Dim result = Await web.GetAsync(Of TopGG.User)
            If result.Status = 429 Then
                'Return Await GetRawUserAsync(id)
            ElseIf result.Status = 404 Then
                Return Nothing
            End If
            Return result
        End Function

        Public Async Function GetBotAsync(ByVal id As ULong) As Task(Of TopGG.User)
            Dim raw = Await GetRawBotAsync(id)
            Return raw.AsObject
        End Function

        Public Async Function GetRawBotAsync(ByVal id As ULong) As Task(Of Web.Response(Of TopGG.User))
            Dim request As IFlurlRequest = BaseURL.AppendPathSegments("bots", id).WithHeader("authorization", GetAuthToken())
            Dim web As New WebClient(request)
            Dim result = Await web.GetAsync(Of TopGG.User)
            If result.Status = 429 Then
                'Return Await GetRawUserAsync(id)
            ElseIf result.Status = 404 Then
                Return Nothing
            End If
            Return result
        End Function
#End Region


    End Class
End Namespace

