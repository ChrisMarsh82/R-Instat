Public Class SingleElementControl
    Implements IControl

    Protected _selected As String

    Public Function GetParameterWithQuotes() As String Implements IControl.GetParameterWithQuotes
        Return """" + _selected + """"
    End Function

    Public Function GetParameter() As String Implements IControl.GetParameter
        Return _selected
    End Function
End Class
