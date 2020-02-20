Public Class GuestListForm

    Inherits UserControl
    Private Shared _instance As GuestListForm
    Public Shared ReadOnly Property Instance() As GuestListForm
        Get
            If _instance Is Nothing Then
                _instance = New GuestListForm()

            End If
            Return _instance
        End Get
    End Property

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub
End Class
