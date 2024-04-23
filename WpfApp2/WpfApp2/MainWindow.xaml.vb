Class MainWindow
    Private Sub Yen_Checked(sender As Object, e As RoutedEventArgs) Handles Yen.Checked
        cLabel.Content = (USDtext.Text * 154.8).ToString("c2")
    End Sub

    Private Sub CAD_Checked(sender As Object, e As RoutedEventArgs) Handles CAD.Checked
        cLabel.Content = (USDtext.Text * 1.37).ToString("c2")
    End Sub

    Private Sub AUD_Checked(sender As Object, e As RoutedEventArgs) Handles AUD.Checked
        cLabel.Content = (USDtext.Text * 1.54).ToString("c2")
    End Sub

    Private Sub Euro_Checked(sender As Object, e As RoutedEventArgs) Handles Euro.Checked
        cLabel.Content = (USDtext.Text * 0.93).ToString("c2")
    End Sub

    Private Sub Franc_Checked(sender As Object, e As RoutedEventArgs) Handles Franc.Checked
        cLabel.Content = (USDtext.Text * 0.91).ToString("c2")
    End Sub

    Private Sub Pound_Checked(sender As Object, e As RoutedEventArgs) Handles Pound.Checked
        cLabel.Content = (USDtext.Text * 0.8).ToString("c2")
    End Sub

    Private Sub clearButton_Click(sender As Object, e As RoutedEventArgs) Handles clearButton.Click
        cLabel.Content = ""
        USDtext.Text = ""
    End Sub
End Class
