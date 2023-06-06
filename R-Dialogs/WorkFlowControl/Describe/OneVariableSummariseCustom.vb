Imports R_Adapter2.R_Adapter.ScriptBuilder

Public Class OneVariableSummariseCustom

    ' Private addAndGetObject As  
    Private RCode As RWorkFlow



    'should be able to push values to controls if to be run from right click in grids
    Private dataframeSelector As New DataFrameSelector
    Private coloumnSelector As New ColumnSelector(dataframeSelector)
    Private maxLevelsSelector As New NumberSelector(12, 999)
    Private summaryNameSelector As New TextSelector("last_summary")

    Private placeHolderControl As New DataFrameSelector

    Public Sub PopulateScripts()
        RCode = New RWorkFlow

        RCode.PreScript = New RFunction
        RCode.PreScript.SetDataBookCommand("summary_table")
        RCode.PreScript.SetAssignTo(summaryNameSelector.GetParameter)
        RCode.PreScript.AddParameter("data_name", dataframeSelector.GetParameterWithQuotes)
        RCode.PreScript.AddParameter("treat_columns_as_factor", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("na.rm", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("margins", "summary")
        RCode.PreScript.AddParameter("include_margins", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("margin_name", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("summaries", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("na_type", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("na_max_prop", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("columns_to_summarise", coloumnSelector.GetParameterWithQuotes)
        RCode.PreScript.AddParameter("na_max_n", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("na_consecutive_n", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("na_min_n", placeHolderControl.GetParameter)
        RCode.PreScript.AddParameter("j", placeHolderControl.GetParameter)

        RCode.Script = New RFunction
        RCode.Script.SetPackageRCommand("mmtable2", "mmtable")
        RCode.Script.SetAssignTo("last_table")
        RCode.Script.AddParameter("data", summaryNameSelector.GetParameter)
        RCode.Script.AddParameter("cells", "value")
        RCode.Script.AddParameterAsPlus() 'Will pass in control here
        RCode.Script.AddParameterAsPlus() 'Will pass in control here
    End Sub
End Class
