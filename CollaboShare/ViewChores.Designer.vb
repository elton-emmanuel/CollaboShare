<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewChores
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
        Me.BackButtonViewChores = New System.Windows.Forms.PictureBox()
        Me.ViewChoresBanner = New System.Windows.Forms.PictureBox()
        Me.HomeMenuButtonsViewChores = New CollaboShare.HomeMenuButtons()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.BackButtonViewChores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewChoresBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButtonViewChores
        '
        Me.BackButtonViewChores.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonViewChores.Location = New System.Drawing.Point(0, 0)
        Me.BackButtonViewChores.Name = "BackButtonViewChores"
        Me.BackButtonViewChores.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonViewChores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonViewChores.TabIndex = 0
        Me.BackButtonViewChores.TabStop = False
        '
        'ViewChoresBanner
        '
        Me.ViewChoresBanner.Image = Global.CollaboShare.My.Resources.Resources.ViewChoresBanner
        Me.ViewChoresBanner.Location = New System.Drawing.Point(0, 36)
        Me.ViewChoresBanner.Name = "ViewChoresBanner"
        Me.ViewChoresBanner.Size = New System.Drawing.Size(350, 125)
        Me.ViewChoresBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ViewChoresBanner.TabIndex = 2
        Me.ViewChoresBanner.TabStop = False
        '
        'HomeMenuButtonsViewChores
        '
        Me.HomeMenuButtonsViewChores.Location = New System.Drawing.Point(1, 509)
        Me.HomeMenuButtonsViewChores.Name = "HomeMenuButtonsViewChores"
        Me.HomeMenuButtonsViewChores.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsViewChores.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Should view chores be the same thing as calendar???"
        '
        'ViewChores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HomeMenuButtonsViewChores)
        Me.Controls.Add(Me.BackButtonViewChores)
        Me.Controls.Add(Me.ViewChoresBanner)
        Me.Name = "ViewChores"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.BackButtonViewChores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewChoresBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButtonViewChores As PictureBox
    Friend WithEvents ViewChoresBanner As PictureBox
    Friend WithEvents HomeMenuButtonsViewChores As HomeMenuButtons
    Friend WithEvents Label2 As Label
End Class
