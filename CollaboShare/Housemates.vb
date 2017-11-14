Public Class Housemates
    Public Event AddHouseMateEvent()
    Public Event HouseMateBackEvent()
    Private Sub HouseMatesAddBtn_Click(sender As Object, e As EventArgs) Handles HouseMatesAddBtn.Click
        RaiseEvent AddHouseMateEvent()
    End Sub

    Private Sub BackButtonHousemates_Click(sender As Object, e As EventArgs) Handles BackButtonHousemates.Click
        RaiseEvent HouseMateBackEvent()
    End Sub
End Class
