Class MainWindow
    Private Sub pnlEventHandling_MouseDown(sender As Object, e As MouseButtonEventArgs)
        MessageBox.Show("You clicked me at " + e.GetPosition(Me).ToString())
    End Sub
End Class
