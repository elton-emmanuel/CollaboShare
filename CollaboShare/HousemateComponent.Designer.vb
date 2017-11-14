<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HousemateComponent
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
        Me.AvatarPictureBox = New System.Windows.Forms.PictureBox()
        Me.HousemateComponentBackground = New System.Windows.Forms.PictureBox()
        Me.HousemateNameLabel = New System.Windows.Forms.Label()
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousemateComponentBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AvatarPictureBox
        '
        Me.AvatarPictureBox.BackColor = System.Drawing.Color.White
        Me.AvatarPictureBox.Image = Global.CollaboShare.My.Resources.Resources.Avatar1
        Me.AvatarPictureBox.Location = New System.Drawing.Point(16, 14)
        Me.AvatarPictureBox.Name = "AvatarPictureBox"
        Me.AvatarPictureBox.Size = New System.Drawing.Size(71, 59)
        Me.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AvatarPictureBox.TabIndex = 1
        Me.AvatarPictureBox.TabStop = False
        '
        'HousemateComponentBackground
        '
        Me.HousemateComponentBackground.Image = Global.CollaboShare.My.Resources.Resources.whiteBubble
        Me.HousemateComponentBackground.Location = New System.Drawing.Point(-9, 0)
        Me.HousemateComponentBackground.Name = "HousemateComponentBackground"
        Me.HousemateComponentBackground.Size = New System.Drawing.Size(300, 85)
        Me.HousemateComponentBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HousemateComponentBackground.TabIndex = 0
        Me.HousemateComponentBackground.TabStop = False
        '
        'HousemateNameLabel
        '
        Me.HousemateNameLabel.AutoSize = True
        Me.HousemateNameLabel.BackColor = System.Drawing.Color.White
        Me.HousemateNameLabel.Location = New System.Drawing.Point(109, 40)
        Me.HousemateNameLabel.Name = "HousemateNameLabel"
        Me.HousemateNameLabel.Size = New System.Drawing.Size(35, 13)
        Me.HousemateNameLabel.TabIndex = 2
        Me.HousemateNameLabel.Text = "Name"
        '
        'HousemateComponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Controls.Add(Me.HousemateNameLabel)
        Me.Controls.Add(Me.AvatarPictureBox)
        Me.Controls.Add(Me.HousemateComponentBackground)
        Me.Name = "HousemateComponent"
        Me.Size = New System.Drawing.Size(282, 85)
        CType(Me.AvatarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousemateComponentBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HousemateComponentBackground As PictureBox
    Friend WithEvents AvatarPictureBox As PictureBox
    Friend WithEvents HousemateNameLabel As Label
End Class
