<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SuitList = New System.Windows.Forms.ImageList(Me.components)
        Me.ValueList = New System.Windows.Forms.ImageList(Me.components)
        Me.CardBodyList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Flop = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Hand = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.opponentNum = New System.Windows.Forms.TextBox()
        Me.RestartBtn = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.currentLoss = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.minimumBet = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RaiseBtn = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.raise = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.allowance = New System.Windows.Forms.TextBox()
        Me.callBtn = New System.Windows.Forms.Button()
        Me.foldBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Flop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Hand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'SuitList
        '
        Me.SuitList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.SuitList.ImageStream = CType(resources.GetObject("SuitList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SuitList.TransparentColor = System.Drawing.Color.Transparent
        Me.SuitList.Images.SetKeyName(0, "0.png")
        Me.SuitList.Images.SetKeyName(1, "1.png")
        Me.SuitList.Images.SetKeyName(2, "2.png")
        Me.SuitList.Images.SetKeyName(3, "3.png")
        '
        'ValueList
        '
        Me.ValueList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ValueList.ImageStream = CType(resources.GetObject("ValueList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ValueList.TransparentColor = System.Drawing.Color.Transparent
        Me.ValueList.Images.SetKeyName(0, "1.png")
        Me.ValueList.Images.SetKeyName(1, "2.png")
        Me.ValueList.Images.SetKeyName(2, "3.png")
        Me.ValueList.Images.SetKeyName(3, "4.png")
        Me.ValueList.Images.SetKeyName(4, "5.png")
        Me.ValueList.Images.SetKeyName(5, "6.png")
        Me.ValueList.Images.SetKeyName(6, "7.png")
        Me.ValueList.Images.SetKeyName(7, "8.png")
        Me.ValueList.Images.SetKeyName(8, "9.png")
        Me.ValueList.Images.SetKeyName(9, "10.png")
        Me.ValueList.Images.SetKeyName(10, "11.png")
        Me.ValueList.Images.SetKeyName(11, "12.png")
        Me.ValueList.Images.SetKeyName(12, "0.png")
        '
        'CardBodyList
        '
        Me.CardBodyList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.CardBodyList.ImageStream = CType(resources.GetObject("CardBodyList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.CardBodyList.TransparentColor = System.Drawing.Color.Transparent
        Me.CardBodyList.Images.SetKeyName(0, "Blank.png")
        Me.CardBodyList.Images.SetKeyName(1, "Back card.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Flop)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 109)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flop"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(139, 65)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 45)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Flop
        '
        Me.Flop.Location = New System.Drawing.Point(5, 17)
        Me.Flop.Name = "Flop"
        Me.Flop.Size = New System.Drawing.Size(116, 87)
        Me.Flop.TabIndex = 6
        Me.Flop.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Hand)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 111)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hand"
        '
        'Hand
        '
        Me.Hand.Location = New System.Drawing.Point(6, 18)
        Me.Hand.Name = "Hand"
        Me.Hand.Size = New System.Drawing.Size(71, 87)
        Me.Hand.TabIndex = 8
        Me.Hand.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.opponentNum)
        Me.GroupBox3.Controls.Add(Me.RestartBtn)
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.RaiseBtn)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.callBtn)
        Me.GroupBox3.Controls.Add(Me.foldBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(145, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 226)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controls"
        '
        'opponentNum
        '
        Me.opponentNum.Location = New System.Drawing.Point(87, 161)
        Me.opponentNum.Name = "opponentNum"
        Me.opponentNum.PlaceholderText = "Number of players(2-9)"
        Me.opponentNum.Size = New System.Drawing.Size(138, 23)
        Me.opponentNum.TabIndex = 19
        '
        'RestartBtn
        '
        Me.RestartBtn.Enabled = False
        Me.RestartBtn.Location = New System.Drawing.Point(87, 132)
        Me.RestartBtn.Name = "RestartBtn"
        Me.RestartBtn.Size = New System.Drawing.Size(138, 23)
        Me.RestartBtn.TabIndex = 1
        Me.RestartBtn.Text = "Restart"
        Me.RestartBtn.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.currentLoss)
        Me.GroupBox8.Location = New System.Drawing.Point(87, 73)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(138, 53)
        Me.GroupBox8.TabIndex = 18
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Your current bet"
        '
        'currentLoss
        '
        Me.currentLoss.Location = New System.Drawing.Point(6, 19)
        Me.currentLoss.Name = "currentLoss"
        Me.currentLoss.ReadOnly = True
        Me.currentLoss.Size = New System.Drawing.Size(126, 23)
        Me.currentLoss.TabIndex = 0
        Me.currentLoss.Text = "5"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.minimumBet)
        Me.GroupBox5.Location = New System.Drawing.Point(87, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(138, 53)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Current minimum bet"
        '
        'minimumBet
        '
        Me.minimumBet.Location = New System.Drawing.Point(6, 19)
        Me.minimumBet.Name = "minimumBet"
        Me.minimumBet.ReadOnly = True
        Me.minimumBet.Size = New System.Drawing.Size(126, 23)
        Me.minimumBet.TabIndex = 0
        Me.minimumBet.Text = "5"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(87, 191)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PlaceholderText = "Hand Value"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(138, 19)
        Me.TextBox3.TabIndex = 9
        '
        'RaiseBtn
        '
        Me.RaiseBtn.Location = New System.Drawing.Point(6, 132)
        Me.RaiseBtn.Name = "RaiseBtn"
        Me.RaiseBtn.Size = New System.Drawing.Size(75, 23)
        Me.RaiseBtn.TabIndex = 18
        Me.RaiseBtn.Text = "Raise"
        Me.RaiseBtn.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.raise)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 161)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(75, 53)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Raise by:"
        '
        'raise
        '
        Me.raise.Location = New System.Drawing.Point(6, 19)
        Me.raise.Mask = "00000"
        Me.raise.Name = "raise"
        Me.raise.Size = New System.Drawing.Size(63, 23)
        Me.raise.TabIndex = 0
        Me.raise.Text = "5"
        Me.raise.ValidatingType = GetType(Integer)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.allowance)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(75, 53)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cash"
        '
        'allowance
        '
        Me.allowance.Location = New System.Drawing.Point(6, 19)
        Me.allowance.Name = "allowance"
        Me.allowance.ReadOnly = True
        Me.allowance.Size = New System.Drawing.Size(63, 23)
        Me.allowance.TabIndex = 0
        Me.allowance.Text = "100"
        '
        'callBtn
        '
        Me.callBtn.Location = New System.Drawing.Point(6, 105)
        Me.callBtn.Name = "callBtn"
        Me.callBtn.Size = New System.Drawing.Size(75, 23)
        Me.callBtn.TabIndex = 17
        Me.callBtn.Text = "Call"
        Me.callBtn.UseVisualStyleBackColor = True
        '
        'foldBtn
        '
        Me.foldBtn.Location = New System.Drawing.Point(6, 76)
        Me.foldBtn.Name = "foldBtn"
        Me.foldBtn.Size = New System.Drawing.Size(75, 23)
        Me.foldBtn.TabIndex = 16
        Me.foldBtn.Text = "Fold"
        Me.foldBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 252)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(406, 291)
        Me.MinimumSize = New System.Drawing.Size(406, 291)
        Me.Name = "Form1"
        Me.Text = "Poker"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Flop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Hand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SuitList As ImageList
    Friend WithEvents ValueList As ImageList
    Friend WithEvents CardBodyList As ImageList
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Flop As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Hand As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents callBtn As Button
    Friend WithEvents foldBtn As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents allowance As TextBox
    Friend WithEvents RaiseBtn As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents currentLoss As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents minimumBet As TextBox
    Friend WithEvents RestartBtn As Button
    Friend WithEvents raise As MaskedTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents opponentNum As TextBox
End Class
