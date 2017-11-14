Public Class ViewChores
    Public Event ViewChoresBackEvent()
    Private Sub BackButtonViewChores_Click(sender As Object, e As EventArgs) Handles BackButtonViewChores.Click
        RaiseEvent ViewChoresBackEvent()
    End Sub
End Class
