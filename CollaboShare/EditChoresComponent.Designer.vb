<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditChoresComponent
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
        Me.EditChoreName = New System.Windows.Forms.Label()
        Me.EditChoresPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.EditChoresPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EditChoreName
        '
        Me.EditChoreName.AutoSize = True
        Me.EditChoreName.BackColor = System.Drawing.Color.White
        Me.EditChoreName.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditChoreName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.EditChoreName.Location = New System.Drawing.Point(15, 7)
        Me.EditChoreName.Name = "EditChoreName"
        Me.EditChoreName.Size = New System.Drawing.Size(143, 29)
        Me.EditChoreName.TabIndex = 0
        Me.EditChoreName.Text = "Chore Name"
        '
        'EditChoresPicture
        '
        Me.EditChoresPicture.BackColor = System.Drawing.Color.White
        Me.EditChoresPicture.Image = Global.CollaboShare.My.Resources.Resources.editchoresymbol
        Me.EditChoresPicture.Location = New System.Drawing.Point(225, 9)
        Me.EditChoresPicture.Name = "EditChoresPicture"
        Me.EditChoresPicture.Size = New System.Drawing.Size(61, 29)
        Me.EditChoresPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EditChoresPicture.TabIndex = 1
        Me.EditChoresPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CollaboShare.My.Resources.Resources.whiteBubble
        Me.PictureBox1.Location = New System.Drawing.Point(-8, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(316, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'EditChoresComponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Controls.Add(Me.EditChoresPicture)
        Me.Controls.Add(Me.EditChoreName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EditChoresComponent"
        Me.Size = New System.Drawing.Size(300, 45)
        CType(Me.EditChoresPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EditChoreName As Label
    Friend WithEvents EditChoresPicture As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
