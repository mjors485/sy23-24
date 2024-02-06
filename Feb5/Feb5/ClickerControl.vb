Public Class ClickerControl
    Public Property increment As Integer = 1
    Dim c As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.increment = increment
        c.click()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.reset()
        TextBox1.Text = c.count
    End Sub
End Class
