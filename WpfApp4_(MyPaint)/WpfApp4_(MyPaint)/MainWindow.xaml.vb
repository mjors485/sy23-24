Class MainWindow
    Private Sub drawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingCanvas.MouseMove
        If shapeLabel.Content = "Elipse" Then
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
        End If
        If shapeLabel.Content = "Rectangle" Then
            Dim re As New Rectangle
            re.Width = widthSlider.Value
            re.Height = heightSlider.Value
            re.Fill = colorRectangle1.Fill
            Dim p As Point = Mouse.GetPosition(drawingCanvas)
            Canvas.SetLeft(re, p.X)
            Canvas.SetTop(re, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                drawingCanvas.Children.Add(re)
            End If
        End If
    End Sub

    Private Sub color2Rectangle_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color2Rectangle.MouseDown, color1Rectangle.MouseDown, color3Rectangle.MouseDown, color4Rectangle.MouseDown, color5Rectangle.MouseDown
        colorRectangle1.Fill = sender.fill
    End Sub

    Private Sub clearButton_Click(sender As Object, e As RoutedEventArgs) Handles clearButton.Click
        drawingCanvas.Children.RemoveRange(1, drawingCanvas.Children.Count - 1)
    End Sub

    Private Sub undoButton_Click(sender As Object, e As RoutedEventArgs) Handles undoButton.Click
        drawingCanvas.Children.RemoveAt(drawingCanvas.Children.Count - 1)
    End Sub

    Private Sub elipseButton_Click(sender As Object, e As RoutedEventArgs) Handles elipseButton.Click, rectangleButton.Click
        shapeLabel.Content = sender.content
    End Sub
End Class
