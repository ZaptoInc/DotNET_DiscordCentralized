Imports Flurl.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace Core.Web
    Public Class Response(Of T)
        Public Headers As New Headers
        Public AsString As String
        Public AsJSON As JToken
        Public AsObject As T
        Public Status As Integer? = Nothing

        Sub New()

        End Sub

        Sub New(resp As IFlurlResponse)
            Dim temp_headers = New Dictionary(Of String, String)
            For Each header In resp.Headers
                temp_headers.Add(header.Name.ToLower, header.Value)
            Next
            Headers.AsDictionary = temp_headers
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

