Imports Flurl.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Core.Web
    Public Class Response(Of T)
        Public Headers As Flurl.Util.IReadOnlyNameValueList(Of String)
        Public AsString As String
        Public AsJSON As JToken
        Public AsObject As T
        Public Status As Integer? = Nothing

        Sub New()

        End Sub

        Sub New(resp As IFlurlResponse)
            Headers = resp.Headers
            AsString = resp.GetStringAsync().Result
            Try
                AsJSON = JsonConvert.DeserializeObject(Of Object)(AsString)
            Catch
            End Try

            Try
                AsObject = JsonConvert.DeserializeObject(Of T)(AsString)
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

