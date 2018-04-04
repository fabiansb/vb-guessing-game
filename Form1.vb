Public Class Form1
    Private Sub ShowAnswerButton_Click(sender As Object, e As EventArgs) Handles ShowAnswerButton.Click
        AnswerLabel.Text = "Theodore Roosevelt"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
