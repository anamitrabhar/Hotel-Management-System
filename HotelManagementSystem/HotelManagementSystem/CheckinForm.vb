Public Class CheckinForm

    Inherits UserControl
    Private Shared _instance As CheckinForm
    Public Shared ReadOnly Property Instance() As CheckinForm
        Get
            If _instance Is Nothing Then
                _instance = New CheckinForm()

            End If
            Return _instance
        End Get
    End Property

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub

End Class
