<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddHousemate
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
        Me.HomeMenuButtonsAddHousemate = New CollaboShare.HomeMenuButtons()
        Me.BackButtonAddHousemate = New System.Windows.Forms.PictureBox()
        Me.AddHousemateBanner = New System.Windows.Forms.PictureBox()
        CType(Me.BackButtonAddHousemate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddHousemateBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeMenuButtonsAddHousemate
        '
        Me.HomeMenuButtonsAddHousemate.Location = New System.Drawing.Point(1, 507)
        Me.HomeMenuButtonsAddHousemate.Name = "HomeMenuButtonsAddHousemate"
        Me.HomeMenuButtonsAddHousemate.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsAddHousemate.TabIndex = 14
        '
        'BackButtonAddHousemate
        '
        Me.BackButtonAddHousemate.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonAddHousemate.Location = New System.Drawing.Point(-1, 2)
        Me.BackButtonAddHousemate.Name = "BackButtonAddHousemate"
        Me.BackButtonAddHousemate.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonAddHousemate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonAddHousemate.TabIndex = 12
        Me.BackButtonAddHousemate.TabStop = False
        '
        'AddHousemateBanner
        '
        Me.AddHousemateBanner.Image = Global.CollaboShare.My.Resources.Resources.AddHousemateBanner
        Me.AddHousemateBanner.Location = New System.Drawing.Point(-1, 38)
        Me.AddHousemateBanner.Name = "AddHousemateBanner"
        Me.AddHousemateBanner.Size = New System.Drawing.Size(350, 125)
        Me.AddHousemateBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddHousemateBanner.TabIndex = 13
        Me.AddHousemateBanner.TabStop = False
        '
        'AddHousemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.HomeMenuButtonsAddHousemate)
        Me.Controls.Add(Me.BackButtonAddHousemate)
        Me.Controls.Add(Me.AddHousemateBanner)
        Me.Name = "AddHousemate"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.BackButtonAddHousemate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddHousemateBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeMenuButtonsAddHousemate As HomeMenuButtons
    Friend WithEvents BackButtonAddHousemate As PictureBox
    Friend WithEvents AddHousemateBanner As PictureBox
End Class
