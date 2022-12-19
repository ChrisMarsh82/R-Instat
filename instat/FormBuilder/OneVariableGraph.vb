Public Class OneVariableGraph
    'Should be using builder and directory patterns

    Private RCode = "$graph_one_variable"

    Private Parameters As List(Of ParameterControl)

    Public Sub New()
        Parameters = New List(Of ParameterControl)
        Dim selector As ucrSelectorByDataFrameAddRemove = GetSelectorByDataFrameAddRemove()
        Parameters.Add(New ParameterControl("", GetReceiverMultiple(selector))
        Parameters.Add(New ParameterControl("", GetPanel))
        Parameters.Add(New ParameterControl("", GetCheck))
        Parameters.Add(New ParameterControl("", GetSave))
    End Sub

    Private Function GetSelectorByDataFrameAddRemove() As ucrSelectorByDataFrameAddRemove
        Dim selectorByDataframe As New ucrSelectorByDataFrameAddRemove()
        selectorByDataframe.SetParameter(New RParameter("data_name", 0))
        selectorByDataframe.SetParameterIsString()
        Return selectorByDataframe
    End Function

    Private Function GetReceiverMultiple(selector As ucrSelector) As ucrReceiverMultiple
        Dim receiverMultiple As New ucrReceiverMultiple()
        receiverMultiple.SetParameter(New RParameter("columns", 1))
        receiverMultiple.SetParameterIsString()
        receiverMultiple.Selector = selector
        receiverMultiple.SetMeAsReceiver()
        Return receiverMultiple
    End Function

    Private Function GetPanel() As UcrPanel
        Dim panel As New UcrPanel()
        panel.SetParameter(New RParameter("output", 4))
        'To do add comboboxes
        ' panel.AddRadioButton(rdoFacets, Chr(34) & "facets" & Chr(34))
        ' panel.AddRadioButton(rdoCombine, Chr(34) & "combine" & Chr(34))
        ' panel.AddRadioButton(rdoSingleGraphs, Chr(34) & "single" & Chr(34))
        panel.SetRDefault(Chr(34) & "facets" & Chr(34))
        Return panel
    End Function


    Private Function GetCheck() As ucrCheck
        Dim check As New ucrCheck
        check.SetParameter(New RParameter("coord_flip", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        check.SetText("Flip Coordinates")
        check.SetRDefault("FALSE")
        Return check
    End Function


    Private Function GetSave() As ucrSave
        Dim save As New ucrSave()
        save.SetPrefix("one_var")
        save.SetSaveTypeAsGraph()
        'ToDo dataframe
        ' save.SetDataFrameSelector(ucrSelectorOneVarGraph.ucrAvailableDataFrames)
        save.SetCheckBoxText("Save Graph")
        save.SetIsComboBox()
        save.SetAssignToIfUncheckedValue("last_graph")
        Return save
    End Function

End Class
