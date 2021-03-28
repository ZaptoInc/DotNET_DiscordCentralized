Imports System
Imports System.Collections.Generic
Imports System.Globalization

Namespace Core.Discord
    Friend Structure RateLimit
        Public ReadOnly Property IsGlobal As Boolean
        Public ReadOnly Property Limit As Integer?
        Public ReadOnly Property Remaining As Integer?
        Public ReadOnly Property RetryAfter As Integer?
        Public ReadOnly Property Reset As DateTimeOffset?
        Public ReadOnly Property ResetAfter As TimeSpan?
        Public ReadOnly Property Bucket As String
        Public ReadOnly Property Lag As TimeSpan?

        Friend Sub New(ByVal headers As Web.Headers)
            Dim temp As String = Nothing

            If headers.ContainsKey("x-ratelimit-global") Then
                IsGlobal = CType(headers("x-ratelimit-global"), Boolean)
            End If
            If headers.ContainsKey("x-ratelimit-limit") Then
                Limit = CType(headers("x-ratelimit-limit"), Integer)
            End If
            If headers.ContainsKey("x-ratelimit-remaining") Then
                Remaining = CType(headers("x-ratelimit-remaining"), Integer)
            End If
            If headers.ContainsKey("x-ratelimit-reset") Then
                Reset = DateTimeOffset.FromUnixTimeMilliseconds(CDbl(headers("x-ratelimit-reset").Replace(".", ",")) * 1000)
            End If
            If headers.ContainsKey("retry-after") Then
                RetryAfter = CType(headers("retry-after"), Integer)
            End If
            If headers.ContainsKey("x-ratelimit-reset-after") Then
                ResetAfter = TimeSpan.FromMilliseconds(CDbl(headers("x-ratelimit-reset-after").Replace(".", ",")) * 1000)
            End If
            If headers.ContainsKey("x-ratelimit-bucket") Then
                Bucket = headers("x-ratelimit-bucket")
            End If
            Dim [date] As DateTime = Nothing
            If headers.ContainsKey("date") Then
                [date] = Convert.ToDateTime(headers("date"))
                Lag = TimeSpan.FromMilliseconds(Date.UtcNow.Subtract([date]).TotalMilliseconds)
            End If
        End Sub

        Async Function AwaitRateLimit() As Task
            Dim NeedsWait As Boolean
            NeedsWait = False
            If IsGlobal Then NeedsWait = True
            If Remaining.HasValue Then
                If Remaining = 0 Then
                    NeedsWait = True
                End If
            End If
            If NeedsWait = True Then
                If ResetAfter.HasValue Then
                    Await Task.Delay(ResetAfter.Value)
                Else
                    If RetryAfter.HasValue Then
                        Await Task.Delay(RetryAfter.Value * 1000)
                    Else
                        Await Task.Delay(1000)
                    End If
                End If
            End If
            Return
        End Function
    End Structure
End Namespace
