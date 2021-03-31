Imports System.Drawing
Imports Newtonsoft.Json

Namespace Core.TopGG
    Public Class Bot

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

        <JsonProperty("lib")>
        Private internal_lib As String = Nothing

        <JsonIgnore>
        Property Library As String
            Get
                Return internal_lib
            End Get
            Private Set(value As String)
                internal_lib = value
            End Set
        End Property

        <JsonProperty("prefix")>
        Private internal_prefix As String = Nothing

        <JsonIgnore>
        Property Prefix As String
            Get
                Return internal_prefix
            End Get
            Private Set(value As String)
                internal_prefix = value
            End Set
        End Property

        <JsonProperty("shortdesc")>
        Private internal_shortdesc As String = Nothing

        <JsonIgnore>
        Property ShortDescription As String
            Get
                Return internal_shortdesc
            End Get
            Private Set(value As String)
                internal_shortdesc = value
            End Set
        End Property

        <JsonProperty("longdesc", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_longdesc As String = Nothing

        <JsonIgnore>
        Property LongDescription As String
            Get
                Return internal_longdesc
            End Get
            Private Set(value As String)
                internal_longdesc = value
            End Set
        End Property

        <JsonProperty("tags")>
        Private internal_tags As List(Of String) = Nothing

        <JsonIgnore>
        Property Tags As List(Of String)
            Get
                Return internal_tags
            End Get
            Private Set(value As List(Of String))
                internal_tags = value
            End Set
        End Property

        <JsonProperty("website", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_website As String = Nothing

        <JsonIgnore>
        Property WebsiteURL As String
            Get
                If String.IsNullOrWhiteSpace(internal_website) Then
                    Return Nothing
                Else
                    Return internal_website
                End If
            End Get
            Private Set(value As String)
                internal_website = value
            End Set
        End Property

        <JsonProperty("support", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_support As String = Nothing

        <JsonIgnore>
        Property SupportInviteCode As String
            Get
                Return internal_support
            End Get
            Private Set(value As String)
                internal_support = value
            End Set
        End Property

        <JsonIgnore>
        Property SupportInviteUrl As String
            Get
                If String.IsNullOrWhiteSpace(internal_support) Then
                    Return Nothing
                Else
                    Return $"https://discord.gg/{internal_support}"
                End If
            End Get
            Private Set(value As String)
            End Set
        End Property


        <JsonProperty("github", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_github As String = Nothing

        <JsonIgnore>
        Property GithubURL As String
            Get
                If String.IsNullOrWhiteSpace(internal_github) Then
                    Return Nothing
                Else
                    Return internal_github
                End If
            End Get
            Private Set(value As String)
                internal_github = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_owners As List(Of ULong)

        <JsonProperty("owners")>
        Property RawOwnerIDs As List(Of String)
            Get
                If internal_owners IsNot Nothing Then
                    Dim res As New List(Of String)
                    For Each owner In internal_owners
                        res.Add(owner)
                    Next
                    Return res
                Else
                    Return Nothing
                End If
            End Get
            Private Set(value As List(Of String))
                If value IsNot Nothing Then
                    Dim res As New List(Of ULong)
                    For Each owner In value
                        res.Add(owner)
                    Next
                    internal_owners = res
                Else
                    internal_owners = Nothing
                End If
            End Set
        End Property

        <JsonIgnore>
        Property OwnerIDs As List(Of ULong)
            Get
                Return internal_owners
            End Get
            Private Set(value As List(Of ULong))
                internal_owners = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_guilds As List(Of ULong)

        <JsonProperty("guilds")>
        Property RawGuildIDs As List(Of String)
            Get
                If internal_guilds IsNot Nothing Then
                    Dim res As New List(Of String)
                    For Each owner In internal_guilds
                        res.Add(owner)
                    Next
                    Return res
                Else
                    Return Nothing
                End If
            End Get
            Private Set(value As List(Of String))
                If value IsNot Nothing Then
                    Dim res As New List(Of ULong)
                    For Each owner In value
                        res.Add(owner)
                    Next
                    internal_guilds = res
                Else
                    internal_guilds = Nothing
                End If
            End Set
        End Property

        <JsonIgnore>
        Property GuildIDs As List(Of ULong)
            Get
                Return internal_guilds
            End Get
            Private Set(value As List(Of ULong))
                internal_guilds = value
            End Set
        End Property

        <JsonProperty("invite")>
        Private internal_invite As String

        <JsonIgnore>
        Property Invite As Discord.OauthUrl
            Get
                If Not String.IsNullOrWhiteSpace(internal_invite) Then
                    Return New Discord.OauthUrl(internal_invite)
                Else
                    Return Nothing
                End If
            End Get
            Private Set(value As Discord.OauthUrl)
                If value IsNot Nothing Then
                    If Not String.IsNullOrWhiteSpace(value.Url) Then
                        internal_invite = value.Url
                    Else
                        internal_invite = Nothing
                    End If
                Else
                    internal_invite = Nothing
                End If
            End Set
        End Property

        <JsonIgnore>
        Private internal_date As String

        <JsonProperty("date")>
        Property RawApprovedDate As String
            Get
                Return internal_date
            End Get
            Private Set(value As String)
                internal_date = value
            End Set
        End Property

        <JsonIgnore>
        Property ApprovedDate As Date
            Get
                Return internal_date
            End Get
            Private Set(value As Date)
                internal_date = value
            End Set
        End Property

        <JsonProperty("certifiedBot")>
        Private internal_certifiedBot As Boolean = False

        <JsonIgnore>
        Property IsCertifiedBot As Boolean
            Get
                Return internal_certifiedBot
            End Get
            Private Set(value As Boolean)
                internal_certifiedBot = value
            End Set
        End Property

        <JsonProperty("vanity", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_vanity As String = Nothing

        <JsonIgnore>
        Property VanityCode As String
            Get
                Return internal_vanity
            End Get
            Private Set(value As String)
                internal_vanity = value
            End Set
        End Property

        <JsonIgnore>
        Property VanityUrl As String
            Get
                If String.IsNullOrWhiteSpace(internal_vanity) Then
                    Return Nothing
                Else
                    Return $"https://top.gg/bot/{internal_vanity}"
                End If
            End Get
            Private Set(value As String)
            End Set
        End Property

        <JsonProperty("points")>
        Private internal_points As Integer

        <JsonIgnore>
        Property TotalUpvotes As Integer
            Get
                Return internal_points
            End Get
            Private Set(value As Integer)
                internal_points = value
            End Set
        End Property

        <JsonProperty("monthlyPoints")>
        Private internal_monthlyPoints As Integer

        <JsonIgnore>
        Property MonthlyUpvotes As Integer
            Get
                Return internal_monthlyPoints
            End Get
            Private Set(value As Integer)
                internal_monthlyPoints = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_donatebotguildid As ULong?

        <JsonProperty("donatebotguildid")>
        Property RawDonateBotGuildID As String
            Get
                If internal_donatebotguildid.HasValue Then
                    Return internal_donatebotguildid.Value
                Else
                    Return ""
                End If
            End Get
            Private Set(value As String)
                Try
                    If String.IsNullOrWhiteSpace(value) Then
                        internal_donatebotguildid = Nothing
                    Else
                        internal_donatebotguildid = value
                    End If
                Catch
                End Try

            End Set
        End Property

        <JsonIgnore>
        Property DonateBotGuildID As ULong?
            Get
                Return internal_donatebotguildid
            End Get
            Private Set(value As ULong?)
                internal_donatebotguildid = value
            End Set
        End Property

        <JsonProperty("server_count")>
        Private internal_server_count As Integer?

        <JsonIgnore>
        Property ServerCount As Integer
            Get
                Return internal_server_count
            End Get
            Set(value As Integer)
                internal_server_count = value
            End Set
        End Property

        <JsonProperty("shards")>
        Private internal_shards As List(Of Integer) = Nothing

        <JsonIgnore>
        Property Shards As List(Of Integer)
            Get
                Return internal_shards
            End Get
            Set(value As List(Of Integer))
                internal_shards = value
            End Set
        End Property

        <JsonProperty("shard_count")>
        Private internal_shard_count As Integer?

        <JsonIgnore>
        Property ShardCount As Integer?
            Get
                Return internal_shard_count
            End Get
            Set(value As Integer?)
                internal_shard_count = value
            End Set
        End Property
    End Class
End Namespace

