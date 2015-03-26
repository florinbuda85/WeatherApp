Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq



Public Class WebFetcher
    Private ReadOnly m_Path As String = "http://api.openweathermap.org/data/2.5/weather?q="
    Private ReadOnly m_ApiKey As String = "adefc6767ca95569cbf94d14c2b21353"
    'Temperature, Kelvin (subtract 273.15 to convert to Celsius)

    Private m_CityName As String
    Private m_CountryCode As String

    Public Sub New(ByVal CityName As String, ByVal CountryCode As String)
        Me.m_CityName = CityName
        Me.m_CountryCode = CountryCode
    End Sub


    Private Function createURL() As String
        Return m_Path + System.Net.WebUtility.HtmlEncode(m_CityName) + "," + m_CountryCode
    End Function


    Public Function getWeatherInfo() As WeatherInfo
        Dim RequestURL As String = createURL()
        Dim Content As String = getContent(RequestURL)

        Dim json As JObject = JObject.Parse(Content)

        Dim weatherInfo As WeatherInfo = New WeatherInfo

        weatherInfo.City = m_CityName
        Try
            weatherInfo.Temperature = makeTempString(json.SelectToken("main").SelectToken("temp").ToString())
            weatherInfo.WeatherDescription = json.SelectToken("weather").ElementAt(0).SelectToken("main").ToString() + " / " + json.SelectToken("weather").ElementAt(0).SelectToken("description").ToString()
            weatherInfo.Icon = json.SelectToken("weather").ElementAt(0).SelectToken("icon")

            Return weatherInfo
        Catch
            Return Nothing
        End Try

    End Function

    Private Function makeTempString(ByVal temp As String) As String
        Return String.Format("{0:f2}", Convert.ToDecimal(temp) - 273.15) + " °C"
    End Function




    Private Function getContent(ByVal url As String) As String
        Try
            ' Create a request for the URL. 		 
            Dim request As WebRequest = WebRequest.Create(url)
            ' If required by the server, set the credentials.
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            ' Get the stream containing content returned by the server. 
            Dim dataStream As Stream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access. 
            Dim reader As New StreamReader(dataStream)
            ' Read the content. 
            Dim responseFromServer As String = reader.ReadToEnd()
            ' Cleanup the streams and the response.
            reader.Close()
            dataStream.Close()
            response.Close()
            Return responseFromServer
        Catch
            Return Nothing
        End Try
    End Function 'Main


End Class
