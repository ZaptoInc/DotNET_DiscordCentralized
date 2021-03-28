Imports Newtonsoft.Json

Namespace Core.Discord
    Public Class User

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

        <JsonProperty("username")>
        Private internal_username As String = Nothing

        <JsonIgnore>
        Property Username As String
            Get
                Return internal_username
            End Get
            Private Set(value As String)
                internal_username = value
            End Set
        End Property

        <JsonProperty("avatar")>
        Private internal_avatar As String = Nothing

        <JsonIgnore>
        Property AvatarID As String
            Get
                Return internal_avatar
            End Get
            Private Set(value As String)
                internal_avatar = value
            End Set
        End Property



        <JsonProperty("discriminator")>
        Private internal_discriminator As String = Nothing

        <JsonIgnore>
        Property Discriminator As String
            Get
                Return internal_discriminator
            End Get
            Private Set(value As String)
                internal_discriminator = value
            End Set
        End Property

        <JsonProperty("public_flags", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_public_flags As UserPublicFlags? = Nothing

        <JsonIgnore>
        Property PublicFlags As UserPublicFlags
            Get
                If internal_public_flags.HasValue Then
                    Return internal_public_flags
                Else
                    Return UserPublicFlags.None
                End If
            End Get
            Private Set(value As UserPublicFlags)
                internal_public_flags = value
            End Set
        End Property

        <JsonProperty("bot", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_bot As Boolean? = Nothing

        <JsonIgnore>
        Property IsBot As Boolean
            Get
                If internal_bot.HasValue Then
                    Return internal_bot
                Else
                    Return False
                End If
            End Get
            Private Set(value As Boolean)
                internal_bot = value
            End Set
        End Property

        <JsonProperty("mfa_enabled", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_mfa_enabled As Boolean? = Nothing

        <JsonIgnore>
        Property MfaEnabled As Boolean
            Get
                If internal_mfa_enabled.HasValue Then
                    Return internal_mfa_enabled
                Else
                    Return False
                End If
            End Get
            Private Set(value As Boolean)
                internal_mfa_enabled = value
            End Set
        End Property

        <JsonProperty("locale", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_locale As String = Nothing

        <JsonIgnore>
        Property Locale As String
            Get
                Return internal_locale
            End Get
            Private Set(value As String)
                internal_locale = value
            End Set
        End Property

        <JsonProperty("verified", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_verified As Boolean? = Nothing

        <JsonIgnore>
        Property Verified As Boolean
            Get
                If internal_verified.HasValue Then
                    Return internal_verified
                Else
                    Return False
                End If
            End Get
            Private Set(value As Boolean)
                internal_verified = value
            End Set
        End Property

        <JsonProperty("email", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_email As String = Nothing

        <JsonIgnore>
        Property Email As String
            Get
                Return internal_email
            End Get
            Private Set(value As String)
                internal_email = value
            End Set
        End Property

        <JsonProperty("premium_type", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_premium_type As UserPremiumType? = Nothing

        <JsonIgnore>
        Property PremiumType As UserPremiumType
            Get
                If internal_premium_type.HasValue Then
                    Return internal_premium_type
                Else
                    Return UserPremiumType.None
                End If
            End Get
            Private Set(value As UserPremiumType)
                internal_premium_type = value
            End Set
        End Property
    End Class
End Namespace

