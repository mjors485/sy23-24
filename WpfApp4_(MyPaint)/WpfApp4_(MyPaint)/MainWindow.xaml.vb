Imports Microsoft.Win32
Imports System.IO
Imports System.Xml

Class MainWindow
    Dim grad1 As Color
    Dim grad2 As Color
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
            Dim el As New Rectangle
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
        If shapeLabel.Content = "Polygon" Then
            Dim r As New Polygon
            r.Fill = colorRectangle1.Fill
            r.Points.Add(New Point(0, 8))
            r.Points.Add(New Point(2, 2))
            r.Points.Add(New Point(8, 0))
            r.Points.Add(New Point(2, -2))
            r.Points.Add(New Point(0, -8))
            r.Points.Add(New Point(-2, -2))
            r.Points.Add(New Point(-8, 0))
            r.Points.Add(New Point(-2, 2))
            Dim p As Point = Mouse.GetPosition(drawingCanvas)
            Canvas.SetLeft(r, p.X)
            Canvas.SetTop(r, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                drawingCanvas.Children.Add(r)
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

    Private Sub saveButton_Click(sender As Object, e As RoutedEventArgs) Handles saveButton.Click
        ExportToPng(drawingCanvas)
    End Sub

    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(drawingCanvas, 200)

        Canvas.SetTop(drawingCanvas, 10)

    End Sub

    Private Sub color1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color1.MouseDown
        grad1 = Color.FromRgb(r.Value, g.Value, b.Value)
        sender.fill = New SolidColorBrush(grad1)
    End Sub

    Private Sub color2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color2.MouseDown
        grad2 = Color.FromRgb(r.Value, g.Value, b.Value)
        sender.fill = New SolidColorBrush(grad2)
    End Sub

    Private Sub angleSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleSlider.ValueChanged
        colorRectangle1.Fill = New LinearGradientBrush(grad1, grad2, angleSlider.Value)
    End Sub

    Private Sub polygonButton_Click(sender As Object, e As RoutedEventArgs) Handles polygonButton.Click
        shapeLabel.Content = "Polygon"
    End Sub
End Class
