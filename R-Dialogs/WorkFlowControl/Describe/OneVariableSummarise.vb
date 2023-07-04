Imports R_Adapter2.R_Adapter.Enum
Imports R_Adapter2.R_Adapter.ScriptBuilder

Public Class OneVariableSummarise

    Private preScript As String
    Private script As String
    Private addScript As String
    Private getScript As String
    Private cleanUpScript As String
    Private script2 As RFunction

    Public RCode As RWorkFlow


    Public dataframeSelector As New DataFrameSelector
    Public coloumnSelector As New ColumnSelector(dataframeSelector)
    Public maxLevelsSelector As New NumberSelector(12, 999)
    Public summaryNameSelector As New TextSelector("last_summary")

    Public Sub New()

    End Sub
    Public Sub PopulateScripts()
        RCode = New RWorkFlow

        RCode.SetDatabookObjectLog(RObjectTypeLabel.Summary, RObjectFormat.Text, True)

        RCode.Script = New RFunction
        RCode.Script.SetBasicRCommand("summary")
        RCode.Script.SetAssignTo(summaryNameSelector.GetParameter)
        RCode.Script.AddParameter("object", coloumnSelector.GetRFunction)
        RCode.Script.AddParameter("na.rm", "FALSE")
        RCode.Script.AddParameter("maxsum", maxLevelsSelector.GetParameter)

    End Sub
End Class
