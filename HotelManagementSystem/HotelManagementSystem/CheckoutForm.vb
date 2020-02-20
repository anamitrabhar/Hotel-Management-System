Public Class CheckoutForm

    Inherits UserControl
    Private Shared _instance As CheckoutForm
    Public Shared ReadOnly Property Instance() As CheckoutForm
        Get
            If _instance Is Nothing Then
                _instance = New CheckoutForm()

            End If
            Return _instance
        End Get
    End Property
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub
End Class
