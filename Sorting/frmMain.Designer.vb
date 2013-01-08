<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtUnsorted = New System.Windows.Forms.TextBox()
        Me.grpUnsorted = New System.Windows.Forms.GroupBox()
        Me.grpSorted = New System.Windows.Forms.GroupBox()
        Me.txtSorted = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.cmbAlgorithm = New System.Windows.Forms.ComboBox()
        Me.pnlTexts = New System.Windows.Forms.Panel()
        Me.pnlInputsTop = New System.Windows.Forms.Panel()
        Me.chkUmlaute = New System.Windows.Forms.CheckBox()
        Me.chkCompareText = New System.Windows.Forms.CheckBox()
        Me.chkWords = New System.Windows.Forms.CheckBox()
        Me.pnlInputAlgorithm = New System.Windows.Forms.Panel()
        Me.lblAlgo = New System.Windows.Forms.Label()
        Me.pnlInputsBottom = New System.Windows.Forms.Panel()
        Me.lblWordNum = New System.Windows.Forms.Label()
        Me.txtWordNum = New System.Windows.Forms.TextBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSortieren = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompareText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWorte = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUmlaute = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlgorithmus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBubblesort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertionsort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuicksort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRipplesort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgLoadText = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSaveText = New System.Windows.Forms.SaveFileDialog()
        Me.tspTools = New System.Windows.Forms.ToolStrip()
        Me.tlbNew = New System.Windows.Forms.ToolStripButton()
        Me.tlbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tlbSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbCut = New System.Windows.Forms.ToolStripButton()
        Me.tlbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tlbPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbSort = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlbHelp = New System.Windows.Forms.ToolStripButton()
        Me.pnlFix1 = New System.Windows.Forms.Panel()
        Me.pnlFix2 = New System.Windows.Forms.Panel()
        Me.grpUnsorted.SuspendLayout()
        Me.grpSorted.SuspendLayout()
        Me.pnlTexts.SuspendLayout()
        Me.pnlInputsTop.SuspendLayout()
        Me.pnlInputAlgorithm.SuspendLayout()
        Me.pnlInputsBottom.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.tspTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUnsorted
        '
        Me.txtUnsorted.Location = New System.Drawing.Point(6, 19)
        Me.txtUnsorted.MaxLength = 5000000
        Me.txtUnsorted.Multiline = True
        Me.txtUnsorted.Name = "txtUnsorted"
        Me.txtUnsorted.Size = New System.Drawing.Size(745, 266)
        Me.txtUnsorted.TabIndex = 0
        '
        'grpUnsorted
        '
        Me.grpUnsorted.Controls.Add(Me.txtUnsorted)
        Me.grpUnsorted.Location = New System.Drawing.Point(3, 3)
        Me.grpUnsorted.Name = "grpUnsorted"
        Me.grpUnsorted.Size = New System.Drawing.Size(757, 292)
        Me.grpUnsorted.TabIndex = 1
        Me.grpUnsorted.TabStop = False
        Me.grpUnsorted.Text = "Unsortiert"
        '
        'grpSorted
        '
        Me.grpSorted.Controls.Add(Me.txtSorted)
        Me.grpSorted.Location = New System.Drawing.Point(3, 301)
        Me.grpSorted.Name = "grpSorted"
        Me.grpSorted.Size = New System.Drawing.Size(757, 292)
        Me.grpSorted.TabIndex = 2
        Me.grpSorted.TabStop = False
        Me.grpSorted.Text = "Sortiert"
        '
        'txtSorted
        '
        Me.txtSorted.Location = New System.Drawing.Point(6, 19)
        Me.txtSorted.MaxLength = 5000000
        Me.txtSorted.Multiline = True
        Me.txtSorted.Name = "txtSorted"
        Me.txtSorted.ReadOnly = True
        Me.txtSorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSorted.Size = New System.Drawing.Size(745, 266)
        Me.txtSorted.TabIndex = 0
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(9, 3)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(103, 23)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sortieren"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(401, 8)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(47, 13)
        Me.lblDuration.TabIndex = 4
        Me.lblDuration.Text = "Duration"
        '
        'txtDuration
        '
        Me.txtDuration.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDuration.Enabled = False
        Me.txtDuration.Location = New System.Drawing.Point(454, 5)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtDuration.TabIndex = 5
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(692, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'cmbAlgorithm
        '
        Me.cmbAlgorithm.FormattingEnabled = True
        Me.cmbAlgorithm.Items.AddRange(New Object() {"Bubblesort", "Insertionsort", "Quicksort", "Ripplesort"})
        Me.cmbAlgorithm.Location = New System.Drawing.Point(62, 3)
        Me.cmbAlgorithm.Name = "cmbAlgorithm"
        Me.cmbAlgorithm.Size = New System.Drawing.Size(140, 21)
        Me.cmbAlgorithm.TabIndex = 7
        '
        'pnlTexts
        '
        Me.pnlTexts.Controls.Add(Me.grpUnsorted)
        Me.pnlTexts.Controls.Add(Me.grpSorted)
        Me.pnlTexts.Location = New System.Drawing.Point(12, 98)
        Me.pnlTexts.Name = "pnlTexts"
        Me.pnlTexts.Size = New System.Drawing.Size(770, 633)
        Me.pnlTexts.TabIndex = 9
        '
        'pnlInputsTop
        '
        Me.pnlInputsTop.Controls.Add(Me.chkUmlaute)
        Me.pnlInputsTop.Controls.Add(Me.chkCompareText)
        Me.pnlInputsTop.Controls.Add(Me.chkWords)
        Me.pnlInputsTop.Controls.Add(Me.pnlInputAlgorithm)
        Me.pnlInputsTop.Location = New System.Drawing.Point(12, 58)
        Me.pnlInputsTop.Name = "pnlInputsTop"
        Me.pnlInputsTop.Size = New System.Drawing.Size(770, 30)
        Me.pnlInputsTop.TabIndex = 10
        '
        'chkUmlaute
        '
        Me.chkUmlaute.AutoSize = True
        Me.chkUmlaute.Location = New System.Drawing.Point(537, 6)
        Me.chkUmlaute.Name = "chkUmlaute"
        Me.chkUmlaute.Size = New System.Drawing.Size(65, 17)
        Me.chkUmlaute.TabIndex = 15
        Me.chkUmlaute.Text = "Umlaute"
        Me.chkUmlaute.UseVisualStyleBackColor = True
        '
        'chkCompareText
        '
        Me.chkCompareText.AutoSize = True
        Me.chkCompareText.Location = New System.Drawing.Point(414, 7)
        Me.chkCompareText.Name = "chkCompareText"
        Me.chkCompareText.Size = New System.Drawing.Size(100, 17)
        Me.chkCompareText.TabIndex = 14
        Me.chkCompareText.Text = "Vergleiche Text"
        Me.chkCompareText.UseVisualStyleBackColor = True
        '
        'chkWords
        '
        Me.chkWords.AutoSize = True
        Me.chkWords.Location = New System.Drawing.Point(342, 6)
        Me.chkWords.Name = "chkWords"
        Me.chkWords.Size = New System.Drawing.Size(57, 17)
        Me.chkWords.TabIndex = 13
        Me.chkWords.Text = "Words"
        Me.chkWords.UseVisualStyleBackColor = True
        '
        'pnlInputAlgorithm
        '
        Me.pnlInputAlgorithm.Controls.Add(Me.lblAlgo)
        Me.pnlInputAlgorithm.Controls.Add(Me.cmbAlgorithm)
        Me.pnlInputAlgorithm.Location = New System.Drawing.Point(3, 0)
        Me.pnlInputAlgorithm.Name = "pnlInputAlgorithm"
        Me.pnlInputAlgorithm.Size = New System.Drawing.Size(205, 27)
        Me.pnlInputAlgorithm.TabIndex = 12
        '
        'lblAlgo
        '
        Me.lblAlgo.AutoSize = True
        Me.lblAlgo.Location = New System.Drawing.Point(3, 6)
        Me.lblAlgo.Name = "lblAlgo"
        Me.lblAlgo.Size = New System.Drawing.Size(53, 13)
        Me.lblAlgo.TabIndex = 8
        Me.lblAlgo.Text = "Algorithm:"
        '
        'pnlInputsBottom
        '
        Me.pnlInputsBottom.Controls.Add(Me.lblWordNum)
        Me.pnlInputsBottom.Controls.Add(Me.txtWordNum)
        Me.pnlInputsBottom.Controls.Add(Me.btnQuit)
        Me.pnlInputsBottom.Controls.Add(Me.lblDuration)
        Me.pnlInputsBottom.Controls.Add(Me.btnSort)
        Me.pnlInputsBottom.Controls.Add(Me.txtDuration)
        Me.pnlInputsBottom.Location = New System.Drawing.Point(12, 710)
        Me.pnlInputsBottom.Name = "pnlInputsBottom"
        Me.pnlInputsBottom.Size = New System.Drawing.Size(770, 28)
        Me.pnlInputsBottom.TabIndex = 11
        '
        'lblWordNum
        '
        Me.lblWordNum.AutoSize = True
        Me.lblWordNum.Location = New System.Drawing.Point(193, 8)
        Me.lblWordNum.Name = "lblWordNum"
        Me.lblWordNum.Size = New System.Drawing.Size(74, 13)
        Me.lblWordNum.TabIndex = 7
        Me.lblWordNum.Text = "Anzahl Wörter"
        '
        'txtWordNum
        '
        Me.txtWordNum.BackColor = System.Drawing.SystemColors.Menu
        Me.txtWordNum.Enabled = False
        Me.txtWordNum.Location = New System.Drawing.Point(273, 5)
        Me.txtWordNum.Name = "txtWordNum"
        Me.txtWordNum.Size = New System.Drawing.Size(100, 20)
        Me.txtWordNum.TabIndex = 8
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuOptions, Me.mnuInfo, Me.ToolStripMenuItem1})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuMain.Size = New System.Drawing.Size(799, 24)
        Me.mnuMain.TabIndex = 12
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuToolStripSeparator1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuFile.Size = New System.Drawing.Size(46, 20)
        Me.mnuFile.Text = "&Datei"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(166, 22)
        Me.mnuNew.Text = "Neu"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(166, 22)
        Me.mnuOpen.Text = "Öffnen"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(166, 22)
        Me.mnuSave.Text = "Speichern"
        '
        'mnuToolStripSeparator1
        '
        Me.mnuToolStripSeparator1.Name = "mnuToolStripSeparator1"
        Me.mnuToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(166, 22)
        Me.mnuExit.Text = "Beenden"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSortieren, Me.mnuToolStripSeparator2, Me.mnuCut, Me.mnuCopy, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(75, 20)
        Me.mnuEdit.Text = "&Bearbeiten"
        '
        'mnuSortieren
        '
        Me.mnuSortieren.Name = "mnuSortieren"
        Me.mnuSortieren.Size = New System.Drawing.Size(189, 22)
        Me.mnuSortieren.Text = "Sortieren"
        '
        'mnuToolStripSeparator2
        '
        Me.mnuToolStripSeparator2.Name = "mnuToolStripSeparator2"
        Me.mnuToolStripSeparator2.Size = New System.Drawing.Size(186, 6)
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(189, 22)
        Me.mnuCut.Text = "&Ausschneiden"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(189, 22)
        Me.mnuCopy.Text = "&Kopieren"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(189, 22)
        Me.mnuPaste.Text = "&Einfügen"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCompareText, Me.mnuWorte, Me.mnuUmlaute, Me.mnuAlgorithmus})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(69, 20)
        Me.mnuOptions.Text = "&Optionen"
        '
        'mnuCompareText
        '
        Me.mnuCompareText.Name = "mnuCompareText"
        Me.mnuCompareText.Size = New System.Drawing.Size(154, 22)
        Me.mnuCompareText.Text = "&Vergleiche Text"
        '
        'mnuWorte
        '
        Me.mnuWorte.Name = "mnuWorte"
        Me.mnuWorte.Size = New System.Drawing.Size(154, 22)
        Me.mnuWorte.Text = "&Worte"
        '
        'mnuUmlaute
        '
        Me.mnuUmlaute.Name = "mnuUmlaute"
        Me.mnuUmlaute.Size = New System.Drawing.Size(154, 22)
        Me.mnuUmlaute.Text = "&Umlaute"
        '
        'mnuAlgorithmus
        '
        Me.mnuAlgorithmus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBubblesort, Me.mnuInsertionsort, Me.mnuQuicksort, Me.mnuRipplesort})
        Me.mnuAlgorithmus.Name = "mnuAlgorithmus"
        Me.mnuAlgorithmus.Size = New System.Drawing.Size(154, 22)
        Me.mnuAlgorithmus.Text = "&Algorithmus"
        '
        'mnuBubblesort
        '
        Me.mnuBubblesort.Name = "mnuBubblesort"
        Me.mnuBubblesort.Size = New System.Drawing.Size(152, 22)
        Me.mnuBubblesort.Text = "&Bubblesort"
        '
        'mnuInsertionsort
        '
        Me.mnuInsertionsort.Name = "mnuInsertionsort"
        Me.mnuInsertionsort.Size = New System.Drawing.Size(152, 22)
        Me.mnuInsertionsort.Text = "&Insertionsort"
        '
        'mnuQuicksort
        '
        Me.mnuQuicksort.Name = "mnuQuicksort"
        Me.mnuQuicksort.Size = New System.Drawing.Size(152, 22)
        Me.mnuQuicksort.Text = "&Quicksort"
        '
        'mnuRipplesort
        '
        Me.mnuRipplesort.Name = "mnuRipplesort"
        Me.mnuRipplesort.Size = New System.Drawing.Size(152, 22)
        Me.mnuRipplesort.Text = "&Ripplesort"
        '
        'mnuInfo
        '
        Me.mnuInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuInfo.Name = "mnuInfo"
        Me.mnuInfo.Size = New System.Drawing.Size(45, 20)
        Me.mnuInfo.Text = "&Infos"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(99, 22)
        Me.mnuAbout.Text = "&Über"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = " "
        '
        'dlgLoadText
        '
        Me.dlgLoadText.FileName = "Select File"
        '
        'tspTools
        '
        Me.tspTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tspTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlbNew, Me.tlbOpen, Me.tlbSave, Me.ToolStripSeparator1, Me.tlbCut, Me.tlbCopy, Me.tlbPaste, Me.ToolStripSeparator2, Me.tlbSort, Me.ToolStripSeparator3, Me.tlbHelp})
        Me.tspTools.Location = New System.Drawing.Point(0, 24)
        Me.tspTools.Name = "tspTools"
        Me.tspTools.Padding = New System.Windows.Forms.Padding(0)
        Me.tspTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspTools.Size = New System.Drawing.Size(799, 25)
        Me.tspTools.TabIndex = 13
        '
        'tlbNew
        '
        Me.tlbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbNew.Image = CType(resources.GetObject("tlbNew.Image"), System.Drawing.Image)
        Me.tlbNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tlbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbNew.Name = "tlbNew"
        Me.tlbNew.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.tlbNew.Size = New System.Drawing.Size(32, 22)
        Me.tlbNew.Text = "Neu"
        Me.tlbNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlbOpen
        '
        Me.tlbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbOpen.Image = CType(resources.GetObject("tlbOpen.Image"), System.Drawing.Image)
        Me.tlbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbOpen.Name = "tlbOpen"
        Me.tlbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tlbOpen.Text = "Öffnen"
        '
        'tlbSave
        '
        Me.tlbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbSave.Image = CType(resources.GetObject("tlbSave.Image"), System.Drawing.Image)
        Me.tlbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSave.Name = "tlbSave"
        Me.tlbSave.Size = New System.Drawing.Size(23, 22)
        Me.tlbSave.Text = "Speichern"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlbCut
        '
        Me.tlbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbCut.Image = CType(resources.GetObject("tlbCut.Image"), System.Drawing.Image)
        Me.tlbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbCut.Name = "tlbCut"
        Me.tlbCut.Size = New System.Drawing.Size(23, 22)
        Me.tlbCut.Text = "Ausschneiden"
        '
        'tlbCopy
        '
        Me.tlbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbCopy.Image = CType(resources.GetObject("tlbCopy.Image"), System.Drawing.Image)
        Me.tlbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbCopy.Name = "tlbCopy"
        Me.tlbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tlbCopy.Text = "Kopieren"
        '
        'tlbPaste
        '
        Me.tlbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbPaste.Image = CType(resources.GetObject("tlbPaste.Image"), System.Drawing.Image)
        Me.tlbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbPaste.Name = "tlbPaste"
        Me.tlbPaste.Size = New System.Drawing.Size(23, 22)
        Me.tlbPaste.Text = "Einfügen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tlbSort
        '
        Me.tlbSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbSort.Image = CType(resources.GetObject("tlbSort.Image"), System.Drawing.Image)
        Me.tlbSort.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbSort.Name = "tlbSort"
        Me.tlbSort.Size = New System.Drawing.Size(23, 22)
        Me.tlbSort.Text = "Sortieren"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tlbHelp
        '
        Me.tlbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlbHelp.Image = CType(resources.GetObject("tlbHelp.Image"), System.Drawing.Image)
        Me.tlbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlbHelp.Name = "tlbHelp"
        Me.tlbHelp.Size = New System.Drawing.Size(23, 22)
        Me.tlbHelp.Text = "Über"
        '
        'pnlFix1
        '
        Me.pnlFix1.Location = New System.Drawing.Point(0, 47)
        Me.pnlFix1.Name = "pnlFix1"
        Me.pnlFix1.Size = New System.Drawing.Size(804, 5)
        Me.pnlFix1.TabIndex = 14
        '
        'pnlFix2
        '
        Me.pnlFix2.Location = New System.Drawing.Point(0, 20)
        Me.pnlFix2.Name = "pnlFix2"
        Me.pnlFix2.Size = New System.Drawing.Size(804, 5)
        Me.pnlFix2.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 742)
        Me.Controls.Add(Me.pnlFix2)
        Me.Controls.Add(Me.pnlFix1)
        Me.Controls.Add(Me.tspTools)
        Me.Controls.Add(Me.pnlInputsBottom)
        Me.Controls.Add(Me.pnlInputsTop)
        Me.Controls.Add(Me.pnlTexts)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sorting"
        Me.grpUnsorted.ResumeLayout(False)
        Me.grpUnsorted.PerformLayout()
        Me.grpSorted.ResumeLayout(False)
        Me.grpSorted.PerformLayout()
        Me.pnlTexts.ResumeLayout(False)
        Me.pnlInputsTop.ResumeLayout(False)
        Me.pnlInputsTop.PerformLayout()
        Me.pnlInputAlgorithm.ResumeLayout(False)
        Me.pnlInputAlgorithm.PerformLayout()
        Me.pnlInputsBottom.ResumeLayout(False)
        Me.pnlInputsBottom.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.tspTools.ResumeLayout(False)
        Me.tspTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUnsorted As System.Windows.Forms.TextBox
    Friend WithEvents grpUnsorted As System.Windows.Forms.GroupBox
    Friend WithEvents grpSorted As System.Windows.Forms.GroupBox
    Friend WithEvents txtSorted As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents cmbAlgorithm As System.Windows.Forms.ComboBox
    Friend WithEvents pnlTexts As System.Windows.Forms.Panel
    Friend WithEvents pnlInputsTop As System.Windows.Forms.Panel
    Friend WithEvents pnlInputsBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlInputAlgorithm As System.Windows.Forms.Panel
    Friend WithEvents lblAlgo As System.Windows.Forms.Label
    Friend WithEvents chkWords As System.Windows.Forms.CheckBox
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSortieren As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompareText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWorte As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkCompareText As System.Windows.Forms.CheckBox
    Friend WithEvents mnuAlgorithmus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBubblesort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuicksort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInsertionsort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRipplesort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgLoadText As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSaveText As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkUmlaute As System.Windows.Forms.CheckBox
    Friend WithEvents mnuToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUmlaute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblWordNum As System.Windows.Forms.Label
    Friend WithEvents txtWordNum As System.Windows.Forms.TextBox
    Friend WithEvents tspTools As System.Windows.Forms.ToolStrip
    Friend WithEvents tlbNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlbPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbSort As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlbHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlFix1 As System.Windows.Forms.Panel
    Friend WithEvents pnlFix2 As System.Windows.Forms.Panel

End Class
