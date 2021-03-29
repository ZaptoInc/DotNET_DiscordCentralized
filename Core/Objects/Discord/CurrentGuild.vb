Imports Newtonsoft.Json

Namespace Core.Discord
    Public Class CurrentGuild

        <JsonIgnore>
        Private internal_client As DiscordAPI

        <JsonIgnore>
        Private internal_id As ULong?

        <JsonProperty("id")>
        Property RawID As String
            Get
                Return internal_id
            End Get
            Private Set(value As String)
                internal_id = value
            End Set
        End Property

        <JsonIgnore>
        Property ID As ULong
            Get
                Return internal_id
            End Get
            Private Set(value As ULong)
                internal_id = value
            End Set
        End Property

        <JsonProperty("name")>
        Private internal_name As String = Nothing

        <JsonIgnore>
        Property Name As String
            Get
                Return internal_name
            End Get
            Private Set(value As String)
                internal_name = value
            End Set
        End Property

        <JsonProperty("icon")>
        Private internal_icon As String = Nothing

        <JsonIgnore>
        Property IconID As String
            Get
                Return internal_icon
            End Get
            Private Set(value As String)
                internal_icon = value
            End Set
        End Property

        <JsonProperty("features")>
        Private internal_features As List(Of String) = Nothing

        <JsonIgnore>
        Property Features As List(Of String)
            Get
                Return internal_features
            End Get
            Private Set(value As List(Of String))
                internal_features = value
            End Set
        End Property

        <JsonProperty("owner", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_owner As Boolean? = Nothing

        <JsonIgnore>
        Property IsOwner As Boolean
            Get
                If internal_owner.HasValue Then
                    Return internal_owner
                Else
                    Return False
                End If
            End Get
            Private Set(value As Boolean)
                internal_owner = value
            End Set
        End Property

        <JsonProperty("permissions", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_permissions As DiscordGuildPermission? = Nothing

        <JsonIgnore>
        Property Permissions As DiscordGuildPermission
            Get
                Return internal_permissions
            End Get
            Private Set(value As DiscordGuildPermission)
                internal_permissions = value
            End Set
        End Property

        Function WithClient(client As DiscordAPI) As CurrentGuild
            Me.internal_client = client
            Return Me
        End Function

        Function GetGuild() As Guild

        End Function

    End Class
End Namespace

