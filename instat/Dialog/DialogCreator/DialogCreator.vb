Imports R_Adapter2.R_Adapter.RLink
Imports R_Dialogs

Public Class DialogCreator
    Public clsScriptRunner As ScriptRunner = ScriptRunner.SingletonInstance
    Public Function CreateOneVariableSummariseDialog() As Form

        'Create dialog passing OneVariableSummarise
        Dim summariseControls As New OneVariableSummarise
        Dim summariseDialog As New DialogTemplate()
        summariseDialog.Initalize(summariseControls)

        Dim dataframeSelector As New dataframeSelectorControl
        dataframeSelector.Initialize(summariseControls.dataframeSelector)
        summariseDialog.AddControl(dataframeSelector, 0, 0, 1, 2)

        Dim columnSelector As New columnSelectorControl
        columnSelector.Initialize(summariseControls.coloumnSelector)
        summariseDialog.AddControl(columnSelector, 0, 1, 2, 3)

        Return summariseDialog
    End Function


    Public Sub Test()
        Dim summariseControls As New OneVariableSummarise
        summariseControls.dataframeSelector.Selected = summariseControls.dataframeSelector.DataFrames(0)
        summariseControls.coloumnSelector.Selected = New List(Of String)
        summariseControls.coloumnSelector.Selected.Add(summariseControls.coloumnSelector.Columns(0))
        summariseControls.PopulateScripts()

        clsScriptRunner.RunRWorkflow(summariseControls.RCode)

    End Sub


End Class
