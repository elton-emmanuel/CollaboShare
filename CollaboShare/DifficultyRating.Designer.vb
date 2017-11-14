<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DifficultyRating
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
        Me.EmptyStar1 = New System.Windows.Forms.PictureBox()
        Me.EmptyStar2 = New System.Windows.Forms.PictureBox()
        Me.EmptyStar3 = New System.Windows.Forms.PictureBox()
        Me.EmptyStar4 = New System.Windows.Forms.PictureBox()
        Me.EmptyStar5 = New System.Windows.Forms.PictureBox()
        CType(Me.EmptyStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptyStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptyStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptyStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptyStar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmptyStar1
        '
        Me.EmptyStar1.Image = Global.CollaboShare.My.Resources.Resources.emptyStar
        Me.EmptyStar1.Location = New System.Drawing.Point(0, 0)
        Me.EmptyStar1.Name = "EmptyStar1"
        Me.EmptyStar1.Size = New System.Drawing.Size(42, 30)
        Me.EmptyStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmptyStar1.TabIndex = 0
        Me.EmptyStar1.TabStop = False
        '
        'EmptyStar2
        '
        Me.EmptyStar2.Image = Global.CollaboShare.My.Resources.Resources.emptyStar
        Me.EmptyStar2.Location = New System.Drawing.Point(48, 0)
        Me.EmptyStar2.Name = "EmptyStar2"
        Me.EmptyStar2.Size = New System.Drawing.Size(42, 30)
        Me.EmptyStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmptyStar2.TabIndex = 1
        Me.EmptyStar2.TabStop = False
        '
        'EmptyStar3
        '
        Me.EmptyStar3.Image = Global.CollaboShare.My.Resources.Resources.emptyStar
        Me.EmptyStar3.Location = New System.Drawing.Point(96, 0)
        Me.EmptyStar3.Name = "EmptyStar3"
        Me.EmptyStar3.Size = New System.Drawing.Size(42, 30)
        Me.EmptyStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmptyStar3.TabIndex = 2
        Me.EmptyStar3.TabStop = False
        '
        'EmptyStar4
        '
        Me.EmptyStar4.Image = Global.CollaboShare.My.Resources.Resources.emptyStar
        Me.EmptyStar4.Location = New System.Drawing.Point(144, 0)
        Me.EmptyStar4.Name = "EmptyStar4"
        Me.EmptyStar4.Size = New System.Drawing.Size(42, 30)
        Me.EmptyStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmptyStar4.TabIndex = 3
        Me.EmptyStar4.TabStop = False
        '
        'EmptyStar5
        '
        Me.EmptyStar5.Image = Global.CollaboShare.My.Resources.Resources.emptyStar
        Me.EmptyStar5.Location = New System.Drawing.Point(192, 0)
        Me.EmptyStar5.Name = "EmptyStar5"
        Me.EmptyStar5.Size = New System.Drawing.Size(42, 30)
        Me.EmptyStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EmptyStar5.TabIndex = 4
        Me.EmptyStar5.TabStop = False
        '
        'DifficultyRating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Controls.Add(Me.EmptyStar5)
        Me.Controls.Add(Me.EmptyStar4)
        Me.Controls.Add(Me.EmptyStar3)
        Me.Controls.Add(Me.EmptyStar2)
        Me.Controls.Add(Me.EmptyStar1)
        Me.Name = "DifficultyRating"
        Me.Size = New System.Drawing.Size(234, 30)
        CType(Me.EmptyStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptyStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptyStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptyStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptyStar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmptyStar1 As PictureBox
    Friend WithEvents EmptyStar2 As PictureBox
    Friend WithEvents EmptyStar3 As PictureBox
    Friend WithEvents EmptyStar4 As PictureBox
    Friend WithEvents EmptyStar5 As PictureBox
End Class
