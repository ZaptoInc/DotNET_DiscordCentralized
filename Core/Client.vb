Namespace Core
    Public Class DiscordCentralizedClient
#Region "Internal Objects"
        Private Internal_Discord As DiscordAPI = Nothing
#End Region

#Region "External Objects"
        Property Discord As DiscordAPI
            Get
                Return Internal_Discord
            End Get
            Private Set(value As DiscordAPI)
                Internal_Discord = value
            End Set
        End Property
#End Region


#Region "Initialization Settings"
        Public Function WithDiscordToken(token As String, Optional token_type As DiscordAPITokenType = DiscordAPITokenType.Bot) As DiscordCentralizedClient
            Discord = New DiscordAPI(token, token_type)
            Return Me
        End Function
#End Region

#Region "New"
        Sub New()

        End Sub
#End Region

    End Class
End Namespace

