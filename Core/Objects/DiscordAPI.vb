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
        Public Async Function GetUserAsync(ByVal id As ULong) As Task(Of Discord.MinimalUser)
            Dim raw = Await GetRawUserAsync(id)
            Return raw.AsObject
        End Function

        Public Async Function GetRawUserAsync(ByVal id As ULong) As Task(Of Web.Response(Of Discord.MinimalUser))
            Dim request As IFlurlRequest = BaseURL.AppendPathSegments("users", id).WithHeader("authorization", GetAuthToken())
            Dim web As New WebClient(request)
            Dim result = Await web.GetAsync(Of Discord.MinimalUser)
            Dim ratelimit = New Discord.RateLimit(result.Headers)
            Await ratelimit.AwaitRateLimit
            If result.Status = 429 Then
                Return Await GetRawUserAsync(id)
            End If
            Return result
        End Function

        Public Async Function GetCurrentUserAsync() As Task(Of Discord.User)
            Dim raw = Await GetRawCurrentUserAsync()
            Return raw.AsObject
        End Function

        Public Async Function GetRawCurrentUserAsync() As Task(Of Web.Response(Of Discord.User))
            Dim request As IFlurlRequest = BaseURL.AppendPathSegments("users", "@me").WithHeader("authorization", GetAuthToken())
            Dim web As New WebClient(request)
            Dim result = Await web.GetAsync(Of Discord.User)
            Dim ratelimit = New Discord.RateLimit(result.Headers)
            Await ratelimit.AwaitRateLimit
            If result.Status = 429 Then
                Return Await GetRawCurrentUserAsync()
            End If
            Return result
        End Function

        Public Async Function GetCurrentUserGuildsAsync() As Task(Of List(Of Discord.CurrentGuild))
            Return Await GetAllCurrentUserGuilds()
        End Function

        Private Async Function GetAllCurrentUserGuilds(Optional previous As List(Of Discord.CurrentGuild) = Nothing) As Task(Of List(Of Discord.CurrentGuild))
            Dim current As New List(Of Discord.CurrentGuild)
            If previous IsNot Nothing Then
                current = previous
            End If
            Dim latest_guild As ULong = 0
            If current.Count > 0 Then
                latest_guild = current.OrderBy(Function(x) x.ID).Last.ID
            End If
            Dim request = Await GetRawCurrentUserGuildsAsync(after:=latest_guild)
            If request.AsObject IsNot Nothing Then
                If request.AsObject.Count > 0 Then
                    For Each guild In request.AsObject
                        guild.WithClient(Me)
                        current.Add(guild)
                    Next
                    If request.AsObject.Count < 100 Then
                        Return current
                    Else
                        Return Await GetAllCurrentUserGuilds(current)
                    End If
                End If
                End If

        End Function

        Public Async Function GetRawCurrentUserGuildsAsync(Optional before As ULong? = Nothing, Optional after As ULong? = Nothing, Optional limit As Integer? = Nothing) As Task(Of Web.Response(Of List(Of Discord.CurrentGuild)))
            Dim request As IFlurlRequest = BaseURL.AppendPathSegments("users", "@me", "guilds").WithHeader("authorization", GetAuthToken())
            If before.HasValue Then
                request = request.SetQueryParam("before", before.Value)
            End If
            If after.HasValue Then
                request = request.SetQueryParam("after", after.Value)
            End If
            If limit.HasValue Then
                request = request.SetQueryParam("limit", limit.Value)
            End If
            Dim web As New WebClient(request)
            Dim result = Await web.GetAsync(Of List(Of Discord.CurrentGuild))
            Dim ratelimit = New Discord.RateLimit(result.Headers)
            Await ratelimit.AwaitRateLimit
            If result.Status = 429 Then
                Return Await GetRawCurrentUserGuildsAsync(before, after, limit)
            End If
            Return result
        End Function

        Public Async Function GetGuildAsync(ByVal id As ULong) As Task(Of Discord.Guild)
            Dim raw = Await GetRawGuildAsync(id)
            Return raw.AsObject
        End Function

        Public Async Function GetRawGuildAsync(ByVal id As ULong) As Task(Of Web.Response(Of Discord.Guild))
            Dim request As IFlurlRequest = BaseURL.AppendPathSegments("guilds", id).WithHeader("authorization", GetAuthToken()).SetQueryParam("with_counts", "true")
            Dim web As New WebClient(request)
            Dim result = Await web.GetAsync(Of Discord.Guild)
            Dim ratelimit = New Discord.RateLimit(result.Headers)
            Await ratelimit.AwaitRateLimit
            If result.Status = 429 Then
                Return Await GetRawGuildAsync(id)
            End If
            Return result
        End Function
#End Region


    End Class
End Namespace

