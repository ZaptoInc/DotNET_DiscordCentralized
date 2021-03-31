Imports Newtonsoft.Json
Imports Flurl.Http

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

        <JsonProperty("client_id", NullValueHandling:=NullValueHandling.Ignore)>
        Property RawClientID As String
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Dim internal_flurl As Flurl.Url = internal_url
                    If internal_flurl.QueryParams.Contains("client_id") Then
                        Return internal_flurl.QueryParams.GetAll("client_id").First
                    Else
                        Return Nothing
                    End If
                End If
            End Get
            Private Set(value As String)

            End Set
        End Property

        <JsonIgnore>
        Property ClientID As ULong?
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Dim internal_flurl As Flurl.Url = internal_url
                    If internal_flurl.QueryParams.Contains("client_id") Then
                        Return internal_flurl.QueryParams.GetAll("client_id").First
                    Else
                        Return Nothing
                    End If
                End If
            End Get
            Private Set(value As ULong?)

            End Set
        End Property

        <JsonProperty("response_type", NullValueHandling:=NullValueHandling.Ignore)>
        Property ResponseType As String
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Dim internal_flurl As Flurl.Url = internal_url
                    If internal_flurl.QueryParams.Contains("response_type") Then
                        Return internal_flurl.QueryParams.GetAll("response_type").First
                    Else
                        Return Nothing
                    End If
                End If
            End Get
            Private Set(value As String)

            End Set
        End Property

        <JsonProperty("scope", NullValueHandling:=NullValueHandling.Ignore)>
        Property Scope As String
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Dim internal_flurl As Flurl.Url = internal_url
                    If internal_flurl.QueryParams.Contains("scope") Then
                        Return internal_flurl.QueryParams.GetAll("scope").First
                    Else
                        Return Nothing
                    End If
                End If
            End Get
            Private Set(value As String)

            End Set
        End Property

        <JsonProperty("state", NullValueHandling:=NullValueHandling.Ignore)>
        Property State As String
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Dim internal_flurl As Flurl.Url = internal_url
                    If internal_flurl.QueryParams.Contains("state") Then
                        Return internal_flurl.QueryParams.GetAll("state").First
                    Else
                        Return Nothing
                    End If
                End If
            End Get
            Private Set(value As String)

            End Set
        End Property

        <JsonProperty("redirect_uri", NullValueHandling:=NullValueHandling.Ignore)>
        Property RedirectURI As String
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Dim internal_flurl As Flurl.Url = internal_url
                    If internal_flurl.QueryParams.Contains("redirect_uri") Then
                        Return internal_flurl.QueryParams.GetAll("redirect_uri").First
                    Else
                        Return Nothing
                    End If
                End If
            End Get
            Private Set(value As String)

            End Set
        End Property

        <JsonProperty("permissions", NullValueHandling:=NullValueHandling.Ignore)>
        Property RawPermissions As String
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Dim internal_flurl As Flurl.Url = internal_url
                    If internal_flurl.QueryParams.Contains("permissions") Then
                        Return internal_flurl.QueryParams.GetAll("permissions").First
                    Else
                        Return Nothing
                    End If
                End If
            End Get
            Private Set(value As String)

            End Set
        End Property

        <JsonIgnore>
        Property Permissions As DiscordGuildPermission?
            Get
                If String.IsNullOrWhiteSpace(internal_url) Then
                    Return Nothing
                Else
                    Dim internal_flurl As Flurl.Url = internal_url
                    If internal_flurl.QueryParams.Contains("permissions") Then
                        Return internal_flurl.QueryParams.GetAll("permissions").First
                    Else
                        Return Nothing
                    End If
                End If
            End Get
            Private Set(value As DiscordGuildPermission?)

            End Set
        End Property

        Sub New()

        End Sub

        Sub New(url As String)
            internal_url = url
        End Sub
    End Class
End Namespace

