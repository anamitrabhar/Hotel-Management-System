Public Class RoomListForm

    Inherits UserControl
    Private Shared _instance As RoomListForm
    Public Shared ReadOnly Property Instance() As RoomListForm
        Get
            If _instance Is Nothing Then
                _instance = New RoomListForm()

            End If
            Return _instance
        End Get
    End Property
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub
End Class
