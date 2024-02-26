Public Class Form1
    Dim dollars As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dollars >= 1 Then
            dollars -= 1
            Label1.Text = dollars.ToString("c2")
            ReelControl1.Spin()
            ReelControl2.Spin()
            ReelControl3.Spin()
            r1Label.Text = ReelControl1.itemValue
            r2Label.Text = ReelControl2.itemValue
            r3Label.Text = ReelControl3.itemValue
        End If

        If ReelControl1.itemValue > 0 And
            ReelControl1.itemValue = ReelControl2.itemValue And
            ReelControl2.itemValue = ReelControl3.itemValue Then
            Label2.Text = "WIN"
        Else
            Label2.Text = "LOSE"
        End If
    End Sub

    Private Sub doButton_Click(sender As Object, e As EventArgs) Handles doButton.Click
        dollars += 1
        Label1.Text = dollars.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label2.Text = "WIN" Then
            dollars += 5
            Label1.Text = dollars.ToString("c2")
            Label2.Text = "___"
        End If
    End Sub
End Class
