Public Class EditChores
    Public Event EditChoresBackEvent()
    Public Event EditChoresAddChoreNav()
    Private Sub BackButtonEditChores_Click(sender As Object, e As EventArgs) Handles BackButtonEditChores.Click
        RaiseEvent EditChoresBackEvent()
    End Sub

    Private Sub AddChoreButton_Click(sender As Object, e As EventArgs) Handles AddChoreButton.Click
        RaiseEvent EditChoresAddChoreNav()
    End Sub
End Class
