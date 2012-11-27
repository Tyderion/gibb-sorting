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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAlgo = New System.Windows.Forms.Label()
        Me.pnlInputsBottom = New System.Windows.Forms.Panel()
        Me.chkWords = New System.Windows.Forms.CheckBox()
        Me.grpUnsorted.SuspendLayout()
        Me.grpSorted.SuspendLayout()
        Me.pnlTexts.SuspendLayout()
        Me.pnlInputsTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlInputsBottom.SuspendLayout()
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
        Me.pnlTexts.Location = New System.Drawing.Point(12, 48)
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
        Me.pnlInputsTop.Controls.Add(Me.chkWords)
        Me.pnlInputsTop.Controls.Add(Me.Panel2)
        Me.pnlInputsTop.Controls.Add(Me.btnSort)
        Me.pnlInputsTop.Location = New System.Drawing.Point(12, 12)
        Me.pnlInputsTop.Name = "pnlInputsTop"
        Me.pnlInputsTop.Size = New System.Drawing.Size(770, 30)
        Me.pnlInputsTop.TabIndex = 10
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 824)
        Me.Controls.Add(Me.pnlInputsBottom)
        Me.Controls.Add(Me.pnlInputsTop)
        Me.Controls.Add(Me.pnlTexts)
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
        Me.ResumeLayout(False)

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

End Class
