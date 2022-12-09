Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports R_Link.ScriptBuilder
Imports RDotNet

Public Class ScriptRunner
    Inherits RConnector



    Public HelperFunctions As HelperFunction
    '  Private Shared ReadOnly Logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    Public Sub New()
        HelperFunctions = New HelperFunction(Me)
    End Sub


    Public Function RunUnvalidatedScript(strNewScript As String, strNewComment As String) As String
        Dim strScriptCmd As String = ""

        'for each line in script
        For Each strScriptLine As String In strNewScript.Split(Environment.NewLine)
            'remove any comments (character '#' and anything after)
            Dim iCommentPos As Integer = strScriptLine.IndexOf("#")
            Select Case iCommentPos
                Case 0      'a normal comment line (starts with '#')
                    Continue For
                Case Is > 0 ' a line with an appended comment (e.g. 'x <- 1 # generate data' converted to 'x <- 1 ')
                    strScriptLine = strScriptLine.Substring(0, iCommentPos - 1)
            End Select

            'if line is empty or only whitespace then ignore line
            Dim strTrimmedLine As String = strScriptLine.Trim(vbLf).Trim()
            If strTrimmedLine.Length <= 0 Then
                Continue For
            End If

            'else append line of script to command
            strScriptCmd &= strScriptLine

            'if line ends in a '+', ',', or '%>%'; or there are open curly braces; or open quotations, 
            '    then assume command is not complete
            Dim cLastChar As Char = strTrimmedLine.Last
            Dim strLast3Chars As String = ""
            Dim iNumOpenRound As Integer = strScriptCmd.Where(Function(c) c = "("c).Count
            Dim iNumClosedRound As Integer = strScriptCmd.Where(Function(c) c = ")"c).Count
            Dim iNumOpenCurlies As Integer = strScriptCmd.Where(Function(c) c = "{"c).Count
            Dim iNumClosedCurlies As Integer = strScriptCmd.Where(Function(c) c = "}"c).Count
            Dim iNumDoubleQuotes As Integer = strScriptCmd.Where(Function(c) c = """"c).Count
            If strTrimmedLine.Length >= 3 Then
                strLast3Chars = strTrimmedLine.Substring(strTrimmedLine.Length - 3)
            End If
            If cLastChar = "+" OrElse cLastChar = "," OrElse strLast3Chars = "%>%" _
                    OrElse iNumOpenRound <> iNumClosedRound _
                    OrElse iNumOpenCurlies <> iNumClosedCurlies _
                    OrElse iNumDoubleQuotes Mod 2 Then
                Continue For
            End If

            'else execute command
            Dim iCallType As Integer = 5
            If strScriptCmd.Contains(Constant.DataBookName & "$get_graphs") Then
                iCallType = 3
            End If
            RunScript(strScriptCmd.Trim(vbLf), iCallType:=iCallType, strComment:=strNewComment, bSeparateThread:=False, bSilent:=False)
            strScriptCmd = ""
            strNewComment = ""
        Next
        Return strScriptCmd
    End Function


    Private Function GetFormattedComment(strComment As String) As String
        Dim strReconstructedComment As String = ""
        Dim arrCommentParts As String()
        If strComment.Length > 0 Then
            arrCommentParts = strComment.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            For Each strPart As String In arrCommentParts
                If strReconstructedComment = "" Then
                    strReconstructedComment = "# " & strPart
                Else
                    strReconstructedComment = strReconstructedComment & Environment.NewLine & "# " & strPart
                End If
            Next
        End If
        Return strReconstructedComment
    End Function

    Public Sub RunScript(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing, Optional bUpdateGrids As Boolean = True, Optional bSilent As Boolean = False)
        Dim strTemp As String = ""
        Dim strOutput As String = ""
        Dim strScriptWithComment As String
        Dim clsPNGFunction As New RFunction
        Dim strTempAssignTo As String = ".temp_val"
        Dim bError As Boolean = False

        Dim returnType As R_ReturnType = R_ReturnType.IgnoreResult

        If iCallType = 0 Then
            returnType = R_ReturnType.IgnoreResult
        ElseIf iCallType = 1 Then
            returnType = R_ReturnType.ResultAsTemporaryVariable
        ElseIf iCallType = 2 Then
            returnType = R_ReturnType.ResultAsText
        ElseIf iCallType = 3 Then
            returnType = R_ReturnType.ResultAsImage
        ElseIf iCallType = 4 Then
            returnType = R_ReturnType.ResultAsWebControl
        End If




        strScriptWithComment = GetFormattedComment(strComment) & Environment.NewLine & strScript

        Select Case returnType
            Case R_ReturnType.IgnoreResult
                RunScriptNoResult(strScript)
            Case R_ReturnType.ResultAsTemporaryVariable
                strOutput = RunScriptGetTemporaryVariable(strScript)
            Case R_ReturnType.ResultAsText
                strOutput = RunScriptGetText(strScript)
            Case R_ReturnType.ResultAsImage
              '  strOutput = RunScriptGetImage(strScript, bSeparateThread, bShowWaitDialogOverride, bSilent)
            Case R_ReturnType.ResultAsWebControl
                strOutput = RunScriptAndShowInWeb(strScript)
            Case Else
                MsgBox("Unable to find a valid return type, Return Type: {0}" + returnType.ToString(), MsgBoxStyle.Critical)
        End Select

        'ToDo Output
        'If bOutput Then
        '    clsOutputLogger.Add(strScriptWithComment, strOutput, returnType, scriptType)
        'End If

        'ToDo Logs????
        ' AppendToAutoSaveLog(strScriptWithComment & Environment.NewLine)

        'ToDo move this to main project
        'If bUpdateGrids Then
        '    frmMain.UpdateAllGrids()
        'End If

        'ToDo delete file after output
        'If returnType = R_ReturnType.ResultAsImage AndAlso strOutput <> "" Then
        '    Try
        '        My.Computer.FileSystem.DeleteFile(strOutput)
        '    Catch e As Exception
        '        MsgBox(e.Message & Environment.NewLine & "A problem occured in attempting to delete the temporary file: " & strOutput & " The possible exceptions are described here: https://msdn.microsoft.com/en-us/library/tdx72k4b.aspx", MsgBoxStyle.Critical)
        '    End Try
        'End If


    End Sub


    Public Sub RunScriptNoResult(strScript As String)
        Evaluate(strScript)
    End Sub

    Public Function RunScriptGetTemporaryVariable(strScript As String) As String
        Dim expTemp As SymbolicExpression
        Dim strOutput As String = ""
        Dim clsPNGFunction As New RFunction
        Dim strTempAssignTo As String = ".temp_val"
        Try
            'TODO check this is valid syntax in all cases
            '     i.e. this is potentially: x <- y <- 1
            Evaluate(strTempAssignTo & " <- " & strScript)
            expTemp = GetSymbol(strTempAssignTo)
            If expTemp IsNot Nothing Then
                Dim strTemp As String = String.Join(Environment.NewLine, expTemp.AsCharacter())
                strOutput = strOutput & strTemp & Environment.NewLine
            End If
        Catch e As Exception
            MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
        End Try

        'ToDo Return Output
        Return strOutput
    End Function



    Public Function RunScriptGetText(strScript As String)

        Dim strCapturedScript As String
        Dim expTemp As RDotNet.SymbolicExpression
        Dim strTemp As String = ""
        Dim strOutput As String = ""
        Dim strSplitScript As String
        Dim clsPNGFunction As New RFunction
        Dim strTempAssignTo As String = ".temp_val"
        Dim bError As Boolean = False

        '  strCapturedScript = WrapScriptWithCaptureOutput(strScript)
        ' else if script output should not be ignored, not stored in a graph and not stored in a variable
        'if script comes from script window, or else script is a single line
        If strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray) = -1 Then
            'wrap the whole script in 'capture.output'
            '  'capture.output' returns the result of the R command as a string.
            '  This string can be displayed later in the output window.
            strCapturedScript = "capture.output(" & strScript & ")"

            ' strCapturedScript = strScript
        Else 'else if script is multi-line
            'execute all lines apart from the final line
            strSplitScript = Left(strScript, strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray))
            If strSplitScript <> "" Then
                Try
                    bError = Not Evaluate(strSplitScript)
                Catch e As Exception
                    MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                End Try
            End If
            'ensure that the final line of the script will be executed next
            strSplitScript = Right(strScript, strScript.Length - strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray) - 2)
            'wrap the final line in 'capture.output' so that when it's executed, the result can be displayed in the output window
            strCapturedScript = "capture.output(" & strSplitScript & ")"
        End If

        Try
            If Not bError Then
                'execute the script and assign the result to a temporary variable
                If Evaluate(strTempAssignTo & " <- " & strCapturedScript) Then
                    expTemp = GetSymbol(strTempAssignTo)
                    Evaluate("rm(" & strTempAssignTo & ")")
                    If expTemp IsNot Nothing Then
                        strTemp = String.Join(Environment.NewLine, expTemp.AsCharacter())
                        If strTemp <> "" Then
                            'ensure that the data returned from the script will be displayed in the output window
                            strOutput = strOutput & strTemp & Environment.NewLine
                        End If
                    End If
                End If
            End If
        Catch e As Exception
            ' MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
        End Try
        Return strOutput
    End Function



    Public Function RunScriptGetImages(strGraphDisplayOption As String, strScript As String) As List(Of Image)
        Dim strTemp As String = ""
        Dim strOutput As String = ""
        Dim strTempGraphsDirectory As String
        Dim clsPNGFunction As New RFunction
        Dim strTempAssignTo As String = ".temp_val"
        Dim bError As Boolean = False
        Dim filelocation As String = ""
        Dim images As New List(Of Image)
        Dim fsTemp As System.IO.FileStream

        Dim bSuccess As Boolean
        ' set temp folder for graphs, e.g. to "C:\Users\myName\Temp\R_Instat_Temp_Graphs"
        strTempGraphsDirectory = System.IO.Path.Combine(System.IO.Path.GetTempPath() & "R_Instat_Temp_Graphs")
        'Need to create directory as R unable to create the directory in linux
        If Not Directory.Exists(strTempGraphsDirectory) Then
            Directory.CreateDirectory(strTempGraphsDirectory)
        End If

        Try
            If strGraphDisplayOption = "view_output_window" OrElse strGraphDisplayOption = "view_separate_window" Then
                clsPNGFunction.SetPackageName("grDevices")
                clsPNGFunction.SetRCommand("png")
                clsPNGFunction.AddParameter("filename", Chr(34) & System.IO.Path.Combine(strTempGraphsDirectory & "/Graph.png").Replace("\", "/") & Chr(34))
                'TODO make these options
                clsPNGFunction.AddParameter("width", 4000)
                clsPNGFunction.AddParameter("height", 4000)
                clsPNGFunction.AddParameter("res", 500)
                bSuccess = Evaluate(clsPNGFunction.ToScript())
                ' Temporary solution to being unable to save graphs in a temporary location for display.
                ' This can occur if System.IO.Path.GetTempPath() returns a path that is not writable.
                If Not bSuccess Then
                    Evaluate("graphics.off()")
                    strGraphDisplayOption = "view_R_viewer"
                    'MsgBox("A problem occured saving graphs in the temporary location " & strTempGraphsDirectory & vbNewLine & vbNewLine & "To ensure graphs can still be viewed, graphs will now appear in a pop up R viewer." & vbNewLine & "Restarting R-Instat and/or your machine usually resolves this. You can change this setting back in Tools > Options: 'Graph Display' if this later becomes resolved.", MsgBoxStyle.Exclamation)
                    Logger.Error("A problem occured saving graphs in the temporary location " & strTempGraphsDirectory &
                                vbNewLine & vbNewLine &
                                "To ensure graphs can still be viewed, graphs will now appear in a pop up R viewer." &
                                vbNewLine &
                                "Restarting R-Instat and/or your machine usually resolves this. " &
                                 "You can change this setting back in Tools > Options: 'Graph Display' " &
                                 "if this later becomes resolved.")
                End If
            End If
            If strGraphDisplayOption = "view_R_viewer" Then
                Evaluate(strScript)
            Else 'TODO SJL this is the only line executed if iCallType is 0. Move outside if block to simplify logic?
                Evaluate(strScript)
            End If
            If strGraphDisplayOption = "view_output_window" OrElse strGraphDisplayOption = "view_separate_window" Then
                'add an R script (maybe in the form of one of our methods) that copies divices to the temp directory, using the default device production... use dev.list() and dev.copy() with arguments device = the devices in the list and which = jpeg devices with different paths leading to the temp directory, using a paste() method to find different names for the files
                Evaluate("graphics.off()") 'not quite sure if this would work, otherwise find the right way to close the appropriate devices.
                'clsEngine.Evaluate("ggsave(" & Chr(34) & strTempGraphsDirectory.Replace("\", "/") & "Graph.jpg" & Chr(34) & ")")
                'This sub is used to display graphics in the output window when necessary.
                'This sub is checking the temp directory "R_Instat_Temp_Graphs", created during setup to see if there are any graphs to display. If there are some, then it sends them to the output window, and removes them from the directory.
                'It is called from RLink at the end of RunScript.
                Dim lstTempGraphFiles As ObjectModel.ReadOnlyCollection(Of String)
                Dim iNumberOfFiles As Integer = -1
                strTempGraphsDirectory = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "R_Instat_Temp_Graphs")
                Try
                    lstTempGraphFiles = FileIO.FileSystem.GetFiles(strTempGraphsDirectory)
                Catch e As Exception
                    lstTempGraphFiles = Nothing
                    MsgBox(e.Message & Environment.NewLine & "A problem occured in getting the content of the temporary graphs directory: " & strTempGraphsDirectory & " Possible exceptions are described here: https://msdn.microsoft.com/en-us/library/kf41fdf4.aspx", MsgBoxStyle.Critical)
                End Try
                If lstTempGraphFiles IsNot Nothing Then
                    iNumberOfFiles = CStr(lstTempGraphFiles.Count)
                End If
                If iNumberOfFiles > 0 Then
                    For Each strFileName As String In lstTempGraphFiles
                        fsTemp = New System.IO.FileStream(strFileName, IO.FileMode.Open, IO.FileAccess.Read)
                        images.Add(System.Drawing.Image.FromStream(fsTemp))
                        fsTemp.Close()
                        Try
                            System.IO.File.Delete(strFileName)
                        Catch e As Exception
                            MsgBox(e.Message & Environment.NewLine & "A problem occured in attempting to delete the temporary file: " & strFileName & " The possible exceptions are described here: https://msdn.microsoft.com/en-us/library/tdx72k4b.aspx", MsgBoxStyle.Critical)
                        End Try
                    Next
                End If
            End If
        Catch e As Exception
            MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
        End Try
        Return images
    End Function

    Private Function RunScriptAndShowInWeb(strScript As String) As String
        Dim strCapturedScript As String
        Dim expTemp As RDotNet.SymbolicExpression
        Dim strOutput As String = ""
        Dim strSplitScript As String
        Dim clsPNGFunction As New RFunction
        Dim strTempAssignTo As String = ".temp_val"
        Dim bError As Boolean = False

        Dim strTemp As String
        Try
            'TODO check this is valid syntax in all cases
            '     i.e. this is potentially: x <- y <- 1
            Evaluate(strTempAssignTo & " <- " & strScript)
            expTemp = GetSymbol(strTempAssignTo)
            If expTemp IsNot Nothing Then
                strTemp = String.Join(Environment.NewLine, expTemp.AsCharacter())
                strOutput = strOutput & strTemp & Environment.NewLine
            End If
        Catch e As Exception
            MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
        End Try
        ' else if script output should not be ignored, not stored in a graph and not stored in a variable
        'if script comes from script window, or else script is a single line
        If strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray) = -1 Then
            'wrap the whole script in 'capture.output'
            '  'capture.output' returns the result of the R command as a string.
            '  This string can be displayed later in the output window.
            strCapturedScript = "capture.output(" & strScript & ")"
        Else 'else if script is multi-line
            'execute all lines apart from the final line
            strSplitScript = Left(strScript, strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray))
            If strSplitScript <> "" Then
                Try
                    bError = Not Evaluate(strSplitScript)
                Catch e As Exception
                    MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                End Try
            End If
            'ensure that the final line of the script will be executed next
            strSplitScript = Right(strScript, strScript.Length - strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray) - 2)
            'wrap the final line in 'capture.output' so that when it's executed, the result can be displayed in the output window
            strCapturedScript = "capture.output(" & strSplitScript & ")"
        End If
        Try
            If Not bError Then
                'execute the script and assign the result to a temporary variable
                If Evaluate(strTempAssignTo & " <- " & strCapturedScript) Then
                    expTemp = GetSymbol(strTempAssignTo)
                    Evaluate("rm(" & strTempAssignTo & ")")
                    If expTemp IsNot Nothing Then
                        strTemp = String.Join(Environment.NewLine, expTemp.AsCharacter())
                        If strTemp <> "" Then
                            'ensure that the data returned from the script will be displayed in the output window
                            strOutput = strOutput & strTemp & Environment.NewLine
                        End If
                    End If
                End If
            End If
        Catch e As Exception
            MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
        End Try

        Return strOutput

    End Function

    Public Function RunInternalScriptGetString(strScript As String, Optional strVariableName As String = ".temp_value") As String
        Dim expTemp As SymbolicExpression
        expTemp = RunInternalScriptGetValue(strScript, strVariableName)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsCharacter(0)
        Else
            Return ""
        End If
    End Function
    Public Function RunInternalScriptGetStringArray(strScript As String, Optional strVariableName As String = ".temp_value") As String()
        Dim expTemp As SymbolicExpression
        expTemp = RunInternalScriptGetValue(strScript, strVariableName)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsCharacter.ToArray
        Else
            Return Nothing
        End If
    End Function

    Public Function RunInternalScriptGetInteger(strScript As String, Optional strVariableName As String = ".temp_value") As Integer
        Dim expTemp As SymbolicExpression

        expTemp = RunInternalScriptGetValue(strScript, strVariableName)

        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsNumeric(0)
        Else
            Return ""
        End If
    End Function

    Public Function RunInternalScriptGetOutput(strScript As String) As CharacterVector



        Dim chrTemp As CharacterVector
        Dim expTemp As SymbolicExpression

        expTemp = RunInternalScriptGetValue("capture.output(" & strScript & ")", ".temp_value")
        Try
            chrTemp = expTemp.AsCharacter()
        Catch ex As Exception
            chrTemp = Nothing
        End Try
        Return chrTemp
    End Function

    Public Function RunInternalScript(strScript As String, Optional strVariableName As String = "") As Boolean
        Dim strCommand As String
        Dim bReturn As Boolean
        If strVariableName <> "" Then
            strCommand = strVariableName & "<-" & strScript
        Else
            strCommand = strScript
        End If
        If _rEngine IsNot Nothing Then
            bReturn = Evaluate(strCommand)
            Return bReturn
        Else
            Return False
        End If
    End Function
    Public Function RunInternalScriptGetValue(strScript As String, strVariableName As String) As SymbolicExpression
        Dim expTemp As SymbolicExpression
        Dim strCommand As String
        'TODO Legacy - Bug here if strScript is multiple lines. Wrong value will be returned
        strCommand = strVariableName & " <- " & strScript
        Evaluate(strCommand)
        expTemp = GetSymbol(strVariableName, bSilent:=True)
        'Very important to remove the variable after getting it otherwise could be returning wrong variable later if a command gives an error
        Evaluate("rm(" & strVariableName & ")")
        Return expTemp
    End Function
    Public Function RunInternalScriptGetBoolean(strScript As String, Optional strVariableName As String = ".temp_value") As Boolean
        Dim expTemp As SymbolicExpression
        expTemp = RunInternalScriptGetValue(strScript, strVariableName)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            Return ""
        End If
    End Function

    Public Function ConnectAndCheckVersion(expectedMajorVersion As String, expectedMinorVersion As String)
        'ToDo this should do one thing
        Dim bClose As Boolean = Connect()

        If Not HelperFunctions.CompareRVersion(expectedMajorVersion, expectedMinorVersion) Then
            Return False
        End If

        'ToDo
        '    bREngineInitialised = True
        'If strScript = "" Then
        '    strScript = GetRSetupScript()
        '    iCallType = 0
        '    strComment = "Setting working directory, sourcing R code and loading R packages"

        '    bSeparateThread = True
        'End If
        'For Each strLine As String In strScript.Split(Environment.NewLine)
        '    If strLine.Trim(vbLf).Count > 0 Then
        '        If strLine.Contains(strInstatDataObject & "$get_graphs") Then
        '            iCurrentCallType = 3
        '        Else
        '            iCurrentCallType = iCallType
        '        End If
        '        RunScript(strScript:=strLine.Trim(vbLf), iCallType:=iCurrentCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bSilent:=True)
        '    End If
        '    strComment = ""
        'Next
        'strMissingPackages = GetPackagesNotInstalled()
        'If strMissingPackages IsNot Nothing AndAlso strMissingPackages.Count > 0 Then
        '    frmPackageIssues.SetMissingPackages(strMissingPackages)
        '    frmPackageIssues.ShowDialog()
        '    bClose = frmPackageIssues.bCloseRInstat
        'End If
        'bInstatObjectExists = True
        Return bClose
    End Function


End Class
