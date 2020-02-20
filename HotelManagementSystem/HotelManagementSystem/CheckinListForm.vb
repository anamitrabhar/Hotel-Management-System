Public Class CheckinListForm
    Inherits UserControl
    Private Shared _instance As CheckinListForm
    Public Shared ReadOnly Property Instance() As CheckinListForm
        Get
            If _instance Is Nothing Then
                _instance = New CheckinListForm()

            End If
            Return _instance
        End Get
    End Property
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()

    End Sub

    
End Class
