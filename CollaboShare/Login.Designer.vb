<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LoginUsername = New System.Windows.Forms.TextBox()
        Me.LoginUsernameLabel = New System.Windows.Forms.Label()
        Me.LoginPasswordLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LoginLogo = New System.Windows.Forms.PictureBox()
        Me.LoginButton = New System.Windows.Forms.PictureBox()
        Me.SignUpButton = New System.Windows.Forms.PictureBox()
        CType(Me.LoginLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignUpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginUsername
        '
        Me.LoginUsername.Location = New System.Drawing.Point(134, 376)
        Me.LoginUsername.Name = "LoginUsername"
        Me.LoginUsername.Size = New System.Drawing.Size(191, 20)
        Me.LoginUsername.TabIndex = 1
        '
        'LoginUsernameLabel
        '
        Me.LoginUsernameLabel.AutoSize = True
        Me.LoginUsernameLabel.Location = New System.Drawing.Point(35, 383)
        Me.LoginUsernameLabel.Name = "LoginUsernameLabel"
        Me.LoginUsernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LoginUsernameLabel.TabIndex = 4
        Me.LoginUsernameLabel.Text = "Username:"
        '
        'LoginPasswordLabel
        '
        Me.LoginPasswordLabel.AutoSize = True
        Me.LoginPasswordLabel.Location = New System.Drawing.Point(35, 430)
        Me.LoginPasswordLabel.Name = "LoginPasswordLabel"
        Me.LoginPasswordLabel.Size = New System.Drawing.Size(56, 13)
        Me.LoginPasswordLabel.TabIndex = 5
        Me.LoginPasswordLabel.Text = "Password:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 430)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 20)
        Me.TextBox1.TabIndex = 6
        '
        'LoginLogo
        '
        Me.LoginLogo.Image = Global.CollaboShare.My.Resources.Resources.Screen_Shot_2017_11_09_at_3_00_02_PM
        Me.LoginLogo.Location = New System.Drawing.Point(20, 23)
        Me.LoginLogo.Name = "LoginLogo"
        Me.LoginLogo.Size = New System.Drawing.Size(308, 328)
        Me.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoginLogo.TabIndex = 0
        Me.LoginLogo.TabStop = False
        '
        'LoginButton
        '
        Me.LoginButton.Image = Global.CollaboShare.My.Resources.Resources.loginButton
        Me.LoginButton.Location = New System.Drawing.Point(97, 456)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(144, 71)
        Me.LoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoginButton.TabIndex = 7
        Me.LoginButton.TabStop = False
        '
        'SignUpButton
        '
        Me.SignUpButton.Image = Global.CollaboShare.My.Resources.Resources.SignUpButton
        Me.SignUpButton.Location = New System.Drawing.Point(113, 533)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(112, 51)
        Me.SignUpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SignUpButton.TabIndex = 8
        Me.SignUpButton.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LoginPasswordLabel)
        Me.Controls.Add(Me.LoginUsernameLabel)
        Me.Controls.Add(Me.LoginUsername)
        Me.Controls.Add(Me.LoginLogo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Login"
        Me.Size = New System.Drawing.Size(348, 598)
        CType(Me.LoginLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignUpButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginLogo As PictureBox
    Friend WithEvents LoginUsername As TextBox
    Friend WithEvents LoginUsernameLabel As Label
    Friend WithEvents LoginPasswordLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LoginButton As PictureBox
    Friend WithEvents SignUpButton As PictureBox
End Class
