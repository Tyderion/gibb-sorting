
Public Class frmMain


    Public alive As Boolean = True

    Private blnSortWords As Boolean = False
    Private blnCompareText As Boolean = False
    Private blnUmlaute As Boolean = False


    Private udtList As StringSorting = New StringSorting("")

    'Public Function alive() As Boolean
    '    Return mblnalive
    'End Function

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

    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        udtList.kill()
        txtSorted.Text = ""
        txtUnsorted.Text = ""
    End Sub

    Private Sub WorteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuWorte.Click
        swapWordsCheckboxes()
    End Sub

    Private Sub swapWordsCheckboxes()
        blnSortWords = Not blnSortWords
        mnuWorte.Checked = blnSortWords
        chkWords.Checked = blnSortWords
    End Sub

    Private Sub chkWords_Click(sender As Object, e As EventArgs) Handles chkWords.Click
        swapWordsCheckboxes()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SortierenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Enter
        chkWords.Checked = blnSortWords
        mnuWorte.Checked = blnSortWords
        chkCompareText.Checked = blnCompareText

    End Sub



    Public Function optionCompare() As CompareMethod
        If blnCompareText Then
            Return CompareMethod.Text
        Else
            Return CompareMethod.Binary
        End If
    End Function


    Public Function maskUmlaute() As Boolean
        Return blnUmlaute
    End Function
    Private Sub swapCompareTextDisplay()
        blnCompareText = Not blnCompareText
        mnuCompareText.Checked = blnCompareText
        chkCompareText.Checked = blnCompareText
    End Sub
    Private Sub swapUmlautDisplay()
        blnUmlaute = Not blnUmlaute
        mnuUmlaute.Checked = blnUmlaute
        chkUmlaute.Checked = blnUmlaute
    End Sub

    Private Sub chkUmlaute_Click(sender As Object, e As EventArgs) Handles chkCompareText.Click, mnuCompareText.Click
        swapCompareTextDisplay()
    End Sub

    Private Sub mnuUmlaute_Click(sender As Object, e As EventArgs) Handles mnuUmlaute.Click, chkUmlaute.Click
        swapUmlautDisplay()
    End Sub

    Private Sub setAlgorithm(ByVal strAlgo As String)
        cmbAlgorithm.SelectedItem = strAlgo
        For Each s As ToolStripMenuItem In mnuAlgorithmus.DropDownItems
            s.Checked = False
        Next
        Select Case strAlgo
            Case "Bubblesort"
                mnuBubblesort.Checked = True
            Case "Ripplesort"
                mnuRipplesort.Checked = True
            Case "Quicksort"
                mnuQuicksort.Checked = True
            Case "Insertionsort"
                mnuInsertionsort.Checked = True
            Case "Mergesort"
                mnuMergesort.Checked = True
        End Select
    End Sub

    Private Sub cmbAlgorithm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlgorithm.SelectedIndexChanged
        setAlgorithm(cmbAlgorithm.SelectedItem)
    End Sub

    Private Sub Menu_Algorithm_Click(sender As Object, e As EventArgs) Handles mnuBubblesort.Click, mnuAlgorithmus.Click, mnuInsertionsort.Click, mnuQuicksort.Click, mnuRipplesort.Click, mnuMergesort.Click
        Dim item As ToolStripMenuItem = sender
        setAlgorithm(item.Text)

    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        ofdLoadText.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdLoadText.FileOk
        Try
            Using sr As New IO.StreamReader(ofdLoadText.FileName)
                txtUnsorted.Text = sr.ReadToEnd()
            End Using
        Catch
            txtUnsorted.Text = "Could not read the file"
        End Try


    End Sub

    Private Sub SortierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortierenToolStripMenuItem.Click
        btnSort_Click(sender, e)
    End Sub


End Class
