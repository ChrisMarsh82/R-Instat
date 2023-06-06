Imports R_Adapter2.R_Adapter.ScriptBuilder

Public Class OneVariableSummarise

    Private preScript As String
    Private script As String
    Private addScript As String
    Private getScript As String
    Private cleanUpScript As String
    Private script2 As RFunction

    Private RCode As RWorkFlow


    Private dataframeSelector As New DataFrameSelector
    Private coloumnSelector As New ColumnSelector(dataframeSelector)
    Private maxLevelsSelector As New NumberSelector(12, 999)
    Private summaryNameSelector As New TextSelector("last_summary")

    Public Sub New()

    End Sub
    Public Sub PopulateScripts()
        RCode = New RWorkFlow



        RCode.Script = New RFunction
        RCode.Script.SetBasicRCommand("summary")
        RCode.Script.SetAssignTo(summaryNameSelector.GetParameter)
        RCode.Script.AddParameter("object", coloumnSelector.GetRFunction)
        RCode.Script.AddParameter("na.rm", "FALSE")
        RCode.Script.AddParameter("maxsum", maxLevelsSelector.GetParameter)






        'addScript = "data_book$add_object(data_name=" + dataframeSelector.GetParameterWithQuotes +
        '            ", object_name=" + summaryNameSelector.GetParameterWithQuotes +
        '            ", object_type_label='summary', object_format='text', object=" + summaryNameSelector.GetParameter + ")"
        'getScript = "data_book$get_object_data(data_name=" + summaryNameSelector.GetParameterWithQuotes +
        '            ", object_name=" + summaryNameSelector.GetParameterWithQuotes + ", as_file=TRUE)"
        'cleanUpScript = "rm(" + summaryNameSelector.GetParameter + ")"


        ' fullScript = script2.GetScript
        'fullScript = +script2.GetAddScript("summary", "text")
        ' fullScript = +script2.GetGetScript(True)
        ' fullScript = script2.CleanUpScript
    End Sub
End Class
