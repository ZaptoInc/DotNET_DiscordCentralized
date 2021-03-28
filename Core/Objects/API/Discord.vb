Imports Flurl
Imports Flurl.Http

Namespace Core
    Public Class DiscordAPI
#Region "Internal Objects"
        Private Token As String = Nothing

        Private TokenType As DiscordAPITokenType = DiscordAPITokenType.User

        Private BaseURL As String = "https://discord.com/api/v8"
#End Region
#Region "New"
        Sub New()

        End Sub

        Sub New(token As String, token_type As DiscordAPITokenType)
            Me.Token = token
            Me.TokenType = token_type
        End Sub
#End Region

#Region "Internal Functions"
        Private Function GetAuthToken() As String
            Dim result As String
            Select Case TokenType
                Case DiscordAPITokenType.User
                    result = $"{Token}"
                Case Else
                    result = $"{TokenType.ToString} {Token}"
            End Select
            Return result
        End Function
#End Region

#Region "Public Functions"
        Public Async Function GetUserAsync(ByVal id As ULong) As Task(Of Discord.User)
            Dim raw = Await GetRawUserAsync(id)
            Return raw.AsObject
        End Function

        Public Async Function GetRawUserAsync(ByVal id As ULong) As Task(Of WebResponse(Of Discord.User))
            Dim request As IFlurlRequest = BaseURL.AppendPathSegments("users", id).WithHeader("authorization", GetAuthToken())
            Dim web As New WebClient(request)
            Return Await web.GetAsync(Of Discord.User)
        End Function

        Public Async Function GetCurrentUserAsync() As Task(Of Discord.User)
            Dim raw = Await GetRawCurrentUserAsync()
            Return raw.AsObject
        End Function

        Public Async Function GetRawCurrentUserAsync() As Task(Of WebResponse(Of Discord.User))
            Dim request As IFlurlRequest = BaseURL.AppendPathSegments("users", "@me").WithHeader("authorization", GetAuthToken())
            Dim web As New WebClient(request)
            Return Await web.GetAsync(Of Discord.User)
        End Function
#End Region


    End Class
End Namespace

