<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CorrectLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Answer1 = New System.Windows.Forms.Label()
        Me.Answer2 = New System.Windows.Forms.Label()
        Me.Answer3 = New System.Windows.Forms.Label()
        Me.Minutes = New System.Windows.Forms.Label()
        Me.Seconds = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.up = New System.Windows.Forms.Timer(Me.components)
        Me.Down = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ResumeButton = New System.Windows.Forms.Button()
        Me.pausedlabel = New System.Windows.Forms.Label()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.SpawnPoint = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpawnPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.BackColor = System.Drawing.Color.Transparent
        Me.QuestionLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionLabel.Location = New System.Drawing.Point(212, 9)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(61, 38)
        Me.QuestionLabel.TabIndex = 1
        Me.QuestionLabel.Text = "123"
        Me.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.QuestionLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.player1
        Me.PictureBox1.Location = New System.Drawing.Point(574, 452)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'CorrectLabel
        '
        Me.CorrectLabel.AutoSize = True
        Me.CorrectLabel.BackColor = System.Drawing.Color.Transparent
        Me.CorrectLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrectLabel.Location = New System.Drawing.Point(448, 147)
        Me.CorrectLabel.Name = "CorrectLabel"
        Me.CorrectLabel.Size = New System.Drawing.Size(0, 114)
        Me.CorrectLabel.TabIndex = 6
        Me.CorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Answer1
        '
        Me.Answer1.AutoSize = True
        Me.Answer1.BackColor = System.Drawing.Color.Transparent
        Me.Answer1.Font = New System.Drawing.Font("Bernard MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer1.Location = New System.Drawing.Point(383, 304)
        Me.Answer1.Name = "Answer1"
        Me.Answer1.Size = New System.Drawing.Size(99, 38)
        Me.Answer1.TabIndex = 8
        Me.Answer1.Text = "Label3"
        Me.Answer1.Visible = False
        '
        'Answer2
        '
        Me.Answer2.AutoSize = True
        Me.Answer2.BackColor = System.Drawing.Color.Transparent
        Me.Answer2.Font = New System.Drawing.Font("Bernard MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer2.Location = New System.Drawing.Point(592, 304)
        Me.Answer2.Name = "Answer2"
        Me.Answer2.Size = New System.Drawing.Size(99, 38)
        Me.Answer2.TabIndex = 9
        Me.Answer2.Text = "Label2"
        Me.Answer2.Visible = False
        '
        'Answer3
        '
        Me.Answer3.AutoSize = True
        Me.Answer3.BackColor = System.Drawing.Color.Transparent
        Me.Answer3.Font = New System.Drawing.Font("Bernard MT Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer3.Location = New System.Drawing.Point(803, 304)
        Me.Answer3.Name = "Answer3"
        Me.Answer3.Size = New System.Drawing.Size(99, 38)
        Me.Answer3.TabIndex = 10
        Me.Answer3.Text = "Label2"
        Me.Answer3.Visible = False
        '
        'Minutes
        '
        Me.Minutes.AutoSize = True
        Me.Minutes.BackColor = System.Drawing.Color.Transparent
        Me.Minutes.Font = New System.Drawing.Font("Bernard MT Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutes.Location = New System.Drawing.Point(1, 23)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(52, 44)
        Me.Minutes.TabIndex = 14
        Me.Minutes.Text = "01"
        '
        'Seconds
        '
        Me.Seconds.AutoSize = True
        Me.Seconds.BackColor = System.Drawing.Color.Transparent
        Me.Seconds.Font = New System.Drawing.Font("Bernard MT Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds.Location = New System.Drawing.Point(67, 23)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(56, 44)
        Me.Seconds.TabIndex = 15
        Me.Seconds.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bernard MT Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 44)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = ":"
        Me.Label7.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 200
        '
        'up
        '
        Me.up.Interval = 15
        '
        'Down
        '
        Me.Down.Interval = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(0, 579)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1264, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'ResumeButton
        '
        Me.ResumeButton.BackColor = System.Drawing.Color.Black
        Me.ResumeButton.Enabled = False
        Me.ResumeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ResumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ResumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.ResumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ResumeButton.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResumeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResumeButton.Location = New System.Drawing.Point(556, 116)
        Me.ResumeButton.Name = "ResumeButton"
        Me.ResumeButton.Size = New System.Drawing.Size(142, 66)
        Me.ResumeButton.TabIndex = 18
        Me.ResumeButton.Text = "Resume"
        Me.ResumeButton.UseVisualStyleBackColor = False
        Me.ResumeButton.Visible = False
        '
        'pausedlabel
        '
        Me.pausedlabel.AutoSize = True
        Me.pausedlabel.BackColor = System.Drawing.Color.Transparent
        Me.pausedlabel.Font = New System.Drawing.Font("Bernard MT Condensed", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pausedlabel.Location = New System.Drawing.Point(481, -1)
        Me.pausedlabel.Name = "pausedlabel"
        Me.pausedlabel.Size = New System.Drawing.Size(316, 114)
        Me.pausedlabel.TabIndex = 19
        Me.pausedlabel.Text = "PAUSED"
        Me.pausedlabel.Visible = False
        '
        'MenuButton
        '
        Me.MenuButton.BackColor = System.Drawing.Color.Black
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MenuButton.Enabled = False
        Me.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MenuButton.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuButton.Location = New System.Drawing.Point(556, 235)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(142, 66)
        Me.MenuButton.TabIndex = 20
        Me.MenuButton.Text = "Menu"
        Me.MenuButton.UseVisualStyleBackColor = False
        Me.MenuButton.Visible = False
        '
        'RestartButton
        '
        Me.RestartButton.BackColor = System.Drawing.Color.Black
        Me.RestartButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.RestartButton.Enabled = False
        Me.RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RestartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.RestartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RestartButton.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartButton.ForeColor = System.Drawing.Color.Azure
        Me.RestartButton.Location = New System.Drawing.Point(556, 353)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(142, 66)
        Me.RestartButton.TabIndex = 21
        Me.RestartButton.Text = "Restart"
        Me.RestartButton.UseVisualStyleBackColor = False
        Me.RestartButton.Visible = False
        '
        'SpawnPoint
        '
        Me.SpawnPoint.BackColor = System.Drawing.Color.Transparent
        Me.SpawnPoint.Location = New System.Drawing.Point(574, 452)
        Me.SpawnPoint.Name = "SpawnPoint"
        Me.SpawnPoint.Size = New System.Drawing.Size(142, 127)
        Me.SpawnPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpawnPoint.TabIndex = 22
        Me.SpawnPoint.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.backgroundcontrols1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.ResumeButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pausedlabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Answer3)
        Me.Controls.Add(Me.Answer2)
        Me.Controls.Add(Me.Answer1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.CorrectLabel)
        Me.Controls.Add(Me.QuestionLabel)
        Me.Controls.Add(Me.SpawnPoint)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpawnPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuestionLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CorrectLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Answer1 As System.Windows.Forms.Label
    Friend WithEvents Answer2 As System.Windows.Forms.Label
    Friend WithEvents Answer3 As System.Windows.Forms.Label
    Friend WithEvents Minutes As System.Windows.Forms.Label
    Friend WithEvents Seconds As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents up As System.Windows.Forms.Timer
    Friend WithEvents Down As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ResumeButton As System.Windows.Forms.Button
    Friend WithEvents pausedlabel As System.Windows.Forms.Label
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents RestartButton As System.Windows.Forms.Button
    Friend WithEvents SpawnPoint As System.Windows.Forms.PictureBox

End Class
