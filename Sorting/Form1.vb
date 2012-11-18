Public Class frmMain


    Private alive As Boolean = True

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        alive = False
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
        Dim startTime As DateTime = Now
        Select Case cmbAlgorithm.SelectedItem
            Case "Bubblesort"
                BubbleSort(strText)
            Case "Insertionsort"
                Insertionsort(strText)
            Case "Quicksort"
                Quicksort(strText)
        End Select
        txtDuration.Text = Now.Subtract(startTime).ToString()
        txtSorted.Text = CStr(strText)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txtUnsorted_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnsorted.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.A Then
            txtUnsorted.SelectAll()
        End If
    End Sub

    Private Sub Insertionsort(ByRef chrArray() As Char)
        Dim intLength As Integer = chrArray.Length
        Dim intLeft As Integer = 0
        Do
            Dim intMax As Integer = intLeft
            For i = intLeft + 1 To intLength - 1
                If chrArray(i) < chrArray(intMax) Then
                    intMax = i
                End If
                If Not alive Then ' Make it correctly quit when quitting :)
                    Exit Sub
                End If
            Next
            SwapValuesInArray(Of Char)(chrArray, intMax, intLeft)
            intLeft += 1
        Loop While intLeft < intLength
    End Sub

    Private Sub BubbleSort(ByRef chrArray() As Char)
        Dim length As Integer = chrArray.Length
        Dim swapped As Boolean = False
        Do
            swapped = False
            For i = 0 To length - 2
                If chrArray(i) > chrArray(i + 1) Then
                    SwapValuesInArray(Of Char)(chrArray, i, i + 1)
                    swapped = True
                End If
                If Not alive Then ' Make it correctly quit when quitting :)
                    Exit Sub
                End If
            Next
            length = length - 1
            If length Mod 10 = 0 Then
                txtSorted.Text = CStr(chrArray)
            End If
        Loop While swapped And length >= 1
    End Sub




    Private Sub Quicksort(ByRef chrArray() As Char, Optional ByVal intLeft As Integer = 0, Optional ByVal intRight As Integer = Int32.MinValue)
        If intRight = Int32.MinValue Then
            intRight = chrArray.Length - 1 'index of the right most element
        End If
        If intRight - intLeft <= 0 Then
            Exit Sub
        End If
        Dim pivot As Integer = intLeft + (intRight - intLeft) / 2 ' Taking middle value, not the best pivot-selection, this works for big ints at least (not like (left+right)/2)
        Dim newPivot As Integer = partitionArray(chrArray, intLeft, intRight, pivot)
        Quicksort(chrArray, newPivot + 1, intRight)
        Quicksort(chrArray, intLeft, newPivot - 1)

    End Sub


    Private Function partitionArray(ByRef chrArray() As Char, ByVal intLeft As Integer, ByVal intRight As Integer, ByVal intPivot As Integer)
        Dim chrPivot As Char = chrArray(intPivot)
        SwapValuesInArray(Of Char)(chrArray, intPivot, intRight)
        Dim intStoreIndex As Integer = intLeft
        For i = intLeft To intRight - 1
            If chrArray(i) < chrPivot Then
                SwapValuesInArray(Of Char)(chrArray, i, intStoreIndex)
                intStoreIndex += 1
            End If
            If Not alive Then ' Make it correctly quit when quitting :)
                Return Nothing
            End If
        Next
        SwapValuesInArray(Of Char)(chrArray, intStoreIndex, intRight)
        Return intStoreIndex

    End Function

    Private Sub SwapValuesInArray(Of T)(ByRef array() As T, ByVal intFirst As Integer, ByVal intSecond As Integer)
        Application.DoEvents() ' Make the program responsive (in here because all sort-functions use this)
        Dim temp As T
        temp = array(intFirst)
        array(intFirst) = array(intSecond)
        array(intSecond) = temp
    End Sub

End Class
