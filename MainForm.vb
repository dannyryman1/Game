Public Class MainForm

    Private Sub TimeTrialButton_Click(sender As Object, e As EventArgs) Handles TimeTrialButton.Click
        Me.Hide()
        Form1.Show()
        If Form1.tutorialComplete = False Then
            Form1.Minutes.Visible = False
            Form1.Seconds.Visible = False
            Form1.ResumeButton.Enabled = False
            Form1.ResumeButton.Visible = False
            Form1.MenuButton.Enabled = False
            Form1.MenuButton.Visible = False
            Form1.Timer1.Enabled = False
            Form1.Timer2.Enabled = True
            Form1.Down.Enabled = True
            Form1.pauseBoolean = True
            Form1.Answer1.Visible = False
            Form1.Answer2.Visible = False
            Form1.Answer3.Visible = False
            Form1.QuestionLabel.Visible = False
            Form1.CorrectLabel.Visible = False
            Form1.RestartButton.Visible = False
            Form1.pausedlabel.Visible = False
        End If
        Form1.AmountQs = 0
        Form1.CorrectQs = 0
        Form1.CorrectLabel.Text = ""
        Form1.Minutes.Text = "01"
        Form1.Seconds.Text = "00"

    End Sub
End Class