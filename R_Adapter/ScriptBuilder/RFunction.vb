
Imports R_Adapter2.R_Adapter.Constant

Namespace R_Adapter.ScriptBuilder
    Public Class RFunction

        Private _assignment = ""
        Private _command = "command not assigned"
        Private _parameters = ""


        Public Function GetAssigned() As String
            Return _assignment
        End Function

        Public Sub AddParameter(param As String, value As String, Optional addQuotes As Boolean = False)
            If value <> "" Then
                If _parameters <> "" Then
                    _parameters &= ", "
                End If
                If addQuotes Then
                    value = """" & value & """"
                End If
                _parameters &= param & "=" & value
            End If
        End Sub

        Public Sub AddParameter(param As String, values As List(Of String), Optional addQuotes As Boolean = False)
            Dim stringValue As String = ""
            Dim first As Boolean = True
            If values.Count > 1 Then
                stringValue = "c("
                For Each value In values
                    If Not first Then
                        stringValue &= ", "
                    End If
                    If addQuotes Then
                        stringValue = stringValue & """" & value & """"
                    Else
                        stringValue &= value
                    End If
                    first = False
                Next
                stringValue &= ")"
            Else
                If addQuotes Then
                    stringValue = """" & values(0) & """"
                Else
                    stringValue = values(0)
                End If
            End If
            AddParameter(param, stringValue)
        End Sub

        Public Sub AddParameter(param As String, rFunction As RFunction)
            AddParameter(param, rFunction.ToScript())
        End Sub

        Public Sub AddParameter(param As String, value As Boolean)
            AddParameter(param, value.ToString)
        End Sub

        Public Sub AddParameter(param As String, value As Integer)
            AddParameter(param, value.ToString)
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
            _assignment = assign
        End Sub

        Public Sub AddParameterAsPlus()

        End Sub


        Public Function ToScript() As String
            If _assignment <> "" Then
                _assignment &= " <- "
            End If
            Return _assignment & _command & "(" & _parameters & ")"
        End Function
    End Class
End Namespace
