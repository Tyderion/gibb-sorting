Public Class StringSorting 
    Private blnUseWords As Boolean '
    Private strWords As String() ' The objects to be sorted
    Private blnAlive As Boolean = True ' This needs to be here, it doesn't work when saved in the form. Makes Functions abort when false
    Private alstList As ArrayList


    'Constructor
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
        ReDim Preserve strWords(alstList.ToArray.Length - 1)
        alstList.ToArray.CopyTo(strWords, 0)
    End Sub
	
	
	'Sorting Functions
	
    Public Sub Insertionsort()
        Dim intLength As Integer = strWords.Length
        Dim intLeft As Integer = 0
        Do
            Dim intMax As Integer = intLeft
            For i = intLeft + 1 To intLength - 1
                If StrComp(maskUmlaute(strWords(i)), maskUmlaute(strWords(intMax)), compareMethod()) = -1 Then
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
        alstList.AddRange(strWords)
    End Sub

    Public Sub BubbleSort()
        Dim length As Integer = strWords.Length
        Dim swapped As Boolean = False
        Do
            swapped = False
            For i = 0 To length - 2
                If StrComp(maskUmlaute(strWords(i)), maskUmlaute(strWords(i + 1)), compareMethod()) = 1 Then
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
        Dim length As Integer = strWords.Length
        Dim swapped As Boolean = False
        Do
            swapped = False
            For i = 0 To length - 2
                If StrComp(maskUmlaute(strWords(i)), maskUmlaute(strWords(i + 1)), compareMethod()) = 1 Then
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
            intRight = strWords.Length - 1 'index of the right most element
        End If
        Dim i = intLeft
        Dim j = intRight
        Dim x As String = strWords((intLeft + intRight) \ 2)
        While i <= j

            While StrComp(maskUmlaute(strWords(i)), maskUmlaute(x), compareMethod()) = -1
                i += 1
            End While
            While StrComp(maskUmlaute(x), maskUmlaute(strWords(j)), compareMethod()) = -1
                j -= 1
            End While
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

    'Utility Functions

    Private Sub SwapValues(ByVal intFirst As Integer, ByVal intSecond As Integer)
        Application.DoEvents() ' Make the program responsive (in here because all sort-functions use this)
        Dim temp As String
        temp = strWords(intFirst)
        strWords(intFirst) = strWords(intSecond)
        strWords(intSecond) = temp
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
                    Case "È"
                        Mid(strWord, i) = "E"
                End Select
            Next
        End If
        Return strWord
    End Function



    Public Overrides Function ToString() As String
        alstList.Clear()
        alstList.AddRange(strWords)
        Dim strReturn As String = ""
        Dim e As IEnumerator
        e = alstList.GetEnumerator()
        While (e.MoveNext())
            Dim objWord As Object = e.Current
            strReturn &= CStr(objWord)
            If Me.blnUseWords Then
                strReturn &= " "
            End If
        End While
        Return strReturn
    End Function


    Private Function compareMethod() As CompareMethod
        If frmMain.textCompare() Then
            Return CompareMethod.Text
        Else
            Return CompareMethod.Binary
        End If
    End Function
	
	    Public Sub kill()
        blnAlive = False
    End Sub

    Public Function Length() As Integer
        Return alstList.ToArray.Length
    End Function

End Class
