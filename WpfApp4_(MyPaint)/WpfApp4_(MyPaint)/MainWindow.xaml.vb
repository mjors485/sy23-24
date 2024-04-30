Class MainWindow
    Private Sub drawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingCanvas.MouseMove
        Dim el As New Ellipse
        el.Width = widthSlider.Value
        el.Height = heightSlider.Value
        el.Fill = colorRectangle1.Fill
        Dim p As Point = Mouse.GetPosition(drawingCanvas)
        Canvas.SetLeft(el, p.X)
        Canvas.SetTop(el, p.Y)
        If e.LeftButton = MouseButtonState.Pressed Then
            drawingCanvas.Children.Add(el)
        End If
    End Sub

    Private Sub color2Rectangle_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color2Rectangle.MouseDown, color1Rectangle.MouseDown, color3Rectangle.MouseDown, color4Rectangle.MouseDown
        colorRectangle1.Fill = sender.fill
    End Sub
End Class
