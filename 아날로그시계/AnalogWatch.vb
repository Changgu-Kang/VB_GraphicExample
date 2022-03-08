

Public Class AnalogWatch

    Structure Particle
        Dim pos As Point
        Dim Mov_Horizontal_Cnt As Integer
        Dim Mov_Horizontal_Dir As Integer
        Dim Moving As Boolean

        Dim DownSpeed As Integer
    End Structure

    Dim ParticleMax As Integer = 900

    Dim HourPen As System.Drawing.Pen
    Dim MinPen As System.Drawing.Pen
    Dim SecPen As System.Drawing.Pen
    Dim decoPen1 As System.Drawing.Pen
    Dim decoPen2 As System.Drawing.Pen
    Dim decoBrush As New System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke)

    Dim pre_second As Integer = 0

    Dim Particles As ArrayList

    Dim Rand As New Random()


    Dim backImage As Image


    Dim FrameCnt As Integer = 0

    Private Sub Timer_second_Tick(sender As Object, e As EventArgs) Handles Timer_second.Tick
        ParticleUpdate()
        Invalidate()
    End Sub

    Private Sub AnalogWatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        backImage = Image.FromFile("background.png")

        HourPen = New Pen(Color.Red, 3)
        MinPen = New Pen(Color.Green, 2)
        SecPen = New Pen(Color.Blue, 1)
        decoPen1 = New Pen(Color.Magenta, 1)
        decoPen2 = New Pen(Color.Magenta, 3)

        Particles = New ArrayList

        Invalidate()
    End Sub



    Private Sub ParticleUpdate()


        Dim StopCnt As Integer = 0


        For i = 0 To Particles.Count - 1
            Dim p0 = CType(Particles(i), Particle)

            If p0.Moving = True And p0.pos.Y < (Me.Height - 43) Then

                Dim isStop As Boolean = False
                For j = 0 To i - 1
                    If i <> j Then
                        Dim p1 = CType(Particles(j), Particle)

                        If p0.pos.Y < p1.pos.Y Then
                            Dim dis = Math.Sqrt(Math.Pow(p0.pos.X - p1.pos.X, 2) + Math.Pow(p0.pos.Y - p1.pos.Y, 2))

                            If dis < 2.0 Then
                                p0.Moving = False
                                isStop = True

                                Exit For
                            End If
                        End If
                    End If

                Next

                If isStop = False Then

                    p0.pos.Y = p0.pos.Y + p0.DownSpeed

                    If p0.Mov_Horizontal_Dir = 0 Then
                        p0.pos.X = p0.pos.X - 1
                    ElseIf p0.Mov_Horizontal_Dir = 2 Then
                        p0.pos.X = p0.pos.X + 1
                    End If

                    If p0.Mov_Horizontal_Cnt <= 0 Then
                        p0.Mov_Horizontal_Dir = Rand.Next(0, 7)
                        p0.Mov_Horizontal_Cnt = Rand.Next(30, 50)
                    End If

                    Particles(i) = p0
                Else
                    StopCnt += 1
                End If
            Else
                StopCnt += 1
                p0.Moving = False
            End If


        Next


        If FrameCnt Mod 3 = 0 Then
            If Particles.Count < ParticleMax Then

                Dim genCnt As Integer

                If ParticleMax > 5 Then
                    genCnt = Rand.Next(0, 5)
                Else
                    genCnt = Rand.Next(0, 4)
                End If

                If Particles.Count + genCnt > ParticleMax Then
                    genCnt = ParticleMax - Particles.Count
                End If

                For i = 1 To genCnt
                    Dim p As Particle = New Particle
                    p.pos = New Point(Rand.Next(1, Me.Width), 10)
                    p.Moving = True
                    p.Mov_Horizontal_Dir = Rand.Next(0, 7)
                    p.Mov_Horizontal_Cnt = Rand.Next(30, 50)
                    p.DownSpeed = Rand.Next(1, 3)
                    Particles.Add(p)
                Next
            End If
        End If


        If StopCnt >= ParticleMax Then
            Particles.Clear()
        End If


        FrameCnt = FrameCnt + 1


    End Sub


    Private Sub DrawCanvas(graphics As Graphics)

        'graphics.Clear(Color.Black) '화면 지우기
        graphics.DrawImage(backImage, New Point(0, 0))


        Dim cur_hour As Integer
        Dim cur_minute As Integer
        Dim cur_second As Integer

        If Now.Hour > 12 Then
            cur_hour = Now.Hour - 12
        Else
            cur_hour = Now.Hour
        End If

        cur_minute = Now.Minute
        cur_second = Now.Second

        Dim center_x = Me.Width / 2.0 - 10
        Dim center_y = Me.Height / 2.0 - 20

        Dim hour_angle = (360.0 / 12.0)
        Dim min_angle = (360.0 / 60.0)
        Dim sec_angle = (360.0 / 60.0)

        Dim hour_x As Double = 0
        Dim hour_y As Double = -50

        Dim min_x As Double = 0
        Dim min_y As Double = -60

        Dim sec_x As Double = 0
        Dim sec_y As Double = -70

        hour_angle *= cur_hour
        min_angle *= cur_minute
        sec_angle *= cur_second

        hour_angle = hour_angle + cur_minute / 60.0 * 30.0

        Dim new_hour_x = Math.Cos(hour_angle * Math.PI / 180.0) * hour_x - Math.Sin(hour_angle * Math.PI / 180.0) * hour_y
        Dim new_hour_y = Math.Sin(hour_angle * Math.PI / 180.0) * hour_x + Math.Cos(hour_angle * Math.PI / 180.0) * hour_y

        Dim new_min_x = Math.Cos(min_angle * Math.PI / 180.0) * min_x - Math.Sin(min_angle * Math.PI / 180.0) * min_y
        Dim new_min_y = Math.Sin(min_angle * Math.PI / 180.0) * min_x + Math.Cos(min_angle * Math.PI / 180.0) * min_y

        Dim new_sec_x = Math.Cos(sec_angle * Math.PI / 180.0) * sec_x - Math.Sin(sec_angle * Math.PI / 180.0) * sec_y
        Dim new_sec_y = Math.Sin(sec_angle * Math.PI / 180.0) * sec_x + Math.Cos(sec_angle * Math.PI / 180.0) * sec_y




        graphics.DrawLine(HourPen, CInt(center_x), CInt(center_y), CInt(center_x + new_hour_x), CInt(center_y + new_hour_y))
        graphics.DrawLine(MinPen, CInt(center_x), CInt(center_y), CInt(center_x + new_min_x), CInt(center_y + new_min_y))
        graphics.DrawLine(SecPen, CInt(center_x), CInt(center_y), CInt(center_x + new_sec_x), CInt(center_y + new_sec_y))

        For i = 0 To 360 Step 6

            Dim s_x = Math.Cos(i * Math.PI / 180.0) * 75.0 - Math.Sin(i * Math.PI / 180.0) * 0
            Dim s_y = Math.Sin(i * Math.PI / 180.0) * 75.0 + Math.Cos(i * Math.PI / 180.0) * 0

            Dim m_x = Math.Cos(i * Math.PI / 180.0) * 78.0 - Math.Sin(i * Math.PI / 180.0) * 0
            Dim m_y = Math.Sin(i * Math.PI / 180.0) * 78.0 + Math.Cos(i * Math.PI / 180.0) * 0

            Dim e_x = Math.Cos(i * Math.PI / 180.0) * 81.0 - Math.Sin(i * Math.PI / 180.0) * 0
            Dim e_y = Math.Sin(i * Math.PI / 180.0) * 81.0 + Math.Cos(i * Math.PI / 180.0) * 0
            If i Mod 15 = 0 Then
                graphics.DrawLine(decoPen2, CInt(center_x + s_x), CInt(center_y + s_y), CInt(center_x + e_x), CInt(center_y + e_y))
            Else
                graphics.DrawLine(decoPen1, CInt(center_x + s_x), CInt(center_y + s_y), CInt(center_x + m_x), CInt(center_y + m_y))
            End If
        Next


        Dim drawTextFont1 As New System.Drawing.Font("broadway", 15)
        Dim drawTextBrush As New System.Drawing.SolidBrush(System.Drawing.Color.Blue)
        graphics.DrawString(Now.ToLongTimeString(), drawTextFont1, drawTextBrush, New Point(70, Me.Height - 75))


        'Dim drawTextFont2 As New System.Drawing.Font(Font.Bold, 10)
        'graphics.DrawString("Particle Count: " + CStr(Particles.Count), drawTextFont2, drawTextBrush, New Point(5, 25))

        'Dim signature As String = "made by ckang"
        'Dim drawTextFont3 As New System.Drawing.Font(Font.Italic, 10)
        'graphics.DrawString(signature, drawTextFont3, drawTextBrush, New Point(Me.Width * 2 / 3 - 15, Me.Height - 61))

        For i = 0 To Particles.Count - 1
            graphics.FillEllipse(decoBrush, Particles(i).pos.X, Particles(i).pos.Y, 4, 4)

        Next


    End Sub

    Private Sub AnalogWatch_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawCanvas(e.Graphics)
    End Sub
End Class
