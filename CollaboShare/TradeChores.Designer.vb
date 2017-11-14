<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TradeChores
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
        Me.TradingChores2 = New CollaboShare.TradingChores()
        Me.TradingChores1 = New CollaboShare.TradingChores()
        Me.HomeMenuButtonsTradeChores = New CollaboShare.HomeMenuButtons()
        Me.TradeChoresBackground = New System.Windows.Forms.PictureBox()
        Me.BackButtonTradeChores = New System.Windows.Forms.PictureBox()
        Me.TradeChoresBanner = New System.Windows.Forms.PictureBox()
        CType(Me.TradeChoresBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButtonTradeChores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradeChoresBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TradingChores2
        '
        Me.TradingChores2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TradingChores2.Location = New System.Drawing.Point(51, 355)
        Me.TradingChores2.Name = "TradingChores2"
        Me.TradingChores2.Size = New System.Drawing.Size(252, 148)
        Me.TradingChores2.TabIndex = 10
        '
        'TradingChores1
        '
        Me.TradingChores1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.TradingChores1.Location = New System.Drawing.Point(51, 140)
        Me.TradingChores1.Name = "TradingChores1"
        Me.TradingChores1.Size = New System.Drawing.Size(252, 148)
        Me.TradingChores1.TabIndex = 9
        '
        'HomeMenuButtonsTradeChores
        '
        Me.HomeMenuButtonsTradeChores.Location = New System.Drawing.Point(1, 509)
        Me.HomeMenuButtonsTradeChores.Name = "HomeMenuButtonsTradeChores"
        Me.HomeMenuButtonsTradeChores.Size = New System.Drawing.Size(351, 88)
        Me.HomeMenuButtonsTradeChores.TabIndex = 7
        '
        'TradeChoresBackground
        '
        Me.TradeChoresBackground.Image = Global.CollaboShare.My.Resources.Resources.tradeChoresBackground2
        Me.TradeChoresBackground.Location = New System.Drawing.Point(-15, 140)
        Me.TradeChoresBackground.Name = "TradeChoresBackground"
        Me.TradeChoresBackground.Size = New System.Drawing.Size(381, 370)
        Me.TradeChoresBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TradeChoresBackground.TabIndex = 8
        Me.TradeChoresBackground.TabStop = False
        '
        'BackButtonTradeChores
        '
        Me.BackButtonTradeChores.Image = Global.CollaboShare.My.Resources.Resources.BackButton
        Me.BackButtonTradeChores.Location = New System.Drawing.Point(0, -1)
        Me.BackButtonTradeChores.Name = "BackButtonTradeChores"
        Me.BackButtonTradeChores.Size = New System.Drawing.Size(63, 58)
        Me.BackButtonTradeChores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackButtonTradeChores.TabIndex = 5
        Me.BackButtonTradeChores.TabStop = False
        '
        'TradeChoresBanner
        '
        Me.TradeChoresBanner.Image = Global.CollaboShare.My.Resources.Resources.TradeChoresBanner
        Me.TradeChoresBanner.Location = New System.Drawing.Point(0, 35)
        Me.TradeChoresBanner.Name = "TradeChoresBanner"
        Me.TradeChoresBanner.Size = New System.Drawing.Size(350, 125)
        Me.TradeChoresBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TradeChoresBanner.TabIndex = 6
        Me.TradeChoresBanner.TabStop = False
        '
        'TradeChores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.TradingChores2)
        Me.Controls.Add(Me.TradingChores1)
        Me.Controls.Add(Me.TradeChoresBackground)
        Me.Controls.Add(Me.HomeMenuButtonsTradeChores)
        Me.Controls.Add(Me.BackButtonTradeChores)
        Me.Controls.Add(Me.TradeChoresBanner)
        Me.Name = "TradeChores"
        Me.Size = New System.Drawing.Size(350, 600)
        CType(Me.TradeChoresBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButtonTradeChores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradeChoresBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButtonTradeChores As PictureBox
    Friend WithEvents TradeChoresBanner As PictureBox
    Friend WithEvents HomeMenuButtonsTradeChores As HomeMenuButtons
    Friend WithEvents TradeChoresBackground As PictureBox
    Friend WithEvents TradingChores1 As TradingChores
    Friend WithEvents TradingChores2 As TradingChores
End Class
