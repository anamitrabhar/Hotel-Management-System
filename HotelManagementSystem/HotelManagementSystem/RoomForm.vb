Public Class RoomForm

    Inherits UserControl
    Private Shared _instance As RoomForm
    Public Shared ReadOnly Property Instance() As RoomForm
        Get
            If _instance Is Nothing Then
                _instance = New RoomForm()

            End If
            Return _instance
        End Get
    End Property
   
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub
End Class
