Public Class CheckoutListForm

    Inherits UserControl
    Private Shared _instance As CheckoutListForm
    Public Shared ReadOnly Property Instance() As CheckoutListForm
        Get
            If _instance Is Nothing Then
                _instance = New CheckoutListForm()

            End If
            Return _instance
        End Get
    End Property
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub
End Class
