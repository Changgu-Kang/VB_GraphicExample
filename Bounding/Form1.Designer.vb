﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CallbackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnAddNextBall = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CallbackTimer
        '
        Me.CallbackTimer.Enabled = True
        Me.CallbackTimer.Interval = 33
        '
        'btnAddNextBall
        '
        Me.btnAddNextBall.Location = New System.Drawing.Point(597, 12)
        Me.btnAddNextBall.Name = "btnAddNextBall"
        Me.btnAddNextBall.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNextBall.TabIndex = 1
        Me.btnAddNextBall.Text = "Next"
        Me.btnAddNextBall.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 497)
        Me.Controls.Add(Me.btnAddNextBall)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CallbackTimer As Timer
    Friend WithEvents btnAddNextBall As Button
End Class
