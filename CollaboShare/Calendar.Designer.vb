<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calendar
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
        Me.HomeMenuButtonsCalendar = New CollaboShare.HomeMenuButtons()
        Me.CalendarBanner = New System.Windows.Forms.PictureBox()
        Me.WeekDayBackground = New System.Windows.Forms.PictureBox()
        Me.CalendarLeftArrow = New System.Windows.Forms.PictureBox()
        Me.CalendarRightArrow = New System.Windows.Forms.PictureBox()
        Me.CalendarBackground = New System.Windows.Forms.PictureBox()
        Me.WeekDayLabel = New System.Windows.Forms.Label()
        Me.CalendarChores1 = New CollaboShare.CalendarChores()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.CalendarBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekDayBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarLeftArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarRightArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeMenuButtonsCalendar
        '
        Me.HomeMenuButtonsCalendar.Location = New System.Drawing.Point(0, 511)
        Me.HomeMenuButtonsCalendar.Name = "HomeMenuButtonsCalendar"
        Me.HomeMenuButtonsCalendar.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsCalendar.TabIndex = 10
        '
        'CalendarBanner
        '
        Me.CalendarBanner.Image = Global.CollaboShare.My.Resources.Resources.CalendarBanner
        Me.CalendarBanner.Location = New System.Drawing.Point(0, 32)
        Me.CalendarBanner.Name = "CalendarBanner"
        Me.CalendarBanner.Size = New System.Drawing.Size(350, 125)
        Me.CalendarBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CalendarBanner.TabIndex = 9
        Me.CalendarBanner.TabStop = False
        '
        'WeekDayBackground
        '
        Me.WeekDayBackground.Image = Global.CollaboShare.My.Resources.Resources.CalendarWeekDayBackground
        Me.WeekDayBackground.Location = New System.Drawing.Point(84, 154)
        Me.WeekDayBackground.Name = "WeekDayBackground"
        Me.WeekDayBackground.Size = New System.Drawing.Size(183, 78)
        Me.WeekDayBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WeekDayBackground.TabIndex = 11
        Me.WeekDayBackground.TabStop = False
        '
        'CalendarLeftArrow
        '
        Me.CalendarLeftArrow.Image = Global.CollaboShare.My.Resources.Resources.CalendarLeftArrow
        Me.CalendarLeftArrow.Location = New System.Drawing.Point(0, 154)
        Me.CalendarLeftArrow.Name = "CalendarLeftArrow"
        Me.CalendarLeftArrow.Size = New System.Drawing.Size(78, 78)
        Me.CalendarLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CalendarLeftArrow.TabIndex = 13
        Me.CalendarLeftArrow.TabStop = False
        '
        'CalendarRightArrow
        '
        Me.CalendarRightArrow.Image = Global.CollaboShare.My.Resources.Resources.CalendarRightArrow
        Me.CalendarRightArrow.Location = New System.Drawing.Point(273, 154)
        Me.CalendarRightArrow.Name = "CalendarRightArrow"
        Me.CalendarRightArrow.Size = New System.Drawing.Size(78, 78)
        Me.CalendarRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CalendarRightArrow.TabIndex = 14
        Me.CalendarRightArrow.TabStop = False
        '
        'CalendarBackground
        '
        Me.CalendarBackground.Image = Global.CollaboShare.My.Resources.Resources.CalendarBackground
        Me.CalendarBackground.Location = New System.Drawing.Point(16, 238)
        Me.CalendarBackground.Name = "CalendarBackground"
        Me.CalendarBackground.Size = New System.Drawing.Size(318, 269)
        Me.CalendarBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CalendarBackground.TabIndex = 15
        Me.CalendarBackground.TabStop = False
        '
        'WeekDayLabel
        '
        Me.WeekDayLabel.AutoSize = True
        Me.WeekDayLabel.BackColor = System.Drawing.Color.White
        Me.WeekDayLabel.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekDayLabel.ForeColor = System.Drawing.Color.SeaGreen
        Me.WeekDayLabel.Location = New System.Drawing.Point(143, 177)
        Me.WeekDayLabel.Name = "WeekDayLabel"
        Me.WeekDayLabel.Size = New System.Drawing.Size(67, 33)
        Me.WeekDayLabel.TabIndex = 16
        Me.WeekDayLabel.Text = "Day"
        '
        'CalendarChores1
        '
        Me.CalendarChores1.BackColor = System.Drawing.Color.White
        Me.CalendarChores1.Location = New System.Drawing.Point(41, 266)
        Me.CalendarChores1.Name = "CalendarChores1"
        Me.CalendarChores1.Size = New System.Drawing.Size(246, 42)
        Me.CalendarChores1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CalendarChores1)
        Me.Controls.Add(Me.WeekDayLabel)
        Me.Controls.Add(Me.CalendarBackground)
        Me.Controls.Add(Me.CalendarRightArrow)
        Me.Controls.Add(Me.CalendarLeftArrow)
        Me.Controls.Add(Me.WeekDayBackground)
        Me.Controls.Add(Me.HomeMenuButtonsCalendar)
        Me.Controls.Add(Me.CalendarBanner)
        Me.Name = "Calendar"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.CalendarBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekDayBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarLeftArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarRightArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeMenuButtonsCalendar As HomeMenuButtons
    Friend WithEvents CalendarBanner As PictureBox
    Friend WithEvents WeekDayBackground As PictureBox
    Friend WithEvents CalendarLeftArrow As PictureBox
    Friend WithEvents CalendarRightArrow As PictureBox
    Friend WithEvents CalendarBackground As PictureBox
    Friend WithEvents WeekDayLabel As Label
    Friend WithEvents CalendarChores1 As CalendarChores
    Friend WithEvents PictureBox1 As PictureBox
End Class
