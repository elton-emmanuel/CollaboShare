<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DistributeChores
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
        Me.BackButtonDistributeChores = New System.Windows.Forms.PictureBox()
        Me.DistributeChoresBanner = New System.Windows.Forms.PictureBox()
        CType(Me.BackButtonDistributeChores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistributeChoresBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButtonDistributeChores
        '
        Me.BackButtonDistributeChores.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonDistributeChores.Location = New System.Drawing.Point(0, 1)
        Me.BackButtonDistributeChores.Name = "BackButtonDistributeChores"
        Me.BackButtonDistributeChores.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonDistributeChores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonDistributeChores.TabIndex = 7
        Me.BackButtonDistributeChores.TabStop = False
        '
        'DistributeChoresBanner
        '
        Me.DistributeChoresBanner.Image = Global.CollaboShare.My.Resources.Resources.DistributeChoresBanner
        Me.DistributeChoresBanner.Location = New System.Drawing.Point(0, 37)
        Me.DistributeChoresBanner.Name = "DistributeChoresBanner"
        Me.DistributeChoresBanner.Size = New System.Drawing.Size(350, 125)
        Me.DistributeChoresBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DistributeChoresBanner.TabIndex = 8
        Me.DistributeChoresBanner.TabStop = False
        '
        'DistributeChores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.BackButtonDistributeChores)
        Me.Controls.Add(Me.DistributeChoresBanner)
        Me.Name = "DistributeChores"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.BackButtonDistributeChores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistributeChoresBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButtonDistributeChores As PictureBox
    Friend WithEvents DistributeChoresBanner As PictureBox
End Class
