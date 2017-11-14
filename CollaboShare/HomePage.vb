Public Class HomePage
    Public Event HouseMatesNav()
    Public Event HomePageBackEvent()
    Public Event HomePageSignOutEvent()
    Public Event HomePageChoresNav()
    Private Sub Login1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChoresHome_Click(sender As Object, e As EventArgs) Handles ChoresHome.Click
        RaiseEvent HomePageChoresNav()
    End Sub

    Private Sub HousematesHome_Click(sender As Object, e As EventArgs) Handles HousematesHome.Click
        RaiseEvent HouseMatesNav()
    End Sub

    Private Sub BackButtonHome_Click(sender As Object, e As EventArgs) Handles BackButtonHome.Click
        RaiseEvent HomePageBackEvent()
    End Sub

    Private Sub SignOutButton_Click(sender As Object, e As EventArgs) Handles SignOutButton.Click
        RaiseEvent HomePageSignOutEvent()
    End Sub
End Class
