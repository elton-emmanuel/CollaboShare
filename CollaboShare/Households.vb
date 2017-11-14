Public Class Households
    Public Event Select_HouseholdNameClick()
    Private Sub HouseholdName_Click(sender As Object, e As EventArgs) Handles HouseholdName.Click
        RaiseEvent Select_HouseholdNameClick()
    End Sub
End Class
