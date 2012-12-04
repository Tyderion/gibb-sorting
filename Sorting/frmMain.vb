Public Class frmMain


    Public alive As Boolean = True

    Private blnSortWords As Boolean = False
    Private blnSpecialUmlaute As Boolean = False

    Private udtList As ListWithSorting = New ListWithSorting("")

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
            udtList = New ListWithSorting(txtUnsorted.Text, True)
        Else
            udtList = New ListWithSorting(txtUnsorted.Text)
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


    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        btnQuit_Click(sender, e)
    End Sub

    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click
        udtList.kill()
        txtSorted.Text = ""
        txtUnsorted.Text = ""
    End Sub

    Private Sub WorteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorteToolStripMenuItem.Click
        swapWordsCheckboxes()
    End Sub

    Private Sub swapWordsCheckboxes()
        blnSortWords = Not blnSortWords
        WorteToolStripMenuItem.Checked = blnSortWords
        chkWords.Checked = blnSortWords
    End Sub

    Private Sub chkWords_Click(sender As Object, e As EventArgs) Handles chkWords.Click
        swapWordsCheckboxes()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkWords.Checked = blnSortWords
        WorteToolStripMenuItem.Checked = blnSortWords
        chkUmlaute.Checked = blnSpecialUmlaute

    End Sub



    Public Function optionCompare() As CompareMethod
        If blnSpecialUmlaute Then
            Return CompareMethod.Text
        Else
            Return CompareMethod.Binary
        End If
    End Function
    Private Sub swapUmlautDisplay()
        blnSpecialUmlaute = Not blnSpecialUmlaute
        UmlauteToolStripMenuItem.Checked = blnSpecialUmlaute
        chkUmlaute.Checked = blnSpecialUmlaute

    End Sub

    Private Sub UmlauteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UmlauteToolStripMenuItem.Click
        swapUmlautDisplay()
    End Sub
    Private Sub chkUmlaute_Click(sender As Object, e As EventArgs) Handles chkUmlaute.Click
        swapUmlautDisplay()
    End Sub

    Private Sub setAlgorithm(ByVal strAlgo As String)
        cmbAlgorithm.SelectedItem = strAlgo
        BubblesortToolStripMenuItem.Checked = False
        RipplesortToolStripMenuItem.Checked = False
        QuicksortToolStripMenuItem.Checked = False
        InsertionsortToolStripMenuItem.Checked = False
        MergesortToolStripMenuItem.Checked = False
        Select Case strAlgo
            Case "Bubblesort"
                BubblesortToolStripMenuItem.Checked = True
            Case "Ripplesort"
                RipplesortToolStripMenuItem.Checked = True
            Case "Quicksort"
                QuicksortToolStripMenuItem.Checked = True
            Case "Insertionsort"
                InsertionsortToolStripMenuItem.Checked = True
            Case "Mergesort"
                MergesortToolStripMenuItem.Checked = True
        End Select
    End Sub

    Private Sub cmbAlgorithm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlgorithm.SelectedIndexChanged
        setAlgorithm(cmbAlgorithm.SelectedItem)
    End Sub

    Private Sub Menu_Algorithm_Click(sender As Object, e As EventArgs) Handles BubblesortToolStripMenuItem.Click
        For Each s As ToolStripMenuItem In AlgorithmusToolStripMenuItem.DropDownItems
            s.Checked = True
        Next
    End Sub

    Private Sub AlgorithmusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlgorithmusToolStripMenuItem.Click

    End Sub
End Class
