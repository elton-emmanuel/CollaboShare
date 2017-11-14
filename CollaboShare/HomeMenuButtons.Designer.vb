<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeMenuButtons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeMenuButtons))
        Me.choreMenuButton = New System.Windows.Forms.PictureBox()
        Me.calendarMenuButton = New System.Windows.Forms.PictureBox()
        Me.noMailMenuButton = New System.Windows.Forms.PictureBox()
        Me.profileMenuButton = New System.Windows.Forms.PictureBox()
        Me.homeMenuButton = New System.Windows.Forms.PictureBox()
        CType(Me.choreMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calendarMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noMailMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profileMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.homeMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'choreMenuButton
        '
        Me.choreMenuButton.Image = CType(resources.GetObject("choreMenuButton.Image"), System.Drawing.Image)
        Me.choreMenuButton.Location = New System.Drawing.Point(0, 17)
        Me.choreMenuButton.Name = "choreMenuButton"
        Me.choreMenuButton.Size = New System.Drawing.Size(61, 63)
        Me.choreMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.choreMenuButton.TabIndex = 4
        Me.choreMenuButton.TabStop = False
        '
        'calendarMenuButton
        '
        Me.calendarMenuButton.Image = Global.CollaboShare.My.Resources.Resources.calendarButton
        Me.calendarMenuButton.Location = New System.Drawing.Point(67, 17)
        Me.calendarMenuButton.Name = "calendarMenuButton"
        Me.calendarMenuButton.Size = New System.Drawing.Size(61, 63)
        Me.calendarMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.calendarMenuButton.TabIndex = 3
        Me.calendarMenuButton.TabStop = False
        '
        'noMailMenuButton
        '
        Me.noMailMenuButton.Image = Global.CollaboShare.My.Resources.Resources.mailButtonNoMail
        Me.noMailMenuButton.Location = New System.Drawing.Point(287, 17)
        Me.noMailMenuButton.Name = "noMailMenuButton"
        Me.noMailMenuButton.Size = New System.Drawing.Size(61, 63)
        Me.noMailMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.noMailMenuButton.TabIndex = 2
        Me.noMailMenuButton.TabStop = False
        '
        'profileMenuButton
        '
        Me.profileMenuButton.Image = Global.CollaboShare.My.Resources.Resources.profileButton
        Me.profileMenuButton.Location = New System.Drawing.Point(221, 17)
        Me.profileMenuButton.Name = "profileMenuButton"
        Me.profileMenuButton.Size = New System.Drawing.Size(61, 63)
        Me.profileMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profileMenuButton.TabIndex = 1
        Me.profileMenuButton.TabStop = False
        '
        'homeMenuButton
        '
        Me.homeMenuButton.Image = Global.CollaboShare.My.Resources.Resources.homeButton
        Me.homeMenuButton.Location = New System.Drawing.Point(131, 0)
        Me.homeMenuButton.Name = "homeMenuButton"
        Me.homeMenuButton.Size = New System.Drawing.Size(87, 88)
        Me.homeMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.homeMenuButton.TabIndex = 0
        Me.homeMenuButton.TabStop = False
        '
        'HomeMenuButtons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.choreMenuButton)
        Me.Controls.Add(Me.calendarMenuButton)
        Me.Controls.Add(Me.noMailMenuButton)
        Me.Controls.Add(Me.profileMenuButton)
        Me.Controls.Add(Me.homeMenuButton)
        Me.Name = "HomeMenuButtons"
        Me.Size = New System.Drawing.Size(351, 88)
        CType(Me.choreMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calendarMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noMailMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profileMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.homeMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents homeMenuButton As PictureBox
    Friend WithEvents profileMenuButton As PictureBox
    Friend WithEvents noMailMenuButton As PictureBox
    Friend WithEvents calendarMenuButton As PictureBox
    Friend WithEvents choreMenuButton As PictureBox
End Class
