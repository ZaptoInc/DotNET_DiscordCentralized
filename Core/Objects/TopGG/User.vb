Imports System.Drawing
Imports Newtonsoft.Json

Namespace Core.TopGG
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

        <JsonProperty("defAvatar")>
        Private internal_defAvatar As String = Nothing

        <JsonIgnore>
        Property DefAvatarHash As String
            Get
                Return internal_defAvatar
            End Get
            Private Set(value As String)
                internal_defAvatar = value
            End Set
        End Property

        <JsonProperty("bio", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_bio As String = Nothing

        <JsonIgnore>
        Property Bio As String
            Get
                Return internal_bio
            End Get
            Private Set(value As String)
                internal_bio = value
            End Set
        End Property

        <JsonProperty("banner", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_banner As String = Nothing

        <JsonIgnore>
        Property BannerURL As String
            Get
                Return internal_bio
            End Get
            Private Set(value As String)
                internal_bio = value
            End Set
        End Property

        <JsonProperty("social", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_social As UserSocial = Nothing

        <JsonIgnore>
        Property Social As UserSocial
            Get
                If internal_social IsNot Nothing Then
                    Return internal_social
                Else
                    Return New UserSocial
                End If

            End Get
            Private Set(value As UserSocial)
                internal_social = value
            End Set
        End Property

        <JsonProperty("color", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_color As String = Nothing

        <JsonIgnore>
        Property ColorHex As String
            Get
                Return internal_color

            End Get
            Private Set(value As String)
                internal_color = value
            End Set
        End Property

        Property Color As Drawing.Color?
            Get
                Try
                    Return ColorTranslator.FromHtml(internal_color)
                Catch ex As Exception
                    Return Nothing
                End Try

            End Get
            Private Set(value As Drawing.Color?)
                If value.HasValue Then
                    internal_color = ColorTranslator.ToHtml(value.Value)
                Else
                    internal_color = Nothing
                End If
            End Set
        End Property

        <JsonProperty("supporter")>
        Private internal_supporter As Boolean = False

        <JsonIgnore>
        Property IsSupporter As Boolean
            Get
                Return internal_supporter
            End Get
            Private Set(value As Boolean)
                internal_supporter = value
            End Set
        End Property

        <JsonProperty("certifiedDev")>
        Private internal_certifiedDev As Boolean = False

        <JsonIgnore>
        Property IsCertifiedDev As Boolean
            Get
                Return internal_certifiedDev
            End Get
            Private Set(value As Boolean)
                internal_certifiedDev = value
            End Set
        End Property

        <JsonProperty("mod")>
        Private internal_mod As Boolean = False

        <JsonIgnore>
        Property IsMod As Boolean
            Get
                Return internal_mod
            End Get
            Private Set(value As Boolean)
                internal_mod = value
            End Set
        End Property

        <JsonProperty("webMod")>
        Private internal_webMod As Boolean = False

        <JsonIgnore>
        Property IsWebMod As Boolean
            Get
                Return internal_webMod
            End Get
            Private Set(value As Boolean)
                internal_webMod = value
            End Set
        End Property

        <JsonProperty("admin")>
        Private internal_admin As Boolean = False

        <JsonIgnore>
        Property IsAdmin As Boolean
            Get
                Return internal_admin
            End Get
            Private Set(value As Boolean)
                internal_admin = value
            End Set
        End Property
    End Class

    Public Class UserSocial
        <JsonProperty("youtube", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_youtube As String = Nothing

        <JsonIgnore>
        Property YoutubeChannelID As String
            Get
                Return internal_youtube
            End Get
            Private Set(value As String)
                internal_youtube = value
            End Set
        End Property

        <JsonProperty("reddit", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_reddit As String = Nothing

        <JsonIgnore>
        Property RedditUsername As String
            Get
                Return internal_reddit
            End Get
            Private Set(value As String)
                internal_reddit = value
            End Set
        End Property

        <JsonProperty("twitter", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_twitter As String = Nothing

        <JsonIgnore>
        Property TwitterUsername As String
            Get
                Return internal_twitter
            End Get
            Private Set(value As String)
                internal_twitter = value
            End Set
        End Property

        <JsonProperty("instagram", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_instagram As String = Nothing

        <JsonIgnore>
        Property InstagramUsername As String
            Get
                Return internal_instagram
            End Get
            Private Set(value As String)
                internal_instagram = value
            End Set
        End Property

        <JsonProperty("github", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_github As String = Nothing

        <JsonIgnore>
        Property GithubUsername As String
            Get
                Return internal_github
            End Get
            Private Set(value As String)
                internal_github = value
            End Set
        End Property
    End Class
End Namespace

