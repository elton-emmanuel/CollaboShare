Public Class AddHousemate
    Public Event AddHouseMateBack()
    Private Sub BackButtonAddHousemate_Click(sender As Object, e As EventArgs) Handles BackButtonAddHousemate.Click
        RaiseEvent AddHouseMateBack()
    End Sub
End Class
