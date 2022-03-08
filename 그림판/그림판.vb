Public Class 그림판

    Dim drawingType As Integer
    Dim colorType As Color
    Dim lineWidth As Integer

    Dim isClick As Boolean = False
    Dim pre_pos As Point

    Dim temp_element As Element

    Dim objId As Integer


    Structure Element
        Dim type As Integer
        Dim pos0 As Point
        Dim pos1 As Point
        Dim isFill As Boolean
        Dim color As Color
        Dim id As Integer
        Dim width As Integer
    End Structure

    Dim ElementSet As ArrayList
    Dim RestoreSet As ArrayList

    Private Sub TypeA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbinfolocation.Text = ""
        lbinfoSize.Text = ""
        drawingType = 0
        objId = 0
        colorType = Color.Black
        ElementSet = New ArrayList
        RestoreSet = New ArrayList
        tsBtnShapeToogle()
        tsBtnColorToogle()
    End Sub

    Private Sub tsBtnPen_Click(sender As Object, e As EventArgs) Handles tsBtnPen.Click
        drawingType = 0
        colorType = Color.Black
        tsBtnShapeToogle()
    End Sub

    Private Sub tsBtnLine_Click(sender As Object, e As EventArgs) Handles tsBtnLine.Click
        drawingType = 1
        tsBtnShapeToogle()
    End Sub

    Private Sub tsBtnRec_Click(sender As Object, e As EventArgs) Handles tsBtnRec.Click
        drawingType = 2
        tsBtnShapeToogle()
    End Sub

    Private Sub tsBtnEllipse_Click(sender As Object, e As EventArgs) Handles tsBtnEllipse.Click
        drawingType = 3
        tsBtnShapeToogle()
    End Sub

    Private Sub tsBtnBlack_Click(sender As Object, e As EventArgs) Handles tsBtnBlack.Click
        colorType = Color.Black
        tsBtnColorToogle()

    End Sub

    Private Sub tsBtnGray_Click(sender As Object, e As EventArgs) Handles tsBtnGray.Click
        colorType = Color.Gray
        tsBtnColorToogle()
    End Sub

    Private Sub tsBtnRed_Click(sender As Object, e As EventArgs) Handles tsBtnRed.Click
        colorType = Color.Red
        tsBtnColorToogle()
    End Sub

    Private Sub tsBtnGreen_Click(sender As Object, e As EventArgs) Handles tsBtnGreen.Click
        colorType = Color.Green
        tsBtnColorToogle()
    End Sub

    Private Sub tsBtnBlue_Click(sender As Object, e As EventArgs) Handles tsBtnBlue.Click
        colorType = Color.Blue
        tsBtnColorToogle()
    End Sub

    Private Sub tsBtnColorToogle()
        tsBtnBlack.Checked = False
        tsBtnGray.Checked = False
        tsBtnRed.Checked = False
        tsBtnGreen.Checked = False
        tsBtnBlue.Checked = False

        If colorType = Color.Black Then
            tsBtnBlack.Checked = True
        ElseIf colorType = Color.Gray Then
            tsBtnGray.Checked = True
        ElseIf colorType = Color.Red Then
            tsBtnRed.Checked = True
        ElseIf colorType = Color.Green Then
            tsBtnGreen.Checked = True
        ElseIf colorType = Color.Blue Then
            tsBtnBlue.Checked = True
        End If
    End Sub


    Private Sub tsBtnShapeToogle()
        tsBtnPen.Checked = False
        tsBtnLine.Checked = False
        tsBtnRec.Checked = False
        tsBtnEllipse.Checked = False

        If drawingType = 0 Then
            tsBtnPen.Checked = True
        ElseIf drawingType = 1 Then
            tsBtnLine.Checked = True
        ElseIf drawingType = 2 Then
            tsBtnRec.Checked = True
        ElseIf drawingType = 3 Then
            tsBtnEllipse.Checked = True
        End If
    End Sub



    Private Sub Paint_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If drawingType = 1 Then
            temp_element = New Element
            temp_element.width = lineWidth
            temp_element.id = objId
            temp_element.color = colorType
            temp_element.type = drawingType
            temp_element.pos0.X = e.X
            temp_element.pos0.Y = e.Y
            temp_element.pos1.X = e.X
            temp_element.pos1.Y = e.Y

        ElseIf drawingType = 2 Or drawingType = 3 Then
            temp_element = New Element
            temp_element.width = lineWidth
            temp_element.id = objId
            temp_element.color = colorType
            temp_element.type = drawingType
            temp_element.pos0.X = e.X
            temp_element.pos0.Y = e.Y
            temp_element.pos1.X = 0
            temp_element.pos1.Y = 0
        Else
            pre_pos.X = e.X
            pre_pos.Y = e.Y
        End If
        isClick = True
        Invalidate()
    End Sub

    Private Sub Paint_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        isClick = False

        If drawingType = 1 Then
            If temp_element.pos0 <> temp_element.pos1 Then
                ElementSet.Add(temp_element)
            End If
        ElseIf drawingType = 2 Or drawingType = 3 Then
            If Math.Abs(temp_element.pos1.X) > 0 And Math.Abs(temp_element.pos1.Y) > 0 Then
                ElementSet.Add(temp_element)
            End If
        End If




        objId = objId + 1
        RestoreSet.Clear()
        Invalidate()
    End Sub

    Private Sub Paint_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If isClick = True Then
            If drawingType = 0 Then
                Dim element As Element = New Element
                element.width = lineWidth
                element.id = objId
                element.pos0.X = pre_pos.X
                element.pos0.Y = pre_pos.Y
                element.pos1.X = e.X
                element.pos1.Y = e.Y
                element.type = drawingType
                element.color = colorType
                ElementSet.Add(element)
                pre_pos.X = e.X
                pre_pos.Y = e.Y
                lbinfolocation.Text = CStr(e.Location.X) + ", " + CStr(e.Location.Y - ToolStrip1.Size.Height - MenuStrip1.Size.Height) + "px"
            ElseIf drawingType = 1 Then
                temp_element.pos1.X = e.X
                temp_element.pos1.Y = e.Y
                lbinfolocation.Text = CStr(e.Location.X) + ", " + CStr(e.Location.Y - ToolStrip1.Size.Height - MenuStrip1.Size.Height) + "px"
                lbinfoSize.Text = CStr(Math.Abs(temp_element.pos0.X - temp_element.pos1.X)) + " × " + CStr(Math.Abs(temp_element.pos0.Y - temp_element.pos1.Y)) + "px"
            ElseIf drawingType = 2 Then
                temp_element.pos1.X = e.X - temp_element.pos0.X
                temp_element.pos1.Y = e.Y - temp_element.pos0.Y
                lbinfoSize.Text = CStr(Math.Abs(temp_element.pos1.X)) + " × " + CStr(Math.Abs(temp_element.pos1.Y)) + "px"
            ElseIf drawingType = 3 Then
                temp_element.pos1.X = e.X - temp_element.pos0.X
                temp_element.pos1.Y = e.Y - temp_element.pos0.Y
                lbinfoSize.Text = CStr(Math.Abs(temp_element.pos1.X)) + " × " + CStr(Math.Abs(temp_element.pos1.Y)) + "px"
            End If
            Invalidate()
        Else
            lbinfolocation.Text = CStr(e.Location.X) + ", " + CStr(e.Location.Y - ToolStrip1.Size.Height - MenuStrip1.Size.Height) + "px"
            lbinfoSize.Text = ""
        End If
    End Sub

    Private Sub TypeA_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        For i = 0 To ElementSet.Count - 1
            Dim element = CType(ElementSet(i), Element)

            If element.type = 0 Or element.type = 1 Then
                e.Graphics.DrawLine(New Pen(element.color, element.width), element.pos0, element.pos1)
            ElseIf element.type = 2 Then
                If element.pos1.X < 0 And element.pos1.Y < 0 Then
                    e.Graphics.DrawRectangle(New Pen(element.color, element.width), element.pos0.X + element.pos1.X, element.pos0.Y + element.pos1.Y, -element.pos1.X, -element.pos1.Y)
                ElseIf element.pos1.X < 0 Then
                    e.Graphics.DrawRectangle(New Pen(element.color, element.width), element.pos0.X + element.pos1.X, element.pos0.Y, -element.pos1.X, element.pos1.Y)
                ElseIf element.pos1.Y < 0 Then
                    e.Graphics.DrawRectangle(New Pen(element.color, element.width), element.pos0.X, element.pos0.Y + element.pos1.Y, element.pos1.X, -element.pos1.Y)
                Else
                    e.Graphics.DrawRectangle(New Pen(element.color, element.width), element.pos0.X, element.pos0.Y, element.pos1.X, element.pos1.Y)
                End If

            ElseIf element.type = 3 Then
                e.Graphics.DrawEllipse(New Pen(element.color, element.width), element.pos0.X, element.pos0.Y, element.pos1.X, element.pos1.Y)
            End If
        Next

        If isClick = True Then
            If drawingType = 1 Then
                e.Graphics.DrawLine(New Pen(temp_element.color, temp_element.width), temp_element.pos0.X, temp_element.pos0.Y, temp_element.pos1.X, temp_element.pos1.Y)
            ElseIf drawingType = 2 Then
                If temp_element.pos1.X < 0 And temp_element.pos1.Y < 0 Then
                    e.Graphics.DrawRectangle(New Pen(temp_element.color, temp_element.width), temp_element.pos0.X + temp_element.pos1.X, temp_element.pos0.Y + temp_element.pos1.Y, -temp_element.pos1.X, -temp_element.pos1.Y)
                ElseIf temp_element.pos1.X < 0 Then
                    e.Graphics.DrawRectangle(New Pen(temp_element.color, temp_element.width), temp_element.pos0.X + temp_element.pos1.X, temp_element.pos0.Y, -temp_element.pos1.X, temp_element.pos1.Y)
                ElseIf temp_element.pos1.Y < 0 Then
                    e.Graphics.DrawRectangle(New Pen(temp_element.color, temp_element.width), temp_element.pos0.X, temp_element.pos0.Y + temp_element.pos1.Y, temp_element.pos1.X, -temp_element.pos1.Y)
                Else
                    e.Graphics.DrawRectangle(New Pen(temp_element.color, temp_element.width), temp_element.pos0.X, temp_element.pos0.Y, temp_element.pos1.X, temp_element.pos1.Y)
                End If

            ElseIf drawingType = 3 Then
                e.Graphics.DrawEllipse(New Pen(temp_element.color, temp_element.width), temp_element.pos0.X, temp_element.pos0.Y, temp_element.pos1.X, temp_element.pos1.Y)
            End If
        End If
    End Sub

    Private Sub menuMakeNew_Click(sender As Object, e As EventArgs) Handles menuMakeNew.Click
        ElementSet.Clear()
        Invalidate()
    End Sub

    Private Sub menuGoBack_Click(sender As Object, e As EventArgs) Handles menuGoBack.Click

        Dim index As Integer = ElementSet.Count - 1
        Dim PreId As Integer = -1
        Dim CurId As Integer = -1

        If index >= 0 Then
            Dim Temp = CType(ElementSet(index), Element)
            CurId = Temp.id
            RestoreSet.Add(Temp)
            ElementSet.RemoveAt(index)
            While index > 0
                index = index - 1
                Temp = CType(ElementSet(index), Element)
                PreId = CurId
                CurId = Temp.id
                If PreId = CurId Then
                    RestoreSet.Add(Temp)
                    ElementSet.RemoveAt(index)
                Else
                    Exit While
                End If
            End While
            Invalidate()
        End If
    End Sub


    Private Sub btnLineWidth_TextChanged(sender As Object, e As EventArgs) Handles btnLineWidth.TextChanged
        Try
            Dim temp = CInt(btnLineWidth.Text)
            If temp = 0 Then
                MsgBox("잘못된 입력입니다.")
                btnLineWidth.Text = CStr(lineWidth)
                btnLineWidth.Focus()
            Else
                lineWidth = temp
            End If
        Catch ex As Exception
            MsgBox("잘못된 입력입니다.")
            btnLineWidth.Text = CStr(lineWidth)
            btnLineWidth.Focus()
        End Try

    End Sub

    Private Sub btnLineWidth_Click(sender As Object, e As EventArgs) Handles btnLineWidth.Click
        lineWidth = CInt(btnLineWidth.Text)
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        End
    End Sub


    Private Sub 그림판_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        lbinfolocation.Text = ""
        lbinfoSize.Text = ""
    End Sub

    Private Sub 그림판_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

        lbinfoWsize.Text = CStr(Me.Width) + " × " + CStr(Me.Height - ToolStrip1.Height - MenuStrip1.Height) + "px"
    End Sub

    Private Sub menuRestore_Click(sender As Object, e As EventArgs) Handles menuRestore.Click

        Dim index As Integer = RestoreSet.Count - 1
        Dim PreId As Integer = -1
        Dim CurId As Integer = -1

        If index >= 0 Then
            Dim Temp = CType(RestoreSet(index), Element)
            CurId = Temp.id
            ElementSet.Add(Temp)
            RestoreSet.RemoveAt(index)
            While index > 0
                index = index - 1
                Temp = CType(RestoreSet(index), Element)
                PreId = CurId
                CurId = Temp.id
                If PreId = CurId Then
                    ElementSet.Add(Temp)
                    RestoreSet.RemoveAt(index)
                Else
                    Exit While
                End If
            End While
            Invalidate()
        End If
    End Sub
End Class