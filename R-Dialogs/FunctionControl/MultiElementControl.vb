Public Class MultiElementControl
    Implements IControl

    Property _selected As List(Of String)
    Public Function GetParameterWithQuotes() As String Implements IControl.GetParameterWithQuotes
        'ToDo the command to create c(  ) should be more central
        If _selected.Count = 1 Then
            Return """" + _selected(0) + """"
        Else
            Dim strTemp As String
            strTemp = "c("
            For i = 0 To _selected.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                strTemp = strTemp & """" & _selected(i) & """" 'Chr(34)
            Next
            strTemp = strTemp & ")"
            Return strTemp
        End If
    End Function

    Public Function GetParameter() As String Implements IControl.GetParameter
        If _selected.Count = 1 Then
            Return _selected(0)
        Else
            Dim strTemp As String
            strTemp = "c("
            For i = 0 To _selected.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                strTemp = strTemp & _selected(i)
            Next
            strTemp = strTemp & ")"
            Return strTemp
        End If
    End Function
End Class
