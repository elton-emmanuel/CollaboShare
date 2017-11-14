Public Class Form
    Sub Main()
        AddHandler Login.Log_LoginButtonClick, AddressOf LoginButton_Click
        AddHandler SelectHousehold.Event1, AddressOf Method
        AddHandler HomePage.HouseMatesNav, AddressOf HousematesHome_Click
        AddHandler Housemates.AddHouseMateEvent, AddressOf HouseMatesAddBtn_Click
        AddHandler AddHousemate.AddHouseMateBack, AddressOf BackButtonAddHousemate_Click
        AddHandler Housemates.HouseMateBackEvent, AddressOf BackButtonHousemates_Click
        AddHandler HomePage.HomePageBackEvent, AddressOf BackButtonHome_Click
        AddHandler HomePage.HomePageSignOutEvent, AddressOf SignOutButton_Click
        AddHandler SelectHousehold.SelectHouseHoldAddHouseHoldEvent, AddressOf AddNewHouseholdButton_Click
        AddHandler AddHousehold.AddHouseholdBackEvent, AddressOf BackButtonAddHousehold_Click
        AddHandler HomePage.HomePageChoresNav, AddressOf ChoresHome_Click
        AddHandler ChoresMenu.ChoresMenuBackEvent, AddressOf BackButtonChoresMenu_Click
        AddHandler ChoresMenu.ChoresMenuViewChoresNav, AddressOf ViewChoresButton_Click
        AddHandler ViewChores.ViewChoresBackEvent, AddressOf BackButtonViewChores_Click
        AddHandler ChoresMenu.ChoresMenuEditChoresNav, AddressOf EditChoresButton_Click
        AddHandler EditChores.EditChoresBackEvent, AddressOf BackButtonEditChores_Click
        AddHandler EditChores.EditChoresAddChoreNav, AddressOf AddChoreButton_Click
        AddHandler AddChore.AddChoreBackEvent, AddressOf BackButtonAddChores_Click
        AddHandler ChoresMenu.ChoresMenuTradeChoresNav, AddressOf TradeChoresButton_Click
        AddHandler TradeChores.TradeChoresBackEvent, AddressOf BackButtonTradeChores_Click
        AddHandler ChoresMenu.ChoresMenuVerifyCompletionNav, AddressOf VerifyCompletionButton_Click
        AddHandler VerifyCompletion.VerifyCompletionBackEvent, AddressOf BackButtonVerifyCompletion_Click
    End Sub

    Private Sub BackButtonVerifyCompletion_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub VerifyCompletionButton_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonTradeChores_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub TradeChoresButton_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonAddChores_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub AddChoreButton_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonEditChores_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub EditChoresButton_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonViewChores_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub ViewChoresButton_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonChoresMenu_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub ChoresHome_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonAddHousehold_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub AddNewHouseholdButton_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub SignOutButton_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonHome_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonHousemates_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub BackButtonAddHousemate_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub HouseMatesAddBtn_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub HousematesHome_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub Method()
        Throw New NotImplementedException()
    End Sub

    Private Sub HouseHoldName_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub SelectHouseHold_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub LoginButton_Click()
        Throw New NotImplementedException()
    End Sub
    Private Sub HouseHold1_Click()
        Throw New NotImplementedException()
    End Sub

    Private Sub Login1_Load(sender As Object, e As EventArgs) Handles Login.Load

    End Sub
    Private Sub Log() Handles Login.Log_LoginButtonClick
        Login.Visible = False
        SelectHousehold.Visible = True


    End Sub
    Private Sub SelectHouse() Handles SelectHousehold.Event1
        SelectHousehold.Visible = False
        HomePage.Visible = True
    End Sub
    Private Sub HouseMatesClick() Handles HomePage.HouseMatesNav
        HomePage.Visible = False
        Housemates.Visible = True

    End Sub
    Private Sub AddHouseMatesClick() Handles Housemates.AddHouseMateEvent
        Housemates.Visible = False
        AddHousemate.Visible = True
    End Sub
    Private Sub AddHouseMatesBackClick() Handles AddHousemate.AddHouseMateBack
        AddHousemate.Visible = False
        Housemates.Visible = True
    End Sub
    Private Sub HouseMateBackClick() Handles Housemates.HouseMateBackEvent
        Housemates.Visible = False
        HomePage.Visible = True
    End Sub
    Private Sub HomePageBackClick() Handles HomePage.HomePageBackEvent
        HomePage.Visible = False
        SelectHousehold.Visible = True
    End Sub
    Private Sub HomePageSignOutClick() Handles HomePage.HomePageSignOutEvent
        HomePage.Visible = False
        Login.Visible = True
    End Sub
    Private Sub SelectHouseHoldAddHouseHoldCLick() Handles SelectHousehold.SelectHouseHoldAddHouseHoldEvent
        SelectHousehold.Visible = False
        AddHousehold.Visible = True
    End Sub
    Private Sub AddHouseholdBackClick() Handles AddHousehold.AddHouseholdBackEvent
        AddHousehold.Visible = False
        SelectHousehold.Visible = True
    End Sub
    Private Sub HomePageChoresClick() Handles HomePage.HomePageChoresNav
        HomePage.Visible = False
        ChoresMenu.Visible = True
    End Sub
    Private Sub ChoresMenuBackClick() Handles ChoresMenu.ChoresMenuBackEvent
        ChoresMenu.Visible = False
        HomePage.Visible = True
    End Sub
    Private Sub ChoresMenuViewChoresClick() Handles ChoresMenu.ChoresMenuViewChoresNav
        ChoresMenu.Visible = False
        ViewChores.Visible = True
    End Sub
    Private Sub ViewChoresBackClick() Handles ViewChores.ViewChoresBackEvent
        ViewChores.Visible = False
        ChoresMenu.Visible = True
    End Sub
    Private Sub ChoresMenuEditChoresClick() Handles ChoresMenu.ChoresMenuEditChoresNav
        ChoresMenu.Visible = False
        EditChores.Visible = True
    End Sub
    Private Sub EditChoresBackClick() Handles EditChores.EditChoresBackEvent
        EditChores.Visible = False
        ChoresMenu.Visible = True
    End Sub
    Private Sub EditChoreAddChoreClick() Handles EditChores.EditChoresAddChoreNav
        EditChores.Visible = False
        AddChore.Visible = True
    End Sub
    Private Sub AddChoreBackClick() Handles AddChore.AddChoreBackEvent
        AddChore.Visible = False
        EditChores.Visible = True
    End Sub
    Private Sub ChoresMenuTradeChoresClick() Handles ChoresMenu.ChoresMenuTradeChoresNav
        ChoresMenu.Visible = False
        TradeChores.Visible = True
    End Sub
    Private Sub TradeChoresBackClick() Handles TradeChores.TradeChoresBackEvent
        TradeChores.Visible = False
        ChoresMenu.Visible = True
    End Sub
    Private Sub ChoresMenuVerifyCompletion() Handles ChoresMenu.ChoresMenuVerifyCompletionNav
        ChoresMenu.Visible = False
        VerifyCompletion.Visible = True
    End Sub
    Private Sub VerifyCompletionBackClick() Handles VerifyCompletion.VerifyCompletionBackEvent
        VerifyCompletion.Visible = False
        ChoresMenu.Visible = True
    End Sub
End Class
