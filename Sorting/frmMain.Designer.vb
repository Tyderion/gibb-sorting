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
        Me.txtUnsorted = New System.Windows.Forms.TextBox()
        Me.grpUnsorted = New System.Windows.Forms.GroupBox()
        Me.grpSorted = New System.Windows.Forms.GroupBox()
        Me.txtSorted = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.cmbAlgorithm = New System.Windows.Forms.ComboBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.pnlTexts = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlInputsTop = New System.Windows.Forms.Panel()
        Me.chkUmlaute = New System.Windows.Forms.CheckBox()
        Me.chkWords = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAlgo = New System.Windows.Forms.Label()
        Me.pnlInputsBottom = New System.Windows.Forms.Panel()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SortierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UmlauteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlgorithmusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BubblesortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertionsortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuicksortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RipplesortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MergesortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpUnsorted.SuspendLayout()
        Me.grpSorted.SuspendLayout()
        Me.pnlTexts.SuspendLayout()
        Me.pnlInputsTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlInputsBottom.SuspendLayout()
        Me.mnuMain.SuspendLayout()
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
        Me.grpUnsorted.Text = "Unsorted"
        '
        'grpSorted
        '
        Me.grpSorted.Controls.Add(Me.txtSorted)
        Me.grpSorted.Location = New System.Drawing.Point(3, 335)
        Me.grpSorted.Name = "grpSorted"
        Me.grpSorted.Size = New System.Drawing.Size(757, 292)
        Me.grpSorted.TabIndex = 2
        Me.grpSorted.TabStop = False
        Me.grpSorted.Text = "Sorted"
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
        Me.btnSort.Location = New System.Drawing.Point(214, 3)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(103, 23)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(301, 8)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(47, 13)
        Me.lblDuration.TabIndex = 4
        Me.lblDuration.Text = "Duration"
        '
        'txtDuration
        '
        Me.txtDuration.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDuration.Enabled = False
        Me.txtDuration.Location = New System.Drawing.Point(354, 5)
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
        Me.cmbAlgorithm.Items.AddRange(New Object() {"Bubblesort", "Insertionsort", "Quicksort", "Ripplesort", "Mergesort"})
        Me.cmbAlgorithm.Location = New System.Drawing.Point(62, 3)
        Me.cmbAlgorithm.Name = "cmbAlgorithm"
        Me.cmbAlgorithm.Size = New System.Drawing.Size(140, 21)
        Me.cmbAlgorithm.TabIndex = 7
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(3, 3)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(162, 23)
        Me.btnCopy.TabIndex = 8
        Me.btnCopy.Text = "Copy Sorted Text to Clipboard"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'pnlTexts
        '
        Me.pnlTexts.Controls.Add(Me.Panel1)
        Me.pnlTexts.Controls.Add(Me.grpUnsorted)
        Me.pnlTexts.Controls.Add(Me.grpSorted)
        Me.pnlTexts.Location = New System.Drawing.Point(12, 75)
        Me.pnlTexts.Name = "pnlTexts"
        Me.pnlTexts.Size = New System.Drawing.Size(770, 633)
        Me.pnlTexts.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 28)
        Me.Panel1.TabIndex = 12
        '
        'pnlInputsTop
        '
        Me.pnlInputsTop.Controls.Add(Me.chkUmlaute)
        Me.pnlInputsTop.Controls.Add(Me.chkWords)
        Me.pnlInputsTop.Controls.Add(Me.Panel2)
        Me.pnlInputsTop.Controls.Add(Me.btnSort)
        Me.pnlInputsTop.Location = New System.Drawing.Point(12, 35)
        Me.pnlInputsTop.Name = "pnlInputsTop"
        Me.pnlInputsTop.Size = New System.Drawing.Size(770, 30)
        Me.pnlInputsTop.TabIndex = 10
        '
        'chkUmlaute
        '
        Me.chkUmlaute.AutoSize = True
        Me.chkUmlaute.Location = New System.Drawing.Point(405, 7)
        Me.chkUmlaute.Name = "chkUmlaute"
        Me.chkUmlaute.Size = New System.Drawing.Size(65, 17)
        Me.chkUmlaute.TabIndex = 14
        Me.chkUmlaute.Text = "Umlaute"
        Me.chkUmlaute.UseVisualStyleBackColor = True
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblAlgo)
        Me.Panel2.Controls.Add(Me.cmbAlgorithm)
        Me.Panel2.Location = New System.Drawing.Point(3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 27)
        Me.Panel2.TabIndex = 12
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
        Me.pnlInputsBottom.Controls.Add(Me.btnCopy)
        Me.pnlInputsBottom.Controls.Add(Me.btnQuit)
        Me.pnlInputsBottom.Controls.Add(Me.lblDuration)
        Me.pnlInputsBottom.Controls.Add(Me.txtDuration)
        Me.pnlInputsBottom.Location = New System.Drawing.Point(12, 687)
        Me.pnlInputsBottom.Name = "pnlInputsBottom"
        Me.pnlInputsBottom.Size = New System.Drawing.Size(770, 28)
        Me.pnlInputsBottom.TabIndex = 11
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.OptionenToolStripMenuItem, Me.InfosToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1310, 24)
        Me.mnuMain.TabIndex = 12
        Me.mnuMain.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.ToolStripSeparator1, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(123, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.ToolStripSeparator2, Me.SortierenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AusschneidenToolStripMenuItem.Text = "Ausschneiden"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.KopierenToolStripMenuItem.Text = "Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EinfügenToolStripMenuItem.Text = "Einfügen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(145, 6)
        '
        'SortierenToolStripMenuItem
        '
        Me.SortierenToolStripMenuItem.Name = "SortierenToolStripMenuItem"
        Me.SortierenToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SortierenToolStripMenuItem.Text = "Sortieren"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UmlauteToolStripMenuItem, Me.WorteToolStripMenuItem, Me.AlgorithmusToolStripMenuItem})
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OptionenToolStripMenuItem.Text = "Optionen"
        '
        'UmlauteToolStripMenuItem
        '
        Me.UmlauteToolStripMenuItem.Name = "UmlauteToolStripMenuItem"
        Me.UmlauteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UmlauteToolStripMenuItem.Text = "Umlaute"
        '
        'WorteToolStripMenuItem
        '
        Me.WorteToolStripMenuItem.Name = "WorteToolStripMenuItem"
        Me.WorteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WorteToolStripMenuItem.Text = "Worte"
        '
        'AlgorithmusToolStripMenuItem
        '
        Me.AlgorithmusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BubblesortToolStripMenuItem, Me.InsertionsortToolStripMenuItem, Me.QuicksortToolStripMenuItem, Me.RipplesortToolStripMenuItem, Me.MergesortToolStripMenuItem})
        Me.AlgorithmusToolStripMenuItem.Name = "AlgorithmusToolStripMenuItem"
        Me.AlgorithmusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlgorithmusToolStripMenuItem.Text = "Algorithmus"
        '
        'BubblesortToolStripMenuItem
        '
        Me.BubblesortToolStripMenuItem.Name = "BubblesortToolStripMenuItem"
        Me.BubblesortToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BubblesortToolStripMenuItem.Text = "Bubblesort"
        '
        'InsertionsortToolStripMenuItem
        '
        Me.InsertionsortToolStripMenuItem.Name = "InsertionsortToolStripMenuItem"
        Me.InsertionsortToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InsertionsortToolStripMenuItem.Text = "Insertionsort"
        '
        'QuicksortToolStripMenuItem
        '
        Me.QuicksortToolStripMenuItem.Name = "QuicksortToolStripMenuItem"
        Me.QuicksortToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuicksortToolStripMenuItem.Text = "Quicksort"
        '
        'RipplesortToolStripMenuItem
        '
        Me.RipplesortToolStripMenuItem.Name = "RipplesortToolStripMenuItem"
        Me.RipplesortToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RipplesortToolStripMenuItem.Text = "Ripplesort"
        '
        'MergesortToolStripMenuItem
        '
        Me.MergesortToolStripMenuItem.Name = "MergesortToolStripMenuItem"
        Me.MergesortToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MergesortToolStripMenuItem.Text = "Mergesort"
        '
        'InfosToolStripMenuItem
        '
        Me.InfosToolStripMenuItem.Name = "InfosToolStripMenuItem"
        Me.InfosToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.InfosToolStripMenuItem.Text = "Infos"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 824)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlInputsBottom.ResumeLayout(False)
        Me.pnlInputsBottom.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
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
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents pnlTexts As System.Windows.Forms.Panel
    Friend WithEvents pnlInputsTop As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlInputsBottom As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblAlgo As System.Windows.Forms.Label
    Friend WithEvents chkWords As System.Windows.Forms.CheckBox
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SortierenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UmlauteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkUmlaute As System.Windows.Forms.CheckBox
    Friend WithEvents AlgorithmusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BubblesortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuicksortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertionsortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MergesortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RipplesortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
