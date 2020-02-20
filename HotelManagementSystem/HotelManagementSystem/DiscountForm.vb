Public Class DiscountForm
    Inherits UserControl
    Private Shared _instance As DiscountForm
    Public Shared ReadOnly Property Instance() As DiscountForm
        Get
            If _instance Is Nothing Then
                _instance = New DiscountForm()

            End If
            Return _instance
        End Get
    End Property

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub
End Class
