<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Housemates
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackButtonHousemates = New System.Windows.Forms.PictureBox()
        Me.HousematesBanner = New System.Windows.Forms.PictureBox()
        Me.HouseMatesAddBtn = New System.Windows.Forms.PictureBox()
        Me.HousemateComponent1 = New CollaboShare.HousemateComponent()
        Me.HomeMenuButtonsHousemates = New CollaboShare.HomeMenuButtons()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButtonHousemates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousematesBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseMatesAddBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CollaboShare.My.Resources.Resources.beigeBubble
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 329)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BackButtonHousemates
        '
        Me.BackButtonHousemates.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonHousemates.Location = New System.Drawing.Point(-1, 2)
        Me.BackButtonHousemates.Name = "BackButtonHousemates"
        Me.BackButtonHousemates.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonHousemates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonHousemates.TabIndex = 9
        Me.BackButtonHousemates.TabStop = False
        '
        'HousematesBanner
        '
        Me.HousematesBanner.Image = Global.CollaboShare.My.Resources.Resources.HouseMatesBanner
        Me.HousematesBanner.Location = New System.Drawing.Point(-1, 38)
        Me.HousematesBanner.Name = "HousematesBanner"
        Me.HousematesBanner.Size = New System.Drawing.Size(350, 125)
        Me.HousematesBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HousematesBanner.TabIndex = 10
        Me.HousematesBanner.TabStop = False
        '
        'HouseMatesAddBtn
        '
        Me.HouseMatesAddBtn.Image = Global.CollaboShare.My.Resources.Resources.AddButton
        Me.HouseMatesAddBtn.Location = New System.Drawing.Point(123, 454)
        Me.HouseMatesAddBtn.Name = "HouseMatesAddBtn"
        Me.HouseMatesAddBtn.Size = New System.Drawing.Size(100, 50)
        Me.HouseMatesAddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HouseMatesAddBtn.TabIndex = 14
        Me.HouseMatesAddBtn.TabStop = False
        '
        'HousemateComponent1
        '
        Me.HousemateComponent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.HousemateComponent1.Location = New System.Drawing.Point(33, 156)
        Me.HousemateComponent1.Name = "HousemateComponent1"
        Me.HousemateComponent1.Size = New System.Drawing.Size(283, 81)
        Me.HousemateComponent1.TabIndex = 13
        '
        'HomeMenuButtonsHousemates
        '
        Me.HomeMenuButtonsHousemates.Location = New System.Drawing.Point(0, 510)
        Me.HomeMenuButtonsHousemates.Name = "HomeMenuButtonsHousemates"
        Me.HomeMenuButtonsHousemates.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsHousemates.TabIndex = 11
        '
        'Housemates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.HouseMatesAddBtn)
        Me.Controls.Add(Me.HousemateComponent1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HomeMenuButtonsHousemates)
        Me.Controls.Add(Me.BackButtonHousemates)
        Me.Controls.Add(Me.HousematesBanner)
        Me.Name = "Housemates"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButtonHousemates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousematesBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseMatesAddBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeMenuButtonsHousemates As HomeMenuButtons
    Friend WithEvents BackButtonHousemates As PictureBox
    Friend WithEvents HousematesBanner As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HousemateComponent1 As HousemateComponent
    Friend WithEvents HouseMatesAddBtn As PictureBox
End Class
