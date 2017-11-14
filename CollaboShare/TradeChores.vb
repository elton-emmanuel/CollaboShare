Public Class TradeChores
    Public Event TradeChoresBackEvent()
    Private Sub BackButtonTradeChores_Click(sender As Object, e As EventArgs) Handles BackButtonTradeChores.Click
        RaiseEvent TradeChoresBackEvent()
    End Sub
End Class
