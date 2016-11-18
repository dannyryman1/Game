Public Class Form1
    Dim random As New Random
    Dim num1, num, number, num2, location1, location2 As Integer
    Dim ans1, ans2, num3 As String
    Dim question As String
    Dim correct As Boolean
    Dim corans As Integer
    Public AmountQs As Integer = 0
    Public CorrectQs As Integer = 0

    Dim flip As Boolean = False
    Public tutorialComplete As Boolean = False
    Public pauseBoolean As Boolean = True
    Dim jumpbl As Boolean = True
    Dim stopTutorial As Boolean = True
    Dim normalstring1, normalstring2, normalstring3 As String
    Dim y As Integer = 0

    Dim ans As String
    Dim ansDouble As Double


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tutorialComplete = True
                If stopTutorial = True Then
                    If tutorialComplete = True Then
                        Me.BackgroundImage = My.Resources.background
                        Timer1.Enabled = True
                        Minutes.Visible = True
                        Seconds.Visible = True
                        Label7.Visible = True
                        Answer1.Visible = True
                        Answer2.Visible = True
                        Answer3.Visible = True
                        QuestionLabel.Visible = True
                        CorrectLabel.Visible = True
                        CorrectLabel.Text = ""
                        AmountQs = 0
                        CorrectQs = 0
                        Label7.Visible = True
                        questions()
                        stopTutorial = False
                    End If
                End If
            Case Keys.A
                leftMove()
            Case Keys.Left
                leftMove()
            Case Keys.D
                RightMove()
            Case Keys.Right
                RightMove()
            Case Keys.Space
                Jump()
            Case Keys.Up
                Jump()
            Case Keys.Escape
                If tutorialComplete = True Then
                    pauseBoolean = False
                    Timer1.Enabled = False
                    Timer2.Enabled = False
                    up.Enabled = False
                    Down.Enabled = False
                    ResumeButton.Visible = True
                    ResumeButton.Enabled = True
                    MenuButton.Visible = True
                    MenuButton.Enabled = True
                    RestartButton.Visible = True
                    RestartButton.Enabled = True
                    Answer1.Visible = False
                    Answer2.Visible = False
                    Answer3.Visible = False
                    QuestionLabel.Visible = False
                    CorrectLabel.Visible = False
                    pausedlabel.Visible = True
                End If

        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
    End Sub
    Sub leftMove()
        flip = True
        If PictureBox1.Left < 0 Then
            PictureBox1.Left = PictureBox1.Left
        Else
            For i = 1 To 20
                Me.PictureBox1.Left -= 1
            Next

        End If
        If up.Enabled = False Then
            Down.Enabled = True
        End If
    End Sub

    Sub RightMove()
        flip = False
        If PictureBox1.Left > 1122 Then
            PictureBox1.Left = PictureBox1.Left
        Else
            For i = 1 To 20
                Me.PictureBox1.Left += 1
            Next
        End If

        If up.Enabled = False Then
            Down.Enabled = True
        End If
    End Sub
    Sub Jump()
        If jumpbl = True Then
            up.Enabled = True
            jumpbl = False
        End If
    End Sub
    Function DisplayQuestion()
        If number = 1 Then
            QuestionLabel.Text = temperatureQuestion()
        ElseIf number = 2 Then
            QuestionLabel.Text = timeQuestion()
        ElseIf number = 3 Then
            QuestionLabel.Text = MoneyQuestion()
        ElseIf number = 4 Then
            QuestionLabel.Text = howManyQuestion()
        ElseIf number = 5 Then
            QuestionLabel.Text = FigureQuestion()
        ElseIf number = 6 Then
            QuestionLabel.Text = mmQuestion()
        ElseIf number = 7 Then
            QuestionLabel.Text = multiplicationQuestion()
        End If
        Return QuestionLabel.Text
    End Function
    Function DisplayAnswer()

        Dim timenum3, timenum1, timenum As Integer
        Dim timenum2, timetotal(2) As String

        corans = random.Next(1, 100)
        If number = 1 Then

            If corans <= 33 Then
                Answer2.Text = temperatureAnswer()
                Answer1.Text = random.Next(-5, 10)
                Answer3.Text = random.Next(0, 8)
            ElseIf corans >= 34 And corans <= 66 Then
                Answer1.Text = temperatureAnswer()
                Answer2.Text = random.Next(0, 8)
                Answer3.Text = random.Next(-5, 10)
            ElseIf corans >= 67 Then
                Answer3.Text = temperatureAnswer()
                Answer1.Text = random.Next(-5, 10)
                Answer2.Text = random.Next(0, 8)
            End If

        ElseIf number = 2 Then

            For i = 0 To 2

                timenum = random.Next(1, 4)
                timenum1 = random.Next(1, 12)
                timenum3 = timenum1
                If timenum = 1 Then
                    timenum2 = ":15"
                ElseIf timenum = 2 Then
                    timenum2 = ":30"
                ElseIf timenum = 3 Then
                    timenum2 = ":45"
                ElseIf timenum = 4 Then
                    timenum2 = ":00"
                End If
                timetotal(i) = timenum3 & timenum2
            Next

            If corans <= 33 Then
                Answer2.Text = timeAnswer()
                Answer1.Text = timetotal(1)
                Answer3.Text = timetotal(2)
            ElseIf corans >= 34 And corans <= 66 Then
                Answer1.Text = timeAnswer()
                Answer2.Text = timetotal(1)
                Answer3.Text = timetotal(2)
            ElseIf corans >= 67 Then
                Answer3.Text = timeAnswer()
                Answer1.Text = timetotal(1)
                Answer2.Text = timetotal(2)
            End If

        ElseIf number = 3 Then

            If corans <= 33 Then
                Answer2.Text = "£" & MoneyAnswer() & "0"
                Answer1.Text = "£" & MoneyAnswer() - 2 & "0"
                Answer3.Text = "£" & MoneyAnswer() + 2 & "0"
            ElseIf corans >= 34 And corans <= 66 Then
                Answer1.Text = "£" & MoneyAnswer() & "0"
                Answer2.Text = "£" & MoneyAnswer() + 2 & "0"
                Answer3.Text = "£" & MoneyAnswer() - 2 & "0"
            ElseIf corans >= 67 Then
                Answer3.Text = "£" & MoneyAnswer() & "0"
                Answer1.Text = "£" & MoneyAnswer() - 2 & "0"
                Answer2.Text = "£" & MoneyAnswer() + 2 & "0"
            End If

        ElseIf number = 4 Then

            If corans <= 33 Then
                Answer2.Text = howManyAnswer()
                Answer1.Text = howManyAnswer() - 2
                Answer3.Text = howManyAnswer() + 2
            ElseIf corans >= 34 And corans <= 66 Then
                Answer1.Text = howManyAnswer()
                Answer2.Text = howManyAnswer() - 2
                Answer3.Text = howManyAnswer() + 2
            ElseIf corans >= 67 Then
                Answer3.Text = howManyAnswer()
                Answer1.Text = howManyAnswer() + 2
                Answer2.Text = howManyAnswer() - 2
            End If

        ElseIf number = 5 Then

            If corans <= 33 Then
                Answer2.Text = FigureAnswer()
                Answer1.Text = FigureAnswer() - 10
                Answer3.Text = FigureAnswer() + 10
            ElseIf corans >= 34 And corans <= 66 Then
                Answer1.Text = FigureAnswer()
                Answer2.Text = FigureAnswer() - 10
                Answer3.Text = FigureAnswer() + 10
            ElseIf corans >= 67 Then
                Answer3.Text = FigureAnswer()
                Answer1.Text = FigureAnswer() + 10
                Answer2.Text = FigureAnswer() - 10
            End If

        ElseIf number = 6 Then

            If corans <= 33 Then
                Answer2.Text = mmAnswer()
                Answer1.Text = mmAnswer() - 10
                Answer3.Text = mmAnswer() + 10
            ElseIf corans >= 34 And corans <= 66 Then
                Answer1.Text = mmAnswer()
                Answer2.Text = mmAnswer() - 10
                Answer3.Text = mmAnswer() + 10
            ElseIf corans >= 67 Then
                Answer3.Text = mmAnswer()
                Answer1.Text = mmAnswer() + 10
                Answer2.Text = mmAnswer() - 10
            End If

        ElseIf number = 7 Then

            If corans <= 33 Then
                Answer2.Text = multiplicationAnswer()
                Answer1.Text = multiplicationAnswer() - 10
                Answer3.Text = multiplicationAnswer() + 10
            ElseIf corans >= 34 And corans <= 66 Then
                Answer1.Text = multiplicationAnswer()
                Answer2.Text = multiplicationAnswer() - 10
                Answer3.Text = multiplicationAnswer() + 10
            ElseIf corans >= 67 Then
                Answer3.Text = multiplicationAnswer()
                Answer1.Text = multiplicationAnswer() + 10
                Answer2.Text = multiplicationAnswer() - 10
            End If
        End If

    End Function
    Function getQuestion()
        number = random.Next(1, 8)
        Return number
    End Function

    Function multiplicationQuestion()

        num1 = random.Next(1, 5)
        num2 = random.Next(10, 25)

        question = "What is " & num1 & " multiplied by " & num2 & "?"
        Return question
    End Function
    Function multiplicationAnswer()

        ans = num1 * num2
        Return ans

    End Function

    Function mmQuestion()
        num1 = random.Next(2, 10)
        question = "How many millimetres are there in " & num1 & " centimetres?"

        Return question
    End Function
    Function mmAnswer()
        ans = num1 * 10
        Return ans
    End Function

    Function FigureQuestion()

        Dim numbers() As String
        numbers = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"}
        num = random.Next(1, 10)
        num1 = random.Next(1, 10)
        num2 = random.Next(1, 10)
        normalstring1 = numbers(num)
        normalstring2 = numbers(num1)
        normalstring3 = numbers(num2)

        question = "Write " & normalstring1 & " thousand " & normalstring2 & " hundred and " & normalstring3 & " in figures"
        Return question
    End Function
    Function FigureAnswer()
        ans = num & num1 & "0" & num2
        Return ans
    End Function

    Function howManyQuestion()
        num1 = random.Next(1, 10)
        num2 = random.Next(1, 10)
        num3 = num1 * num2
        question = "How many " & num1 & "'s are in " & num3 & "?"
        Return question
    End Function
    Function howManyAnswer()
        ans = num2
        Return ans
    End Function

    Function MoneyQuestion()

        num1 = random.Next(17, 30)
        num2 = random.Next(1, 15)

        question = "What is £" & num1 & " - £" & num2 & ".50?"
        Return question
    End Function
    Function MoneyAnswer()
        ansDouble = num1 - num2
        ansDouble = ansDouble - 0.5
        Return ansDouble
    End Function

    Function temperatureQuestion()

        num1 = random.Next(1, 10)
        num2 = random.Next(-10, -1)

        question = "What temperature is " & num1 & " degrees higher than " & num2 & " degrees celsius?"
        Return question

    End Function
    Function temperatureAnswer()
        ans = num2 + num1
        Return ans

    End Function

    Function timeQuestion()
        num1 = random.Next(1, 12)
        num2 = random.Next(1, 4)
        If num2 = 1 Then
            num3 = 15
            If num1 = 1 Then
                ans1 = 12
                ans2 = ":45"
            Else
                ans1 = num1 - 1
                ans2 = ":45"
            End If
        ElseIf num2 = 2 Then
            num3 = 30
            ans1 = num1
            ans2 = ":00"
        ElseIf num2 = 3 Then
            num3 = "45"
            ans1 = num1
            ans2 = ":15"
        ElseIf num2 = 4 Then
            num3 = "00"
            If num1 = 1 Then
                ans1 = 12
                ans2 = ":30"
            Else
                ans1 = num1 - 1
                ans2 = ":30"
            End If

        End If
        question = "What time is it half an hour before " & num1 & ":" & num3 & "?"
        Return question

    End Function
    Function timeAnswer()
        ans = ans1 & ans2
        Return ans
    End Function

    Sub questions()
        getQuestion()
        DisplayQuestion()
        DisplayAnswer()
        
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Minutes.Text = "01" Then
            Minutes.Text = "00"
            Seconds.Text = "60"
        End If
        If Minutes.Text = "00" Then
            Seconds.Text -= 1
        End If

        If Minutes.Text = "00" And Seconds.Text = "0" Then
            Timer1.Enabled = False
            MsgBox("You correctly answered " & CorrectQs & " out of " & AmountQs & " questions.")
            Me.Hide()
            MainForm.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If up.Enabled = False Then
            If y Mod 2 = 0 Then
                Me.PictureBox1.Image = My.Resources.player1
            Else
                Me.PictureBox1.Image = My.Resources.player2
            End If
        End If
        If flip = False Then
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        End If
        y += 1
        Me.Refresh()

    End Sub




    Private Sub Down_Tick(sender As Object, e As EventArgs) Handles Down.Tick
        If Not PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            For i = 1 To 10
                PictureBox1.Top += 1
            Next

            jumpbl = False

            If PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) Then

                PictureBox1.Top = PictureBox2.Top - 127

                Down.Enabled = False
                jumpbl = True

            End If
        End If


    End Sub

    Private Sub up_Tick(sender As Object, e As EventArgs) Handles up.Tick
        Static x As Integer = 0
        If x < 20 Then
            'x is 0, every tick will increase the players y coordinate by 16
            For i = 1 To 10
                PictureBox1.Top -= 1

            Next

        Else
            'if x is bigger than 20 then the jump timer will be disabled and the down timer will be enabled
            up.Enabled = False
            AmountQs += 1
            If PictureBox1.Bounds.IntersectsWith(Answer1.Bounds) Then
                If corans >= 34 And corans <= 66 Then
                    CorrectLabel.ForeColor = Color.Green
                    CorrectLabel.Text = "Correct"
                    CorrectQs += 1
                    questions()
                Else
                    CorrectLabel.ForeColor = Color.Red
                    CorrectLabel.Text = "Incorrect"
                    questions()
                End If

            ElseIf PictureBox1.Bounds.IntersectsWith(Answer2.Bounds) Then

                If corans <= 33 Then
                    CorrectLabel.ForeColor = Color.Green
                    CorrectLabel.Text = "Correct"
                    CorrectQs += 1
                    questions()
                Else
                    CorrectLabel.ForeColor = Color.Red
                    CorrectLabel.Text = "Incorrect"
                    questions()
                End If

            ElseIf PictureBox1.Bounds.IntersectsWith(Answer3.Bounds) Then
                If corans >= 67 Then
                    CorrectLabel.ForeColor = Color.Green
                    CorrectLabel.Text = "Correct"
                    CorrectQs += 1
                    questions()
                Else
                    CorrectLabel.ForeColor = Color.Red
                    CorrectLabel.Text = "Incorrect"
                    questions()
                End If

            End If
            Down.Enabled = True
            x = 0
        End If
        x += 1
    End Sub

    Private Sub ResumeButton_Click(sender As Object, e As EventArgs) Handles ResumeButton.Click
        ResumeButton.Enabled = False
        ResumeButton.Visible = False
        MenuButton.Enabled = False
        MenuButton.Visible = False
        RestartButton.Enabled = False
        RestartButton.Visible = False
        If tutorialComplete = True Then
            Timer1.Enabled = True
            Answer1.Visible = True
            Answer2.Visible = True
            Answer3.Visible = True
            QuestionLabel.Visible = True
            CorrectLabel.Visible = True
        End If

        Timer2.Enabled = True
        Down.Enabled = True
        pauseBoolean = True
        pausedlabel.Visible = False
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        PictureBox1.Location = SpawnPoint.Location
        ResumeButton.Enabled = False
        ResumeButton.Visible = False
        MenuButton.Enabled = False
        MenuButton.Visible = False
        RestartButton.Enabled = False
        RestartButton.Visible = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        Down.Enabled = True
        pauseBoolean = True
        pausedlabel.Visible = False
        Timer1.Enabled = True
        Answer1.Visible = True
        Answer2.Visible = True
        Answer3.Visible = True
        QuestionLabel.Visible = True
        CorrectLabel.Visible = True

        Me.Hide()

        MainForm.Show()
    End Sub

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        ResumeButton.Enabled = False
        ResumeButton.Visible = False
        MenuButton.Enabled = False
        MenuButton.Visible = False
        RestartButton.Enabled = False
        RestartButton.Visible = False
        questions()
        PictureBox1.Location = SpawnPoint.Location
        CorrectLabel.Text = ""
        Minutes.Text = "01"
        Seconds.Text = "00"
        CorrectQs = 0
        AmountQs = 0
        Timer1.Enabled = True
        Timer2.Enabled = True
        Down.Enabled = True
        pauseBoolean = True
        Answer1.Visible = True
        Answer2.Visible = True
        Answer3.Visible = True
        QuestionLabel.Visible = True
        CorrectLabel.Visible = True
        pausedlabel.Visible = False
    End Sub


End Class