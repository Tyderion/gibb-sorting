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
        Dim strText = txtUnsorted.Text.ToCharArray()
        Select Case cmbAlgorithm.SelectedItem
            Case "Bubblesort"
                Dim startTime As DateTime = Now
                BubbleSort(strText)
                txtDuration.Text = Now.Subtract(startTime).ToString()
            Case "Insertionsort"
            Case "Quicksort"
        End Select
        Dim test As Integer = 1
        txtSorted.Text = CStr(strText)
    End Sub

    Private Sub txtUnsorted_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnsorted.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.A Then
            txtUnsorted.SelectAll()
        End If
    End Sub


    Private Sub BubbleSort(ByRef chrArray() As Char)
        Dim length As Integer = chrArray.Length
        Dim swapped As Boolean = False
        Do
            swapped = False
            For i = 1 To length - 2
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


    Private Sub SwapValuesInArray(Of T)(ByRef array() As T, ByVal left As Integer, ByVal right As Integer)
        Application.DoEvents() ' Make the program responsive (in here because all sort-functions use this)
        Dim temp As T
        temp = array(left)
        array(left) = array(right)
        array(right) = temp
    End Sub

End Class
