Imports System.Net
Imports Flurl
Imports Flurl.Http

Namespace Core
    Public Class WebClient
        Private webrequest As IFlurlRequest

        Private UserAgent As String = "DiscordCentralized"

        Sub New()

        End Sub
        Sub New(request As IFlurlRequest)
            webrequest = request
        End Sub

        Sub New(request As Url)
            webrequest = request
        End Sub

        Async Function GetAsync(Of T)(Optional AllowAnyHttpStatus As Boolean = True) As Task(Of Web.Response(Of T))
            Try
                If AllowAnyHttpStatus Then
                    webrequest = webrequest.AllowAnyHttpStatus
                End If
                webrequest.WithHeader("User-Agent", UserAgent)
                Return New Web.Response(Of T)(Await webrequest.GetAsync())
            Catch ex As FlurlHttpException
                Return New Web.Response(Of T)(ex)
            End Try
        End Function

        Async Function PostJsonAsync(Of T)(data As Object, Optional AllowAnyHttpStatus As Boolean = True) As Task(Of Web.Response(Of T))
            Try
                If AllowAnyHttpStatus Then
                    webrequest = webrequest.AllowAnyHttpStatus
                End If
                webrequest.WithHeader("User-Agent", UserAgent)
                Return New Web.Response(Of T)(Await webrequest.PostJsonAsync(data))
            Catch ex As FlurlHttpException
                Return New Web.Response(Of T)(ex)
            End Try
        End Function
    End Class
End Namespace

