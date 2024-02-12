Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub nButton_Click(sender As Object, e As EventArgs) Handles nButton.Click
        cs.InsertNickel()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub diButton_Click(sender As Object, e As EventArgs) Handles diButton.Click
        cs.InsertDime()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub qButton_Click(sender As Object, e As EventArgs) Handles qButton.Click
        cs.InsertQuarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub doButton_Click(sender As Object, e As EventArgs) Handles doButton.Click
        cs.InsertDollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub returnButton_Click(sender As Object, e As EventArgs) Handles returnButton.Click
        cs.CoinReturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_CoinReturnEvent(n As Integer, di As Integer, q As Integer, dol As Integer) Handles cs.CoinReturnEvent
        If n > 0 Then
            nPictureBox.Visible = True
        Else
            nPictureBox.Visible = False
        End If

        If di > 0 Then
            diPictureBox.Visible = True
        Else
            diPictureBox.Visible = False
        End If

        If q > 0 Then
            qPictureBox.Visible = True
        Else
            qPictureBox.Visible = False
        End If

        If dol > 0 Then
            dolPictureBox.Visible = True
        Else
            dolPictureBox.Visible = False
        End If
    End Sub

    Private Sub buyButton_Click(sender As Object, e As EventArgs) Handles buyButton.Click
        Select Case idTextBox.Text
            Case ProductControl1.ProductID
                ProductControl1.Buy()
            Case 2

            Case Else

        End Select
        ProductControl1.Buy()
    End Sub
End Class
