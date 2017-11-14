<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerifyCompletion
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
        Me.HomeMenuButtonsVerifyCompletion = New CollaboShare.HomeMenuButtons()
        Me.BackButtonVerifyCompletion = New System.Windows.Forms.PictureBox()
        Me.VerifyCompletionBanner = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BackButtonVerifyCompletion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerifyCompletionBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeMenuButtonsVerifyCompletion
        '
        Me.HomeMenuButtonsVerifyCompletion.Location = New System.Drawing.Point(1, 509)
        Me.HomeMenuButtonsVerifyCompletion.Name = "HomeMenuButtonsVerifyCompletion"
        Me.HomeMenuButtonsVerifyCompletion.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsVerifyCompletion.TabIndex = 8
        '
        'BackButtonVerifyCompletion
        '
        Me.BackButtonVerifyCompletion.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonVerifyCompletion.Location = New System.Drawing.Point(0, 1)
        Me.BackButtonVerifyCompletion.Name = "BackButtonVerifyCompletion"
        Me.BackButtonVerifyCompletion.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonVerifyCompletion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonVerifyCompletion.TabIndex = 5
        Me.BackButtonVerifyCompletion.TabStop = False
        '
        'VerifyCompletionBanner
        '
        Me.VerifyCompletionBanner.Image = Global.CollaboShare.My.Resources.Resources.VerifyCompletionBanner
        Me.VerifyCompletionBanner.Location = New System.Drawing.Point(0, 37)
        Me.VerifyCompletionBanner.Name = "VerifyCompletionBanner"
        Me.VerifyCompletionBanner.Size = New System.Drawing.Size(350, 125)
        Me.VerifyCompletionBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VerifyCompletionBanner.TabIndex = 6
        Me.VerifyCompletionBanner.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(116, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 51)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VerifyCompletion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HomeMenuButtonsVerifyCompletion)
        Me.Controls.Add(Me.BackButtonVerifyCompletion)
        Me.Controls.Add(Me.VerifyCompletionBanner)
        Me.Name = "VerifyCompletion"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.BackButtonVerifyCompletion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerifyCompletionBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButtonVerifyCompletion As PictureBox
    Friend WithEvents VerifyCompletionBanner As PictureBox
    Friend WithEvents HomeMenuButtonsVerifyCompletion As HomeMenuButtons
    Friend WithEvents Button1 As Button
End Class
