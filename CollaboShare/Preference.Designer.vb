<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preference
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
        Me.BackButtonVolunteer = New System.Windows.Forms.PictureBox()
        Me.VolutnteerBanner = New System.Windows.Forms.PictureBox()
        Me.HomeMenuButtonsVolunteer = New CollaboShare.HomeMenuButtons()
        CType(Me.BackButtonVolunteer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolutnteerBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButtonVolunteer
        '
        Me.BackButtonVolunteer.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonVolunteer.Location = New System.Drawing.Point(0, 1)
        Me.BackButtonVolunteer.Name = "BackButtonVolunteer"
        Me.BackButtonVolunteer.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonVolunteer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonVolunteer.TabIndex = 7
        Me.BackButtonVolunteer.TabStop = False
        '
        'VolutnteerBanner
        '
        Me.VolutnteerBanner.Image = Global.CollaboShare.My.Resources.Resources.VolunteerBanner
        Me.VolutnteerBanner.Location = New System.Drawing.Point(0, 37)
        Me.VolutnteerBanner.Name = "VolutnteerBanner"
        Me.VolutnteerBanner.Size = New System.Drawing.Size(350, 125)
        Me.VolutnteerBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VolutnteerBanner.TabIndex = 8
        Me.VolutnteerBanner.TabStop = False
        '
        'HomeMenuButtonsVolunteer
        '
        Me.HomeMenuButtonsVolunteer.Location = New System.Drawing.Point(1, 509)
        Me.HomeMenuButtonsVolunteer.Name = "HomeMenuButtonsVolunteer"
        Me.HomeMenuButtonsVolunteer.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsVolunteer.TabIndex = 9
        '
        'Preference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.HomeMenuButtonsVolunteer)
        Me.Controls.Add(Me.BackButtonVolunteer)
        Me.Controls.Add(Me.VolutnteerBanner)
        Me.Name = "Preference"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.BackButtonVolunteer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolutnteerBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButtonVolunteer As PictureBox
    Friend WithEvents VolutnteerBanner As PictureBox
    Friend WithEvents HomeMenuButtonsVolunteer As HomeMenuButtons
End Class
