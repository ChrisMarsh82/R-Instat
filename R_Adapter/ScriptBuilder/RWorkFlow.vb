Imports R_Adapter2.R_Adapter.Enum

Namespace R_Adapter.ScriptBuilder

    Public Class RWorkFlow
        Private _preScript As RFunction = Nothing
        Private _script As RFunction
        Private _objectTypeLabel As RObjectTypeLabel
        Private _objectFormat As RObjectFormat
        Private _asFile As Boolean
        Private _runAddAndGetObjectScripts As Boolean = False


        Public Property PreScript() As RFunction 'May need to be a list
            Get
                Return _preScript
            End Get
            Set(ByVal value As RFunction)
                _preScript = value
            End Set
        End Property


        Public Property Script() As RFunction
            Get
                Return _script
            End Get
            Set(ByVal value As RFunction)
                _script = value
            End Set
        End Property

        Private Function GetDatabookAddObjectScript() As String
            Return "todo"
        End Function

        Private Function GetDatabookGetObjectScript() As String
            Return "todo"
        End Function

        Private Function IsCleanUpNeeded() As Boolean
            Return False
        End Function

        Private Function GetCleanUpScript() As String
            Return "todo"
        End Function

        Public Function GetAllScripts() As List(Of String)
            Dim scripts As New List(Of String)
            If PreScript IsNot Nothing Then
                scripts.Add(PreScript.ToScript)
            End If
            scripts.Add(Script.ToScript)
            If _runAddAndGetObjectScripts Then
                scripts.Add(GetDatabookAddObjectScript)
                scripts.Add(GetDatabookGetObjectScript)
            End If
            If IsCleanUpNeeded() Then
                scripts.Add(GetCleanUpScript)
            End If
            Return scripts
        End Function

        Public Sub SetDatabookObjectLog(objectTypeLabel As RObjectTypeLabel, objectFormat As RObjectFormat, asFile As Boolean)
            _objectTypeLabel = objectTypeLabel
            _objectFormat = objectFormat
            _asFile = asFile
            _runAddAndGetObjectScripts = True
        End Sub


    End Class



End Namespace

