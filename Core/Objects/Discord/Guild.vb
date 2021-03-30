Imports Newtonsoft.Json

Namespace Core.Discord
    Public Class Guild

#Region "Properties"

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

        <JsonProperty("splash")>
        Private internal_splash As String = Nothing

        <JsonIgnore>
        Property SplashID As String
            Get
                Return internal_splash
            End Get
            Private Set(value As String)
                internal_splash = value
            End Set
        End Property

        <JsonProperty("discovery_splash", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_discovery_splash As String = Nothing

        <JsonIgnore>
        Property DiscoverySplashID As String
            Get
                Return internal_discovery_splash
            End Get
            Private Set(value As String)
                internal_discovery_splash = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_owner_id As ULong?

        <JsonProperty("owner_id")>
        Property RawOwnerID As String
            Get
                Return internal_owner_id
            End Get
            Private Set(value As String)
                internal_owner_id = value
            End Set
        End Property

        <JsonIgnore>
        Property OwnerID As ULong
            Get
                Return internal_owner_id
            End Get
            Private Set(value As ULong)
                internal_owner_id = value
            End Set
        End Property

        <JsonProperty("region")>
        Private internal_region As String = Nothing

        <JsonIgnore>
        Property Region As String
            Get
                Return internal_region
            End Get
            Private Set(value As String)
                internal_region = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_afk_channel_id As ULong?

        <JsonProperty("afk_channel_id")>
        Property RawAFKChannelID As String
            Get
                Return internal_afk_channel_id
            End Get
            Private Set(value As String)
                internal_afk_channel_id = value
            End Set
        End Property

        <JsonIgnore>
        Property AFKChannelID As ULong?
            Get
                Return internal_afk_channel_id
            End Get
            Private Set(value As ULong?)
                internal_afk_channel_id = value
            End Set
        End Property

        <JsonProperty("afk_timeout")>
        Private internal_afk_timeout As Integer?

        <JsonIgnore>
        Property AFKTimeout As Integer
            Get
                If internal_afk_timeout.HasValue Then
                    Return internal_afk_timeout.Value
                Else
                    Return 300
                End If
            End Get
            Private Set(value As Integer)
                internal_afk_timeout = value
            End Set
        End Property

        <JsonProperty("widget_enabled", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_widget_enabled As Boolean? = Nothing

        <JsonIgnore>
        Property WidgetEnabled As Boolean
            Get
                If internal_widget_enabled.HasValue Then
                    Return internal_widget_enabled.Value
                Else
                    Return False
                End If
            End Get
            Private Set(value As Boolean)
                internal_widget_enabled = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_widget_channel_id As ULong?

        <JsonProperty("widget_channel_id", NullValueHandling:=NullValueHandling.Ignore)>
        Property RawWidgetChannelID As String
            Get
                Return internal_widget_channel_id
            End Get
            Private Set(value As String)
                internal_widget_channel_id = value
            End Set
        End Property

        <JsonIgnore>
        Property WidgetChannelID As ULong?
            Get
                Return internal_widget_channel_id
            End Get
            Private Set(value As ULong?)
                internal_widget_channel_id = value
            End Set
        End Property

        <JsonProperty("verification_level")>
        Private internal_verification_level As DiscordVerificationLevel

        <JsonIgnore>
        Property VerificationLevel As DiscordVerificationLevel
            Get
                Return internal_verification_level
            End Get
            Private Set(value As DiscordVerificationLevel)
                internal_verification_level = value
            End Set
        End Property

        <JsonProperty("default_message_notifications")>
        Private internal_default_message_notifications As DiscordDefaultMessageNotificationLevel

        <JsonIgnore>
        Property DefaultMessageNotificationLevel As DiscordDefaultMessageNotificationLevel
            Get
                Return internal_default_message_notifications
            End Get
            Private Set(value As DiscordDefaultMessageNotificationLevel)
                internal_default_message_notifications = value
            End Set
        End Property

        <JsonProperty("explicit_content_filter")>
        Private internal_explicit_content_filter As DiscordDefaultMessageNotificationLevel

        <JsonIgnore>
        Property ExplicitContentFilterLevel As DiscordExplicitContentFilterLevel
            Get
                Return internal_explicit_content_filter
            End Get
            Private Set(value As DiscordExplicitContentFilterLevel)
                internal_explicit_content_filter = value
            End Set
        End Property

        <JsonProperty("roles")>
        Private internal_roles As List(Of Role) = Nothing

        <JsonIgnore>
        Property Roles As List(Of Role)
            Get
                Return internal_roles
            End Get
            Private Set(value As List(Of Role))
                internal_roles = value
            End Set
        End Property

        'emojis

        <JsonProperty("mfa_level")>
        Private internal_mfa_level As DiscordMFALevel

        <JsonIgnore>
        Property MFALevel As DiscordMFALevel
            Get
                Return internal_mfa_level
            End Get
            Private Set(value As DiscordMFALevel)
                internal_mfa_level = value
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

        <JsonIgnore>
        Private internal_application_id As ULong?

        <JsonProperty("application_id")>
        Property RawApplicationID As String
            Get
                Return internal_application_id
            End Get
            Private Set(value As String)
                internal_application_id = value
            End Set
        End Property

        <JsonIgnore>
        Property ApplicationID As ULong?
            Get
                Return internal_application_id
            End Get
            Private Set(value As ULong?)
                internal_application_id = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_system_channel_id As ULong?

        <JsonProperty("system_channel_id")>
        Property RawSystemChannelID As String
            Get
                Return internal_system_channel_id
            End Get
            Private Set(value As String)
                internal_system_channel_id = value
            End Set
        End Property

        <JsonIgnore>
        Property SystemChannelID As ULong?
            Get
                Return internal_system_channel_id
            End Get
            Private Set(value As ULong?)
                internal_system_channel_id = value
            End Set
        End Property

        <JsonProperty("system_channel_flags")>
        Private internal_system_channel_flags As DiscordSystemChannelFlags

        <JsonIgnore>
        Property SystemChannelFlags As DiscordSystemChannelFlags
            Get
                Return internal_system_channel_flags
            End Get
            Private Set(value As DiscordSystemChannelFlags)
                internal_system_channel_flags = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_rules_channel_id As ULong?

        <JsonProperty("rules_channel_id")>
        Property RawRuleChannelID As String
            Get
                Return internal_rules_channel_id
            End Get
            Private Set(value As String)
                internal_rules_channel_id = value
            End Set
        End Property

        <JsonIgnore>
        Property RuleChannelID As ULong?
            Get
                Return internal_rules_channel_id
            End Get
            Private Set(value As ULong?)
                internal_rules_channel_id = value
            End Set
        End Property

        <JsonProperty("max_presences")>
        Private internal_max_presences As Integer?

        <JsonIgnore>
        Property MaxPresences As Integer
            Get
                If internal_max_presences.HasValue Then
                    Return internal_max_presences.Value
                Else
                    Return 25000
                End If
            End Get
            Private Set(value As Integer)
                internal_max_presences = value
            End Set
        End Property

        <JsonProperty("max_members")>
        Private internal_max_members As Integer

        <JsonIgnore>
        Property MaxMembers As Integer
            Get
                Return internal_max_members
            End Get
            Private Set(value As Integer)
                internal_max_members = value
            End Set
        End Property

        <JsonProperty("vanity_url_code")>
        Private internal_vanity_url_code As String = Nothing

        <JsonIgnore>
        Property VanityUrlCode As String
            Get
                Return internal_vanity_url_code
            End Get
            Private Set(value As String)
                internal_vanity_url_code = value
            End Set
        End Property

        <JsonIgnore>
        Property VanityUrl As String
            Get
                If String.IsNullOrWhiteSpace(internal_vanity_url_code) Then
                    Return Nothing
                Else
                    Return $"https://discord.gg/{internal_vanity_url_code}"
                End If
            End Get
            Private Set(value As String)
            End Set
        End Property

        <JsonProperty("description")>
        Private internal_description As String = Nothing

        <JsonIgnore>
        Property Description As String
            Get
                Return internal_description
            End Get
            Private Set(value As String)
                internal_description = value
            End Set
        End Property

        <JsonProperty("banner")>
        Private internal_banner As String = Nothing

        <JsonIgnore>
        Property BannerID As String
            Get
                Return internal_banner
            End Get
            Private Set(value As String)
                internal_banner = value
            End Set
        End Property

        <JsonProperty("premium_tier")>
        Private internal_premium_tier As DiscordPremiumTier

        <JsonIgnore>
        Property PremiumTier As DiscordPremiumTier
            Get
                Return internal_premium_tier
            End Get
            Private Set(value As DiscordPremiumTier)
                internal_premium_tier = value
            End Set
        End Property

        <JsonProperty("premium_subscription_count", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_premium_subscription_count As Integer?

        <JsonIgnore>
        Property PremiumSubscriptionCount As Integer
            Get
                If internal_premium_subscription_count.HasValue Then
                    Return internal_premium_subscription_count
                Else
                    Return 0
                End If
            End Get
            Private Set(value As Integer)
                internal_premium_subscription_count = value
            End Set
        End Property

        <JsonProperty("preferred_locale")>
        Private internal_preferred_locale As String = Nothing

        <JsonIgnore>
        Property PreferedLocale As String
            Get
                If String.IsNullOrWhiteSpace(internal_preferred_locale) Then
                    Return "en-US"
                Else
                    Return internal_preferred_locale
                End If
                Return internal_preferred_locale
            End Get
            Private Set(value As String)
                internal_preferred_locale = value
            End Set
        End Property

        <JsonIgnore>
        Private internal_public_updates_channel_id As ULong?

        <JsonProperty("public_updates_channel_id")>
        Property RawPublicUpdatesChannelID As String
            Get
                Return internal_public_updates_channel_id
            End Get
            Private Set(value As String)
                internal_public_updates_channel_id = value
            End Set
        End Property

        <JsonIgnore>
        Property PublicUpdatesChannelID As ULong?
            Get
                Return internal_public_updates_channel_id
            End Get
            Private Set(value As ULong?)
                internal_public_updates_channel_id = value
            End Set
        End Property

        <JsonProperty("premium_subscription_count")>
        Private internal_max_video_channel_users As Integer

        <JsonIgnore>
        Property MaxVideoChannelUsers As Integer
            Get
                Return internal_max_video_channel_users
            End Get
            Private Set(value As Integer)
                internal_max_video_channel_users = value
            End Set
        End Property

        <JsonProperty("approximate_member_count", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_approximate_member_count As Integer?

        <JsonIgnore>
        Property ApproximateMemberCount As Integer?
            Get
                Return internal_approximate_member_count
            End Get
            Private Set(value As Integer?)
                internal_approximate_member_count = value
            End Set
        End Property

        <JsonProperty("approximate_presence_count", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_approximate_presence_count As Integer?

        <JsonIgnore>
        Property ApproximatePresenceCount As Integer?
            Get
                Return internal_approximate_presence_count
            End Get
            Private Set(value As Integer?)
                internal_approximate_presence_count = value
            End Set
        End Property

#End Region

#Region "Functions"
        Function WithClient(client As DiscordAPI) As Guild
            Me.internal_client = client
            Return Me
        End Function
#End Region


    End Class
End Namespace

