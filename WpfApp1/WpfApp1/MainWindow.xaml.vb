﻿Class MainWindow
    Private Sub Clear(sender As Object, e As RoutedEventArgs) Handles clearButton.Click
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
        TextBox13.Text = ""
        submitButton.IsEnabled = False
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TextBox1.TextChanged,
        TextBox2.TextChanged,
        TextBox3.TextChanged,
        TextBox4.TextChanged,
        TextBox5.TextChanged,
        TextBox6.TextChanged,
        TextBox7.TextChanged,
        TextBox8.TextChanged,
        TextBox9.TextChanged,
        TextBox10.TextChanged,
        TextBox11.TextChanged,
        TextBox12.TextChanged,
        TextBox13.TextChanged

        If TextBox1.Text <> "" And
            TextBox2.Text <> "" And
            TextBox3.Text Like "###############*" And
            TextBox4.Text Like "###" And
            TextBox5.Text Like "#*" And
            TextBox6.Text Like "##*" And
            TextBox7.Text <> "" And
            TextBox8.Text <> "" And
            TextBox9.Text <> "" And
            TextBox10.Text Like "#####" And
            TextBox11.Text <> "" And
            TextBox12.Text Like "*@*.*" And
            TextBox13.Text Like "##########" Then
            submitButton.IsEnabled = True
        Else
            submitButton.IsEnabled = False
        End If
    End Sub

End Class
