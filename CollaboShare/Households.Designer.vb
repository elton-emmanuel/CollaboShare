<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Households
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
        Me.HouseholdName = New System.Windows.Forms.Label()
        Me.WhiteBubbleHouseholds = New System.Windows.Forms.PictureBox()
        CType(Me.WhiteBubbleHouseholds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HouseholdName
        '
        Me.HouseholdName.AutoSize = True
        Me.HouseholdName.BackColor = System.Drawing.Color.White
        Me.HouseholdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HouseholdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HouseholdName.Location = New System.Drawing.Point(40, 17)
        Me.HouseholdName.Name = "HouseholdName"
        Me.HouseholdName.Size = New System.Drawing.Size(223, 31)
        Me.HouseholdName.TabIndex = 1
        Me.HouseholdName.Text = "Household Name"
        '
        'WhiteBubbleHouseholds
        '
        Me.WhiteBubbleHouseholds.Image = Global.CollaboShare.My.Resources.Resources.whiteBubble
        Me.WhiteBubbleHouseholds.Location = New System.Drawing.Point(-14, 3)
        Me.WhiteBubbleHouseholds.Name = "WhiteBubbleHouseholds"
        Me.WhiteBubbleHouseholds.Size = New System.Drawing.Size(321, 57)
        Me.WhiteBubbleHouseholds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WhiteBubbleHouseholds.TabIndex = 0
        Me.WhiteBubbleHouseholds.TabStop = False
        '
        'Households
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HouseholdName)
        Me.Controls.Add(Me.WhiteBubbleHouseholds)
        Me.Name = "Households"
        Me.Size = New System.Drawing.Size(310, 60)
        CType(Me.WhiteBubbleHouseholds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WhiteBubbleHouseholds As PictureBox
    Friend WithEvents HouseholdName As Label
End Class
