Imports Newtonsoft.Json

Namespace Core.TopGG
    Public Class BotStatsUpdate

        <JsonIgnore>
        Private internal_bot_id As ULong? = Nothing

        <JsonIgnore>
        Property BotID As ULong
            Get
                Return internal_bot_id
            End Get
            Private Set(value As ULong)
                internal_bot_id = value
            End Set
        End Property

        <JsonProperty("server_count")>
        Private internal_server_count As Integer

        <JsonIgnore>
        Property ServerCount As Integer
            Get
                Return internal_server_count
            End Get
            Private Set(value As Integer)
                internal_server_count = value
            End Set
        End Property

        <JsonProperty("shards", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_shards As List(Of Integer) = Nothing

        <JsonIgnore>
        Property Shards As List(Of Integer)
            Get
                Return internal_shards
            End Get
            Private Set(value As List(Of Integer))
                internal_shards = value
            End Set
        End Property

        <JsonProperty("shard_id", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_shard_id As Integer?

        <JsonIgnore>
        Property ShardID As Integer?
            Get
                Return internal_shard_id
            End Get
            Private Set(value As Integer?)
                internal_shard_id = value
            End Set
        End Property

        <JsonProperty("shard_count", NullValueHandling:=NullValueHandling.Ignore)>
        Private internal_shard_count As Integer?

        <JsonIgnore>
        Property ShardCount As Integer?
            Get
                Return internal_shard_count
            End Get
            Private Set(value As Integer?)
                internal_shard_count = value
            End Set
        End Property

        Sub New()

        End Sub
    End Class
End Namespace

