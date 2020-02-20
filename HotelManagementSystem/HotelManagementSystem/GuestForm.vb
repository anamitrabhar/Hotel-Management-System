Public Class GuestForm

    Inherits UserControl
    Private Shared _instance As GuestForm
    Public Shared ReadOnly Property Instance() As GuestForm
        Get
            If _instance Is Nothing Then
                _instance = New GuestForm()

            End If
            Return _instance
        End Get
    End Property

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub
End Class
