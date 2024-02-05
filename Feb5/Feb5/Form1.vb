Public Class Form1
    Dim c1 As New Clicker
    Dim c2 As New Clicker
    Dim c3 As New Clicker
    Private Sub bButton_Click(sender As Object, e As EventArgs) Handles bButton.Click
        c1.increment = bNumericUpDown.Value
        c1.click()
        TextBox1.Text = c1.count
    End Sub

    Private Sub bReset_Click(sender As Object, e As EventArgs) Handles bReset.Click
        c1.reset()
        TextBox1.Text = c1.count
    End Sub

    Private Sub gButton_Click(sender As Object, e As EventArgs) Handles gButton.Click
        c2.increment = gNumericUpDown.Value
        c2.click()
        TextBox2.Text = c2.count
    End Sub

    Private Sub gReset_Click(sender As Object, e As EventArgs) Handles gReset.Click
        c2.reset()
        TextBox2.Text = c2.count
    End Sub

    Private Sub oButton_Click(sender As Object, e As EventArgs) Handles oButton.Click
        c3.increment = oNumericUpDown.Value
        c3.click()
        TextBox3.Text = c3.count
    End Sub

    Private Sub oReset_Click(sender As Object, e As EventArgs) Handles oReset.Click
        c3.reset()
        TextBox3.Text = c3.count
    End Sub
End Class
