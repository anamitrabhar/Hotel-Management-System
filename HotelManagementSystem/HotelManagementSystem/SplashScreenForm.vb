Public Class SplashScreenForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ProgressBar1.Width += 1
            If ProgressBar1.Width >= 228 Then
                Timer1.[Stop]()
                LoginForm.Show()
                Me.Hide()


            End If


        Catch generatedExceptionName As Exception
            Return


        End Try

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
