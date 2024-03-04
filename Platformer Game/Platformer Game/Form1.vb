Public Class Frm2DPlatformer
    Dim movespeed As Integer = 15
    Dim isJumping As Boolean
    Private Sub Frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.D
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.A
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
            Case Keys.W
                tmrUp.Start()
                isJumping = True

        End Select
    End Sub
    Private Sub Frm2DPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.D
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.A
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
            Case Keys.W
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += movespeed
    End Sub


    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= movespeed

    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
                If b.Tag = "exit" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) And picPlayer.Visible = True Then
                        tmrGravity.Stop()
                        b.BackColor = Color.Black
                        Label1.Visible = False
                        picPlayer.Visible = False
                        Label2.Visible = True
                    End If
                End If
                If b.Tag = "enemy" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                        picPlayer.Visible = False
                        Label2.Text = "You Lose"
                        Label2.Visible = True
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += movespeed
    End Sub
End Class
