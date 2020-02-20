Public Class LoginForm

    
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        HomeForm.Show()


    End Sub
End Class