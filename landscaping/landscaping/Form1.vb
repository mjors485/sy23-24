Public Class Form1
    Dim area As Integer
    Dim perimeter As Integer
    Dim length As Integer
    Dim width As Integer
    Dim price As Decimal = 0
    Private Sub TB_TextChanged(sender As Object, e As EventArgs) Handles widthTB.TextChanged, lengthTB.TextChanged
        If widthTB.Text <> "" And lengthTB.Text <> "" Then
            width = widthTB.Text
            length = lengthTB.Text
            area = (width * length)
            areaTB.Text = area
            perimeter = ((width * 2) + length)
            perimeterTB.Text = perimeter
        Else area = 0
            areaTB.Text = area
            perimeter = 0
            perimeterTB.Text = perimeter
        End If
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        spaceLabel.Visible = False
        price = 0
        If widthTB.Text <> "" And lengthTB.Text <> "" Then
            width = widthTB.Text
            length = lengthTB.Text
            area = (width * length)
            perimeter = ((width * 2) + length)
        Else area = 0
            perimeter = 0
        End If

        If CheckBox1.Checked = True Then
            If area > 500 Then
                area -= 500
                price += 50000
            Else
                spaceLabel.Visible = True
            End If
        End If
        If CheckBox2.Checked = True Then
            If area > 2000 Then
                area -= 2000
                price += 2500
            Else
                spaceLabel.Visible = True
            End If
        End If
        If CheckBox3.Checked = True Then
            price += 2000
        End If
        If CheckBox4.Checked = True Then
            price += 1000
        End If
        If CheckBox5.Checked = True Then
            price += 1250
        End If
        If CheckBox6.Checked = True Then
            price += 5000
        End If

        price += NumericUpDown1.Value
        price += NumericUpDown2.Value * 5
        price += NumericUpDown3.Value * 10
        price += NumericUpDown4.Value * 200

        If RadioButton1.Checked = True Then
            price += area * 1.5
        ElseIf RadioButton2.Checked = True Then
            price += area * 10
        ElseIf RadioButton3.Checked = True Then
            price += area * 0.5
        ElseIf RadioButton4.Checked = True Then
            price += area * 12
        End If
        priceTB.Text = price.ToString("C2")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        pbFloor.BackColor = Color.DarkGray
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        pbFloor.BackColor = Color.Tan
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        pbFloor.BackColor = Color.LightGreen
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        pbFloor.BackColor = Color.LimeGreen
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If NumericUpDown4.Value >= 1 Then
            pbTree.Visible = True
        Else
            pbTree.Visible = False
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value >= 1 Then
            pbSP.Visible = True
        Else
            pbSP.Visible = False
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value >= 1 Then
            pbMP.Visible = True
        Else
            pbMP.Visible = False
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If NumericUpDown3.Value >= 1 Then
            pbLP.Visible = True
        Else
            pbLP.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Or NumericUpDown1.Value >= 1 Then
            pbSP.Visible = True
        Else
            pbSP.Visible = False
        End If

        If CheckBox3.Checked Or NumericUpDown2.Value >= 1 Then
            pbMP.Visible = True
        Else
            pbMP.Visible = False
        End If

        If CheckBox3.Checked Or NumericUpDown3.Value >= 1 Then
            pbLP.Visible = True
        Else
            pbLP.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            pbPool.Visible = True
        Else
            pbPool.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            pbBasket.Visible = True
        Else
            pbBasket.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            pbPlay.Visible = True
        Else
            pbPlay.Visible = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            pbFire.Visible = True
        Else
            pbFire.Visible = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            pbHot.Visible = True
        Else
            pbHot.Visible = False
        End If
    End Sub
End Class
