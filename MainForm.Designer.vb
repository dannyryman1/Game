<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PlayerImage = New System.Windows.Forms.PictureBox()
        Me.StatisticsButton = New System.Windows.Forms.Button()
        Me.TimeTrialButton = New System.Windows.Forms.Button()
        Me.LearnButton = New System.Windows.Forms.Button()
        CType(Me.PlayerImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerImage
        '
        Me.PlayerImage.BackColor = System.Drawing.Color.Transparent
        Me.PlayerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlayerImage.Image = CType(resources.GetObject("PlayerImage.Image"), System.Drawing.Image)
        Me.PlayerImage.Location = New System.Drawing.Point(7, -3)
        Me.PlayerImage.Name = "PlayerImage"
        Me.PlayerImage.Size = New System.Drawing.Size(632, 686)
        Me.PlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerImage.TabIndex = 6
        Me.PlayerImage.TabStop = False
        '
        'StatisticsButton
        '
        Me.StatisticsButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.StatisticsButton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.StatisticsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.StatisticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatisticsButton.Font = New System.Drawing.Font("Sylfaen", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatisticsButton.ForeColor = System.Drawing.Color.White
        Me.StatisticsButton.Location = New System.Drawing.Point(705, 528)
        Me.StatisticsButton.Name = "StatisticsButton"
        Me.StatisticsButton.Size = New System.Drawing.Size(500, 120)
        Me.StatisticsButton.TabIndex = 3
        Me.StatisticsButton.Text = "STATISTICS"
        Me.StatisticsButton.UseVisualStyleBackColor = False
        '
        'TimeTrialButton
        '
        Me.TimeTrialButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TimeTrialButton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TimeTrialButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.TimeTrialButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.TimeTrialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimeTrialButton.Font = New System.Drawing.Font("Sylfaen", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeTrialButton.ForeColor = System.Drawing.Color.White
        Me.TimeTrialButton.Location = New System.Drawing.Point(705, 328)
        Me.TimeTrialButton.Name = "TimeTrialButton"
        Me.TimeTrialButton.Size = New System.Drawing.Size(500, 120)
        Me.TimeTrialButton.TabIndex = 4
        Me.TimeTrialButton.Text = "TIME TRIAL"
        Me.TimeTrialButton.UseVisualStyleBackColor = False
        '
        'LearnButton
        '
        Me.LearnButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.LearnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LearnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue
        Me.LearnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.LearnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LearnButton.Font = New System.Drawing.Font("Sylfaen", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LearnButton.ForeColor = System.Drawing.Color.White
        Me.LearnButton.Location = New System.Drawing.Point(705, 128)
        Me.LearnButton.Name = "LearnButton"
        Me.LearnButton.Size = New System.Drawing.Size(500, 120)
        Me.LearnButton.TabIndex = 5
        Me.LearnButton.Text = "LEARN"
        Me.LearnButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.background0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.PlayerImage)
        Me.Controls.Add(Me.StatisticsButton)
        Me.Controls.Add(Me.TimeTrialButton)
        Me.Controls.Add(Me.LearnButton)
        Me.DoubleBuffered = True
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.PlayerImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlayerImage As System.Windows.Forms.PictureBox
    Friend WithEvents StatisticsButton As System.Windows.Forms.Button
    Friend WithEvents TimeTrialButton As System.Windows.Forms.Button
    Friend WithEvents LearnButton As System.Windows.Forms.Button
End Class
