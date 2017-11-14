<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectHousehold
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
        Me.AddChoresBackground = New System.Windows.Forms.PictureBox()
        Me.SelectAHouseHoldBanner = New System.Windows.Forms.PictureBox()
        Me.AddNewHouseholdButton = New System.Windows.Forms.PictureBox()
        Me.Household2 = New CollaboShare.Households()
        Me.Household1 = New CollaboShare.Households()
        CType(Me.AddChoresBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectAHouseHoldBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddNewHouseholdButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddChoresBackground
        '
        Me.AddChoresBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.AddChoresBackground.Location = New System.Drawing.Point(11, 109)
        Me.AddChoresBackground.Name = "AddChoresBackground"
        Me.AddChoresBackground.Size = New System.Drawing.Size(327, 379)
        Me.AddChoresBackground.TabIndex = 8
        Me.AddChoresBackground.TabStop = False
        '
        'SelectAHouseHoldBanner
        '
        Me.SelectAHouseHoldBanner.Image = Global.CollaboShare.My.Resources.Resources.SelectHouseholdBanner
        Me.SelectAHouseHoldBanner.Location = New System.Drawing.Point(0, 3)
        Me.SelectAHouseHoldBanner.Name = "SelectAHouseHoldBanner"
        Me.SelectAHouseHoldBanner.Size = New System.Drawing.Size(350, 100)
        Me.SelectAHouseHoldBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SelectAHouseHoldBanner.TabIndex = 2
        Me.SelectAHouseHoldBanner.TabStop = False
        '
        'AddNewHouseholdButton
        '
        Me.AddNewHouseholdButton.Image = Global.CollaboShare.My.Resources.Resources.addNewHouseholdButton
        Me.AddNewHouseholdButton.Location = New System.Drawing.Point(20, 494)
        Me.AddNewHouseholdButton.Name = "AddNewHouseholdButton"
        Me.AddNewHouseholdButton.Size = New System.Drawing.Size(310, 98)
        Me.AddNewHouseholdButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AddNewHouseholdButton.TabIndex = 1
        Me.AddNewHouseholdButton.TabStop = False
        '
        'Household2
        '
        Me.Household2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Household2.Location = New System.Drawing.Point(20, 182)
        Me.Household2.Name = "Household2"
        Me.Household2.Size = New System.Drawing.Size(310, 67)
        Me.Household2.TabIndex = 10
        '
        'Household1
        '
        Me.Household1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Household1.Location = New System.Drawing.Point(20, 118)
        Me.Household1.Name = "Household1"
        Me.Household1.Size = New System.Drawing.Size(310, 67)
        Me.Household1.TabIndex = 9
        '
        'SelectHousehold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.Household2)
        Me.Controls.Add(Me.Household1)
        Me.Controls.Add(Me.AddChoresBackground)
        Me.Controls.Add(Me.SelectAHouseHoldBanner)
        Me.Controls.Add(Me.AddNewHouseholdButton)
        Me.Name = "SelectHousehold"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.AddChoresBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectAHouseHoldBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddNewHouseholdButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddNewHouseholdButton As PictureBox
    Friend WithEvents SelectAHouseHoldBanner As PictureBox
    Friend WithEvents AddChoresBackground As PictureBox
    Friend WithEvents Household2 As Households
    Public WithEvents Household1 As Households
End Class
