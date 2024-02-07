Public Class Form1
    Dim cs As New CoinSlot
    Private Sub nButton_Click(sender As Object, e As EventArgs) Handles nButton.Click
        cs.InsertNickel()
        Label1.Text = cs.total
    End Sub

    Private Sub diButton_Click(sender As Object, e As EventArgs) Handles diButton.Click
        cs.InsertDime()
        Label1.Text = cs.total
    End Sub

    Private Sub qButton_Click(sender As Object, e As EventArgs) Handles qButton.Click
        cs.InsertQuarter()
        Label1.Text = cs.total
    End Sub

    Private Sub doButton_Click(sender As Object, e As EventArgs) Handles doButton.Click
        cs.InsertDollar()
        Label1.Text = cs.total
    End Sub
End Class
