Imports Newtonsoft.Json

Namespace Core.Discord
    Public Class Role

        <JsonIgnore>
        Private internal_client As DiscordAPI

        <JsonIgnore>
        Private internal_id As ULong

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
        Private internal_name As String

        <JsonIgnore>
        Property Name As String
            Get
                Return internal_name
            End Get
            Private Set(value As String)
                internal_name = value
            End Set
        End Property

        <JsonProperty("color")>
        Private internal_color As Integer

        <JsonIgnore>
        Property RawColor As Integer
            Get
                Return internal_color
            End Get
            Private Set(value As Integer)
                internal_color = value
            End Set
        End Property

        <JsonIgnore>
        Property Color As Drawing.Color?
            Get
                If internal_color = 0 Then
                    Return Nothing
                Else
                    Return Drawing.Color.FromArgb(internal_color)
                End If
            End Get
            Private Set(value As Drawing.Color?)
                If value.HasValue Then
                    internal_color = value.Value.ToArgb
                Else
                    internal_color = 0
                End If
            End Set
        End Property

        <JsonProperty("hoist")>
        Private internal_hoist As Boolean

        <JsonIgnore>
        Property Hoist As Boolean
            Get
                Return internal_hoist
            End Get
            Private Set(value As Boolean)
                internal_hoist = value
            End Set
        End Property

        <JsonProperty("position")>
        Private internal_position As Integer

        <JsonIgnore>
        Property Position As Integer
            Get
                Return internal_position
            End Get
            Private Set(value As Integer)
                internal_position = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_permissions As DiscordGuildPermission

        <JsonProperty("permissions")>
        Property RawPermissions As String
            Get
                Return CUInt(internal_permissions)
            End Get
            Private Set(value As String)
                internal_permissions = CUInt(value)
            End Set
        End Property

        <JsonIgnore>
        Property Permissions As DiscordGuildPermission
            Get
                Return internal_permissions
            End Get
            Private Set(value As DiscordGuildPermission)
                internal_permissions = value
            End Set
        End Property

        <JsonProperty("managed")>
        Private internal_managed As Boolean

        <JsonIgnore>
        Property Managed As Boolean
            Get
                Return internal_managed
            End Get
            Private Set(value As Boolean)
                internal_managed = value
            End Set
        End Property

        <JsonProperty("mentionable")>
        Private internal_mentionable As Boolean

        <JsonIgnore>
        Property Mentionable As Boolean
            Get
                Return internal_mentionable
            End Get
            Private Set(value As Boolean)
                internal_mentionable = value
            End Set
        End Property

        <JsonProperty("tags", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_tags As RoleTag

        <JsonIgnore>
        Property Tags As RoleTag
            Get
                Return internal_tags
            End Get
            Private Set(value As RoleTag)
                internal_tags = value
            End Set
        End Property

        Function WithClient(client As DiscordAPI) As Role
            Me.internal_client = client
            Return Me
        End Function
    End Class

    Public Class RoleTag
        <JsonIgnore>
        Private internal_bot_id As ULong?

        <JsonProperty("bot_id", NullValueHandling:=NullValueHandling.Ignore)>
        Property RawBotID As String
            Get
                Return internal_bot_id
            End Get
            Private Set(value As String)
                internal_bot_id = value
            End Set
        End Property

        <JsonIgnore>
        Property BotID As ULong?
            Get
                Return internal_bot_id
            End Get
            Private Set(value As ULong?)
                internal_bot_id = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_integration_id As ULong?

        <JsonProperty("integration_id", NullValueHandling:=NullValueHandling.Ignore)>
        Property RawIntegrationID As String
            Get
                Return internal_integration_id
            End Get
            Private Set(value As String)
                internal_integration_id = value
            End Set
        End Property

        <JsonIgnore>
        Property IntegrationID As ULong?
            Get
                Return internal_integration_id
            End Get
            Private Set(value As ULong?)
                internal_integration_id = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_premium_subscriber As Boolean? = False


        <JsonProperty("premium_subscriber")>
        Property IsPremium As Boolean?
            Get
                If internal_premium_subscriber.HasValue Then
                    Return internal_premium_subscriber.Value
                Else
                    Return True
                End If
            End Get
            Private Set(value As Boolean?)
                If value.HasValue Then
                    internal_premium_subscriber = value.Value
                Else
                    internal_premium_subscriber = False
                End If
            End Set
        End Property

    End Class
End Namespace

