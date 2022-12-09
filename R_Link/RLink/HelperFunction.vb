Imports System.Collections.Generic
Imports System.Linq
Imports R_Link.ScriptBuilder

Public Class HelperFunction
    Private ReadOnly _scriptRunner As ScriptRunner

    Public Sub New(scriptRunner As ScriptRunner)
        _scriptRunner = scriptRunner
    End Sub

    Public Function GetDataFrameNames() As List(Of String)
        Dim lstDataFrameNames As New List(Of String)
        Dim clsGetDataNames As New RFunction
        clsGetDataNames.SetRCommand(Constant.DataBookName & "$get_data_names") 'TODO SJL 20/04/20 move to inside if statement?
        lstDataFrameNames.AddRange(_scriptRunner.RunInternalScriptGetStringArray(clsGetDataNames.ToScript()))
        Return lstDataFrameNames
    End Function

    Public Function DataFrameExists(strDataFrameName As String) As Boolean
        Dim clsDataFrameExists As New RFunction
        clsDataFrameExists.SetRCommand(Constant.DataBookName & "$data_frame_exists")
        clsDataFrameExists.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        Return _scriptRunner.RunInternalScriptGetBoolean(clsDataFrameExists.ToScript())
    End Function

    Public Function GetColumnNames(strDataFrameName As String, Optional bIncludeHiddenColumns As Boolean = True) As List(Of String)
        Dim lstCurrColumns As New List(Of String)
        Dim clsGetColumnNames As New RFunction
        If strDataFrameName <> "" AndAlso DataFrameExists(strDataFrameName) Then
            clsGetColumnNames.SetRCommand(Constant.DataBookName & "$get_column_names")
            clsGetColumnNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            If Not bIncludeHiddenColumns Then
                clsGetColumnNames.AddParameter("exclude", "list(Is_Hidden = TRUE)")
            End If
            lstCurrColumns.AddRange(_scriptRunner.RunInternalScriptGetStringArray(clsGetColumnNames.ToScript()))
        End If
        Return lstCurrColumns
    End Function

    Public Function GetDefaultColumnNames(strPrefix As String, strDataFrameName As String) As String
        Dim strNextDefault As String = ""
        Dim clsGetNextDefault As New RFunction
        clsGetNextDefault.SetRCommand(Constant.DataBookName & "$get_next_default_column_name")
        clsGetNextDefault.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        clsGetNextDefault.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        If strDataFrameName <> "" AndAlso DataFrameExists(strDataFrameName) Then
            strNextDefault = _scriptRunner.RunInternalScriptGetString(clsGetNextDefault.ToScript())
        End If
        Return strNextDefault
    End Function

    Public Function GetNextDefault(strPrefix As String, lstItems As List(Of String)) As String
        Dim clsGetDefault As New RFunction
        Dim strExistingNames As String
        clsGetDefault.SetRCommand("next_default_item")
        clsGetDefault.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        strExistingNames = GetListAsRString(lstItems)
        If strExistingNames <> "" Then
            clsGetDefault.AddParameter("existing_names", GetListAsRString(lstItems))
        End If
        Return _scriptRunner.RunInternalScriptGetString(clsGetDefault.ToScript())
    End Function

    Public Function GetListAsRString(lstStrings As List(Of String), Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        Dim i As Integer

        If lstStrings.Count = 1 Then
            If bWithQuotes Then
                strTemp = Chr(34) & lstStrings.Item(0) & Chr(34)
            Else
                strTemp = lstStrings.Item(0)
            End If
        ElseIf lstStrings.Count > 1 Then
            strTemp = "c" & "("
            For i = 0 To lstStrings.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                If lstStrings.Item(i) <> "" Then
                    If bWithQuotes Then
                        strTemp = strTemp & Chr(34) & lstStrings.Item(i) & Chr(34)
                    Else
                        strTemp = strTemp & lstStrings.Item(i)
                    End If
                End If
            Next
            strTemp = strTemp & ")"
        End If
        Return strTemp
    End Function

    Public Function GetLinkedToDataFrameNames(strDataName As String, Optional bIncludeSelf As Boolean = True) As List(Of String)
        Dim lstDataFrameNames As New List(Of String)
        Dim clsGetDataNames As New RFunction
        clsGetDataNames.SetRCommand(Constant.DataBookName & "$get_linked_to_data_name")
        clsGetDataNames.AddParameter("from_data_frame", Chr(34) & strDataName & Chr(34), iPosition:=0)
        If bIncludeSelf Then
            clsGetDataNames.AddParameter("include_self", "TRUE", iPosition:=2)
        Else
            clsGetDataNames.AddParameter("include_self", "FALSE", iPosition:=2)
        End If
        lstDataFrameNames.AddRange(_scriptRunner.RunInternalScriptGetStringArray(clsGetDataNames.ToScript()))
        Return lstDataFrameNames
    End Function

    Public Function GetPackagesNotInstalled() As String()
        Dim clsPackagesNotInstalled As New RFunction
        clsPackagesNotInstalled.SetRCommand("packages_not_installed")
        Return _scriptRunner.RunInternalScriptGetStringArray(clsPackagesNotInstalled.ToScript())
    End Function

    Public Function GetRSetupScript(rSetupPath As String) As String
        Dim clsSetWd As New RFunction
        Dim clsSource As New RFunction
        Dim clsCreateIO As New ROperator
        Dim clsDplyrOption As New RFunction
        Dim strScript As String = ""

        clsSetWd.SetRCommand("setwd")
        clsSetWd.AddParameter("dir", Chr(34) & rSetupPath & Chr(34)) 'This is bad the wd should be flexible and not automatically set to the instat object directory
        clsSource.SetRCommand("source")
        clsSource.AddParameter("file", Chr(34) & "Rsetup.R" & Chr(34))
        clsCreateIO.SetOperation("<-")
        clsCreateIO.AddParameter("left", Constant.DataBookName, iPosition:=0)
        clsCreateIO.AddParameter("right", Constant.DataBookClassName & "$new()", iPosition:=1)
        clsDplyrOption.SetRCommand("options")
        clsDplyrOption.AddParameter("dplyr.summarise.inform", "FALSE", iPosition:=0)

        strScript = ""
        strScript = strScript & clsSetWd.ToScript() & Environment.NewLine
        strScript = strScript & clsSource.ToScript() & Environment.NewLine
        strScript = strScript & clsCreateIO.ToScript() & Environment.NewLine
        strScript = strScript & clsDplyrOption.ToScript()

        Return strScript
    End Function

    Public Sub SetWorkingDirectory(rSetupPath As String, Optional setUpScript As String = "", Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True)
        'ToDo Move this out as needs to write to output
        Dim iCurrentCallType As Integer

        If setUpScript = "" Then
            setUpScript = GetRSetupScript(rSetupPath)
            iCallType = 0
            strComment = "Setting working directory, sourcing R code and loading R packages"
            bSeparateThread = True
        End If
        For Each strLine As String In setUpScript.Split(Environment.NewLine)
            If strLine.Trim(vbLf).Count > 0 Then
                If strLine.Contains(Constant.DataBookName & "$get_graphs") Then
                    iCurrentCallType = 3
                Else
                    iCurrentCallType = iCallType
                End If
                _scriptRunner.RunScript(strScript:=strLine.Trim(vbLf), iCallType:=iCurrentCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bSilent:=True)
            End If
            strComment = ""
        Next
    End Sub

    Public Function CompareRVersion(expectedMajorVersion As String, expectedMinorVersion As String)
        Try
            Dim strMajor As String = _scriptRunner.RunInternalScriptGetString("R.Version()$major")

            Dim strMinor As String = _scriptRunner.RunInternalScriptGetString("R.Version()$minor")

            Dim strRVersionRunning = strMajor & "." & strMinor
            If strMinor.Count >= 3 Then
                If Not (strMajor = expectedMajorVersion AndAlso strMinor.Count > 0 AndAlso strMinor(0) >= expectedMinorVersion) Then
                    'MsgBox("Your current version of R is outdated. You are currently running R version: " & strRVersionRunning & vbNewLine &
                    '       "R-Instat requires at least version " & strRVersionRequired & " or greater." &
                    '       vbNewLine & "Try reruning the installation to install an updated version of R or download R from " &
                    '       "https://cran.r-project.org/bin/windows/base/" & strRVersionRequired & "and restart R-Instat.", MsgBoxStyle.Critical, "R Version not supported.")
                    'Application.Exit()
                    'Environment.Exit(0)
                    Return False
                End If
            Else
                'MsgBox("Could not determine version of R installed on your machine. R-Instat requires version: " & strRVersionRequired & vbNewLine &
                '       "Try uninstalling any versions of R and rerun the installation to install R " & strRVersionRequired & " or download R " &
                '       strRVersionRequired & "From https://cran.r-project.org/bin/windows/base/old/" & strRVersionRequired &
                '       "And restart R-Instat.", MsgBoxStyle.Critical, "R Version error.")
                'Application.Exit()
                'Environment.Exit(0)
                Return False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message & Environment.NewLine & "Could not determine the version of R installed on your machine. We recommend rerunning the installation to install an updated version of R or download the latest version from https://cran.r-project.org/ and restart R-Instat.", MsgBoxStyle.Critical, "Cannot determine R version.")

            'Application.Exit()
            'Environment.Exit(0)
            Return False
        End Try
        Return True
    End Function

    'Public Sub CloseData()
    '    Dim clsRm As New RFunction
    '    Dim clsCreateIO As New ROperator

    '    clsRm.SetRCommand("rm")
    '    clsRm.AddParameter("0", strInstatDataObject, iPosition:=0, bIncludeArgumentName:=False)
    '    clsRm.AddParameter("1", strGraphDataBook, iPosition:=1, bIncludeArgumentName:=False)

    '    clsCreateIO.SetOperation("<-")
    '    clsCreateIO.AddParameter("left", strInstatDataObject, iPosition:=0)
    '    clsCreateIO.AddParameter("right", strDataBookClassName & "$new()", iPosition:=1)

    '    '  bInstatObjectExists = False
    '    RunScript(clsRm.ToScript(), strComment:="Closing data")
    '    ' bInstatObjectExists = True
    '    RunScript(clsCreateIO.ToScript(), strComment:="Creating New Instat Object")
    'End Sub
End Class