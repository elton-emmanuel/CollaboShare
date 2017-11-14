Public Class SelectHousehold
    Public Event Event1()
    Public Event SelectHouseHoldAddHouseHoldEvent()



    Private Sub Household1_Load(sender As Object, e As EventArgs) Handles Household1.Load

    End Sub

    Private Sub AddChoresBackground_Click(sender As Object, e As EventArgs) Handles AddChoresBackground.Click
        MessageBox.Show("Hello")
    End Sub

    Private Sub Household1_MouseClick(sender As Object, e As MouseEventArgs) Handles Household1.MouseClick
        MessageBox.Show("Hello")
    End Sub
    Private Sub Method() Handles Household1.Select_HouseholdNameClick
        RaiseEvent Event1()


    End Sub

    Private Sub AddNewHouseholdButton_Click(sender As Object, e As EventArgs) Handles AddNewHouseholdButton.Click
        RaiseEvent SelectHouseHoldAddHouseHoldEvent()
    End Sub
End Class
