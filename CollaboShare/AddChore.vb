Public Class AddChore
    Public Event AddChoreBackEvent()
    Private Sub BackButtonAddChores_Click(sender As Object, e As EventArgs) Handles BackButtonAddChores.Click
        RaiseEvent AddChoreBackEvent()
    End Sub
End Class
