﻿' R- Instat
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

Imports instat.Translations
Public Class dlgUseGraph
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsUseGraphFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsThemeFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabsFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsFacetsFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)

    Private Sub dlgUseGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 430
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrGraphsSelector.SetParameter(New RParameter("data_name", 0))
        ucrGraphsSelector.SetParameterIsString()

        ucrGraphReceiver.SetParameter(New RParameter("object_name", 1))
        ucrGraphReceiver.Selector = ucrGraphsSelector
        ucrGraphReceiver.strSelectorHeading = "Graphs"
        ucrGraphReceiver.SetParameterIsString()
        ucrGraphReceiver.SetItemType(RObjectTypeLabel.Graph)

        'Theme Tab Checkboxes under grpCommonOptions
        ucrChkLegendPosition.SetText("Legend Position")
        ucrChkLegendPosition.AddToLinkedControls(ucrInputLegendPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegendPosition.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegendPosition.AddParameterPresentCondition(False, "legend.position", False)
        ucrChkLegendPosition.SetLinkedDisplayControl(grpLegend)

        ucrSaveGraph.SetPrefix("use_graph")
        ucrSaveGraph.SetSaveType(strRObjectType:=RObjectTypeLabel.Graph,
                                 strRObjectFormat:=RObjectFormat.Image)
        ucrSaveGraph.SetDataFrameSelector(ucrGraphsSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Store New Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsUseGraphFunction = New RFunction
        clsBaseOperator = New ROperator

        ucrGraphReceiver.SetMeAsReceiver()
        ucrGraphsSelector.Reset()
        ucrSaveGraph.Reset()

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsUseGraphFunction, iPosition:=0)

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsFacetsFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsUseGraphFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

        clsBaseOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                           strRDataFrameNameToAddObjectTo:=ucrGraphsSelector.strCurrentDataFrame,
                                           strObjectName:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrGraphsSelector.SetRCode(clsUseGraphFunction, bReset)
        ucrGraphReceiver.SetRCode(clsUseGraphFunction, bReset)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrGraphReceiver.IsEmpty AndAlso ucrSaveGraph.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions,
                          clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                          clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabsFunction, clsNewFacetFunction:=clsFacetsFunction,
                          ucrNewBaseSelector:=ucrGraphsSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegendPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrGraphReceiver.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrChkLegendPosition.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class