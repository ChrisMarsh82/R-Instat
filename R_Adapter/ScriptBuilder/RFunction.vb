
Imports R_Adapter2.R_Adapter.Constant

Namespace R_Adapter.ScriptBuilder
    Public Class RFunction

        Private _assignment = ""
        Private _command = "command not assigned"
        Private _parameters = ""

        Public Sub AddParameter(param As String, value As String)
            If _parameters <> "" Then
                _parameters = _parameters & ", "
            End If
            _parameters = _parameters & param & "=" & value
        End Sub

        Public Sub AddParameter(param As String, rFunction As RFunction)
            If _parameters <> "" Then
                _parameters = _parameters & ", "
            End If
            _parameters = _parameters & param & "=" & rFunction.ToScript()
        End Sub

        Public Sub SetBasicRCommand(command As String)
            _command = command
        End Sub

        Public Sub SetPackageRCommand(package As String, command As String)
            _command = package & "::" & command
        End Sub

        Public Sub SetDataBookCommand(command As String)
            _command = RCodeConstant.DataBookName & "$" & command
        End Sub

        Public Sub SetAssignTo(assign As String)
            _assignment = assign & " <- "
        End Sub

        Public Sub AddParameterAsPlus()

        End Sub

        Public Sub AddParameterAsPreScript()

        End Sub

        Public Function ToScript() As String
            Return _assignment & _command & "(" & _parameters & ")"
        End Function
    End Class
End Namespace
