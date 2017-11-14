<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditChores
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
        Me.EditChoresBackground = New System.Windows.Forms.PictureBox()
        Me.BackButtonEditChores = New System.Windows.Forms.PictureBox()
        Me.EditChoresBanner = New System.Windows.Forms.PictureBox()
        Me.AddChoreButton = New System.Windows.Forms.PictureBox()
        Me.EditChoresComponent1 = New CollaboShare.EditChoresComponent()
        Me.RemoveChoreButton = New System.Windows.Forms.PictureBox()
        CType(Me.EditChoresBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButtonEditChores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditChoresBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddChoreButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemoveChoreButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeMenuButtonsEditChores
        '
        Me.HomeMenuButtonsEditChores.Location = New System.Drawing.Point(0, 509)
        Me.HomeMenuButtonsEditChores.Name = "HomeMenuButtonsEditChores"
        Me.HomeMenuButtonsEditChores.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsEditChores.TabIndex = 5
        '
        'EditChoresBackground
        '
        Me.EditChoresBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.EditChoresBackground.Location = New System.Drawing.Point(14, 152)
        Me.EditChoresBackground.Name = "EditChoresBackground"
        Me.EditChoresBackground.Size = New System.Drawing.Size(321, 280)
        Me.EditChoresBackground.TabIndex = 6
        Me.EditChoresBackground.TabStop = False
        '
        'BackButtonEditChores
        '
        Me.BackButtonEditChores.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonEditChores.Location = New System.Drawing.Point(0, 0)
        Me.BackButtonEditChores.Name = "BackButtonEditChores"
        Me.BackButtonEditChores.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonEditChores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonEditChores.TabIndex = 3
        Me.BackButtonEditChores.TabStop = False
        '
        'EditChoresBanner
        '
        Me.EditChoresBanner.Image = Global.CollaboShare.My.Resources.Resources.EditChoresBanner
        Me.EditChoresBanner.Location = New System.Drawing.Point(0, 36)
        Me.EditChoresBanner.Name = "EditChoresBanner"
        Me.EditChoresBanner.Size = New System.Drawing.Size(350, 125)
        Me.EditChoresBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EditChoresBanner.TabIndex = 4
        Me.EditChoresBanner.TabStop = False
        '
        'AddChoreButton
        '
        Me.AddChoreButton.Image = Global.CollaboShare.My.Resources.Resources.AddButton
        Me.AddChoreButton.Location = New System.Drawing.Point(33, 438)
        Me.AddChoreButton.Name = "AddChoreButton"
        Me.AddChoreButton.Size = New System.Drawing.Size(131, 65)
        Me.AddChoreButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddChoreButton.TabIndex = 8
        Me.AddChoreButton.TabStop = False
        '
        'EditChoresComponent1
        '
        Me.EditChoresComponent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.EditChoresComponent1.Location = New System.Drawing.Point(24, 167)
        Me.EditChoresComponent1.Name = "EditChoresComponent1"
        Me.EditChoresComponent1.Size = New System.Drawing.Size(311, 46)
        Me.EditChoresComponent1.TabIndex = 10
        '
        'RemoveChoreButton
        '
        Me.RemoveChoreButton.Image = Global.CollaboShare.My.Resources.Resources.RemoveButton
        Me.RemoveChoreButton.Location = New System.Drawing.Point(189, 438)
        Me.RemoveChoreButton.Name = "RemoveChoreButton"
        Me.RemoveChoreButton.Size = New System.Drawing.Size(131, 65)
        Me.RemoveChoreButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RemoveChoreButton.TabIndex = 11
        Me.RemoveChoreButton.TabStop = False
        '
        'EditChores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.RemoveChoreButton)
        Me.Controls.Add(Me.EditChoresComponent1)
        Me.Controls.Add(Me.AddChoreButton)
        Me.Controls.Add(Me.EditChoresBackground)
        Me.Controls.Add(Me.HomeMenuButtonsEditChores)
        Me.Controls.Add(Me.BackButtonEditChores)
        Me.Controls.Add(Me.EditChoresBanner)
        Me.Name = "EditChores"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.EditChoresBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButtonEditChores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditChoresBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddChoreButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemoveChoreButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButtonEditChores As PictureBox
    Friend WithEvents EditChoresBanner As PictureBox
    Friend WithEvents HomeMenuButtonsEditChores As HomeMenuButtons
    Friend WithEvents EditChoresBackground As PictureBox
    Friend WithEvents AddChoreButton As PictureBox
    Friend WithEvents EditChoresComponent1 As EditChoresComponent
    Friend WithEvents RemoveChoreButton As PictureBox
End Class
