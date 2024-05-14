Class MainWindow
    Private Sub Submit(sender As Object, e As RoutedEventArgs) Handles submitButton.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        submitButton.IsEnabled = False
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TextBox1.TextChanged,
        TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged, TextBox10.TextChanged, TextBox11.TextChanged, TextBox12.TextChanged
        submitButton.IsEnabled = False
    End Sub

    Private Sub paypal_Checked(sender As Object, e As RoutedEventArgs) Handles paypal.Checked
        TextBox3.Visibility = Visibility.Hidden
        Label3.Visibility = Visibility.Hidden
        TextBox4.Visibility = Visibility.Hidden
        Label4.Visibility = Visibility.Hidden
        TextBox5.Visibility = Visibility.Hidden
        Label5.Visibility = Visibility.Hidden
        TextBox6.Visibility = Visibility.Hidden
        Label5_Copy.Visibility = Visibility.Hidden
        TextBox12.Visibility = Visibility.Visible
        Label3_Copy.Visibility = Visibility.Visible
        If paypal.IsChecked And
            TextBox1.Text <> "" And
            TextBox2.Text <> "" And
            TextBox7.Text <> "" And
            TextBox8.Text <> "" And
            TextBox9.Text <> "" And
            TextBox10.Text Like "#####" And
            TextBox11.Text <> "" And
            TextBox12.Text Like "*@*.*" Then
            submitButton.IsEnabled = True
        Else
            submitButton.IsEnabled = False
        End If
    End Sub

    Private Sub credit_Checked(sender As Object, e As RoutedEventArgs) Handles credit.Checked
        TextBox3.Visibility = Visibility.Visible
        Label3.Visibility = Visibility.Visible
        TextBox4.Visibility = Visibility.Visible
        Label4.Visibility = Visibility.Visible
        TextBox5.Visibility = Visibility.Visible
        Label5.Visibility = Visibility.Visible
        TextBox6.Visibility = Visibility.Visible
        Label5_Copy.Visibility = Visibility.Visible
        TextBox12.Visibility = Visibility.Hidden
        Label3_Copy.Visibility = Visibility.Hidden
        If credit.IsChecked And
            TextBox1.Text <> "" And
            TextBox2.Text <> "" And
            TextBox3.Text Like "###############*" And
            TextBox4.Text Like "###" And
            TextBox5.Text Like "#*" And
            TextBox6.Text Like "##*" And
            TextBox7.Text <> "" And
            TextBox8.Text <> "" And
            TextBox9.Text <> "" And
            TextBox10.Text Like "#####" And
            TextBox11.Text <> "" Then
            submitButton.IsEnabled = True
        Else
            submitButton.IsEnabled = False
        End If
    End Sub
End Class
