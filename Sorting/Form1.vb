Public Class frmMain


    Public alive As Boolean = True

    Private udtList As StringList

    'Public Function alive() As Boolean
    '    Return mblnalive
    'End Function

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Console.Write(CStr(alive) & " and the function: " & alive())
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
            udtList = New StringList(txtUnsorted.Text, True)
        Else
            udtList = New StringList(txtUnsorted.Text)
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



End Class
