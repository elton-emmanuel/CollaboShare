<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TradingChores
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
        Me.TradingChoresHousemateLabel = New System.Windows.Forms.Label()
        Me.TradingChoresDOWLabel = New System.Windows.Forms.Label()
        Me.DOWListBox = New System.Windows.Forms.ListBox()
        Me.ChoresCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.HousemateListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TradingChoresHousemateLabel
        '
        Me.TradingChoresHousemateLabel.AutoSize = True
        Me.TradingChoresHousemateLabel.Location = New System.Drawing.Point(18, 12)
        Me.TradingChoresHousemateLabel.Name = "TradingChoresHousemateLabel"
        Me.TradingChoresHousemateLabel.Size = New System.Drawing.Size(64, 13)
        Me.TradingChoresHousemateLabel.TabIndex = 0
        Me.TradingChoresHousemateLabel.Text = "Housemate:"
        '
        'TradingChoresDOWLabel
        '
        Me.TradingChoresDOWLabel.AutoSize = True
        Me.TradingChoresDOWLabel.Location = New System.Drawing.Point(18, 52)
        Me.TradingChoresDOWLabel.Name = "TradingChoresDOWLabel"
        Me.TradingChoresDOWLabel.Size = New System.Drawing.Size(73, 13)
        Me.TradingChoresDOWLabel.TabIndex = 2
        Me.TradingChoresDOWLabel.Text = "Day of Week:"
        '
        'DOWListBox
        '
        Me.DOWListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOWListBox.FormattingEnabled = True
        Me.DOWListBox.ItemHeight = 18
        Me.DOWListBox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.DOWListBox.Location = New System.Drawing.Point(97, 43)
        Me.DOWListBox.Name = "DOWListBox"
        Me.DOWListBox.Size = New System.Drawing.Size(120, 22)
        Me.DOWListBox.TabIndex = 3
        '
        'ChoresCheckedListBox
        '
        Me.ChoresCheckedListBox.FormattingEnabled = True
        Me.ChoresCheckedListBox.Items.AddRange(New Object() {"Name of all chores on that day"})
        Me.ChoresCheckedListBox.Location = New System.Drawing.Point(0, 81)
        Me.ChoresCheckedListBox.MultiColumn = True
        Me.ChoresCheckedListBox.Name = "ChoresCheckedListBox"
        Me.ChoresCheckedListBox.Size = New System.Drawing.Size(250, 64)
        Me.ChoresCheckedListBox.TabIndex = 4
        '
        'HousemateListBox
        '
        Me.HousemateListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HousemateListBox.FormattingEnabled = True
        Me.HousemateListBox.ItemHeight = 18
        Me.HousemateListBox.Items.AddRange(New Object() {"Name1", "Name2", "Name3"})
        Me.HousemateListBox.Location = New System.Drawing.Point(97, 8)
        Me.HousemateListBox.Name = "HousemateListBox"
        Me.HousemateListBox.Size = New System.Drawing.Size(120, 22)
        Me.HousemateListBox.TabIndex = 5
        '
        'TradingChores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Controls.Add(Me.HousemateListBox)
        Me.Controls.Add(Me.ChoresCheckedListBox)
        Me.Controls.Add(Me.DOWListBox)
        Me.Controls.Add(Me.TradingChoresDOWLabel)
        Me.Controls.Add(Me.TradingChoresHousemateLabel)
        Me.Name = "TradingChores"
        Me.Size = New System.Drawing.Size(250, 142)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TradingChoresHousemateLabel As Label
    Friend WithEvents TradingChoresDOWLabel As Label
    Friend WithEvents DOWListBox As ListBox
    Friend WithEvents ChoresCheckedListBox As CheckedListBox
    Friend WithEvents HousemateListBox As ListBox
End Class
