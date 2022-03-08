<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 그림판
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(그림판))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbinfolocation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbinfoSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbinfoWsize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsBtnPen = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnLine = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnRec = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnEllipse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnBlack = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnGray = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnRed = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnGreen = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnBlue = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLineWidth = New System.Windows.Forms.ToolStripTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.파일ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMakeNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.편집ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGoBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbinfolocation, Me.lbinfoSize, Me.lbinfoWsize})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "연필"
        '
        'lbinfolocation
        '
        Me.lbinfolocation.AutoSize = False
        Me.lbinfolocation.BackColor = System.Drawing.Color.Transparent
        Me.lbinfolocation.Name = "lbinfolocation"
        Me.lbinfolocation.Size = New System.Drawing.Size(100, 17)
        Me.lbinfolocation.Text = "0, 0px"
        Me.lbinfolocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbinfoSize
        '
        Me.lbinfoSize.AutoSize = False
        Me.lbinfoSize.BackColor = System.Drawing.Color.Transparent
        Me.lbinfoSize.Name = "lbinfoSize"
        Me.lbinfoSize.Size = New System.Drawing.Size(100, 17)
        Me.lbinfoSize.Text = "0 × 0px"
        Me.lbinfoSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbinfoWsize
        '
        Me.lbinfoWsize.AutoSize = False
        Me.lbinfoWsize.BackColor = System.Drawing.Color.Transparent
        Me.lbinfoWsize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbinfoWsize.Name = "lbinfoWsize"
        Me.lbinfoWsize.Size = New System.Drawing.Size(100, 17)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnPen, Me.tsBtnLine, Me.tsBtnRec, Me.tsBtnEllipse, Me.ToolStripSeparator1, Me.tsBtnBlack, Me.tsBtnGray, Me.tsBtnRed, Me.tsBtnGreen, Me.tsBtnBlue, Me.ToolStripSeparator2, Me.btnLineWidth})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsBtnPen
        '
        Me.tsBtnPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnPen.Image = CType(resources.GetObject("tsBtnPen.Image"), System.Drawing.Image)
        Me.tsBtnPen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPen.Name = "tsBtnPen"
        Me.tsBtnPen.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnPen.Text = "ToolStripButton1"
        Me.tsBtnPen.ToolTipText = "연필"
        '
        'tsBtnLine
        '
        Me.tsBtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnLine.Image = CType(resources.GetObject("tsBtnLine.Image"), System.Drawing.Image)
        Me.tsBtnLine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnLine.Name = "tsBtnLine"
        Me.tsBtnLine.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnLine.Text = "ToolStripButton2"
        Me.tsBtnLine.ToolTipText = "선"
        '
        'tsBtnRec
        '
        Me.tsBtnRec.BackColor = System.Drawing.Color.Transparent
        Me.tsBtnRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsBtnRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnRec.Image = CType(resources.GetObject("tsBtnRec.Image"), System.Drawing.Image)
        Me.tsBtnRec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnRec.Name = "tsBtnRec"
        Me.tsBtnRec.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnRec.Text = "ToolStripButton3"
        Me.tsBtnRec.ToolTipText = "직사각형"
        '
        'tsBtnEllipse
        '
        Me.tsBtnEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnEllipse.Image = CType(resources.GetObject("tsBtnEllipse.Image"), System.Drawing.Image)
        Me.tsBtnEllipse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnEllipse.Name = "tsBtnEllipse"
        Me.tsBtnEllipse.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnEllipse.Text = "ToolStripButton4"
        Me.tsBtnEllipse.ToolTipText = "타원"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsBtnBlack
        '
        Me.tsBtnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnBlack.Image = CType(resources.GetObject("tsBtnBlack.Image"), System.Drawing.Image)
        Me.tsBtnBlack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnBlack.Name = "tsBtnBlack"
        Me.tsBtnBlack.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnBlack.Text = "ToolStripButton1"
        Me.tsBtnBlack.ToolTipText = "검정"
        '
        'tsBtnGray
        '
        Me.tsBtnGray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnGray.Image = CType(resources.GetObject("tsBtnGray.Image"), System.Drawing.Image)
        Me.tsBtnGray.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnGray.Name = "tsBtnGray"
        Me.tsBtnGray.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnGray.Text = "ToolStripButton2"
        Me.tsBtnGray.ToolTipText = "회색"
        '
        'tsBtnRed
        '
        Me.tsBtnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnRed.Image = CType(resources.GetObject("tsBtnRed.Image"), System.Drawing.Image)
        Me.tsBtnRed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnRed.Name = "tsBtnRed"
        Me.tsBtnRed.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnRed.Text = "ToolStripButton3"
        Me.tsBtnRed.ToolTipText = "빨강"
        '
        'tsBtnGreen
        '
        Me.tsBtnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnGreen.Image = CType(resources.GetObject("tsBtnGreen.Image"), System.Drawing.Image)
        Me.tsBtnGreen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnGreen.Name = "tsBtnGreen"
        Me.tsBtnGreen.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnGreen.Text = "ToolStripButton4"
        Me.tsBtnGreen.ToolTipText = "녹색"
        '
        'tsBtnBlue
        '
        Me.tsBtnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnBlue.Image = CType(resources.GetObject("tsBtnBlue.Image"), System.Drawing.Image)
        Me.tsBtnBlue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnBlue.Name = "tsBtnBlue"
        Me.tsBtnBlue.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnBlue.Text = "ToolStripButton5"
        Me.tsBtnBlue.ToolTipText = "파랑"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnLineWidth
        '
        Me.btnLineWidth.Font = New System.Drawing.Font("맑은 고딕", 9.0!)
        Me.btnLineWidth.Name = "btnLineWidth"
        Me.btnLineWidth.Size = New System.Drawing.Size(30, 25)
        Me.btnLineWidth.Text = "1"
        Me.btnLineWidth.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnLineWidth.ToolTipText = "크기"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일ToolStripMenuItem, Me.편집ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '파일ToolStripMenuItem
        '
        Me.파일ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMakeNew, Me.menuExit})
        Me.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem"
        Me.파일ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.파일ToolStripMenuItem.Text = "파일"
        '
        'menuMakeNew
        '
        Me.menuMakeNew.Name = "menuMakeNew"
        Me.menuMakeNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.menuMakeNew.Size = New System.Drawing.Size(198, 22)
        Me.menuMakeNew.Text = "새로 만들기(&N)"
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.menuExit.Size = New System.Drawing.Size(198, 22)
        Me.menuExit.Text = "끝내기(&X)"
        '
        '편집ToolStripMenuItem
        '
        Me.편집ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuGoBack, Me.menuRestore})
        Me.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem"
        Me.편집ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.편집ToolStripMenuItem.Text = "편집"
        '
        'menuGoBack
        '
        Me.menuGoBack.Name = "menuGoBack"
        Me.menuGoBack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.menuGoBack.Size = New System.Drawing.Size(182, 22)
        Me.menuGoBack.Text = "실행 취소(&Z)"
        '
        'menuRestore
        '
        Me.menuRestore.Name = "menuRestore"
        Me.menuRestore.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.menuRestore.Size = New System.Drawing.Size(182, 22)
        Me.menuRestore.Text = "다시 실행(&Y)"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "이미지파일(*.jpg)|*.jpg"
        Me.SaveFileDialog.InitialDirectory = "\"
        Me.SaveFileDialog.Title = "저장하기"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "그림판"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbinfolocation As ToolStripStatusLabel
    Friend WithEvents lbinfoSize As ToolStripStatusLabel
    Friend WithEvents lbinfoWsize As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsBtnPen As ToolStripButton
    Friend WithEvents tsBtnLine As ToolStripButton
    Friend WithEvents tsBtnRec As ToolStripButton
    Friend WithEvents tsBtnEllipse As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsBtnBlack As ToolStripButton
    Friend WithEvents tsBtnGray As ToolStripButton
    Friend WithEvents tsBtnRed As ToolStripButton
    Friend WithEvents tsBtnGreen As ToolStripButton
    Friend WithEvents tsBtnBlue As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnLineWidth As ToolStripTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 파일ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuMakeNew As ToolStripMenuItem
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents 편집ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuGoBack As ToolStripMenuItem
    Friend WithEvents menuRestore As ToolStripMenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
End Class
