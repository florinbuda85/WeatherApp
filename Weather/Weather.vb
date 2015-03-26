Public Class Weather

    Private cityName As String
    Private countryCode As String

    Public myThread As System.Threading.Thread = Nothing
    Public webFetcher As WebFetcher = Nothing
    Public Delegate Sub UpdateDelegate(ByVal [msg] As WeatherInfo)
    Dim myDelegate As New UpdateDelegate(AddressOf updateWeatherField)



    Private Sub ButtonFetchData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFetchData.Click
        cityName = TextBoxCityName.Text.Trim
        countryCode = TextBoxCountryCode.Text

        If IsFormValid() Then
            Me.Cursor = Cursors.AppStarting
            myThread = New System.Threading.Thread(AddressOf doFetch)
            myThread.Start()
        End If
    End Sub

    Private Function IsFormValid()

        If cityName.Length <= 2 Then
            MsgBox("City name is invalid.")
            Return False
        End If

        If countryCode.Length < 2 Or countryCode.Length > 3 Then
            MsgBox("Country code is invalid.")
            Return False
        End If

        Return True

    End Function


    Public Sub updateWeatherField(ByVal [msg] As WeatherInfo)

        If msg IsNot Nothing Then
            Me.LabelCityName.Text = msg.City
            Me.LabelTemperature.Text = msg.Temperature
            Me.LabelWeatherDescription.Text = msg.WeatherDescription
            Me.PictureBoxImage.Image = WeatherImageFactory.getImage(msg.Icon)
            Me.Refresh()
        Else
            MsgBox("An error ocurred on fetching data. Check inputs and try again")
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Public Sub doFetch()
        webFetcher = New WebFetcher(cityName, countryCode)
        Dim weatherInfo As WeatherInfo = webFetcher.getWeatherInfo()

        If Me.Label3.InvokeRequired Then
            Me.Invoke(myDelegate, New Object() {weatherInfo})
        Else
            updateWeatherField(weatherInfo)
        End If
    End Sub

End Class
