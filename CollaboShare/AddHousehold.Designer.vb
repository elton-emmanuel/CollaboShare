<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddHousehold
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HomeMenuButtonsAddHousehold = New CollaboShare.HomeMenuButtons()
        Me.BackButtonAddHousehold = New System.Windows.Forms.PictureBox()
        Me.VerifyCompletionBanner = New System.Windows.Forms.PictureBox()
        Me.AddHouseholdBackground = New System.Windows.Forms.PictureBox()
        Me.NameOfHouseholdLabel = New System.Windows.Forms.Label()
        Me.AddHouseholdNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddNewHouseholdButton = New System.Windows.Forms.PictureBox()
        CType(Me.BackButtonAddHousehold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerifyCompletionBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddHouseholdBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddNewHouseholdButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeMenuButtonsAddHousehold
        '
        Me.HomeMenuButtonsAddHousehold.Location = New System.Drawing.Point(1, 509)
        Me.HomeMenuButtonsAddHousehold.Name = "HomeMenuButtonsAddHousehold"
        Me.HomeMenuButtonsAddHousehold.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsAddHousehold.TabIndex = 9
        '
        'BackButtonAddHousehold
        '
        Me.BackButtonAddHousehold.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonAddHousehold.Location = New System.Drawing.Point(0, 1)
        Me.BackButtonAddHousehold.Name = "BackButtonAddHousehold"
        Me.BackButtonAddHousehold.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonAddHousehold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonAddHousehold.TabIndex = 7
        Me.BackButtonAddHousehold.TabStop = False
        '
        'VerifyCompletionBanner
        '
        Me.VerifyCompletionBanner.Image = Global.CollaboShare.My.Resources.Resources.AddHouseholdBanner
        Me.VerifyCompletionBanner.Location = New System.Drawing.Point(0, 37)
        Me.VerifyCompletionBanner.Name = "VerifyCompletionBanner"
        Me.VerifyCompletionBanner.Size = New System.Drawing.Size(350, 125)
        Me.VerifyCompletionBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VerifyCompletionBanner.TabIndex = 8
        Me.VerifyCompletionBanner.TabStop = False
        '
        'AddHouseholdBackground
        '
        Me.AddHouseholdBackground.Image = Global.CollaboShare.My.Resources.Resources.beigeBubble
        Me.AddHouseholdBackground.Location = New System.Drawing.Point(0, 151)
        Me.AddHouseholdBackground.Name = "AddHouseholdBackground"
        Me.AddHouseholdBackground.Size = New System.Drawing.Size(350, 342)
        Me.AddHouseholdBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AddHouseholdBackground.TabIndex = 10
        Me.AddHouseholdBackground.TabStop = False
        '
        'NameOfHouseholdLabel
        '
        Me.NameOfHouseholdLabel.AutoSize = True
        Me.NameOfHouseholdLabel.Location = New System.Drawing.Point(50, 217)
        Me.NameOfHouseholdLabel.Name = "NameOfHouseholdLabel"
        Me.NameOfHouseholdLabel.Size = New System.Drawing.Size(41, 13)
        Me.NameOfHouseholdLabel.TabIndex = 11
        Me.NameOfHouseholdLabel.Text = "Name: "
        '
        'AddHouseholdNameTextBox
        '
        Me.AddHouseholdNameTextBox.Location = New System.Drawing.Point(122, 214)
        Me.AddHouseholdNameTextBox.Name = "AddHouseholdNameTextBox"
        Me.AddHouseholdNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddHouseholdNameTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "What else to put here??"
        '
        'AddNewHouseholdButton
        '
        Me.AddNewHouseholdButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddNewHouseholdButton.Image = Global.CollaboShare.My.Resources.Resources.AddButton
        Me.AddNewHouseholdButton.Location = New System.Drawing.Point(113, 409)
        Me.AddNewHouseholdButton.Name = "AddNewHouseholdButton"
        Me.AddNewHouseholdButton.Size = New System.Drawing.Size(123, 68)
        Me.AddNewHouseholdButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddNewHouseholdButton.TabIndex = 14
        Me.AddNewHouseholdButton.TabStop = False
        '
        'AddHousehold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.AddNewHouseholdButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddHouseholdNameTextBox)
        Me.Controls.Add(Me.NameOfHouseholdLabel)
        Me.Controls.Add(Me.AddHouseholdBackground)
        Me.Controls.Add(Me.HomeMenuButtonsAddHousehold)
        Me.Controls.Add(Me.BackButtonAddHousehold)
        Me.Controls.Add(Me.VerifyCompletionBanner)
        Me.Name = "AddHousehold"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.BackButtonAddHousehold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerifyCompletionBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddHouseholdBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddNewHouseholdButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButtonAddHousehold As PictureBox
    Friend WithEvents VerifyCompletionBanner As PictureBox
    Friend WithEvents HomeMenuButtonsAddHousehold As HomeMenuButtons
    Friend WithEvents AddHouseholdBackground As PictureBox
    Friend WithEvents NameOfHouseholdLabel As Label
    Friend WithEvents AddHouseholdNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddNewHouseholdButton As PictureBox
End Class
