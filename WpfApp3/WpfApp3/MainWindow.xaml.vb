Class MainWindow
    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        Dim m As Integer
        Dim d As Integer
        m = cal1.SelectedDate.Value.Month
        d = cal1.SelectedDate.Value.Day
        If m = 3 And d >= 21 Or m = 4 And d <= 19 Then
            label1.Content = "Aries"
            ariIMG.Opacity = 100
        Else
            ariIMG.Opacity = 0
        End If
        If m = 4 And d >= 20 Or m = 5 And d <= 20 Then
            label1.Content = "Taurus "
            tauIMG.Opacity = 100
        Else
            tauIMG.Opacity = 0
        End If
        If m = 5 And d >= 21 Or m = 6 And d <= 20 Then
            label1.Content = "Gemini "
            gemIMG.Opacity = 100
        Else
            gemIMG.Opacity = 0
        End If
        If m = 6 And d >= 21 Or m = 7 And d <= 22 Then
            label1.Content = "Cancer "
            canIMG.Opacity = 100
        Else
            canIMG.Opacity = 0
        End If
        If m = 7 And d >= 23 Or m = 8 And d <= 22 Then
            label1.Content = "Leo "
            leoIMG.Opacity = 100
        Else
            leoIMG.Opacity = 0
        End If
        If m = 8 And d >= 23 Or m = 9 And d <= 22 Then
            label1.Content = "Virgo "
            virIMG.Opacity = 100
        Else
            virIMG.Opacity = 0
        End If
        If m = 9 And d >= 23 Or m = 10 And d <= 22 Then
            label1.Content = "Libra "
            libIMG.Opacity = 100
        Else
            libIMG.Opacity = 0
        End If
        If m = 10 And d >= 23 Or m = 11 And d <= 21 Then
            label1.Content = "Scorpio "
            scoIMG.Opacity = 100
        Else
            scoIMG.Opacity = 0
        End If
        If m = 11 And d >= 22 Or m = 12 And d <= 21 Then
            label1.Content = "Sagittarius "
            sagIMG.Opacity = 100
        Else
            sagIMG.Opacity = 0
        End If
        If m = 12 And d >= 22 Or m = 1 And d <= 19 Then
            label1.Content = "Capricorn "
            capIMG.Opacity = 100
        Else
            capIMG.Opacity = 0
        End If
        If m = 1 And d >= 20 Or m = 2 And d <= 18 Then
            label1.Content = "Aquarius "
            aquIMG.Opacity = 100
        Else
            aquIMG.Opacity = 0
        End If
        If m = 2 And d >= 19 Or m = 3 And d <= 20 Then
            label1.Content = "Pisces "
            pisIMG.Opacity = 100
        Else
            pisIMG.Opacity = 0
        End If
    End Sub
End Class
