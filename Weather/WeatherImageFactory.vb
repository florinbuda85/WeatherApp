Imports System.Drawing.Image

Public Class WeatherImageFactory

    Public Shared Function getImage(ByVal name As String) As Image

        Select Case name
            Case "01d"
                Return My.Resources._01d
            Case "01n"
                Return My.Resources._01n
            Case "02d"
                Return My.Resources._02d
            Case "02n"
                Return My.Resources._02n
            Case "03d"
                Return My.Resources._03d
            Case "03n"
                Return My.Resources._03n
            Case "04d"
                Return My.Resources._04d
            Case "04n"
                Return My.Resources._04n
            Case "09d"
                Return My.Resources._09d
            Case "09n"
                Return My.Resources._09n
            Case "10d"
                Return My.Resources._10d
            Case "10n"
                Return My.Resources._10n
            Case "11d"
                Return My.Resources._11d
            Case "11n"
                Return My.Resources._11n
            Case "13d"
                Return My.Resources._13d
            Case "13n"
                Return My.Resources._13n
            Case "50d"
                Return My.Resources._50d
            Case "50n"
                Return My.Resources._50n
            Case Else
                Return My.Resources._01d 'TODO: put an error image perhaps
        End Select

    End Function


End Class
