' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports System.Runtime.InteropServices
Imports RDotNet
Imports unvell.ReoGrid
Imports System.IO
Imports RScript
Imports R_Link
Imports System.Threading

'''--------------------------------------------------------------------------------------------
''' <summary>   An object of this class represents an R interface. 
'''             Each instance of this class has its own R environment.
'''             <para>
'''             This class provides methods and fields to:</para>
''' <list type="bullet">
'''     <item><description>
'''             Define the R environment including paths and R versions.
'''     </description></item><item><description>
'''             Open a direct link to the R environment and load the required R packages. 
'''     </description></item><item><description>
'''             Execute a specified R script and display the output as text, graph or in a 
'''             web browser.
'''     </description></item><item><description>
'''             Write to log and debug files.
'''     </description></item><item><description>
'''             Specify the fonts and colours to be used in the output window.
'''     </description></item><item><description>
'''             Populate and configure the data frame control combo box, and the list view control.
'''     </description></item><item><description>
'''             Get names of data frames, columns, models, tables, filters, graphs and survs.
'''     </description></item><item><description>
'''             Get properties and other metadata.
'''     </description></item><item><description>
'''             Execute specific climatic and corruption commands.
'''     </description></item>
''' </list></summary>
'''--------------------------------------------------------------------------------------------
Public Class RLink

    Private _rEngine As ScriptRunner

    ''' <summary>   Full pathname of the climate object file. </summary>
  '  Dim strClimateObjectPath As String = "/ClimateObject/R" 'TODO SJL 23/04/20 Not used. Delete?

    ''' <summary>   The name of the climate object. </summary>
    Public strClimateObject As String = "ClimateObject" 'TODO SJL 23/04/20 make constant?

    ''' <summary>   Full pathname of the instat object file. </summary>
    Dim strInstatObjectPath As String = "/InstatObject/R" 'TODO SJL 23/04/20 make private constant?

    ''' <summary>   The instat data book object. </summary> 
    Public strInstatDataObject As String = "data_book" 'TODO SJL 23/04/20 make private constant?

    ''' <summary> The name of the graph data book used for storing graphs. </summary>
    Private strGraphDataBook As String = ".graph_data_book"

    ''' <summary>   Name of the data book class. </summary>
    Public strDataBookClassName As String = "DataBook" 'TODO SJL 23/04/20 make private constant?


    ''' <summary>   True if no R code has been executed yet. </summary>
   ' Private bFirstRCode As Boolean = True

    ''' <summary>   If true then write executed R script to the debug log file. </summary>
  '  Private bDebugLogExists As Boolean = False

    ''' <summary>   If true then write executed R script to the save log file. </summary>
    Private bAutoSaveLogExists As Boolean = False

    ''' <summary>   True if log file has not yet been created yet. </summary>
    Private bFirstLogCode As Boolean = True

    ''' <summary>   True if there is R code still currently executing. </summary>
    Public bRCodeRunning As Boolean = False


    ''' <summary>   Full pathname of the automatic save log file. </summary>
    Public strAutoSaveLogFilePath As String = ""

    ''' <summary>   Full pathname of the automatic save debug log file. </summary>
    Public strAutoSaveDebugLogFilePath As String = ""


    ''' <summary>   The link to the R environment. </summary>
   ' Public clsEngine As REngine 'TODO SJL 23/04/20 Make private?

    ''' <summary>   True if the link to the R environment is initialised. </summary>
    Public bREngineInitialised As Boolean = False

    ''' The log window.
    Public txtLog As New TextBox

    ''' True if the log window is defined
    Public bLog As Boolean = False

    ''' <summary> True if the R output window is defined.</summary>
    Public bOutput As Boolean = True


    ''' <summary>   True to climate object exists. </summary>
    Public bClimateObjectExists As Boolean = False 'TODO SJL 23/04/20 Not used. Delete?

    ''' <summary>   True if the connection to R is initialized and open. </summary>
    Public bInstatObjectExists As Boolean = False

    ''' <summary>   True to climsoft link exists. </summary>
    Public bClimsoftLinkExists As Boolean = False 'TODO SJL 23/04/20 Not used. Delete?

    ''' <summary> If true then show the executed commands in the R output window.</summary>
    Public bShowCommands As Boolean = True

    ''' <summary>   The graph display option (e.g. 'view_output_window' or 'view_separate_window'). </summary>
    Public strGraphDisplayOption As String = "view_output_window"


    ''' <summary> The current grid (the worksheet that appears similar to a spreadsheet on the 
    ''' left-hand side of the display). </summary>
    Private grdDataView As ReoGridControl

    ''' <summary> If true then, by default, display the waiting dialog (the dialog that is 
    ''' optionally displayed while an R script Is running). </summary>
    Private bShowWaitDialog As Boolean = True

    ''' The time in seconds to wait before showing the waiting dialog
  '  Private iWaitDelay As Integer = 2


    ''' <summary>   The R version major required. </summary>
    Private strRVersionMajorRequired As String = "4"

    ''' <summary>   The R version minor required. </summary>
    Private strRVersionMinorRequired As String = "1"

    ''' <summary>   The R version required. </summary>
  '  Private strRVersionRequired As String = strRVersionMajorRequired & "." & strRVersionMinorRequired & ".0"

    ''' <summary>   The R bundled version. </summary>
 '   Private strRBundledVersion As String = "4.1.2"

    Private clsOutputLogger As clsOutputLogger

    ''' <summary>
    ''' Create method for clsRLink
    ''' Must pass in the output logger so the R link knows where to post outputs to
    ''' </summary>
    ''' <param name="outputLogger"></param>
    Public Sub New(outputLogger As clsOutputLogger)
        clsOutputLogger = outputLogger
        _rEngine = New ScriptRunner
    End Sub


    Private Function GetcpuArchitectureFolder() As String
        If Environment.Is64BitProcess Then
            Return "x64"
        Else
            Return "i386"
        End If
    End Function

    Private Function veryLongTask() As String
        MsgBox("Start Of Thread")
        Threading.Thread.Sleep(5000)
        MsgBox("From the thread")
        Return "it worked"

    End Function

    Private CancellationTokenSource As CancellationTokenSource

    Private Async Function Simplethread(CancellationToken As CancellationToken) As Task
        ' Await Task.Run(Function() veryLongTask())

        Await Task.Run(Sub() ShowLoadingScreenAndWait(CancellationToken), CancellationToken)
    End Function




    Private Function ShowLoadingScreenAndWait(CancellationToken As CancellationToken) As Task
        frmSetupLoading.Show()
        Dim t As New Stopwatch
        t.Start()
        While t.ElapsedMilliseconds < (50000 * 1000)
            Threading.Thread.Sleep(5)
            'ToDo Not sure how this will work
            Application.DoEvents()
            If CancellationToken.IsCancellationRequested Then
                Exit While
            End If
        End While
        frmSetupLoading.Close()
    End Function



    Public Function StartREngine(Optional strScript As String = "", Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True) As Boolean
        bInstatObjectExists = True
        frmSetupLoading.ShowLoadingScreen()

        'Note - taken out version path as we will bundle this as R
        Dim rHome = Path.Combine(Path.GetFullPath("static"), "R")
        Dim rPath = Path.Combine(rHome, "bin", GetcpuArchitectureFolder)
        _rEngine.SetEnviromentVariables(rPath, rHome)

        Dim isConnected As Boolean = _rEngine.ConnectAndCheckVersion(strRVersionMajorRequired, strRVersionMinorRequired)

        Dim strMissingPackages() As String
        Dim bClose As Boolean = False

        Dim rSetupPath As String = Path.Combine(frmMain.strStaticPath.Replace("\", "/") & strInstatObjectPath)
        _rEngine.HelperFunctions.SetWorkingDirectory(rSetupPath, strScript, iCallType, strComment, bSeparateThread)


        'ToDo remove this - this should be a sepertate call from frmMain.AutoRecoverAndStartREngine
        'No reference to this form should be done in here
        strMissingPackages = _rEngine.HelperFunctions.GetPackagesNotInstalled()

        frmSetupLoading.HideLoadingScreen()
        If strMissingPackages IsNot Nothing AndAlso strMissingPackages.Count > 0 Then
            frmPackageIssues.SetMissingPackages(strMissingPackages)
            frmPackageIssues.ShowDialog()
            bClose = frmPackageIssues.bCloseRInstat
        End If
        bInstatObjectExists = True
        Return bClose

    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary> This method executes the <paramref name="strNewScript"/> R script and displays 
    '''           the output as text or graph (determined by <paramref name="strNewScript"/>).
    '''           <para>R commands may be split over multiple lines. This is only allowed if the  
    '''           non-final line ends with '+', ',', or '%>%'; or there are one or more '{'
    '''           brackets that have not been closed with an equivalent '}' bracket.
    '''           This function is named '...FromWindow' because it's designed to execute scripts 
    '''           entered by a human from a dialog window (e.g. a script window). These scripts 
    '''           may contain R commands split over multiple lines to make the commands more 
    '''           readable.</para>
    ''' </summary>
    ''' <param name="strNewScript">    The R script to execute.</param>
    ''' <param name="strNewComment">   Shown as a comment. If this parameter is "" then shows 
    '''                                <paramref name="strNewScript"/> as the comment.</param>
    ''' 
    ''' <returns> Any text at the end of <paramref name="strNewScript"/> that was not executed.
    '''           If all the text in <paramref name="strNewScript"/> was executed then returns "".
    '''           </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function RunScriptFromWindow(strNewScript As String, strNewComment As String) As String
        frmSetupLoading.ShowLoadingScreen()
        Dim Result = _rEngine.RunUnvalidatedScript(strNewScript, strNewComment)
        frmSetupLoading.HideLoadingScreen()
        Return Result
    End Function

    ''' <summary>
    ''' Extracts all the complete runnable R commands from <paramref name="strScript"/>.
    ''' The command lines returned are re-formatted in a format that the R.Net engine can execute.
    ''' </summary>
    ''' <param name="strScript">R script command. Can be a multiline script command</param>
    ''' <returns>an array that contains individual complete runnable R scripts</returns>
    Public Function GetRunnableCommandLines(strScript As String) As String()
        Dim lstRunnableCommandLines As New List(Of String)
        Dim arrScriptCommands As String() = strScript.Split(New String() {Environment.NewLine, vbLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim strSplitScriptCmd As String = ""

        For Each str As String In arrScriptCommands
            'trim the script command parts (for nice formatting)
            strSplitScriptCmd &= str.Trim()
            If Not IsRunnableScript(strSplitScriptCmd) Then
                Continue For
            End If
            lstRunnableCommandLines.Add(strSplitScriptCmd)
            strSplitScriptCmd = ""
        Next
        Return lstRunnableCommandLines.ToArray
    End Function

    ''' <summary>
    ''' checks if <paramref name="strNewScript"/> is complete valid R script that can be run without an error
    ''' </summary>
    ''' <param name="strNewScript">R script command. Can be a multiline script command</param>
    ''' <returns>true, if can be run without an error, and false otherwise</returns>
    Private Function IsRunnableScript(strNewScript As String) As Boolean
        Dim strScriptCmd As String = ""
        Dim bRunnable As Boolean = False

        'for each line in script(after removing empty lines)
        For Each strScriptLine As String In strNewScript.Split(New String() {Environment.NewLine, vbLf}, StringSplitOptions.RemoveEmptyEntries)
            'remove any comments (character '#' and anything after)
            Dim iCommentPos As Integer = strScriptLine.IndexOf("#")
            Select Case iCommentPos
                Case 0      'a normal comment line (starts with '#')
                    Continue For
                Case Is > 0 ' a line with an appended comment (e.g. 'x <- 1 # generate data' converted to 'x <- 1 ')
                    strScriptLine = strScriptLine.Substring(0, iCommentPos - 1)
            End Select

            'if line is only whitespace then ignore line
            Dim strTrimmedLine As String = strScriptLine.Trim()
            If strTrimmedLine.Length <= 0 Then
                Continue For
            End If

            'else append line of script to command
            strScriptCmd &= strScriptLine

            'if line ends in a '+', ',', or '%>%'; or there are open curly braces; or open quotations, 
            '    then assume command is not complete
            Dim cLastChar As Char = strTrimmedLine.Last
            Dim strLast3Chars As String = ""
            Dim iNumOpenCurlies As Integer = strScriptCmd.Where(Function(c) c = "{"c).Count
            Dim iNumClosedCurlies As Integer = strScriptCmd.Where(Function(c) c = "}"c).Count
            Dim iNumDoubleQuotes As Integer = strScriptCmd.Where(Function(c) c = """"c).Count
            If strTrimmedLine.Length >= 3 Then
                strLast3Chars = strTrimmedLine.Substring(strTrimmedLine.Length - 3)
            End If
            If cLastChar = "+" OrElse cLastChar = "," OrElse strLast3Chars = "%>%" OrElse iNumOpenCurlies <> iNumClosedCurlies OrElse iNumDoubleQuotes Mod 2 Then
                bRunnable = False
                Continue For
            End If

            bRunnable = True
        Next

        Return bRunnable
    End Function


    ''' <summary>   Closes down the R engine (which encapsulates the R environment). </summary>
    Public Sub CloseREngine()
        _rEngine.Diconnect()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets packages not installed. </summary>
    '''
    ''' <returns>   The packages not installed. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetPackagesNotInstalled() As String()
        Return _rEngine.HelperFunctions.GetPackagesNotInstalled()
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Loads the required packages. </summary>
    '''
    ''' <param name="bSilent">  (Optional) if false and an exception is raised then open a message
    '''                         box that displays the exception message. </param>
    '''
    ''' <returns>   True if it succeeds, false if it fails. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function LoadedRequiredPackages(Optional bSilent As Boolean = False) As Boolean
        Dim clsLoadPackages As New RFunction

        clsLoadPackages.SetRCommand("load_required_R_Instat_packages")
        Return RunInternalScript(clsLoadPackages.ToScript(), bSilent:=bSilent)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Loads the <paramref name="strFile"/> data file. </summary>
    '''
    ''' <param name="strFile">          The data file to load. </param>
    ''' <param name="bKeepExisting">    (Optional) the value for the 'keep_existing' parameter. </param>
    ''' <param name="strComment">       (Optional) The comment to show before executing the 
    '''                                 R script. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub LoadInstatDataObjectFromFile(strFile As String, Optional bKeepExisting As Boolean = False, Optional strComment As String = "")
        Dim clsImportRDS As New RFunction
        Dim clsReadRDS As New RFunction
        Dim strScript As String = ""
        Dim strTemp As String = ""

        clsReadRDS.SetRCommand("readRDS")
        clsReadRDS.AddParameter("file", Chr(34) & strFile.Replace("\", "/") & Chr(34))
        clsReadRDS.SetAssignTo("new_RDS")

        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS, iPosition:=0)
        'This RFunction takes booleans in capitals hence ToUpper
        clsImportRDS.AddParameter("keep_existing", bKeepExisting.ToString.ToUpper, iPosition:=1)

        strTemp = clsImportRDS.ToScript(strScript)
        RunScript(strScript & strTemp, strComment:=strComment)
        bInstatObjectExists = True
    End Sub




    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the log window. </summary>
    '''
    ''' <param name="tempLog">  The log window. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetLog(tempLog As TextBox)
        txtLog = tempLog
        bLog = True
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets a list of data frame names. </summary>
    '''
    ''' <returns>   The data frame names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataFrameNames() As List(Of String)
        Return _rEngine.HelperFunctions.GetDataFrameNames()
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the list of data names linked to <paramref name="strDataName"/>. </summary>
    '''
    ''' <param name="strDataName">  The data frame to link to. </param>
    ''' <param name="bIncludeSelf"> (Optional) If true then also return the <paramref name="strDataName"/> 
    '''                             data name.</param>.
    '''
    ''' <returns>   The data names linked to <paramref name="strDataName"/>. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetLinkedToDataFrameNames(strDataName As String, Optional bIncludeSelf As Boolean = True) As List(Of String)
        Return _rEngine.HelperFunctions.GetLinkedToDataFrameNames(strDataName, bIncludeSelf)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the column names for a returned dataframe. </summary>
    '''
    ''' <param name="strDataFrameName">         The dataframe name. </param>
    ''' <param name="bIncludeHiddenColumns">    (Optional) If true then also include the hidden 
    '''                                         column names in the returned list. </param>
    '''
    ''' <returns>   The column names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetColumnNames(strDataFrameName As String, Optional bIncludeHiddenColumns As Boolean = True) As List(Of String)
        Return _rEngine.HelperFunctions.GetColumnNames(strDataFrameName, bIncludeHiddenColumns)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Fills the <paramref name="cboColumns"/> combo box with the <paramref name="strDataFrame"/> 
    '''             data frame's column names. </summary>
    '''
    ''' <param name="strDataFrame"> The data frame name. </param>
    ''' <param name="cboColumns">   [in,out] The combobox columns control. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub FillColumnNames(strDataFrame As String, ByRef cboColumns As ComboBox)
        Dim lstCurrColumns As New List(Of String)

        If strDataFrame <> "" Then
            lstCurrColumns = GetColumnNames(strDataFrame)
        End If
        cboColumns.Items.Clear()
        cboColumns.Items.AddRange(lstCurrColumns.ToArray)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   TODO SJL 20/04/20 Not used, remove?. </summary>
    '''
    ''' <param name="strDataFrame"> The data frame. </param>
    ''' <param name="lstColumns">   [in,out] The list columns. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub FillColumnNames(strDataFrame As String, ByRef lstColumns As ListView)
        Dim lstCurrColumns As List(Of String)

        lstCurrColumns = GetColumnNames(strDataFrame)
        lstColumns.Items.Clear()
        If lstColumns.Columns.Count = 0 Then
            lstColumns.Columns.Add("Available Data")
        End If
        For Each strTemp In lstCurrColumns
            lstColumns.Items.Add(strTemp)
        Next
        lstColumns.Columns(0).Width = -2

    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the <paramref name="strDataFrameName"/> data frame's next default column 
    '''             name. </summary>
    '''
    ''' <param name="strPrefix">        The value for the R 'prefix' parameter. </param>
    ''' <param name="strDataFrameName"> The data frame name. </param>
    '''
    ''' <returns>   The default column names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDefaultColumnNames(strPrefix As String, strDataFrameName As String) As String
        Return _rEngine.HelperFunctions.GetDefaultColumnNames(strPrefix, strDataFrameName)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the name of the next default item from the <paramref name="lstItems"/> 
    '''             list of named items. 
    '''             These items may be data frames, tables, graphs or any other type of named R 
    '''             item. </summary>
    '''
    ''' <param name="strPrefix">    The value for the R 'prefix' parameter. </param>
    ''' <param name="lstItems">     The list of named items. </param>
    '''
    ''' <returns>   The name of next default. If the R command doesn't return any items, then
    '''             returns "".</returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetNextDefault(strPrefix As String, lstItems As List(Of String)) As String
        Return _rEngine.HelperFunctions.GetNextDefault(strPrefix, lstItems)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Appends <paramref name="strScript"/> as a new line to the automatic save log
    '''             file. If the log file doesn't exist yet, then it creates it. </summary>
    '''
    ''' <param name="strScript">    The text to add to the save log file. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub AppendToAutoSaveLog(strScript As String)
        Dim strTempFile As String
        Dim i As Integer = 1
        Try
            If bFirstLogCode Then
                If Not Directory.Exists(frmMain.strAutoSaveLogFolderPath) Then
                    Directory.CreateDirectory(frmMain.strAutoSaveLogFolderPath)
                End If
                strTempFile = "log.R"
                While File.Exists(Path.Combine(frmMain.strAutoSaveLogFolderPath, strTempFile))
                    i = i + 1
                    strTempFile = "log" & i & ".R"
                End While
                strAutoSaveLogFilePath = Path.Combine(frmMain.strAutoSaveLogFolderPath, strTempFile)
                File.WriteAllText(strAutoSaveLogFilePath, "")
                bAutoSaveLogExists = True
            End If
            If bAutoSaveLogExists Then
                Using w As StreamWriter = File.AppendText(strAutoSaveLogFilePath)
                    w.WriteLine(strScript)
                End Using
            End If
        Catch ex As Exception
            'MsgBox("Could not add script to auto save log file at:" & frmMain.strAutoSaveLogFilePath & Environment.NewLine & ex.Message, MsgBoxStyle.Exclamation, "Auot save Log File")
            bAutoSaveLogExists = False
        Finally
            bFirstLogCode = False
        End Try
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    ''' This method executes the <paramref name="strScript"/> R script and displays the output. The
    ''' output may be displayed as text, graph or in a web browser (see <paramref name="iCallType"/>).
    ''' </summary>
    ''' <param name="strScript"> is the R script to execute.</param>
    ''' <param name="iCallType"> defines how to display the R output.
    ''' <list type="bullet">
    '''     <item>
    '''        <description>0 Executes <paramref name="strScript"/> and ignores the result.</description>
    '''     </item>
    '''     <item>
    '''        <description>1 Executes <paramref name="strScript"/>, stores the result in a 
    '''        temporary R variable, and then outputs the variable's value as text.</description>
    '''     </item>
    '''     <item>
    '''        <description>2 Executes <paramref name="strScript"/> and if successful shows the 
    '''        result as text.</description>
    '''     </item>
    '''     <item>
    '''        <description>3 Executes <paramref name="strScript"/> and if successful shows the 
    '''        result as a graph.</description>
    '''     </item>
    '''     <item>
    '''        <description>4 Executes <paramref name="strScript"/>, stores the result in a 
    '''        temporary R variable, and then outputs the variable's value in a web browser.</description>
    '''     </item>
    '''     <item>
    '''        <description>5 Executes <paramref name="strScript"/>, and displays the result 
    '''        in the output window. Use this value for manually entered R commands (e.g. for 
    '''        commands entered manually in the script window).</description>
    '''     </item>
    ''' </list>
    ''' </param>
    ''' <param name="strComment"> is shown as a comment. If this parameter is "" then shows 
    ''' <paramref name="strScript"/> as the comment.</param>
    ''' <param name="bSeparateThread"> if true then executes <paramref name="strScript"/> in a 
    ''' new thread.</param>
    ''' <param name="bShowWaitDialogOverride"> if true and <paramref name="bSeparateThread"/> is 
    ''' also true then display a waiting dialog while the R script is executing.</param>
    ''' <param name="bUpdateGrids"> if true then updates grids after executing 
    ''' <paramref name="strScript"/>.</param>
    ''' <param name="bSilent"> if false and an exception is raised then open a message box that 
    ''' displays the exception message.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub RunScript(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "",
                         Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing,
                         Optional bUpdateGrids As Boolean = True, Optional bSilent As Boolean = False)

        Dim strScriptWithComment As String
        Dim returnType As R_ReturnType = R_ReturnType.IgnoreResult
        Dim strOutput As String = ""
        Dim strTempGraphsDirectory As String

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
        Else
            'ToDo raise exception
        End If


        ' set temp folder for graphs, e.g. to "C:\Users\myName\Temp\R_Instat_Temp_Graphs"
        strTempGraphsDirectory = System.IO.Path.Combine(System.IO.Path.GetTempPath() & "R_Instat_Temp_Graphs")
        'Need to create directory as R unable to create the directory in linux
        If Not Directory.Exists(strTempGraphsDirectory) Then
            Directory.CreateDirectory(strTempGraphsDirectory)
        End If

        strOutput = ""

        ' if comment provided
        If strComment <> "" Then
            ' Prefix comment to script, e.g. "# Code generated by the dialog, Import Dataset" & vbCrLf & "new_RDS <- readRDS(file=""C:/Users/myName ...
            strComment = GetFormattedComment(strComment)
            strScriptWithComment = strComment & Environment.NewLine & strScript
        Else
            strScriptWithComment = strScript
        End If
        If bLog Then
            txtLog.Text = txtLog.Text & strScriptWithComment & Environment.NewLine
        End If
        ' if the output window is defined then output comments (if exists) and script (if 'bShowCommands' is true).
        If bOutput Then
            clsOutputLogger.AddRScript(strScriptWithComment)
        End If

        strScriptWithComment = GetFormattedComment(strComment) & Environment.NewLine & strScript

        Select Case returnType
            Case R_ReturnType.IgnoreResult
                _rEngine.RunScriptNoResult(strScript)
            Case R_ReturnType.ResultAsTemporaryVariable
                clsOutputLogger.AddStringOutput(_rEngine.RunScriptGetTemporaryVariable(strScript))
            Case R_ReturnType.ResultAsText
                clsOutputLogger.AddStringOutput(_rEngine.RunScriptGetText(strScript))
            Case R_ReturnType.ResultAsImage
                Dim images As List(Of Image)
                images = _rEngine.RunScriptGetImages(strGraphDisplayOption, strScript)
                For Each image In images
                    If strGraphDisplayOption = "view_output_window" Then
                        clsOutputLogger.AddImageOutput(image)
                    ElseIf strGraphDisplayOption = "view_separate_window" Then
                        frmMain.AddGraphForm(image)
                    End If
                Next
            Case R_ReturnType.ResultAsWebControl
                '  strOutput = _rEngine.RunScriptAndShowInWeb(strScript, bSeparateThread, bShowWaitDialogOverride, bSilent)
            Case Else
                MsgBox("Unable to find a valid return type, Return Type: {0}" + returnType.ToString(), MsgBoxStyle.Critical)
        End Select


        ' if output window is defined, and there's something to output
        If bOutput AndAlso strOutput IsNot Nothing AndAlso strOutput <> "" Then
            ' if output should be sent to web browser
            If iCallType = 4 Then
                '  rtbOutput.AddIntoWebBrowser(strHtmlCode:=strOutput)
                'TODO Add to web browser
            Else
                clsOutputLogger.AddStringOutput(strOutput)
            End If
        End If
        AppendToAutoSaveLog(strScriptWithComment & Environment.NewLine)
        If bUpdateGrids Then
            frmMain.UpdateAllGrids()
        End If
        Exit Sub
    End Sub

    'Private Function RunREngineFunctionInAThread(REngineFunction As Action(Of )
    '    'ToDo bShowWaitDialogOverride what is this used for?


    '    Dim thrRScript As Threading.Thread
    '    Dim thrDelay As Threading.Thread
    '    Dim thrWaitDisplay As Threading.Thread
    '    Dim evtWaitHandleWaitDisplayDone As New System.Threading.AutoResetEvent(False)
    '    Dim evtWaitHandleDelayDone As New System.Threading.AutoResetEvent(False)
    '    Dim bReturn As Boolean = True
    '    Dim i As Integer = 1
    '    Dim strTempError As String = ""
    '    Dim strTempFile As String
    '    Dim bErrorMessageOpen As Boolean = False
    '    Dim bCurrentShowWaiting As Boolean

    '    Dim iWaitDelay = 2
    '    ' loop until any currently running R code has completed
    '    While bRCodeRunning
    '        Threading.Thread.Sleep(5)
    '    End While
    '    bRCodeRunning = True
    '    ' if R engine defined


    '    Try

    '        thrRScript = New Threading.Thread(Sub() REngineFunction(), maxStackSize:=25000000) With {
    '            .IsBackground = True
    '        }
    '        thrDelay = New Threading.Thread(Sub()
    '                                            Dim t As New Stopwatch
    '                                            t.Start()
    '                                            While t.ElapsedMilliseconds < (iWaitDelay * 1000) AndAlso thrRScript.IsAlive
    '                                                Threading.Thread.Sleep(5)
    '                                            End While
    '                                            evtWaitHandleDelayDone.Set()
    '                                        End Sub) With {
    '            .IsBackground = True
    '                                        }
    '        thrWaitDisplay = New Threading.Thread(Sub()
    '                                                  If bCurrentShowWaiting Then
    '                                                      If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
    '                                                          frmSetupLoading.Show()
    '                                                      End If
    '                                                  End If
    '                                                  While thrRScript.IsAlive
    '                                                      If bErrorMessageOpen Then
    '                                                          If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
    '                                                              frmSetupLoading.Close()
    '                                                          End If
    '                                                      End If
    '                                                      Threading.Thread.Sleep(5)
    '                                                      Application.DoEvents()
    '                                                  End While
    '                                                  If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
    '                                                      frmSetupLoading.Close()
    '                                                  End If
    '                                                  evtWaitHandleWaitDisplayDone.Set()
    '                                              End Sub) With {
    '            .IsBackground = True
    '                                              }
    '        thrRScript.Start()
    '        thrDelay.Start()
    '        evtWaitHandleDelayDone.WaitOne()
    '        If thrRScript.IsAlive Then
    '            thrWaitDisplay.Start()
    '            evtWaitHandleWaitDisplayDone.WaitOne()
    '        End If

    '    Catch ex As Exception
    '        ' If Not bSilent Then
    '        ' MsgBox(ex.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
    '        ' End If
    '        strTempError = ex.Message
    '        bReturn = False
    '    End Try

    '    Return bReturn

    'End Function


    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes the the <paramref name="strScript"/> R script and returns the result 
    '''             as a 'SymbolicExpression' object. </summary>
    '''
    ''' <param name="strScript">                The R script to execute. </param>
    ''' <param name="strVariableName">          (Optional) The name of the variable to store the 
    '''                                         result of <paramref name="strScript"/>. The variable 
    '''                                         is deleted before returning.</param>
    ''' <param name="bSilent">                  (Optional) If false and an exception is raised then
    '''                                         open a message box that displays the exception
    '''                                         message. </param>
    ''' <param name="bSeparateThread">          (Optional) If true then executes
    '''                                         <paramref name="strScript"/> in a new thread. </param>
    ''' <param name="bShowWaitDialogOverride">  (Optional) if true and
    '''                                         <paramref name="bSeparateThread"/> is also true then
    '''                                         display a waiting dialog while the R script is
    '''                                         executing. </param>
    ''' <param name="strError">                 [in,out] (Optional) The error. </param>
    '''
    ''' <returns>   The output returned from <paramref name="strScript"/> as a collection of strings.
    '''             If an exception is raised then returns 'Nothing'. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function RunInternalScriptGetValue(strScript As String, Optional strVariableName As String = ".temp_value", Optional bSilent As Boolean = False, Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing, Optional ByRef strError As String = "") As SymbolicExpression
        Dim thrRScript As Threading.Thread
        Dim thrDelay As Threading.Thread
        Dim thrWaitDisplay As Threading.Thread
        Dim evtWaitHandleWaitDisplayDone As New System.Threading.AutoResetEvent(False)
        Dim evtWaitHandleDelayDone As New System.Threading.AutoResetEvent(False)
        Dim bReturn As Boolean = True
        Dim i As Integer = 1
        Dim strTempError As String = ""
        Dim bErrorMessageOpen As Boolean = False
        Dim bCurrentShowWaiting As Boolean


        ' loop until any currently running R code has completed
        'ToDo - could be infinete loop
        'While _codeRunning
        '    Threading.Thread.Sleep(5)
        'End While
        '_codeRunning = True

        'Dim test As Action(Of (String, String, Boolean, Boolean, Boolean?, String), SymbolicExpression) = AddressOf _rEngine.RunInternalScriptGetValue(strScript, strVariableName, bSilent, bSeparateThread, bShowWaitDialogOverride, strError)

        '  RunREngineFunctionInAThread(AddressOf _rEngine.RunInternalScriptGetValue(strScript, strVariableName, bSilent, bSeparateThread, bShowWaitDialogOverride, strError))

        'Return test

        Return _rEngine.RunInternalScriptGetValue(strScript, strVariableName)

    End Function



    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes the the <paramref name="strScript"/> R script and returns the result 
    '''             as a collection of strings. </summary>
    '''
    ''' <param name="strScript">                The R script to execute. </param>
    ''' <param name="bSilent">                  (Optional) If false and an exception is raised then
    '''                                         opens a message box that displays the exception
    '''                                         message. </param>
    ''' <param name="bSeparateThread">          (Optional) If true then executes
    '''                                         <paramref name="strScript"/> in a new thread. </param>
    ''' <param name="bShowWaitDialogOverride">  (Optional) if true and <paramref name="bSeparateThread"/> 
    '''                                         is also true then displays a waiting dialog while 
    '''                                         the R script is executing. </param>
    ''' <param name="strError">                 [in,out] (Optional) The output returned from 
    '''                                         <paramref name="strScript"/> as a collection of 
    '''                                         strings.
    '''                                         If an exception is raised then returns 'Nothing'. </param>
    '''
    ''' <returns>   The result of the script execution as a collection of strings. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function RunInternalScriptGetOutput(strScript As String, Optional bSilent As Boolean = False, Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing, Optional ByRef strError As String = "") As CharacterVector
        Return _rEngine.RunInternalScriptGetOutput(strScript)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes the <paramref name="strScript"/> R script, optionally stores the 
    '''             result in <paramref name="strVariableName"/>, and returns true if execution 
    '''             was successful. </summary>
    '''
    ''' <param name="strScript">                The R script to execute. </param>
    ''' <param name="strVariableName">          (Optional) The name of the variable to store the
    '''                                         result of the R script execution. </param>
    ''' <param name="bSilent">                  (Optional) If false and an exception is raised then
    '''                                         opens a message box that displays the exception
    '''                                         message. </param>
    ''' <param name="bSeparateThread">          (Optional) If true then executes the R script in a new
    '''                                         thread. </param>
    ''' <param name="bShowWaitDialogOverride">  (Optional) If true and <paramref name="bSeparateThread"/> 
    '''                                         is also true then displays a waiting dialog while 
    '''                                         the R script is executing. </param>
    '''
    ''' <returns>   True if <paramref name="strScript"/> executes without raising an exception, 
    '''             else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function RunInternalScript(strScript As String, Optional strVariableName As String = "", Optional bSilent As Boolean = False, Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing) As Boolean
        Dim thrRScript As Threading.Thread
        Dim thrDelay As Threading.Thread
        Dim thrWaitDisplay As Threading.Thread
        Dim evtWaitHandleWaitDisplayDone As New System.Threading.AutoResetEvent(False)
        Dim evtWaitHandleDelayDone As New System.Threading.AutoResetEvent(False)
        Dim bReturn As Boolean = True
        Dim i As Integer = 1
        Dim strTempError As String = ""
        Dim bErrorMessageOpen As Boolean = False
        Dim bCurrentShowWaiting As Boolean



        ' loop until any currently running R code has completed
        'ToDo - could be infinete loop
        'While _codeRunning
        '    Threading.Thread.Sleep(5)
        'End While
        '_codeRunning = True
        bRCodeRunning = True
        Dim temp = True
        'temp = JustATest(strScript, strVariableName, bSilent, bSeparateThread, bShowWaitDialogOverride).Result
        '  DisplayLoading()
        ' _rEngine.RunInternalScript(strScript, strVariableName, bSilent, bSeparateThread, bShowWaitDialogOverride)
        '  temp = JustATest(strScript, strVariableName, bSilent, bSeparateThread, bShowWaitDialogOverride).Result
        'Threading.Thread.Sleep(500)
        bRCodeRunning = False
        ' temp = JustATest(strScript, strVariableName, bSilent, bSeparateThread, bShowWaitDialogOverride).Result
        _rEngine.RunInternalScript(strScript, strVariableName)
        Return temp

        'thrDelay = New Threading.Thread(Sub()
        '                                    Dim t As New Stopwatch
        '                                    t.Start()
        '                                    While t.ElapsedMilliseconds < (2 * 1000) AndAlso _rEngine.ScriptRunning
        '                                        Threading.Thread.Sleep(5)
        '                                    End While
        '                                    evtWaitHandleDelayDone.Set()
        '                                End Sub)
        'thrDelay.IsBackground = True
        'thrWaitDisplay = New Threading.Thread(Sub()
        '                                          If bCurrentShowWaiting Then
        '                                              If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
        '                                                  frmSetupLoading.Show()
        '                                              End If
        '                                          End If
        '                                          While _rEngine.ScriptRunning
        '                                              If bErrorMessageOpen Then
        '                                                  If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
        '                                                      frmSetupLoading.Close()
        '                                                  End If
        '                                              End If
        '                                              Threading.Thread.Sleep(5)
        '                                              'ToDo Not sure how this will work
        '                                              ' Application.DoEvents()
        '                                          End While
        '                                          If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
        '                                              frmSetupLoading.Close()
        '                                          End If
        '                                          evtWaitHandleWaitDisplayDone.Set()
        '                                      End Sub)
        'thrWaitDisplay.IsBackground = True
        'thrDelay.Start()
        'evtWaitHandleDelayDone.WaitOne()
        'If _rEngine.ScriptRunning Then
        '    thrWaitDisplay.Start()
        '    evtWaitHandleWaitDisplayDone.WaitOne()
        'End If

        Return True
    End Function




    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the R setup script.</summary>
    '''
    ''' <returns>   The R setup script. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetRSetupScript() As String
        Dim clsSetWd As New RFunction
        Dim clsSource As New RFunction
        Dim clsCreateIO As New ROperator
        Dim clsDplyrOption As New RFunction
        Dim strScript As String = ""

        clsSetWd.SetRCommand("setwd")
        clsSetWd.AddParameter("dir", Chr(34) & Path.Combine(frmMain.strStaticPath.Replace("\", "/") & strInstatObjectPath) & Chr(34)) 'This is bad the wd should be flexible and not automatically set to the instat object directory 
        clsSource.SetRCommand("source")
        clsSource.AddParameter("file", Chr(34) & "Rsetup.R" & Chr(34))
        clsCreateIO.SetOperation("<-")
        clsCreateIO.AddParameter("left", strInstatDataObject, iPosition:=0)
        clsCreateIO.AddParameter("right", strDataBookClassName & "$new()", iPosition:=1)
        clsDplyrOption.SetRCommand("options")
        clsDplyrOption.AddParameter("dplyr.summarise.inform", "FALSE", iPosition:=0)

        strScript = ""
        strScript = strScript & clsSetWd.ToScript() & Environment.NewLine
        strScript = strScript & clsSource.ToScript() & Environment.NewLine
        strScript = strScript & clsCreateIO.ToScript() & Environment.NewLine
        strScript = strScript & clsDplyrOption.ToScript()

        Return strScript
    End Function

    ''' <summary>   Creates a new instat object. </summary>
    Public Sub CreateNewInstatObject()
        RunScript(strInstatDataObject & " <- " & strDataBookClassName & "$new()", strComment:="Defining new Instat Object")
        bInstatObjectExists = True
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Fills the list view control <paramref name="lstView"/> with the type of items 
    '''             specified by <paramref name="strType"/>. </summary>
    '''
    ''' <param name="lstView">              The list view control. </param>
    ''' <param name="strType">              The type of item to display in the list view.
    '''                                     This can be 'data frame', 'graph', model', 'column' etc. 
    '''                                     For a full list of possible values, please see the 
    '''                                     select statement in the function body below. </param>
    ''' <param name="lstIncludedDataTypes"> (Optional) List of item names to display in the list 
    '''                                     view control. These are passed as 'include' parameters to 
    '''                                     the R 'list' command.</param>
    ''' <param name="lstExcludedDataTypes"> (Optional) List of item names **not** to display in the list
    '''                                     view control. These are passed as 'exclude' parameters to
    '''                                     the R 'list' command. </param>
    ''' <param name="strDataFrameName">     (Optional) The data frame name. </param>
    ''' <param name="strHeading">           (Optional) The heading for the list view display. </param>
    ''' <param name="strExcludedItems">     (Optional) List of item names to exclude from the list
    '''                                     view control. These are passed as parameter values for 
    '''                                     the 'excluded_items' R parameter. </param>
    ''' <param name="strDatabaseQuery">     (Optional) The database query. Only used if 
    '''                                     <paramref name="strType"/> is 'database_variables'.</param>
    ''' <param name="strNcFilePath">        (Optional) Full pathname of the non client file. 
    '''                                     Only used if <paramref name="strType"/> is 
    '''                                     'nc_dim_variables'.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub FillListView(lstView As ListView, strType As String, Optional lstIncludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional lstExcludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional strDataFrameName As String = "", Optional strHeading As String = "Variables", Optional strExcludedItems As String() = Nothing, Optional strDatabaseQuery As String = "", Optional strNcFilePath As String = "")
        Dim vecColumns As GenericVector = Nothing
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim grps As New ListViewGroup
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim clsExcludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim kvpExclude As KeyValuePair(Of String, String())
        Dim expItems As SymbolicExpression
        Dim clsGetColumnTypes As New RFunction
        Dim strCurrColumnTypes() As String
        Dim clsGetColumnLabels As New RFunction
        Dim strCurrColumnLables() As String
        Dim strColumnsRList As String
        Dim strTemp As String
        Dim lviTemp As ListViewItem
        Dim strTopItemText As String = ""

        If bInstatObjectExists Then
            Select Case strType
                Case "column"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_column_names")
                Case "metadata"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_metadata_fields")
                Case "filter"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_filter_names")
                Case "column_selection"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_column_selection_names")
                Case "object"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_object_names")
                Case "model"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_model_names")
                Case "graph"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_graph_names")
                Case "surv"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_surv_names")
                Case "dataframe"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_data_names")
                Case "link"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_link_names")
                Case "key"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_key_names")
                Case "database_variables"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_database_variable_names")
                    clsGetItems.AddParameter("query", Chr(34) & strDatabaseQuery & Chr(34))
                Case "nc_dim_variables"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_nc_variable_names")
                    clsGetItems.AddParameter("file", Chr(34) & strNcFilePath & Chr(34))
                Case "variable_sets"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_variable_sets_names")
                Case "table"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_table_names")
                Case "calculation"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_calculation_names")
            End Select
            clsGetItems.AddParameter("as_list", "TRUE")
            If lstView.TopItem IsNot Nothing Then
                strTopItemText = lstView.TopItem.Text
            End If
            lstView.Clear()
            lstView.Groups.Clear()
            lstView.Columns.Add(strHeading)
            If lstIncludedDataTypes.Count > 0 Then
                clsIncludeList.SetRCommand("list")
                For Each kvpInclude In lstIncludedDataTypes
                    clsIncludeList.AddParameter(kvpInclude.Key, GetListAsRString(kvpInclude.Value.ToList(), bWithQuotes:=False))
                Next
                clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)
            End If
            If lstExcludedDataTypes.Count > 0 Then
                clsExcludeList.SetRCommand("list")
                For Each kvpExclude In lstExcludedDataTypes
                    clsExcludeList.AddParameter(kvpExclude.Key, GetListAsRString(kvpExclude.Value.ToList(), bWithQuotes:=False))
                Next
                clsGetItems.AddParameter("exclude", clsRFunctionParameter:=clsExcludeList)
            End If
            If strDataFrameName <> "" Then
                clsGetItems.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            End If
            If strExcludedItems IsNot Nothing AndAlso strExcludedItems.Count > 0 Then
                clsGetItems.AddParameter("excluded_items", GetListAsRString(strExcludedItems.ToList()))
            End If
            expItems = RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)
            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                vecColumns = expItems.AsList
                For i = 0 To vecColumns.Count - 1
                    If vecColumns.Count > 1 Then
                        grps = New ListViewGroup(key:=vecColumns.Names(i), headerText:=vecColumns.Names(i))
                        lstView.Groups.Add(grps)
                    End If
                    chrCurrColumns = vecColumns(i).AsCharacter
                    If chrCurrColumns IsNot Nothing Then
                        For j = 0 To chrCurrColumns.Count - 1
                            lstView.Items.Add(chrCurrColumns(j))
                            lstView.Items(j).Tag = vecColumns.Names(i)
                            lstView.Items(j).ToolTipText = chrCurrColumns(j)
                            If vecColumns.Count > 1 Then
                                lstView.Items(j).Group = lstView.Groups(i)
                            End If
                        Next
                        If strType = "column" Then
                            strColumnsRList = GetListAsRString(chrCurrColumns.ToList)
                            clsGetColumnTypes.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_data_types")
                            clsGetColumnTypes.AddParameter("data_name", Chr(34) & vecColumns.Names(i) & Chr(34))
                            clsGetColumnTypes.AddParameter("columns", strColumnsRList)
                            expItems = RunInternalScriptGetValue(clsGetColumnTypes.ToScript(), bSilent:=True)
                            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                                strCurrColumnTypes = expItems.AsCharacter.ToArray
                            Else
                                strCurrColumnTypes = New String(chrCurrColumns.Count - 1) {}
                            End If
                            clsGetColumnLabels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_labels")
                            clsGetColumnLabels.AddParameter("data_name", Chr(34) & vecColumns.Names(i) & Chr(34))
                            clsGetColumnLabels.AddParameter("columns", strColumnsRList)
                            expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsGetColumnLabels.ToScript())
                            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                                strCurrColumnLables = expItems.AsCharacter.ToArray
                            Else
                                strCurrColumnLables = New String(chrCurrColumns.Count - 1) {}
                            End If
                            For j = 0 To chrCurrColumns.Count - 1
                                strTemp = strCurrColumnLables(j)
                                If strCurrColumnLables(j) <> "" Then
                                    lstView.Items(j).ToolTipText = lstView.Items(j).ToolTipText & vbNewLine & strTemp
                                End If
                                strTemp = strCurrColumnTypes(j)
                                If strTemp <> "" Then
                                    lstView.Items(j).ToolTipText = lstView.Items(j).ToolTipText & vbNewLine & strTemp
                                End If
                            Next
                        End If
                    End If
                Next
                lstView.Columns(0).Width = -2
                ' When there is a vertical scroll bar, Width = -2 makes it slightly wider than needed
                ' causing the horizontal scroll bar to display even when not needed.
                ' Reducing the Width by ~ 2 removes the horizontal scroll bar when it's not needed 
                ' and doesn't affect the visibility of the longest item
                ' This has been tested on high resolution screens but needs further testing
                ' and possibly a better solution.
                lstView.Columns(0).Width = lstView.Columns(0).Width - 2
                If strTopItemText <> "" Then
                    lviTemp = lstView.FindItemWithText(strTopItemText)
                    If lviTemp IsNot Nothing Then
                        lstView.TopItem = lviTemp
                    End If
                End If
            End If
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Selects the specified <paramref name="strDataFrameName"/> data frame columns in 
    '''             the <paramref name="ucrCurrentReceiver"/> receiver. 
    '''             Columns are specified by <paramref name="strProperty"/> property and 
    '''             <paramref name="strValues"/> values.</summary>
    '''
    ''' <param name="ucrCurrentReceiver">   The receiver to add the column names to (may be a single 
    '''                                     or multiple receiver). </param>
    ''' <param name="strDataFrameName">     The data frame name. </param>
    ''' <param name="strProperty">          Type of column to display in the receiver.
    '''                                     This is passed as a parameter to the R 'list' command. </param>
    ''' <param name="strValues">            List of column names to display in the receiver.
    '''                                     These are passed as 'include' parameters to
    '''                                     the R 'list' command. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SelectColumnsWithMetadataProperty(ucrCurrentReceiver As ucrReceiver, strDataFrameName As String, strProperty As String, strValues As String())
        Dim vecColumns As GenericVector
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim lstItems As New List(Of KeyValuePair(Of String, String))
        Dim expColumns As SymbolicExpression
        Dim ucrReceiverTempMultiple As ucrReceiverMultiple

        kvpInclude = New KeyValuePair(Of String, String())(strProperty, strValues)
        ucrCurrentReceiver.Selector.LoadList()
        If bInstatObjectExists Then
            clsGetItems.SetRCommand(strInstatDataObject & "$get_column_names")
            clsGetItems.AddParameter("as_list", "TRUE")
            If strDataFrameName <> "" Then
                clsGetItems.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            End If
            clsIncludeList.SetRCommand("list")
            clsIncludeList.AddParameter(kvpInclude.Key, GetListAsRString(kvpInclude.Value.ToList(), bWithQuotes:=False))
            clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)
            expColumns = RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)
            If expColumns IsNot Nothing AndAlso Not expColumns.Type = Internals.SymbolicExpressionType.Null Then
                vecColumns = expColumns.AsList
            Else
                vecColumns = Nothing
            End If
            ucrCurrentReceiver.Clear()
            If vecColumns IsNot Nothing Then
                For i = 0 To vecColumns.Count - 1
                    chrCurrColumns = vecColumns(i).AsCharacter
                    If chrCurrColumns Is Nothing Then
                        Continue For
                    End If
                    For Each strColumn As String In chrCurrColumns
                        lstItems.Add(New KeyValuePair(Of String, String)(strDataFrameName, strColumn))
                    Next
                Next
                If TypeOf ucrCurrentReceiver Is ucrReceiverSingle Then
                    If lstItems.Count > 0 Then
                        ucrCurrentReceiver.Add(lstItems(0).Value, lstItems(0).Key)
                    End If
                ElseIf TypeOf ucrCurrentReceiver Is ucrReceiverMultiple Then
                    ucrReceiverTempMultiple = DirectCast(ucrCurrentReceiver, ucrReceiverMultiple)
                    ucrReceiverTempMultiple.AddMultiple(lstItems.ToArray())
                End If
            End If
        End If
        ucrCurrentReceiver.Selector.LoadList()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets a single concatenated string containing all the strings in <paramref name="lstStrings"/>.
    '''             The returned string has the form "(str1,str2,str3, ...)". </summary>
    '''
    ''' <param name="lstStrings">   The list of strings to concatenate. </param>
    ''' <param name="bWithQuotes">  (Optional) If true then surround each string with quotes. </param>
    '''
    ''' <returns>   As single concatenated string containing all the strings in <paramref name="lstStrings"/>. </returns>
    '''--------------------------------------------------------------------------------------------
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Queries if a given data frame exists. </summary>
    '''
    ''' <param name="strDataFrameName"> The data frame name. </param>
    '''
    ''' <returns>   True if <paramref name="strDataFrameName"/> data frame exists, else false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function DataFrameExists(strDataFrameName As String) As Boolean
        Return _rEngine.HelperFunctions.DataFrameExists(strDataFrameName)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the data frame count. </summary>
    '''
    ''' <returns>   The data frame count. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataFrameCount() As Integer
        Dim iCount As Integer
        Dim clsDataFrameCount As New RFunction
        Dim expCount As SymbolicExpression

        clsDataFrameCount.SetRCommand(strInstatDataObject & "$dataframe_count")
        expCount = RunInternalScriptGetValue(clsDataFrameCount.ToScript(), bSilent:=True)
        If expCount IsNot Nothing AndAlso Not expCount.Type = Internals.SymbolicExpressionType.Null Then
            iCount = expCount.AsInteger(0)
        Else
            iCount = 0
        End If
        Return iCount
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the length of <paramref name="strDataFrameName"/> data frame. </summary>
    '''
    ''' <param name="strDataFrameName">     The name of the data frame. </param>
    ''' <param name="bUseCurrentFilter">    (Optional) The value for the R 'use_current_filter' 
    '''                                     parameter. </param>
    '''
    ''' <returns>   The data frame length. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataFrameLength(strDataFrameName As String, Optional bUseCurrentFilter As Boolean = False) As Integer
        Dim iLength As Integer
        Dim clsDataFrameLength As New RFunction
        Dim expLength As SymbolicExpression

        clsDataFrameLength.SetRCommand(strInstatDataObject & "$get_data_frame_length")
        clsDataFrameLength.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        If bUseCurrentFilter Then
            clsDataFrameLength.AddParameter("use_current_filter", "TRUE")
        Else
            clsDataFrameLength.AddParameter("use_current_filter", "FALSE")
        End If
        expLength = RunInternalScriptGetValue(clsDataFrameLength.ToScript(), bSilent:=True)
        If expLength IsNot Nothing AndAlso Not expLength.Type = Internals.SymbolicExpressionType.Null Then
            iLength = expLength.AsInteger(0)
        Else
            iLength = 0
        End If
        Return iLength
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the number of columns in the <paramref name="strDataFrameName"/> data 
    '''             frame. </summary>
    '''
    ''' <param name="strDataFrameName"> The data frame name. </param>
    '''
    ''' <returns>   The number of columns in the <paramref name="strDataFrameName"/> data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataFrameColumnCount(strDataFrameName As String) As Integer
        Dim iColumnCount As Integer
        Dim clsDataFrameColCount As New RFunction
        Dim expCount As SymbolicExpression

        clsDataFrameColCount.SetRCommand(strInstatDataObject & "$get_column_count")
        clsDataFrameColCount.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expCount = RunInternalScriptGetValue(clsDataFrameColCount.ToScript(), bSilent:=True)
        If expCount IsNot Nothing AndAlso Not expCount.Type = Internals.SymbolicExpressionType.Null Then
            iColumnCount = expCount.AsInteger(0)
        Else
            iColumnCount = 0
        End If
        Return iColumnCount
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's models. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's models. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetModelNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_model_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's tables. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's tables. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetTableNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_table_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's filters. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's filters. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetFilterNames(strDataFrameName As String) As List(Of String)
        Return GetNames(strDataFrameName, "$get_filter_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's column selection. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's column selection. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetColumnSelectionNames(strDataFrameName As String) As List(Of String)
        Return GetNames(strDataFrameName, "$get_column_selection_names")
    End Function
    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's graphs. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's graphs. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetGraphNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_graph_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's survs. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's survs. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetSurvNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_surv_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's keys. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's survs. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetKeyNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_key_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's links. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's survs. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetLinkNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_link_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the table, filter, graph, key, surv or link names of the <paramref name="strDataFrameName"/> 
    '''             data frame depending on the <paramref name="strRCommand"/>. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    ''' <param name="strRCommand">(Optional)The name of the Rfunction command.</param>
    '''
    ''' <returns>   The table,filter,graph,key,surv or link names of the <paramref name="strDataFrameName"/> 
    '''             data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function GetNames(strDataFrameName As String, strRCommand As String) As List(Of String)
        Dim lstNames As New List(Of String)
        Dim clsGetNames As New RFunction
        Dim expNames As SymbolicExpression

        clsGetNames.SetRCommand(strInstatDataObject & strRCommand)

        If strDataFrameName <> "" Then
            clsGetNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expNames = RunInternalScriptGetValue(clsGetNames.ToScript(), bSilent:=True)
        If expNames IsNot Nothing AndAlso Not expNames.Type = Internals.SymbolicExpressionType.Null Then
            lstNames = expNames.AsCharacter.ToArray.ToList
        End If
        Return lstNames
    End Function


    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the data type of the <paramref name="strColumnName"/> column in the 
    '''             <paramref name="strDataFrameName"/> data frame. </summary>
    '''
    ''' <param name="strDataFrameName"> The data frame name. </param>
    ''' <param name="strColumnName">    The column name. </param>
    '''
    ''' <returns>   The data type of the <paramref name="strColumnName"/> column in the
    '''             <paramref name="strDataFrameName"/> data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataType(strDataFrameName As String, strColumnName As String) As String
        'TODO SJL 22/04/20 What's the difference between this function and the function below? Could we delete one?
        Dim strDataType As String
        Dim clsGetDataType As New RFunction
        Dim expType As SymbolicExpression

        clsGetDataType.SetRCommand(strInstatDataObject & "$get_data_type")
        clsGetDataType.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        clsGetDataType.AddParameter("col_name", Chr(34) & strColumnName & Chr(34))
        expType = RunInternalScriptGetValue(clsGetDataType.ToScript(), bSilent:=True)
        If expType IsNot Nothing AndAlso Not expType.Type = Internals.SymbolicExpressionType.Null Then
            strDataType = expType.AsCharacter(0)
        Else
            strDataType = ""
        End If
        Return strDataType
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the data type of the <paramref name="strColumnName"/> column in the 
    '''             <paramref name="strDataName"/> data frame. </summary>
    '''
    ''' <param name="strDataName"> The data frame name. </param>
    ''' <param name="strColumnName">    The column name. </param>
    '''
    ''' <returns>   The data type of the <paramref name="strColumnName"/> column in the
    '''             <paramref name="strDataName"/> data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetColumnType(strDataName As String, strColumnName As String) As String
        Dim strDataType As String
        Dim clsGetColumnType As New RFunction
        Dim expDateType As SymbolicExpression

        clsGetColumnType.SetRCommand(strInstatDataObject & "$get_column_data_types")
        clsGetColumnType.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumnType.AddParameter("columns", Chr(34) & strColumnName & Chr(34))
        expDateType = RunInternalScriptGetValue(clsGetColumnType.ToScript(), bSilent:=True)
        If expDateType IsNot Nothing AndAlso expDateType.Type <> Internals.SymbolicExpressionType.Null Then
            strDataType = String.Join(",", expDateType.AsCharacter)
        Else
            strDataType = ""
        End If
        Return strDataType
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Makes a syntactically valid R name from <paramref name="strText"/>. Please see 
    '''             the R documentation for valid name syntax.<para>
    '''             If it's not possible to make a valid name from <paramref name="strText"/> then 
    '''             returns "".</para> </summary>
    '''
    ''' <param name="strText">  The name to convert to a valid name. </param>
    '''
    ''' <returns>   A syntactically valid R name derived from <paramref name="strText"/>. 
    '''             If it's not possible to make a valid name from <paramref name="strText"/> then
    '''             returns "".</returns>
    '''--------------------------------------------------------------------------------------------
    Public Function MakeValidText(strText As String) As String
        Dim strOut As String
        Dim clsMakeNames As New RFunction
        Dim expOut As SymbolicExpression

        clsMakeNames.SetRCommand("make.names")
        clsMakeNames.AddParameter("names", Chr(34) & strText & Chr(34))
        expOut = RunInternalScriptGetValue(clsMakeNames.ToScript(), bSilent:=True)
        If expOut IsNot Nothing AndAlso Not expOut.Type = Internals.SymbolicExpressionType.Null Then
            strOut = expOut.AsCharacter(0)
        Else
            strOut = ""
        End If
        Return strOut
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If <paramref name="strText"/> is a syntactically valid R name then returns true, 
    '''             else returns false. 
    '''             Please see the R documentation for valid name syntax. </summary>
    '''
    ''' <param name="strText">  The name to check. </param>
    '''
    ''' <returns>   True if <paramref name="strText"/> is a syntactically valid R name,
    '''             else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function IsValidText(strText As String) As String
        Dim strValidText As String
        Dim clsMakeNames As New RFunction

        strValidText = MakeValidText(strText)
        Return (strText = strValidText)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets corruption contract data frame names. </summary>
    '''
    ''' <returns>   The corruption contract data frame names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetCorruptionContractDataFrameNames() As List(Of String)
        Dim clsGetDataNames As New RFunction
        Dim lstNames As List(Of String)
        Dim expDataNames As SymbolicExpression

        clsGetDataNames.SetRCommand(strInstatDataObject & "$get_corruption_contract_data_names")
        expDataNames = RunInternalScriptGetValue(clsGetDataNames.ToScript(), bSilent:=True)
        If expDataNames IsNot Nothing AndAlso Not expDataNames.Type = Internals.SymbolicExpressionType.Null Then
            lstNames = expDataNames.AsCharacter.ToList()
        Else
            lstNames = New List(Of String)
        End If
        Return lstNames
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets corruption column of type <paramref name="strType"/> in data frame 
    '''             <paramref name="strDataName"/>. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    ''' <param name="strType">      The column type. </param>
    '''
    ''' <returns>   The corruption column of type <paramref name="strType"/> in data frame <paramref name="strDataName"/>. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetCorruptionColumnOfType(strDataName As String, strType As String) As String
        Dim clsGetColumnName As New RFunction
        Dim strColumn As String
        Dim expColumn As SymbolicExpression

        clsGetColumnName.SetRCommand(strInstatDataObject & "$get_corruption_column_name")
        clsGetColumnName.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumnName.AddParameter("type", strType)
        expColumn = RunInternalScriptGetValue(clsGetColumnName.ToScript(), bSilent:=True)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            strColumn = expColumn.AsCharacter(0)
        Else
            strColumn = ""
        End If
        Return strColumn
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets climatic column of type. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    ''' <param name="strType">      The column type. </param>
    '''
    ''' <returns>   The climatic column of type. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetClimaticColumnOfType(strDataName As String, strType As String) As String
        Dim clsGetColumnName As New RFunction
        Dim strColumn As String
        Dim expColumn As SymbolicExpression

        clsGetColumnName.SetRCommand(strInstatDataObject & "$get_climatic_column_name")
        clsGetColumnName.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumnName.AddParameter("col_name", strType)
        expColumn = RunInternalScriptGetValue(clsGetColumnName.ToScript(), bSilent:=True)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            strColumn = expColumn.AsCharacter(0)
        Else
            strColumn = ""
        End If
        Return strColumn
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets names of the columns of the corruption components in 
    '''             the <paramref name="strDataName"/> data frame. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    '''
    ''' <returns>   The names of the columns of the corruption components in
    '''             the <paramref name="strDataName"/> data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetCorruptionComponentsColumnNames(strDataName As String) As String()
        Return GetColumnNames(strDataName, "$get_CRI_component_column_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets CRI column names. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    '''
    ''' <returns>   The CRI column names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetCRIColumnNames(strDataName As String) As String()
        Return GetColumnNames(strDataName, "$get_CRI_column_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets red flag column names. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    '''
    ''' <returns>   The red flag column names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetRedFlagColumnNames(strDataName As String) As String()
        Return GetColumnNames(strDataName, "$get_red_flag_column_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets specific column names from the <paramref name="strDataFrameName"/> data 
    '''             frame as specified by the <paramref name="strRCommand"/> RFunction command name. 
    '''             </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    ''' <param name="strRCommand"> (Optional)The Rfunction's command name that specifies the column 
    '''                            names to get.</param>
    '''
    ''' <returns>   The column names of the <paramref name="strDataFrameName"/> data frame as 
    '''             specifed by <paramref name="strRCommand"/> RFunction command. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function GetColumnNames(strDataFrameName As String, strRCommand As String) As String()
        Dim clsGetColumnName As New RFunction
        Dim strColumn() As String
        Dim expColumn As SymbolicExpression

        clsGetColumnName.SetRCommand(strInstatDataObject & strRCommand)
        clsGetColumnName.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expColumn = RunInternalScriptGetValue(clsGetColumnName.ToScript(), bSilent:=True)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            strColumn = expColumn.AsCharacter.ToArray()
        Else
            strColumn = Nothing
        End If
        Return strColumn
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if column <paramref name="strColumn"/> in data frame 
    '''             <paramref name="strDataName"/> contains binary data. Else returns false. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    ''' <param name="strColumn">    The column. </param>
    '''
    ''' <returns>   True if column <paramref name="strColumn"/> in data frame
    '''             <paramref name="strDataName"/> contains binary data. Else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function IsBinary(strDataName As String, strColumn As String) As Boolean
        Dim clsGetColumn As New RFunction
        Dim clsIsBinary As New RFunction
        Dim bIsBinary As Boolean
        Dim expBinary As SymbolicExpression

        clsGetColumn.SetRCommand(strInstatDataObject & "$get_columns_from_data")
        clsGetColumn.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumn.AddParameter("col_names", Chr(34) & strColumn & Chr(34))
        clsIsBinary.SetRCommand("is.binary")
        clsIsBinary.AddParameter("x", clsRFunctionParameter:=clsGetColumn)
        expBinary = RunInternalScriptGetValue(clsIsBinary.ToScript())
        If expBinary IsNot Nothing AndAlso Not expBinary.Type = Internals.SymbolicExpressionType.Null Then
            bIsBinary = expBinary.AsLogical(0)
        Else
            bIsBinary = False
        End If
        Return bIsBinary
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if column <paramref name="strColumn"/> in data frame 
    '''             <paramref name="strDataName"/> has property <paramref name="strProperty"/>. 
    '''             Else returns false. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    ''' <param name="strProperty">  The property to look for. </param>
    ''' <param name="strColumn">    (Optional) The column name. </param>
    '''
    ''' <returns>   True if column <paramref name="strColumn"/> in data frame
    '''             <paramref name="strDataName"/> has property <paramref name="strProperty"/>.
    '''             Else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function IsVariablesMetadata(strDataName As String, strProperty As String, Optional strColumn As String = "") As Boolean
        Dim clsIsVarMetadata As New RFunction
        Dim bIsVarMetadata As Boolean
        Dim expIsVar As SymbolicExpression

        clsIsVarMetadata.SetRCommand(strInstatDataObject & "$is_variables_metadata")
        clsIsVarMetadata.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        If strColumn <> "" Then
            clsIsVarMetadata.AddParameter("column", Chr(34) & strColumn & Chr(34))
        End If
        clsIsVarMetadata.AddParameter("property", Chr(34) & strProperty & Chr(34))
        expIsVar = RunInternalScriptGetValue(clsIsVarMetadata.ToScript(), bSilent:=True)
        If expIsVar IsNot Nothing AndAlso expIsVar.Type <> Internals.SymbolicExpressionType.Null Then
            bIsVarMetadata = expIsVar.AsLogical(0)
        Else
            bIsVarMetadata = False
        End If
        Return bIsVarMetadata
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets whether to show the wait window (the window that is optionally displayed 
    '''             while an R script is running). </summary>
    '''
    ''' <param name="bNewShow"> If true then show the wait window. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetShowWaitDialog(bNewShow As Boolean)
        bShowWaitDialog = bNewShow
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the time in seconds to wait before showing the waiting dialog. </summary>
    '''
    ''' <param name="iTimeInSeconds">   The delay in seconds (must be >= 0). </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetWaitDelayTime(iTimeInSeconds As Integer)
        If iTimeInSeconds <= 0 Then
            MsgBox("Wait time must be a positive integer. Resetting to default of 2 seconds.", MsgBoxStyle.Exclamation, "Invalid value")
            iTimeInSeconds = 2
        End If
        ' _rEngine._waitDelay = iTimeInSeconds
        '  iWaitDelay = iTimeInSeconds
    End Sub

    ''' <summary>   Closes the current instat data object, and opens a new one. </summary>
    Public Sub CloseData()
        Dim clsRm As New RFunction
        Dim clsCreateIO As New ROperator

        clsRm.SetRCommand("rm")
        clsRm.AddParameter("0", strInstatDataObject, iPosition:=0, bIncludeArgumentName:=False)
        clsRm.AddParameter("1", strGraphDataBook, iPosition:=1, bIncludeArgumentName:=False)

        clsCreateIO.SetOperation("<-")
        clsCreateIO.AddParameter("left", strInstatDataObject, iPosition:=0)
        clsCreateIO.AddParameter("right", strDataBookClassName & "$new()", iPosition:=1)

        bInstatObjectExists = False
        RunScript(clsRm.ToScript(), strComment:="Closing data")
        bInstatObjectExists = True
        RunScript(clsCreateIO.ToScript(), strComment:="Creating New Instat Object")
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   View last graph. </summary>
    '''
    ''' <param name="bAsPlotly">    (Optional) If true then view last graph as plotly. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub ViewLastGraph(Optional bAsPlotly As Boolean = False)
        Dim clsLastGraph As New RFunction
        clsLastGraph.SetRCommand(strInstatDataObject & "$get_last_graph")

        If bAsPlotly Then
            Dim clsInteractivePlot As New RFunction
            clsLastGraph.AddParameter("print_graph", "FALSE", iPosition:=0)
            clsInteractivePlot.SetPackageName("plotly")
            clsInteractivePlot.SetRCommand("ggplotly")
            clsInteractivePlot.AddParameter("p", clsRFunctionParameter:=clsLastGraph, iPosition:=0)
            'Need to set iCallType = 2 to obtain a graph in an interactive viewer.
            RunScript(clsInteractivePlot.ToScript(), iCallType:=2, strComment:="View last graph as Plotly", bSeparateThread:=False)
        Else
            Dim strGlobalGraphDisplayOption As String
            'store the current set graph display option, to restore after display
            strGlobalGraphDisplayOption = Me.strGraphDisplayOption
            Me.strGraphDisplayOption = "view_R_viewer"
            RunScript(clsLastGraph.ToScript(), iCallType:=3, strComment:="View last graph", bSeparateThread:=False)
            'restore the graph display option
            Me.strGraphDisplayOption = strGlobalGraphDisplayOption
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Prefixes each line of text in <paramref name="strComment"/> with '# '. </summary>
    '''
    ''' <param name="strComment">   The comment text. </param>
    '''
    ''' <returns>   <paramref name="strComment"/> converted to a valid R comment. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetFormattedComment(strComment As String) As String
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   
    ''' Gets the list of clsRParameters from the <paramref name="strFunctionName"/> function 
    ''' definition. 
    ''' For example, the function "str_split(string, pattern, n = Inf, simplify = FALSE)" returns 
    ''' the following parameters:
    ''' <list type="bullet">
    '''     <item><description>
    '''             clsParameter 1: Argument Name ="string" , Parameter position = 0 , Default value = NOTHING 
    '''     </description></item><item><description>
    '''             clsParameter 2: Argument Name = "patterm" , Parameter position = 1 , Default value = NOTHING
    '''     </description></item><item><description>
    '''             clsParameter 3: Argument Name="n" , Parameter position = 2 , Default value = "Inf"
    '''     </description></item><item><description>
    '''             clsParameter 4: Argument Name="simplify" , Parameter position = 3 , Default value = "FALSE")
    '''     </description></item>
    ''' </list></summary>
    ''' 
    ''' <param name="strFunctionName">  The function name provided. </param>
    '''
    ''' <returns>   The list of clsRParameters. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function GetRFunctionDefinitionParameters(strFunctionName As String) As List(Of clsRParameter)
        'Note: this function is not currently called but it will be used in future
        '      functionality to populate dialogs from script.
        '      Please do not delete this function. (@lloyddewit 24/11/21)

        'temporary object that retrieves the output from the environment
        Dim strTempAssignTo As String = ".temp_func"
        Dim expTemp As SymbolicExpression
        Dim clsFormalsFunction As New RFunction
        Dim lstRParameters As New List(Of clsRParameter)
        Dim clsAsListFunction As New RFunction

        clsAsListFunction.SetRCommand("as.list")
        clsAsListFunction.AddParameter(clsRFunctionParameter:=clsFormalsFunction, bIncludeArgumentName:=False, iPosition:=0)

        'The 'formals' function returns the parameters for a specified function. 
        'for example, for the function "str_split(string, pattern, n = Inf, simplify = FALSE)", formals returns
        '    $string
        '    $pattern 
        '    $n 
        '    [1] Inf 
        '    $simplify 
        '    [1] FALSE 
        clsFormalsFunction.SetRCommand("formals")
        clsFormalsFunction.AddParameter(strParameterValue:=strFunctionName, bIncludeArgumentName:=False, iPosition:=0)

        'TODO check that the fuction name provided has no pening and closing brackets at the end
        '?QUESTION /CLARIFICATION Parameters value fror the function  ?gt::cols_merge() are being split into different parts
        'TODO code removed in order seperate RLink
        'If Not Evaluate(strTempAssignTo & " <- " & "capture.output(" & clsAsListFunction.ToScript() & ")", bSilent:=True) Then
        '    'Error getting the parameters either the function name provided is incorrect/package containing the function isn't loaded 
        '    Return Nothing
        'End If
        'expTemp = GetSymbol(strTempAssignTo)
        'Evaluate("rm(" & strTempAssignTo & ")", bSilent:=True)


        If expTemp Is Nothing Then
            Return Nothing
        End If
        Dim iNewArgPosition As Integer = 0
        'parameter name position
        Dim iParameterName As Integer = 0
        'parameter value position
        Dim iParameterValue As Integer = 1
        While (iParameterName < expTemp.AsCharacter().Length)
            Dim clsNewRParameter As New clsRParameter

            'Assign the parameter Name
            clsNewRParameter.strArgName = expTemp.AsCharacter(iParameterName).TrimStart("$")
            'Adding the parameter value
            'check to remove the [1] notation before some parameter values
            If expTemp.AsCharacter(iParameterValue).Contains("[1]") Then
                Dim strcleanArgument As String = expTemp.AsCharacter(iParameterValue).Remove(expTemp.AsCharacter(iParameterValue).IndexOf("["), 3)
                clsNewRParameter.clsArgValueDefault = New clsRScript(strcleanArgument).lstRStatements(0).clsElement
            Else
                'Empty String are Not accepted hence the modification below
                If String.IsNullOrEmpty(expTemp.AsCharacter(iParameterValue)) Then
                    clsNewRParameter.clsArgValueDefault = New clsRScript("NODEFAULTVALUE").lstRStatements(0).clsElement
                Else
                    clsNewRParameter.clsArgValueDefault = New clsRScript(expTemp.AsCharacter(iParameterValue)).lstRStatements(0).clsElement
                End If

            End If
            'Assign the parameter Value
            clsNewRParameter.iArgPosDefinition = iNewArgPosition

            'TEMPORARY FUNCTIONALITY FOR PRESENTATION
            Console.WriteLine("PARAMETER" & clsNewRParameter.iArgPosDefinition)
            Console.WriteLine("..strArgumentName:" & clsNewRParameter.strArgName)
            Console.WriteLine("..strArgumentValue:" & clsNewRParameter.clsArgValueDefault.strTxt)
            Console.WriteLine("..ArgumentPosition:" & clsNewRParameter.iArgPosDefinition)

            iNewArgPosition += 1
            iParameterName += 3
            iParameterValue += 3
            lstRParameters.Add(clsNewRParameter)
        End While

        Return lstRParameters
    End Function
End Class
