Imports R_Adapter2.R_Adapter.ScriptBuilder

Public Class BaseFunctionControl


    Protected _selected As New List(Of String)


    ''' <summary>
    ''' 'Just want to see where this can be viewed from
    ''' </summary>
    ''' <returns>Get something from R script</returns>
    Public Function GetDataBookScript() As String
        Return "Place Holder"
    End Function

    Public Function GetQuotedString() As String
        Return "Place Holder"
    End Function


    Public Function GetString() As String
        Return "Place Holder"
    End Function


    Public Function GetRFunction() As RFunction
        Return Nothing
    End Function
End Class
