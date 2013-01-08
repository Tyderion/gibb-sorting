
Public Class frmMain


    Public alive As Boolean = True

    Private blnSortWords As Boolean = False
    Private blnCompareText As Boolean = False
    Private blnUmlaute As Boolean = False


    Private udtList As StringSorting = New StringSorting("")

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        udtList.kill()
        Me.Close()
    End Sub


    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If cmbAlgorithm.SelectedItem = "" Then
            MsgBox("Please select an algorithm")
        Else
            sort()
        End If
    End Sub


    Private Sub sort()
        txtSorted.Text = ""
        Me.Cursor = Cursors.WaitCursor
        Dim strText = txtUnsorted.Text.ToCharArray()
        'Dim udtList As StringList
        If chkWords.CheckState = 1 Then
            udtList = New StringSorting(txtUnsorted.Text, True)
        Else
            udtList = New StringSorting(txtUnsorted.Text)
        End If
        Dim startTime As DateTime = Now
        Select Case cmbAlgorithm.SelectedItem
            Case "Bubblesort"
                udtList.BubbleSort()
            Case "Insertionsort"
                udtList.Insertionsort()
            Case "Quicksort"
                udtList.Quicksort()
            Case "Ripplesort"
                udtList.RippleSort()
        End Select
        txtDuration.Text = Now.Subtract(startTime).ToString()
        txtWordNum.Text = udtList.Length()
        txtSorted.Text = udtList.ToString()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txtUnsorted_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnsorted.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.A Then
            txtUnsorted.SelectAll()
        End If
    End Sub


    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        btnQuit_Click(sender, e)
    End Sub

    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuNew.Click, tlbNew.Click
        udtList.kill()
        txtSorted.Text = ""
        txtUnsorted.Text = ""
    End Sub

    Private Sub WorteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuWorte.Click, chkWords.Click
        blnSortWords = Not blnSortWords
        mnuWorte.Checked = blnSortWords
        chkWords.Checked = blnSortWords
    End Sub



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnuSortieren.ShortcutKeys = Keys.Control Or Keys.Enter
        chkWords.Checked = blnSortWords
        mnuWorte.Checked = blnSortWords
        chkCompareText.Checked = blnCompareText

    End Sub



    Public Function optionCompare() As Boolean
        Return blnCompareText
    End Function


    Public Function maskUmlaute() As Boolean
        Return blnUmlaute
    End Function

    Private Sub chkUmlaute_Click(sender As Object, e As EventArgs) Handles chkCompareText.Click, mnuCompareText.Click
        blnCompareText = Not blnCompareText
        mnuCompareText.Checked = blnCompareText
        chkCompareText.Checked = blnCompareText
    End Sub

    Private Sub mnuUmlaute_Click(sender As Object, e As EventArgs) Handles mnuUmlaute.Click, chkUmlaute.Click
        blnUmlaute = Not blnUmlaute
        mnuUmlaute.Checked = blnUmlaute
        chkUmlaute.Checked = blnUmlaute
    End Sub

    Private Sub setAlgorithm(ByVal strAlgo As String)
        cmbAlgorithm.SelectedItem = strAlgo
        For Each s As ToolStripMenuItem In mnuAlgorithmus.DropDownItems
            s.Checked = False
            'Remove the preceding & from the Text
            If s.Text.Substring(1) = strAlgo Then
                s.Checked = True
            End If
        Next
    End Sub

    Private Sub cmbAlgorithm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlgorithm.SelectedIndexChanged
        setAlgorithm(cmbAlgorithm.SelectedItem)
    End Sub

    Private Sub Menu_Algorithm_Click(sender As Object, e As EventArgs) Handles mnuBubblesort.Click, mnuAlgorithmus.Click, mnuInsertionsort.Click, mnuQuicksort.Click, mnuRipplesort.Click
        Dim item As ToolStripMenuItem = sender
        setAlgorithm(item.Text.Substring(1))
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click, tlbOpen.Click
        dlgLoadText.DefaultExt = ".txt"
        dlgLoadText.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        dlgLoadText.ShowDialog()

    End Sub

    Private Sub ofdLoadText_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgLoadText.FileOk
        Try
            Using sr As New IO.StreamReader(dlgLoadText.FileName)
                txtUnsorted.Text = sr.ReadToEnd()
            End Using
        Catch
            txtUnsorted.Text = "Could not read the file"
        End Try


    End Sub

    Private Sub mnuSortieren_Click(sender As Object, e As EventArgs) Handles mnuSortieren.Click, tlbSort.Click
        btnSort_Click(sender, e)
    End Sub


    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click, tlbCopy.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            'Clipboard.SetDataObject(CType(Me.ActiveControl, TextBox).SelectedText)
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub
    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click, tlbCut.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            'Clipboard.SetDataObject(CType(Me.ActiveControl, TextBox).SelectedText)
            'CType(Me.ActiveControl, TextBox).Clear()
            CType(Me.ActiveControl, TextBox).Cut()
        End If
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click, tlbPaste.Click
        If TypeOf Me.ActiveControl Is TextBox And Not CType(Me.ActiveControl, TextBox).ReadOnly Then
            CType(Me.ActiveControl, TextBox).Paste()
            'CType(Me.ActiveControl, TextBox).SelectedText = Clipboard.GetDataObject.GetData(DataFormats.Text)
        End If

    End Sub



    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click, tlbSave.Click
        Dim myStream As IO.Stream
        dlgSaveText.DefaultExt = ".txt"
        dlgSaveText.AddExtension = True
        dlgSaveText.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        dlgSaveText.FilterIndex = 2
        dlgSaveText.RestoreDirectory = True

        If dlgSaveText.ShowDialog() = DialogResult.OK Then
            myStream = dlgSaveText.OpenFile()
            If (myStream IsNot Nothing) Then
                Using writer As IO.StreamWriter = New IO.StreamWriter(myStream, System.Text.Encoding.Unicode)
                    If TypeOf Me.ActiveControl Is TextBox Then
                        writer.WriteLine(CType(Me.ActiveControl, TextBox).Text)
                    End If
                End Using
                myStream.Close()
            End If
        End If
    End Sub

    Private Sub show_hide_Items_Handler(sender As Object, e As EventArgs) Handles mnuEdit.DropDownOpening, txtUnsorted.Click, txtSorted.Click,
        chkWords.Click, chkCompareText.Click, chkUmlaute.Click, btnSort.Click
        If TypeOf Me.ActiveControl Is TextBox Then
            mnuCut.Enabled = True
            mnuCopy.Enabled = True
            tlbCopy.Enabled = True
            tlbCut.Enabled = True
        Else
            mnuCut.Enabled = False
            mnuCopy.Enabled = False
            tlbCopy.Enabled = False
            tlbCut.Enabled = False
        End If
        If Clipboard.GetDataObject.GetData(DataFormats.Text) <> "" And TypeOf Me.ActiveControl Is TextBox Then
            If CType(Me.ActiveControl, TextBox).ReadOnly Then
                mnuPaste.Enabled = False
                tlbPaste.Enabled = False
            Else
                mnuPaste.Enabled = True
                tlbPaste.Enabled = True
            End If
        Else
            mnuPaste.Enabled = False
            tlbPaste.Enabled = False
        End If
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click, tlbHelp.Click
        AboutBox1.Show()
    End Sub

End Class
