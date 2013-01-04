Public Class StringSorting 'Rename??
    'Inherits ArrayList
    Private blnUseWords As Boolean '
    Private strings As String() ' The objects to be sorted
    Private blnAlive As Boolean = True ' This needs to be here, it doesn't work when saved in the form. Makes Functions abort when false
    Private alstList As ArrayList

    Public Sub kill()
        blnAlive = False
    End Sub

    Public Function Length() As Integer
        Return alstList.ToArray.Length
    End Function

    Public Sub New(ByVal strText As String, Optional ByVal blnWords As Boolean = False)
        Me.blnUseWords = blnWords
        alstList = New ArrayList
        If Me.blnUseWords Then
            Dim strLines As String() = strText.Split(vbCrLf)
            ' Split each line into words
            For i = 0 To strLines.Length - 1
                Dim strArray = strLines(i).Split(" ")
                ' Add all words to the list
                For j = 0 To strArray.Length - 1
                    alstList.Add(strArray(j))
                Next
            Next
        Else
            For i = 0 To strText.Length - 1 Step 1
                alstList.Add(CStr(strText(i)))
            Next
        End If
        ReDim Preserve strings(alstList.ToArray.Length - 1)
        alstList.ToArray.CopyTo(strings, 0)
    End Sub


    Public Overrides Function ToString() As String
        alstList.Clear()
        alstList.AddRange(strings)
        Dim strReturn As String = ""
        Dim e As IEnumerator
        e = alstList.GetEnumerator()
        While (e.MoveNext())
            Dim ojb As Object = e.Current
            strReturn &= CStr(ojb)
            If Me.blnUseWords Then
                strReturn &= " "
            End If
        End While
        Return strReturn
    End Function


    Public Sub Insertionsort()
        Dim intLength As Integer = strings.Length
        Dim intLeft As Integer = 0
        Do
            Dim intMax As Integer = intLeft
            For i = intLeft + 1 To intLength - 1
                If StrComp(maskUmlaute(strings(i)), maskUmlaute(strings(intMax)), frmMain.optionCompare()) = -1 Then
                    intMax = i
                End If
                If Not blnAlive Then ' Make it correctly quit when quitting :)
                    Exit Sub
                End If
            Next
            SwapValues(intMax, intLeft)
            intLeft += 1
        Loop While intLeft < intLength
        alstList.Clear()
        alstList.AddRange(strings)
    End Sub

    Public Sub BubbleSort()
        Dim length As Integer = strings.Length
        Dim swapped As Boolean = False
        Do
            swapped = False
            For i = 0 To length - 2
                If StrComp(maskUmlaute(strings(i)), maskUmlaute(strings(i + 1)), frmMain.optionCompare()) = 1 Then
                    SwapValues(i, i + 1)
                    swapped = True
                End If
                If Not blnAlive Then ' Make it correctly quit when quitting :)
                    Exit Sub
                End If
            Next
            length = length - 1
        Loop While swapped And length >= 1

    End Sub

    Public Sub RippleSort()
        Dim length As Integer = strings.Length
        Dim swapped As Boolean = False
        Do
            swapped = False
            For i = 0 To length - 2
                If StrComp(maskUmlaute(strings(i)), maskUmlaute(strings(i + 1)), frmMain.optionCompare()) = 1 Then
                    SwapValues(i, i + 1)
                    swapped = True
                End If
                If Not blnAlive Then ' Make it correctly quit when quitting :)
                    Exit Sub
                End If
            Next
        Loop While swapped

    End Sub


    Public Sub Quicksort(Optional ByVal intLeft As Integer = 0, Optional ByVal intRight As Integer = Int32.MaxValue)
        If intRight = Int32.MaxValue Then
            intRight = strings.Length - 1 'index of the right most element
        End If
        Dim i = intLeft
        Dim j = intRight
        Dim x As String = strings((intLeft + intRight) \ 2)

        For Each Str As String In strings
            Debug.Print("An Element: " & Str)
        Next
        Debug.Print("This is the pivot: " & x)
        While i <= j

            While StrComp(maskUmlaute(strings(i)), maskUmlaute(x), frmMain.optionCompare()) = -1
                i += 1
            End While
            Debug.Print("This is left element: " & strings(i))
            Debug.Print("This is the j-element: " & strings(j))
            While StrComp(maskUmlaute(x), maskUmlaute(strings(j)), frmMain.optionCompare()) = -1
                Debug.Print(strings(j))
                j -= 1
            End While
            Debug.Print("This is right element: " & strings(j))
            If i <= j Then
                SwapValues(i, j)
                i += 1
                j -= 1

                If Not blnAlive Then ' Make it correctly quit when quitting :)
                    Exit Sub
                End If
            End If
        End While

        If intLeft < j Then
            Quicksort(intLeft, j)
        End If
        If i < intRight Then
            Quicksort(i, intRight)
        End If

    End Sub


    Private Sub SwapValues(ByVal intFirst As Integer, ByVal intSecond As Integer)
        Application.DoEvents() ' Make the program responsive (in here because all sort-functions use this)
        Dim temp As String
        temp = strings(intFirst)
        strings(intFirst) = strings(intSecond)
        strings(intSecond) = temp
    End Sub


    Private Function maskUmlaute(ByVal strWord As String) As String
        If frmMain.maskUmlaute() Then
            For i As Integer = 1 To strWord.Length
                Select Case strWord(i - 1)
                    Case "ä"
                        Mid(strWord, i) = "a"
                    Case "à"
                        Mid(strWord, i) = "a"
                    Case "ö"
                        Mid(strWord, i) = "o"
                    Case "ü"
                        Mid(strWord, i) = "u"
                    Case "é"
                        Mid(strWord, i) = "e"
                    Case "è"
                        Mid(strWord, i) = "e"
                    Case "ç"
                        Mid(strWord, i) = "c"

                    Case "Ä"
                        Mid(strWord, i) = "A"
                    Case "À"
                        Mid(strWord, i) = "A"
                    Case "Ö"
                        Mid(strWord, i) = "O"
                    Case "Ü"
                        Mid(strWord, i) = "U"
                    Case "É"
                        Mid(strWord, i) = "E"
                    Case "è"
                        Mid(strWord, i) = "E"
                End Select
            Next
        End If
        Return strWord
    End Function

    Private Function optionCompare() As CompareMethod
        If frmMain.optionCompare() Then
            Return CompareMethod.Text
        Else
            Return CompareMethod.Binary
        End If
    End Function

End Class
