<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddChore
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
        Me.HomeMenuButtonsEditChores = New CollaboShare.HomeMenuButtons()
        Me.AddChoresNameLabel = New System.Windows.Forms.Label()
        Me.AddChoresDescriptionLabel = New System.Windows.Forms.Label()
        Me.AddChoresNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddChoresDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AddChoresDifficultyLabel = New System.Windows.Forms.Label()
        Me.AddChoreReccurenceLabel = New System.Windows.Forms.Label()
        Me.AddChoreReccurenceCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.AddChoresRepeatCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.AddChoreAddButton = New System.Windows.Forms.PictureBox()
        Me.BackButtonAddChores = New System.Windows.Forms.PictureBox()
        Me.AddChoresBanner = New System.Windows.Forms.PictureBox()
        Me.DifficultyRating1 = New CollaboShare.DifficultyRating()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AddChoreAddButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButtonAddChores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddChoresBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeMenuButtonsEditChores
        '
        Me.HomeMenuButtonsEditChores.Location = New System.Drawing.Point(1, 509)
        Me.HomeMenuButtonsEditChores.Name = "HomeMenuButtonsEditChores"
        Me.HomeMenuButtonsEditChores.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsEditChores.TabIndex = 8
        '
        'AddChoresNameLabel
        '
        Me.AddChoresNameLabel.AutoSize = True
        Me.AddChoresNameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddChoresNameLabel.Location = New System.Drawing.Point(33, 189)
        Me.AddChoresNameLabel.Name = "AddChoresNameLabel"
        Me.AddChoresNameLabel.Size = New System.Drawing.Size(41, 13)
        Me.AddChoresNameLabel.TabIndex = 9
        Me.AddChoresNameLabel.Text = "Name: "
        '
        'AddChoresDescriptionLabel
        '
        Me.AddChoresDescriptionLabel.AutoSize = True
        Me.AddChoresDescriptionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddChoresDescriptionLabel.Location = New System.Drawing.Point(33, 232)
        Me.AddChoresDescriptionLabel.Name = "AddChoresDescriptionLabel"
        Me.AddChoresDescriptionLabel.Size = New System.Drawing.Size(63, 13)
        Me.AddChoresDescriptionLabel.TabIndex = 10
        Me.AddChoresDescriptionLabel.Text = "Description:"
        '
        'AddChoresNameTextBox
        '
        Me.AddChoresNameTextBox.Location = New System.Drawing.Point(103, 182)
        Me.AddChoresNameTextBox.Name = "AddChoresNameTextBox"
        Me.AddChoresNameTextBox.Size = New System.Drawing.Size(214, 20)
        Me.AddChoresNameTextBox.TabIndex = 11
        '
        'AddChoresDescriptionTextBox
        '
        Me.AddChoresDescriptionTextBox.Location = New System.Drawing.Point(36, 248)
        Me.AddChoresDescriptionTextBox.Name = "AddChoresDescriptionTextBox"
        Me.AddChoresDescriptionTextBox.Size = New System.Drawing.Size(281, 20)
        Me.AddChoresDescriptionTextBox.TabIndex = 12
        '
        'AddChoresDifficultyLabel
        '
        Me.AddChoresDifficultyLabel.AutoSize = True
        Me.AddChoresDifficultyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddChoresDifficultyLabel.Location = New System.Drawing.Point(33, 301)
        Me.AddChoresDifficultyLabel.Name = "AddChoresDifficultyLabel"
        Me.AddChoresDifficultyLabel.Size = New System.Drawing.Size(50, 13)
        Me.AddChoresDifficultyLabel.TabIndex = 13
        Me.AddChoresDifficultyLabel.Text = "Difficulty:"
        '
        'AddChoreReccurenceLabel
        '
        Me.AddChoreReccurenceLabel.AutoSize = True
        Me.AddChoreReccurenceLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddChoreReccurenceLabel.Location = New System.Drawing.Point(33, 341)
        Me.AddChoreReccurenceLabel.Name = "AddChoreReccurenceLabel"
        Me.AddChoreReccurenceLabel.Size = New System.Drawing.Size(69, 13)
        Me.AddChoreReccurenceLabel.TabIndex = 14
        Me.AddChoreReccurenceLabel.Text = "Reccurence:"
        '
        'AddChoreReccurenceCheckedListBox
        '
        Me.AddChoreReccurenceCheckedListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddChoreReccurenceCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddChoreReccurenceCheckedListBox.FormattingEnabled = True
        Me.AddChoreReccurenceCheckedListBox.HorizontalScrollbar = True
        Me.AddChoreReccurenceCheckedListBox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.AddChoreReccurenceCheckedListBox.Location = New System.Drawing.Point(36, 357)
        Me.AddChoreReccurenceCheckedListBox.MultiColumn = True
        Me.AddChoreReccurenceCheckedListBox.Name = "AddChoreReccurenceCheckedListBox"
        Me.AddChoreReccurenceCheckedListBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AddChoreReccurenceCheckedListBox.Size = New System.Drawing.Size(90, 120)
        Me.AddChoreReccurenceCheckedListBox.TabIndex = 15
        '
        'AddChoresRepeatCheckedListBox
        '
        Me.AddChoresRepeatCheckedListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddChoresRepeatCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddChoresRepeatCheckedListBox.FormattingEnabled = True
        Me.AddChoresRepeatCheckedListBox.Items.AddRange(New Object() {"Repeat", "Weekly"})
        Me.AddChoresRepeatCheckedListBox.Location = New System.Drawing.Point(174, 357)
        Me.AddChoresRepeatCheckedListBox.Name = "AddChoresRepeatCheckedListBox"
        Me.AddChoresRepeatCheckedListBox.Size = New System.Drawing.Size(120, 45)
        Me.AddChoresRepeatCheckedListBox.TabIndex = 16
        '
        'AddChoreAddButton
        '
        Me.AddChoreAddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddChoreAddButton.Image = Global.CollaboShare.My.Resources.Resources.AddButton
        Me.AddChoreAddButton.Location = New System.Drawing.Point(119, 452)
        Me.AddChoreAddButton.Name = "AddChoreAddButton"
        Me.AddChoreAddButton.Size = New System.Drawing.Size(110, 51)
        Me.AddChoreAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddChoreAddButton.TabIndex = 17
        Me.AddChoreAddButton.TabStop = False
        '
        'BackButtonAddChores
        '
        Me.BackButtonAddChores.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonAddChores.Location = New System.Drawing.Point(-3, 0)
        Me.BackButtonAddChores.Name = "BackButtonAddChores"
        Me.BackButtonAddChores.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonAddChores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonAddChores.TabIndex = 5
        Me.BackButtonAddChores.TabStop = False
        '
        'AddChoresBanner
        '
        Me.AddChoresBanner.Image = Global.CollaboShare.My.Resources.Resources.AddChoreBanner
        Me.AddChoresBanner.Location = New System.Drawing.Point(-3, 36)
        Me.AddChoresBanner.Name = "AddChoresBanner"
        Me.AddChoresBanner.Size = New System.Drawing.Size(350, 114)
        Me.AddChoresBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddChoresBanner.TabIndex = 6
        Me.AddChoresBanner.TabStop = False
        '
        'DifficultyRating1
        '
        Me.DifficultyRating1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.DifficultyRating1.Location = New System.Drawing.Point(89, 293)
        Me.DifficultyRating1.Name = "DifficultyRating1"
        Me.DifficultyRating1.Size = New System.Drawing.Size(234, 30)
        Me.DifficultyRating1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CollaboShare.My.Resources.Resources.beigeBubble
        Me.PictureBox1.Location = New System.Drawing.Point(0, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 386)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'AddChore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.BackButtonAddChores)
        Me.Controls.Add(Me.AddChoresBanner)
        Me.Controls.Add(Me.DifficultyRating1)
        Me.Controls.Add(Me.AddChoreAddButton)
        Me.Controls.Add(Me.AddChoresRepeatCheckedListBox)
        Me.Controls.Add(Me.AddChoreReccurenceCheckedListBox)
        Me.Controls.Add(Me.AddChoreReccurenceLabel)
        Me.Controls.Add(Me.AddChoresDifficultyLabel)
        Me.Controls.Add(Me.AddChoresDescriptionTextBox)
        Me.Controls.Add(Me.AddChoresNameTextBox)
        Me.Controls.Add(Me.AddChoresDescriptionLabel)
        Me.Controls.Add(Me.AddChoresNameLabel)
        Me.Controls.Add(Me.HomeMenuButtonsEditChores)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AddChore"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.AddChoreAddButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButtonAddChores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddChoresBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButtonAddChores As PictureBox
    Friend WithEvents AddChoresBanner As PictureBox
    Friend WithEvents HomeMenuButtonsEditChores As HomeMenuButtons
    Friend WithEvents AddChoresNameLabel As Label
    Friend WithEvents AddChoresDescriptionLabel As Label
    Friend WithEvents AddChoresNameTextBox As TextBox
    Friend WithEvents AddChoresDescriptionTextBox As TextBox
    Friend WithEvents AddChoresDifficultyLabel As Label
    Friend WithEvents AddChoreReccurenceLabel As Label
    Friend WithEvents AddChoreReccurenceCheckedListBox As CheckedListBox
    Friend WithEvents AddChoresRepeatCheckedListBox As CheckedListBox
    Friend WithEvents AddChoreAddButton As PictureBox
    Friend WithEvents DifficultyRating1 As DifficultyRating
    Friend WithEvents PictureBox1 As PictureBox
End Class
