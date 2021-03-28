Imports Flurl.Http
Imports Newtonsoft.Json.Linq

Namespace Core
    Public Class WebResponse(Of T)
        Public Headers As Dictionary(Of String, String)
        Public AsJSON As Object
        Public AsObject As T
        Public Status As Integer? = Nothing

        Sub New()

        End Sub

        Sub New(resp As IFlurlResponse)
            Headers = New Dictionary(Of String, String)
            For Each header In resp.Headers
                Headers.Add(header.Name, header.Value)
            Next
            AsJSON = resp.GetJsonAsync().Result
            Try
                AsObject = JObject.FromObject(AsJSON).ToObject(Of T)
            Catch
            End Try

            Status = resp.StatusCode
        End Sub

        Sub New(resp As FlurlHttpException)
            AsJSON = resp.GetResponseJsonAsync.Result
            AsObject = resp.GetResponseJsonAsync(Of T).Result
            Status = resp.StatusCode
        End Sub
    End Class
End Namespace

