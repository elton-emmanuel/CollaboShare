Public Class ChoresMenu
    Public Event ChoresMenuBackEvent()
    Public Event ChoresMenuViewChoresNav()
    Public Event ChoresMenuEditChoresNav()
    Public Event ChoresMenuTradeChoresNav()
    Public Event ChoresMenuVerifyCompletionNav()
    Private Sub BackButtonChoresMenu_Click(sender As Object, e As EventArgs) Handles BackButtonChoresMenu.Click
        RaiseEvent ChoresMenuBackEvent()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles DistributeChoresButton.Click

    End Sub

    Private Sub ViewChoresButton_Click(sender As Object, e As EventArgs) Handles ViewChoresButton.Click
        RaiseEvent ChoresMenuViewChoresNav()
    End Sub

    Private Sub EditChoresButton_Click(sender As Object, e As EventArgs) Handles EditChoresButton.Click
        RaiseEvent ChoresMenuEditChoresNav()
    End Sub

    Private Sub TradeChoresButton_Click(sender As Object, e As EventArgs) Handles TradeChoresButton.Click
        RaiseEvent ChoresMenuTradeChoresNav()
    End Sub

    Private Sub VerifyCompletionButton_Click(sender As Object, e As EventArgs) Handles VerifyCompletionButton.Click
        RaiseEvent ChoresMenuVerifyCompletionNav()
    End Sub
End Class
