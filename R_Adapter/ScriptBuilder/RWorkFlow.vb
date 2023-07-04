Imports R_Adapter2.R_Adapter.Enum

Namespace R_Adapter.ScriptBuilder

    Public Class RWorkFlow
        Private _preScript As RFunction = Nothing
        Private _script As RFunction
        Private _objectTypeLabel As String 'RObjectTypeLabel
        Private _objectFormat As String 'RObjectFormat
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
            Dim rFunction As New RFunction
            rFunction.SetDataBookCommand("add_object")
            rFunction.AddParameter("data_name", """airquality""")
            rFunction.AddParameter("object_name", """last_summary""")
            rFunction.AddParameter("object_type_label", _objectTypeLabel)
            rFunction.AddParameter("object_format", _objectFormat)
            rFunction.AddParameter("object", "last_summary")
            Return rFunction.ToScript
        End Function

        Private Function GetDatabookGetObjectScript() As String
            Dim rFunction As New RFunction
            rFunction.SetDataBookCommand("get_object_data")
            rFunction.AddParameter("data_name", """airquality""")
            rFunction.AddParameter("object_name", """last_summary""")
            rFunction.AddParameter("as_file", _asFile)
            Return rFunction.ToScript
        End Function

        Private Function IsCleanUpNeeded() As Boolean
            Return ((_preScript IsNot Nothing) And (_preScript.GetAssigned <> "")) Or (_script.GetAssigned <> "")
        End Function

        Private Function GetAllAssignedObjects() As List(Of String)
            'For each script In _preScript
            Dim allAssigned As New List(Of String)
            If (_preScript IsNot Nothing) And _preScript.GetAssigned <> "" Then
                allAssigned.Add(_preScript.GetAssigned)
            End If
            If _script.GetAssigned <> "" Then
                allAssigned.Add(_script.GetAssigned)
            End If
            Return allAssigned
        End Function

        Private Function GetCleanUpScript() As String
            Dim rFunction As New RFunction
            rFunction.SetBasicRCommand("rm")
            rFunction.AddParameter("list", GetAllAssignedObjects())
            Return rFunction.ToScript
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


        '                                   RObjectTypeLabel                        RObjectFormat
        Public Sub SetDatabookObjectLog(objectTypeLabel As String, objectFormat As String, asFile As Boolean)
            _objectTypeLabel = objectTypeLabel
            _objectFormat = objectFormat
            _asFile = asFile
            _runAddAndGetObjectScripts = True
        End Sub


    End Class



End Namespace

