Public Class ListWithSorting 'Rename??
    Inherits ArrayList
    Private blnUseWords As Boolean '
    Private objects() As Object ' The objects to be sorted
    Private blnAlive As Boolean = True ' This needs to be here, it doesn't work when saved in the form. Makes Functions abort when false

    Public Sub kill()
        blnAlive = False
    End Sub

    Public Sub New(ByVal strText As String, Optional ByVal blnWords As Boolean = False)
        Me.blnUseWords = blnWords
        If Me.blnUseWords Then
            Dim strLines As String() = strText.Split(vbCrLf)
            ' Split each line into words
            For i = 0 To strLines.Length - 1
                Dim strArray = strLines(i).Split(" ")
                ' Add all words to the list
                For j = 0 To strArray.Length - 1
                    Me.Add(strArray(j))
                Next
            Next
        Else
            For i = 0 To strText.Length - 1 Step 1
                Me.Add(strText(i))
            Next
        End If
        objects = Me.ToArray

    End Sub
    Public Overrides Function ToString() As String
        Me.Clear()
        Me.AddRange(objects)
        Dim strReturn As String = ""
        Dim e As IEnumerator
        e = Me.GetEnumerator()
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
        Dim intLength As Integer = objects.Length
        Dim intLeft As Integer = 0
        Do
            Dim intMax As Integer = intLeft
            For i = intLeft + 1 To intLength - 1
                If StrComp(objects(i), objects(intMax), frmMain.optionCompare()) = -1 Then
                    intMax = i
                End If
                If Not blnAlive Then ' Make it correctly quit when quitting :)
                    Exit Sub
                End If
            Next
            SwapValues(Of Object)(intMax, intLeft)
            intLeft += 1
        Loop While intLeft < intLength
        Me.Clear()
        Me.AddRange(objects)
    End Sub

    Public Sub BubbleSort()
        Dim length As Integer = objects.Length
        Dim swapped As Boolean = False
        Do
            swapped = False
            For i = 0 To length - 2
                If StrComp(objects(i), objects(i + 1), frmMain.optionCompare()) = 1 Then
                    SwapValues(Of Object)(i, i + 1)
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
        Dim length As Integer = objects.Length
        Dim swapped As Boolean = False
        Do
            swapped = False
            For i = 0 To length - 2
                If StrComp(objects(i), objects(i + 1), frmMain.optionCompare()) = 1 Then
                    SwapValues(Of Object)(i, i + 1)
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
            intRight = objects.Length - 1 'index of the right most element
        End If
        Dim i = intLeft
        Dim j = intRight
        Dim x As Object = objects((intLeft + intRight) \ 2)
        While i <= j
            While StrComp(objects(i), x, frmMain.optionCompare()) = -1
                i += 1
            End While
            While StrComp(x, objects(j), frmMain.optionCompare()) = -1
                j -= 1
            End While
            If i <= j Then
                SwapValues(Of Object)(i, j)
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


    Private Sub SwapValues(Of T)(ByVal intFirst As Integer, ByVal intSecond As Integer)
        Application.DoEvents() ' Make the program responsive (in here because all sort-functions use this)
        Dim temp As T
        temp = objects(intFirst)
        objects(intFirst) = objects(intSecond)
        objects(intSecond) = temp
    End Sub


End Class
