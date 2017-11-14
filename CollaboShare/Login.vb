Public Class Login
    Public Event Log_LoginButtonClick()
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles LoginUsernameLabel.Click

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        RaiseEvent Log_LoginButtonClick()
    End Sub
End Class
