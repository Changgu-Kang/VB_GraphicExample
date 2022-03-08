Public Class Form1

    Structure Ball
        Dim x_pos As Double
        Dim y_pos As Double
        Dim y_vel As Double
        Dim x_vel As Double
        Dim radius As Double
    End Structure


    Dim Pen_Ball As System.Drawing.Pen
    Dim Pen_Ground As System.Drawing.Pen

    Dim Rand As New Random()

    Dim Balls As ArrayList

    Dim ballImage As Image

    Dim gound_line As Double


    Private Sub UpdateBalls()

        For i = 0 To Balls.Count - 1
            Dim ball = CType(Balls(i), Ball)
            If ball.y_pos < gound_line - ball.radius Then
                ball.y_vel += 0.98
            End If
            Balls(i) = ball
        Next


        For i = 0 To Balls.Count - 1
            Dim ball = CType(Balls(i), Ball)
            ball.x_pos += 3
            If ball.y_pos >= gound_line - ball.radius Then
                ball.y_vel = -ball.y_vel
            End If
            ball.y_pos += ball.y_vel
            Balls(i) = ball
        Next

        Dim index As Integer = 0
        For i = 0 To Balls.Count - 1
            Dim ball = CType(Balls(index), Ball)
            If ball.x_pos > Me.Width Then
                Balls.RemoveAt(index)
            Else
                index += 1
            End If

        Next

    End Sub


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        For i = 0 To Balls.Count - 1
            Dim ball = CType(Balls(i), Ball)
            'e.Graphics.DrawEllipse(Pen_Ball, New Rectangle(ball.x_pos, ball.y_pos, ball.radius, ball.radius))
            e.Graphics.DrawImage(ballImage, New Rectangle(ball.x_pos, ball.y_pos, ball.radius, ball.radius))
            'e.Graphics.DrawString(CStr(ball.x_pos) + " " + CStr(ball.y_vel), New System.Drawing.Font("broadway", 10), New System.Drawing.SolidBrush(System.Drawing.Color.Blue), New Point(55, Me.Height - 61))
        Next
        e.Graphics.DrawLine(Pen_Ground, New Point(0, gound_line), New Point(Me.Width, gound_line))

    End Sub

    Private Sub CallbackTimer_Tick(sender As Object, e As EventArgs) Handles CallbackTimer.Tick
        UpdateBalls()
        Invalidate()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pen_Ball = New Pen(Color.Red, 1)
        Pen_Ground = New Pen(Color.Black, 1)
        Balls = New ArrayList
        ballImage = Image.FromFile("ball.png")
        gound_line = 465
        AddBall()
        Invalidate()
    End Sub

    Private Sub AddBall()
        Dim ball As Ball = New Ball
        ball.x_pos = 0 'Rand.Next(20, Me.Width - 20)
        ball.y_pos = Me.Height / 3
        ball.y_vel = 0.0
        ball.radius = 40
        Balls.Add(ball)
    End Sub



    Private Sub btnAddNextBall_Click(sender As Object, e As EventArgs) Handles btnAddNextBall.Click
        AddBall()
    End Sub

End Class
