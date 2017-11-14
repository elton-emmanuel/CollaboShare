Public Class AddHousehold
    Public Event AddHouseholdBackEvent()
    Private Sub BackButtonAddHousehold_Click(sender As Object, e As EventArgs) Handles BackButtonAddHousehold.Click
        RaiseEvent AddHouseholdBackEvent()
    End Sub
End Class
