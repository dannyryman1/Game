Public Class LoadingForm

    Dim x As Integer

    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Width = 0

        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Panel2.Width += 3
        If Panel2.Width = "450" Then
            Me.Hide()
            MainForm.Show()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If x = 100 Then
            Timer2.Enabled = False
        Else
            load_text.Text += "."
            If load_text.Text = "Loading....." Then
                load_text.Text = "Loading"
            End If
        End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        x += 10
        If x = 10 Then
            Me.PictureBox1.Image = My.Resources.player1
        ElseIf x = 20 Then
            Me.PictureBox1.Image = My.Resources.player1_1
        ElseIf x = 30 Then
            Me.PictureBox1.Image = My.Resources.player2
        ElseIf x = 40 Then
            Me.PictureBox1.Image = My.Resources.player2_1
        ElseIf x = 50 Then
            Me.PictureBox1.Image = My.Resources.player1
        ElseIf x = 60 Then
            Me.PictureBox1.Image = My.Resources.player1_1
        ElseIf x = 70 Then
            Me.PictureBox1.Image = My.Resources.player2
        ElseIf x = 80 Then
            Me.PictureBox1.Image = My.Resources.player2_1
        ElseIf x = 90 Then
            Me.PictureBox1.Image = My.Resources.player1
        ElseIf x = 100 Then
            Me.PictureBox1.Image = My.Resources.player1_1
        End If


        If x > 100 Then
            Timer3.Enabled = False
        Else
            percenttext.Text = x & "% complete"
        End If


    End Sub
End Class