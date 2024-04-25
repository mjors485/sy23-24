Class MainWindow
    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        Dim m As Integer
        Dim d As Integer
        m = cal1.SelectedDate.Value.Month
        d = cal1.SelectedDate.Value.Day
        If m = 3 And d >= 21 Or m = 4 And d <= 19 Then
            label1.Content = "Aries"
        End If
        If m = 4 And d >= 20 Or m = 5 And d <= 20 Then
            label1.Content = "Taurus "
        End If
        If m = 5 And d >= 21 Or m = 6 And d <= 20 Then
            label1.Content = "Gemini "
        End If
        If m = 6 And d >= 21 Or m = 7 And d <= 22 Then
            label1.Content = "Cancer "
        End If
        If m = 7 And d >= 23 Or m = 8 And d <= 22 Then
            label1.Content = "Leo "
        End If
        If m = 8 And d >= 23 Or m = 9 And d <= 22 Then
            label1.Content = "Virgo "
        End If
        If m = 9 And d >= 23 Or m = 10 And d <= 22 Then
            label1.Content = "Libra "
        End If
        If m = 10 And d >= 23 Or m = 11 And d <= 21 Then
            label1.Content = "Scorpio "
        End If
        If m = 11 And d >= 22 Or m = 12 And d <= 21 Then
            label1.Content = "Sagittarius "
        End If
        If m = 12 And d >= 22 Or m = 1 And d <= 19 Then
            label1.Content = "Capricorn "
        End If
        If m = 1 And d >= 20 Or m = 2 And d <= 18 Then
            label1.Content = "Aquarius "
        End If
        If m = 2 And d >= 19 Or m = 3 And d <= 20 Then
            label1.Content = "Pisces "
        End If
    End Sub
End Class
