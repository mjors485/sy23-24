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
                cs.Buy(ProductControl1)
            Case ProductControl2.ProductID
                cs.Buy(ProductControl2)
            Case ProductControl3.ProductID
                cs.Buy(ProductControl3)
            Case ProductControl4.ProductID
                cs.Buy(ProductControl4)
            Case ProductControl5.ProductID
                cs.Buy(ProductControl5)
            Case ProductControl6.ProductID
                cs.Buy(ProductControl6)
            Case ProductControl7.ProductID
                cs.Buy(ProductControl7)
            Case ProductControl8.ProductID
                cs.Buy(ProductControl8)
            Case ProductControl9.ProductID
                cs.Buy(ProductControl9)
            Case ProductControl10.ProductID
                cs.Buy(ProductControl10)
            Case ProductControl11.ProductID
                cs.Buy(ProductControl11)
            Case ProductControl12.ProductID
                cs.Buy(ProductControl12)
            Case ProductControl13.ProductID
                cs.Buy(ProductControl13)
            Case ProductControl14.ProductID
                cs.Buy(ProductControl14)
            Case ProductControl15.ProductID
                cs.Buy(ProductControl15)
            Case ProductControl16.ProductID
                cs.Buy(ProductControl16)
        End Select
        Label1.Text = cs.total.ToString("C2")
    End Sub

    Private Sub ProductControl1_DispenseProduct(i As Image) Handles ProductControl1.DispenseProduct,
        ProductControl2.DispenseProduct,
        ProductControl3.DispenseProduct,
        ProductControl4.DispenseProduct,
        ProductControl5.DispenseProduct,
        ProductControl6.DispenseProduct,
        ProductControl7.DispenseProduct,
        ProductControl8.DispenseProduct,
        ProductControl9.DispenseProduct,
        ProductControl10.DispenseProduct,
        ProductControl11.DispenseProduct,
        ProductControl12.DispenseProduct,
        ProductControl13.DispenseProduct,
        ProductControl14.DispenseProduct,
        ProductControl15.DispenseProduct,
        ProductControl16.DispenseProduct
        productPictureBox.Image = i
    End Sub
End Class
