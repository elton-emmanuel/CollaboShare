<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SignOutButton = New System.Windows.Forms.PictureBox()
        Me.BackButtonHome = New System.Windows.Forms.PictureBox()
        Me.RequestALeaveHome = New System.Windows.Forms.PictureBox()
        Me.MyProfileHome = New System.Windows.Forms.PictureBox()
        Me.ChoresHome = New System.Windows.Forms.PictureBox()
        Me.HousematesHome = New System.Windows.Forms.PictureBox()
        Me.HomeMenuButtonsHomePage = New CollaboShare.HomeMenuButtons()
        CType(Me.SignOutButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButtonHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestALeaveHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyProfileHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoresHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousematesHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SignOutButton
        '
        Me.SignOutButton.Image = Global.CollaboShare.My.Resources.Resources.SignOutButton__1_
        Me.SignOutButton.Location = New System.Drawing.Point(283, 1)
        Me.SignOutButton.Name = "SignOutButton"
        Me.SignOutButton.Size = New System.Drawing.Size(74, 67)
        Me.SignOutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SignOutButton.TabIndex = 7
        Me.SignOutButton.TabStop = False
        '
        'BackButtonHome
        '
        Me.BackButtonHome.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonHome.Location = New System.Drawing.Point(0, 0)
        Me.BackButtonHome.Name = "BackButtonHome"
        Me.BackButtonHome.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonHome.TabIndex = 6
        Me.BackButtonHome.TabStop = False
        '
        'RequestALeaveHome
        '
        Me.RequestALeaveHome.Image = Global.CollaboShare.My.Resources.Resources.RequestALeave
        Me.RequestALeaveHome.Location = New System.Drawing.Point(66, 394)
        Me.RequestALeaveHome.Name = "RequestALeaveHome"
        Me.RequestALeaveHome.Size = New System.Drawing.Size(218, 110)
        Me.RequestALeaveHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RequestALeaveHome.TabIndex = 5
        Me.RequestALeaveHome.TabStop = False
        '
        'MyProfileHome
        '
        Me.MyProfileHome.Image = Global.CollaboShare.My.Resources.Resources.MyProfileHome
        Me.MyProfileHome.Location = New System.Drawing.Point(66, 274)
        Me.MyProfileHome.Name = "MyProfileHome"
        Me.MyProfileHome.Size = New System.Drawing.Size(218, 109)
        Me.MyProfileHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MyProfileHome.TabIndex = 4
        Me.MyProfileHome.TabStop = False
        '
        'ChoresHome
        '
        Me.ChoresHome.Image = Global.CollaboShare.My.Resources.Resources.HomeChores
        Me.ChoresHome.Location = New System.Drawing.Point(68, 151)
        Me.ChoresHome.Name = "ChoresHome"
        Me.ChoresHome.Size = New System.Drawing.Size(216, 117)
        Me.ChoresHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ChoresHome.TabIndex = 3
        Me.ChoresHome.TabStop = False
        '
        'HousematesHome
        '
        Me.HousematesHome.Image = Global.CollaboShare.My.Resources.Resources.Housemates
        Me.HousematesHome.Location = New System.Drawing.Point(63, 37)
        Me.HousematesHome.Name = "HousematesHome"
        Me.HousematesHome.Size = New System.Drawing.Size(221, 117)
        Me.HousematesHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HousematesHome.TabIndex = 2
        Me.HousematesHome.TabStop = False
        '
        'HomeMenuButtonsHomePage
        '
        Me.HomeMenuButtonsHomePage.Location = New System.Drawing.Point(1, 509)
        Me.HomeMenuButtonsHomePage.Name = "HomeMenuButtonsHomePage"
        Me.HomeMenuButtonsHomePage.Size = New System.Drawing.Size(351, 91)
        Me.HomeMenuButtonsHomePage.TabIndex = 1
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.SignOutButton)
        Me.Controls.Add(Me.BackButtonHome)
        Me.Controls.Add(Me.RequestALeaveHome)
        Me.Controls.Add(Me.MyProfileHome)
        Me.Controls.Add(Me.ChoresHome)
        Me.Controls.Add(Me.HousematesHome)
        Me.Controls.Add(Me.HomeMenuButtonsHomePage)
        Me.Name = "HomePage"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.SignOutButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButtonHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestALeaveHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyProfileHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoresHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousematesHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HomeMenuButtonsHomePage As HomeMenuButtons
    Friend WithEvents HousematesHome As PictureBox
    Friend WithEvents ChoresHome As PictureBox
    Friend WithEvents MyProfileHome As PictureBox
    Friend WithEvents RequestALeaveHome As PictureBox
    Friend WithEvents BackButtonHome As PictureBox
    Friend WithEvents SignOutButton As PictureBox
End Class
