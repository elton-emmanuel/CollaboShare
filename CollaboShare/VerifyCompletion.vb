Public Class VerifyCompletion
    Public Event VerifyCompletionBackEvent()
    Private Sub BackButtonVerifyCompletion_Click(sender As Object, e As EventArgs) Handles BackButtonVerifyCompletion.Click
        RaiseEvent VerifyCompletionBackEvent()
    End Sub
End Class
