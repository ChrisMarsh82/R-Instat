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

Imports RDotNet
Imports instat.Translations
Public Class dlgScript
    Private strComment As String = "Code generated by the dialog, Script"
    Private bFirstload As Boolean = True
    Private clsSaveDataFunction As New RFunction
    Private clsGetRObjectFunction As New RFunction
    Private dctOutputObjectTypes As New Dictionary(Of String, String)
    Private dctOutputObjectFormats As New Dictionary(Of String, String)

    Private Sub dlgScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            SetDefaults()
            bFirstload = False
        End If

        If lstExampleCollection.SelectedItems.Count > 0 Then
            'make the listview have the focus
            lstExampleCollection.Select()
            'set the selected item to be visible 
            lstExampleCollection.TopItem = lstExampleCollection.Items(lstExampleCollection.Items.IndexOf(lstExampleCollection.SelectedItems.Item(0)))
        End If

        autoTranslate(Me)
        EnableHelp()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 180

        ' Supported output object types and formats
        dctOutputObjectTypes.Add("Summary", RObjectTypeLabel.Summary)
        dctOutputObjectTypes.Add("Table", RObjectTypeLabel.Table)
        dctOutputObjectTypes.Add("Graph", RObjectTypeLabel.Graph)
        dctOutputObjectTypes.Add("Model", RObjectTypeLabel.Model)
        dctOutputObjectTypes.Add("Structure", RObjectTypeLabel.StructureLabel)

        dctOutputObjectFormats.Add("Image", RObjectFormat.Image)
        dctOutputObjectFormats.Add("Text", RObjectFormat.Text)
        dctOutputObjectFormats.Add("Html", RObjectFormat.Html)

        '--------------------------------
        'save controls
        ucrPnlSaveData.AddRadioButton(rdoSaveDataFrame)
        ucrPnlSaveData.AddRadioButton(rdoSaveColumn)
        ucrPnlSaveData.AddRadioButton(rdoSaveOutputObject)

        ucrCboSaveOutputObjectType.SetItems(dctOutputObjectTypes, bSetConditions:=False)
        ucrCboSaveOutputObjectType.SetDropDownStyleAsNonEditable()
        ucrCboSaveOutputObjectType.SetLinkedDisplayControl(lblSaveObjectType)
        ucrCboSaveOutputObjectType.GetSetSelectedIndex = 0

        ucrCboSaveOutputObjectFormat.SetItems(dctOutputObjectFormats, bSetConditions:=False)
        ucrCboSaveOutputObjectFormat.SetDropDownStyleAsNonEditable()
        ucrCboSaveOutputObjectFormat.SetLinkedDisplayControl(lblSaveObjectFormat)
        ucrCboSaveOutputObjectFormat.GetSetSelectedIndex = 0

        ucrSaveObject.SetLabelText("Save Graph")
        ucrSaveObject.SetIsComboBox()
        ucrSaveObject.SetDataFrameSelector(ucrDataFrameSaveOutputSelect)

        'ucrInputSaveDataFrame.SetLinkedDisplayControl(lblSaveDataFrame)
        ucrPnlSaveDataFrame.AddRadioButton(rdoDataFrame)
        ucrPnlSaveDataFrame.AddRadioButton(rdoFromRFile)

        ucrChkSaveDataFrameSingle.SetText("Single")


        ucrChkDisplayGraph.SetText("Display Output")

        '--------------------------------
        'Get data controls

        ucrPnlGetData.AddRadioButton(rdoGetDataFrame)
        ucrPnlGetData.AddRadioButton(rdoGetColumn)
        ucrPnlGetData.AddRadioButton(rdoGetOutputObject)

        ucrDataFrameGetDF.SetLabelText("Get Data Frame:")

        ucrReceiverGetColumns.Selector = ucrSelectorGetObject
        ucrReceiverGetColumns.SetLinkedDisplayControl(lblGetColumn)

        ucrCboGetOutputObjectType.SetItems(dctOutputObjectTypes, bSetConditions:=False)
        ucrCboGetOutputObjectType.SetDropDownStyleAsNonEditable()
        ucrCboGetOutputObjectType.SetLinkedDisplayControl(lblGetObjectType)
        ucrCboGetOutputObjectType.GetSetSelectedIndex = 0

        ucrReceiverGetOutputObject.Selector = ucrSelectorGetObject
        ucrReceiverGetOutputObject.SetLinkedDisplayControl(lblGetOutputObject)

        '--------------------------------
        ' Command controls

        'todo. this combo box can be a custom package control in future. Its also needed in dlgHelpVignettes
        ucrCboCommandPackage.SetParameter(New RParameter("package", 0))
        ucrCboCommandPackage.SetItems(GetPackages(), bAddConditions:=True)
        ucrCboCommandPackage.SetDropDownStyleAsNonEditable()

        ucrCboCommandDataPackage.SetParameter(New RParameter("package", 0))
        ucrCboCommandDataPackage.SetItems(GetPackages(), bAddConditions:=True)
        ucrCboCommandDataPackage.SetDropDownStyleAsNonEditable()

        ucrChkOpenRFile.SetText("Open R File")

        ucrChkInto.SetText("Into:")

        ucrChkWindow.SetText("Multiple Graphs:")

        ucrInputGgplotify.SetLinkedDisplayControl(lblGraphObject)
        ucrInputGraphCommand.SetLinkedDisplayControl(lblGraphCommand)

        ucrPnlCommands.AddRadioButton(rdoCommandPackage)
        ucrPnlCommands.AddRadioButton(rdoCommandObject)
        ucrPnlCommands.AddRadioButton(rdoGgplotify)
        ucrPnlCommands.AddRadioButton(rdoChooseFile)
        ucrPnlCommands.AddRadioButton(rdoViewData)
        ucrPnlCommands.AddRadioButton(rdoListData)
        ucrPnlCommands.AddRadioButton(rdoWindow)

        '--------------------------------
        'Get example controls
        ucrPnlExample.AddRadioButton(rdoExampleData)
        ucrPnlExample.AddRadioButton(rdoExampleFunction)

        ucrCboExamplePackages.SetItems(GetPackages(), bAddConditions:=False)
        ucrCboExamplePackages.SetDropDownStyleAsNonEditable()

        '-------------------------------
        ' base buttons controls not supported in this dialog
        ucrBase.bAppendScriptsAtCurrentScriptWindowCursorPosition = True

        ' hide controls not supported in this dialog
        ucrBase.chkComment.Checked = False
        ucrBase.chkComment.Visible = False
        ucrBase.txtComment.Visible = False
        ucrBase.bAddScriptToScriptWindowOnClickOk = False
        ucrBase.bMakeVisibleScriptWindow = False

    End Sub

    'todo. this function should eventually be removed once we have a control that displays packages
    Private Function GetPackages() As String()
        Dim arrAvailablePackages() As String = {}
        Dim clsGetPackages As New RFunction
        clsGetPackages.SetRCommand("get_installed_packages_with_data")
        clsGetPackages.AddParameter("with_data", "FALSE")
        Dim expPackageNames As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsGetPackages.ToScript(), bSeparateThread:=False, bSilent:=True)
        If expPackageNames IsNot Nothing AndAlso expPackageNames.Type <> Internals.SymbolicExpressionType.Null Then
            arrAvailablePackages = expPackageNames.AsCharacter.ToArray
            Array.Sort(arrAvailablePackages)
        End If
        Return arrAvailablePackages
    End Function

    Private Sub SetDefaults()
        clsGetRObjectFunction = New RFunction
        ' Examples controls
        rdoExampleData.Checked = True

        ' Command controls
        rdoCommandPackage.Checked = True
        ucrCboCommandPackage.GetSetSelectedIndex = -1
        ucrCboCommandDataPackage.GetSetSelectedIndex = -1

        ucrInputRemoveObjects.Reset()

        ' Save controls reset
        ucrSaveObject.SetRCode(clsSaveDataFunction, True)
        ucrSaveObject.Reset()
        rdoSaveDataFrame.Checked = True
        ucrChkSaveDataFrameSingle.Checked = True
        ucrChkDisplayGraph.Checked = True
        ucrChkOpenRFile.Checked = False
        ucrChkInto.Checked = False
        ucrChkWindow.Checked = True
        ucrDataFrameSaveOutputSelect.Reset()

        ' Get controls reset
        ucrSelectorGetObject.Reset()
        ucrCboGetOutputObjectType.GetSetSelectedIndex = 0
        ucrDataFrameGetDF.Reset()
        rdoGetDataFrame.Checked = True
        rdoDataFrame.Checked = True


        'activate the selected tab to library tab
        tbFeatures.SelectedIndex = -1
        tbFeatures.SelectedTab = tbPageSaveData

    End Sub

    Private Sub ucrPnlSaveData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSaveData.ControlValueChanged
        ucrDataFrameSaveOutputSelect.SetVisible(False)
        ucrCboSaveOutputObjectType.SetVisible(False)
        ucrCboSaveOutputObjectFormat.SetVisible(False)
        ucrSaveObject.SetVisible(False)
        ucrChkDisplayGraph.Visible = False
        ucrPnlSaveDataFrame.SetVisible(False)
        If rdoSaveDataFrame.Checked Then
            'ucrInputSaveDataFrame.SetVisible(True)
            ' ucrChkSaveDataFrameSingle.SetVisible(True)
            ucrPnlSaveDataFrame.SetVisible(True)
            VisiilityOfControls()
            ucrChkDisplayGraph.Visible = False
            ucrInputSaveDataFrame.SetName("")
        ElseIf rdoSaveColumn.Checked Then
            ucrSaveObject.Location = New Point(ucrSaveObject.Location.X, ucrCboSaveOutputObjectType.Location.Y)
            ucrSaveObject.SetVisible(True)
            ucrDataFrameSaveOutputSelect.SetVisible(True)
            ucrChkDisplayGraph.Visible = False
            ucrInputSaveRFile.SetVisible(False)
            ucrInputSaveDataFrame.SetVisible(False)
            ucrChkSaveDataFrameSingle.SetVisible(False)
            ucrPnlSaveDataFrame.SetVisible(False)
            SetupSaveDataControl("Column", RObjectTypeLabel.Column, "")
        ElseIf rdoSaveOutputObject.Checked Then
            ucrSaveObject.Location = New Point(ucrSaveObject.Location.X, ucrCboSaveOutputObjectFormat.Location.Y + 33)
            ucrSaveObject.SetVisible(True)
            ucrDataFrameSaveOutputSelect.SetVisible(True)
            ucrChkDisplayGraph.Visible = True
            ucrCboSaveOutputObjectType.SetVisible(True)
            ucrInputSaveRFile.SetVisible(False)
            ucrInputSaveDataFrame.SetVisible(False)
            ucrCboSaveOutputObjectFormat.SetVisible(True)
            ucrChkSaveDataFrameSingle.SetVisible(False)
            ucrPnlSaveDataFrame.SetVisible(False)
            SetupSaveDataControl(ucrCboSaveOutputObjectType.GetText(), dctOutputObjectTypes.Item(ucrCboSaveOutputObjectType.GetText()), dctOutputObjectFormats.Item(ucrCboSaveOutputObjectFormat.GetText()))
        End If
    End Sub

    Private Sub ucrCboSaveOutputObjectType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSaveOutputObjectType.ControlValueChanged, ucrCboSaveOutputObjectFormat.ControlValueChanged
        If Not ucrCboSaveOutputObjectType.IsEmpty() AndAlso Not ucrCboSaveOutputObjectFormat.IsEmpty() Then
            SetupSaveDataControl(ucrCboSaveOutputObjectType.GetText(), dctOutputObjectTypes.Item(ucrCboSaveOutputObjectType.GetText()), dctOutputObjectFormats.Item(ucrCboSaveOutputObjectFormat.GetText()))
        End If
    End Sub

    Private Sub SetupSaveDataControl(strLabel As String, strDataType As String, strFormat As String)
        ucrSaveObject.SetSaveType(strDataType, strFormat)
        ucrSaveObject.SetLabelText(strLabel)
        ucrSaveObject.SetName("")
    End Sub

    Private Sub ucrSaveDataFrameControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSaveDataFrame.ControlContentsChanged, ucrChkSaveDataFrameSingle.ControlContentsChanged,
            ucrInputSaveRFile.ControlContentsChanged

        Dim strScript As String = ""

        If rdoDataFrame.Checked Then
            If Not ucrInputSaveDataFrame.IsEmpty() Then
                Dim clsImportRFunction As New RFunction
                Dim strDataFrameName As String = ucrInputSaveDataFrame.GetText()

                clsImportRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")

                If ucrChkSaveDataFrameSingle.Checked Then
                    ' If it's a single data frame then wrap it into a list
                    Dim clsDataListRFunction As New RFunction
                    clsDataListRFunction.SetRCommand("list")
                    clsDataListRFunction.AddParameter(strParameterName:=strDataFrameName, strParameterValue:=strDataFrameName)
                    clsImportRFunction.AddParameter(strParameterName:="data_tables", clsRFunctionParameter:=clsDataListRFunction)
                Else
                    ' If it's already a list of data frames, then add the name directly
                    clsImportRFunction.AddParameter(strParameterName:="data_tables", strParameterValue:=strDataFrameName)
                End If

                strScript = "# Save data frame(s) """ & strDataFrameName & """" & Environment.NewLine & clsImportRFunction.ToScript()

            End If
        Else
            If Not ucrInputSaveRFile.IsEmpty Then
                Dim clsImportRDSFunction As New RFunction
                Dim strRFileName As String = ucrInputSaveRFile.GetText()

                clsImportRDSFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
                clsImportRDSFunction.AddParameter(strParameterName:="data_RDS", strParameterValue:=strRFileName)

                strScript = "# Save RDS File(s) """ & strRFileName & """" & Environment.NewLine & clsImportRDSFunction.ToScript()

            End If
        End If


        PreviewScript(strScript)
    End Sub

    Private Sub ucrSaveData_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveObject.ControlContentsChanged, ucrChkDisplayGraph.ControlValueChanged
        Dim strScript As String = ""
        Dim strGetScript As String = ""

        If ucrSaveObject.IsComplete Then
            ' R code is not automatiucally updated by save control when control contents changed event is raised by the control
            ucrSaveObject.UpdateRCode()

            Dim strDataType As String = ""
            If rdoSaveColumn.Checked Then
                strDataType = "column"
            ElseIf rdoSaveOutputObject.Checked Then
                strDataType = ucrCboSaveOutputObjectType.GetText().ToLower()
            End If
            Dim strTemp As String = ""
            clsSaveDataFunction.Clone.ToScript(strTemp)
            Dim arrtemp() As String = strTemp.Trim().Split(Environment.NewLine)
            If arrtemp.Length > 1 Then
                'ignore the first line of the script because it is an "empty" assignment
                strTemp = arrtemp(1)
                strScript = "# Save " & strDataType & " """ & ucrSaveObject.GetText() & """" & Environment.NewLine & strTemp
            End If

            If ucrChkDisplayGraph.Checked Then
                ucrChkDisplayGraph.UpdateRCode()
                clsGetRObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
                clsGetRObjectFunction.AddParameter("data_name", Chr(34) & ucrDataFrameSaveOutputSelect.strCurrDataFrame & Chr(34), iPosition:=0)
                clsGetRObjectFunction.AddParameter("as_file", "TRUE", iPosition:=2)
                clsGetRObjectFunction.AddParameter("object_name", Chr(34) & ucrSaveObject.GetText & Chr(34), iPosition:=1)
                strGetScript = "" & Environment.NewLine & clsGetRObjectFunction.ToScript()
            End If
        End If
        Dim combinedScript As String = strScript & Environment.NewLine & strGetScript
        PreviewScript(combinedScript)
    End Sub

    Private Sub ucrPnlGetData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGetData.ControlValueChanged
        ucrDataFrameGetDF.SetVisible(False)
        ucrCboGetOutputObjectType.SetVisible(False)
        ucrSelectorGetObject.SetVisible(False)
        ucrReceiverGetColumns.SetVisible(False)
        ucrReceiverGetOutputObject.SetVisible(False)
        PreviewScript("")
        If rdoGetDataFrame.Checked Then
            ucrDataFrameGetDF.SetVisible(True)
            ucrReceiverGetOutputObject.SetVisible(False)
            ucrDataFrameGetDF.Reset()
        ElseIf rdoGetColumn.Checked Then
            ucrSelectorGetObject.SetVisible(True)
            ucrReceiverGetColumns.SetVisible(True)
            ucrReceiverGetColumns.SetMeAsReceiver()
            ucrReceiverGetColumns.Clear()
        ElseIf rdoGetOutputObject.Checked Then
            ucrSelectorGetObject.SetVisible(True)
            ucrCboGetOutputObjectType.SetVisible(True)
            ucrReceiverGetOutputObject.SetVisible(True)
            SetupReceiverForGetOutputObject(ucrCboGetOutputObjectType.GetText(), dctOutputObjectTypes.Item(ucrCboGetOutputObjectType.GetText()))
            ucrReceiverGetOutputObject.SetMeAsReceiver()
        End If
    End Sub

    Private Sub SetupReceiverForGetOutputObject(strLabel As String, strDataType As String)
        ucrReceiverGetOutputObject.Clear()
        lblGetOutputObject.Text = strLabel & ":"
        ucrReceiverGetOutputObject.SetSelectorHeading(strLabel)
        ucrReceiverGetOutputObject.SetItemType(strDataType)
    End Sub

    Private Sub ucrDataFrameGet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameGetDF.ControlContentsChanged
        Dim strScript As String = ""

        If Not String.IsNullOrEmpty(ucrDataFrameGetDF.strCurrDataFrame) Then
            Dim strAssignedScript As String = ""
            ucrDataFrameGetDF.clsCurrDataFrame.Clone().ToScript(strAssignedScript)
            strScript = "# Get data frame """ & ucrDataFrameGetDF.strCurrDataFrame & """" & Environment.NewLine & strAssignedScript
        End If

        PreviewScript(strScript)
    End Sub

    Private Sub ucrReceiverGetColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverGetColumns.ControlContentsChanged
        Dim strScript As String = ""

        If Not ucrReceiverGetColumns.IsEmpty() Then
            Dim clsRFunction As RFunction = ucrReceiverGetColumns.GetVariables()
            Dim strAssignedScript As String = ""
            clsRFunction.SetAssignTo(ucrSelectorGetObject.strCurrentDataFrame & "_cols")
            clsRFunction.ToScript(strScript:=strAssignedScript)
            strScript = "# Get column(s) " & String.Join(",", ucrReceiverGetColumns.GetVariableNamesList(bWithQuotes:=True)) & Environment.NewLine & strAssignedScript
        End If

        PreviewScript(strScript)
    End Sub

    Private Sub ucrInputGetObjectType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboGetOutputObjectType.ControlValueChanged
        If Not ucrCboGetOutputObjectType.IsEmpty() Then
            SetupReceiverForGetOutputObject(ucrCboGetOutputObjectType.GetText(), dctOutputObjectTypes.Item(ucrCboGetOutputObjectType.GetText()))
        End If
    End Sub

    Private Sub ucrReceiverGetOutputObject_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverGetOutputObject.ControlContentsChanged
        Dim strScript As String = ""

        If Not ucrReceiverGetOutputObject.IsEmpty() Then
            Dim clsRFunction As RFunction = ucrReceiverGetOutputObject.GetVariables()
            Dim strAssignedScript As String = ""
            clsRFunction.ToScript(strScript:=strAssignedScript)
            strScript = "# Get " & ucrCboGetOutputObjectType.GetText().ToLower() & " " & ucrReceiverGetOutputObject.GetVariableNames(bWithQuotes:=True) & Environment.NewLine & strAssignedScript
        End If

        PreviewScript(strScript)
    End Sub

    Private Sub ucrPnlCommands_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCommands.ControlValueChanged
        ucrCboCommandPackage.SetVisible(False)
        ucrInputRemoveObjects.SetVisible(False)
        ucrInputGgplotify.SetVisible(False)
        ucrInputGraphCommand.SetVisible(False)
        ucrChkOpenRFile.SetVisible(False)
        ucrChkInto.SetVisible(False)
        ucrInputChooseFile.SetVisible(False)
        ucrInputViewData.SetVisible(False)
        ucrCboCommandDataPackage.SetVisible(False)
        ucrInputSaveData.SetVisible(False)
        ucrChkWindow.SetVisible(False)
        If rdoCommandPackage.Checked Then
            ucrCboCommandPackage.SetVisible(True)
            ucrCboCommandPackage.OnControlValueChanged()
        ElseIf rdoCommandObject.Checked Then
            ucrInputRemoveObjects.SetVisible(True)
            ucrInputRemoveObjects.OnControlValueChanged()
        ElseIf rdoGgplotify.Checked Then
            ucrInputGgplotify.SetVisible(True)
            ucrInputGgplotify.OnControlValueChanged()
            ucrInputGraphCommand.SetVisible(True)
            ucrInputGraphCommand.OnControlValueChanged()
        ElseIf rdoChooseFile.Checked Then
            ucrChkOpenRFile.SetVisible(True)
            ucrChkOpenRFile.OnControlValueChanged()
            ucrInputChooseFile.OnControlValueChanged()
        ElseIf rdoViewData.Checked Then
            ucrInputViewData.SetVisible(True)
            ucrInputViewData.OnControlValueChanged()
        ElseIf rdoListData.Checked Then
            ucrCboCommandDataPackage.SetVisible(True)
            ucrChkInto.SetVisible(True)
            ucrCboCommandDataPackage.OnControlValueChanged()
            ucrInputSaveData.OnControlValueChanged()
            ucrChkInto.OnControlValueChanged()
        ElseIf rdoWindow.Checked Then
            ucrChkWindow.SetVisible(True)
            ucrChkWindow.OnControlValueChanged()
        End If
    End Sub

    Private Sub ucrCboLibPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboCommandPackage.ControlValueChanged
        Dim strScript As String = ""

        If Not ucrCboCommandPackage.IsEmpty() Then
            Dim clsLibraryFunction As New RFunction
            clsLibraryFunction.SetRCommand("library")
            clsLibraryFunction.AddParameter("package", Chr(34) & ucrCboCommandPackage.GetText() & Chr(34))
            strScript = "# Load library """ & ucrCboCommandPackage.GetText() & """" & Environment.NewLine & clsLibraryFunction.ToScript
        End If

        PreviewScript(strScript)
    End Sub

    Private Sub ucrCboCommandDataPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSaveData.ControlContentsChanged, ucrChkInto.ControlContentsChanged, ucrCboCommandDataPackage.ControlValueChanged
        ucrInputSaveData.Visible = ucrChkInto.Checked

        Dim strScript As String = ""
        Dim strScriptDataFrame As String = ""
        Dim clsDatasetFunction As New RFunction
        clsDatasetFunction.SetPackageName("vcdExtra")

        If Not ucrCboCommandDataPackage.IsEmpty() Then
            clsDatasetFunction.SetRCommand("datasets")
            clsDatasetFunction.AddParameter("package", Chr(34) & ucrCboCommandDataPackage.GetText() & Chr(34), bIncludeArgumentName:=False)
            strScript = "#List of data sets " & Environment.NewLine & clsDatasetFunction.ToScript
        End If

        If ucrChkInto.Checked AndAlso Not ucrInputSaveData.IsEmpty() Then
            Dim strDataFrameName As String = ucrInputSaveData.GetText()
            Dim clsImportRFunction As New RFunction
            Dim strAssignedScript As String = ""

            clsDatasetFunction.SetRCommand("datasets")
            clsDatasetFunction.SetAssignTo(strDataFrameName)
            clsDatasetFunction.AddParameter("package", Chr(34) & ucrCboCommandDataPackage.GetText() & Chr(34), bIncludeArgumentName:=False)
            clsDatasetFunction.ToScript(strScript:=strAssignedScript)
            strScript = "#List of data sets " & Environment.NewLine & strAssignedScript

            clsImportRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")

            Dim clsDataListRFunction As New RFunction
            clsDataListRFunction.SetRCommand("list")
            clsDataListRFunction.AddParameter(strParameterName:=strDataFrameName, strParameterValue:=strDataFrameName)
            clsImportRFunction.AddParameter(strParameterName:="data_tables", clsRFunctionParameter:=clsDataListRFunction)

            strScriptDataFrame = "# Save data frame """ & strDataFrameName & """" & Environment.NewLine & clsImportRFunction.ToScript()
        End If

        Dim combinedScript As String = strScript & Environment.NewLine & strScriptDataFrame

        PreviewScript(combinedScript)
    End Sub

    Private Sub ucrInputRemoveObject_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputRemoveObjects.ControlContentsChanged
        Dim strScript As String = ""

        If Not ucrInputRemoveObjects.IsEmpty() Then
            ' Create function to remove the objects added in the script
            Dim lstAssignToStrings As String() = ucrInputRemoveObjects.GetText().Split(",")
            Dim clsRemoveFunc As New RFunction
            Dim clsRemoveListFun As New RFunction
            clsRemoveFunc.SetRCommand("rm")
            clsRemoveListFun.SetRCommand("c")

            For i As Integer = 0 To lstAssignToStrings.Count - 1
                lstAssignToStrings.SetValue(Chr(34) & lstAssignToStrings(i) & Chr(34), i)
                clsRemoveListFun.AddParameter(i, lstAssignToStrings(i), bIncludeArgumentName:=False)
            Next
            clsRemoveFunc.AddParameter("list", clsRFunctionParameter:=clsRemoveListFun)
            strScript = "# Remove object(s) " & String.Join(",", lstAssignToStrings) & Environment.NewLine & clsRemoveFunc.ToScript()
        End If

        PreviewScript(strScript)
    End Sub

    Private Sub ucrInputGgplotify_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputGraphCommand.ControlContentsChanged, ucrInputGgplotify.ControlContentsChanged
        Dim strScript As String = ""

        If Not ucrInputGgplotify.IsEmpty() AndAlso Not ucrInputGraphCommand.IsEmpty Then
            Dim clsGgglorifyFunction As New RFunction

            clsGgglorifyFunction.SetPackageName("ggplotify")
            clsGgglorifyFunction.SetRCommand("as.ggplot")


            Dim strAssignedScript As String = ""
            clsGgglorifyFunction.AddParameter("plot", "~" & ucrInputGraphCommand.GetText(), bIncludeArgumentName:=False)
            clsGgglorifyFunction.SetAssignTo(ucrInputGgplotify.GetText)
            clsGgglorifyFunction.ToScript(strScript:=strAssignedScript)

            strScript = "# Make Graph a ggplot " & Environment.NewLine & strAssignedScript

        End If
        PreviewScript(strScript)
    End Sub

    Private Sub ucrInputViewData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputViewData.ControlContentsChanged
        Dim strScript As String = ""

        If Not ucrInputViewData.IsEmpty Then
            Dim clsViewDataFunction As New RFunction

            clsViewDataFunction.SetRCommand("View")
            clsViewDataFunction.AddParameter("view", ucrInputViewData.GetText(), bIncludeArgumentName:=False)

            strScript = "#Show data in the R spreadsheet-type viewer" & Environment.NewLine & clsViewDataFunction.ToScript()

        End If
        PreviewScript(strScript)
    End Sub

    Private Sub ucrComboGetPackages_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExample.ControlValueChanged, ucrCboExamplePackages.ControlValueChanged
        PreviewScript("")
        lstExampleCollection.Items.Clear()

        If ucrCboExamplePackages.IsEmpty Then
            Exit Sub
        End If

        Dim strSelectedPackage As String = ucrCboExamplePackages.GetText()

        If rdoExampleData.Checked Then
            lstExampleCollection.Columns(0).Text = "Data"
            lstExampleCollection.Items.AddRange(GetDatasets(strSelectedPackage))
        ElseIf rdoExampleFunction.Checked Then
            lstExampleCollection.Columns(0).Text = "Functions"
            lstExampleCollection.Items.AddRange(GetFunctions(strSelectedPackage))
        End If
        lstExampleCollection.Select()
        EnableHelp()
    End Sub

    Private Function GetDatasets(strPackage As String) As ListViewItem()

        Dim dfDataframe As DataFrame = frmMain.clsRLink.RunInternalScriptGetValue(
            "data.frame(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results)[ ,3:4]", bSilent:=True)?.AsDataFrame()

        If dfDataframe Is Nothing Then
            Return {}
        End If

        Dim lstViewItems(dfDataframe.RowCount - 1) As ListViewItem
        For i As Integer = 0 To dfDataframe.RowCount - 1
            Dim lstViewItem As New ListViewItem With {
                .Text = dfDataframe(i, 0)
            }

            'lstViewItem.SubItems.Add(dfDataframe(i, 0))
            lstViewItem.SubItems.Add(If(dfDataframe.ColumnCount > 1, dfDataframe(i, 1), ""))
            lstViewItems(i) = lstViewItem
        Next
        Return lstViewItems

    End Function

    Private Function GetFunctions(strPackage As String) As ListViewItem()

        Dim expTemp As GenericVector = frmMain.clsRLink.RunInternalScriptGetValue("ls(pos = asNamespace(" & Chr(34) & strPackage & Chr(34) & "))", bSilent:=True)?.AsList()

        If expTemp Is Nothing Then
            Return {}
        End If

        Dim lstViewItems(expTemp.Length - 1) As ListViewItem
        For i = 0 To expTemp.Length - 1
            Dim lstViewItem As New ListViewItem With {
                .Text = expTemp.AsCharacter(i)
            }
            lstViewItem.SubItems.Add("")
            lstViewItems(i) = lstViewItem
        Next
        Return lstViewItems

    End Function

    Private Sub lstExampleCollection_Click(sender As Object, e As EventArgs) Handles lstExampleCollection.Click
        If lstExampleCollection.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        Dim strTopic As String = lstExampleCollection.SelectedItems(0).SubItems(0).Text
        Try

            Dim clsLibraryExpFunction As New RFunction
            clsLibraryExpFunction.SetRCommand("getExample")
            clsLibraryExpFunction.AddParameter("package", Chr(34) & ucrCboExamplePackages.GetText() & Chr(34), iPosition:=1)
            clsLibraryExpFunction.AddParameter("topic", Chr(34) & strTopic & Chr(34), iPosition:=0)

            Dim strExample As String = frmMain.clsRLink.RunInternalScriptGetValue(clsLibraryExpFunction.Clone.ToScript(), bSilent:=True).AsCharacter(0)
            strExample = strExample.Replace("##D", String.Empty)
            PreviewScript(strExample)
        Catch ex As Exception
            MsgBox(strTopic & " has a help file but no examples.")
        End Try
        EnableHelp()
    End Sub

    Private Sub txtScript_TextChanged(sender As Object, e As EventArgs) Handles txtScript.TextChanged
        ucrBase.clsRsyntax.SetCommandString(txtScript.Text)
        ucrBase.OKEnabled(txtScript.Text.Length > 0)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        EnableHelp()
    End Sub

    Private Sub tbFeatures_Selected(sender As Object, e As TabControlEventArgs) Handles tbFeatures.Selected
        If e.TabPage Is tbPageGetData Then
            rdoGetDataFrame.Checked = True
            ucrPnlGetData.OnControlValueChanged()
        ElseIf e.TabPage Is tbPageSaveData Then
            rdoSaveDataFrame.Checked = True
            ucrPnlSaveData.OnControlValueChanged()
        ElseIf e.TabPage Is tbPageCommand Then
            'alwys reset the common controls to be blank.
            'the controls functionalities are not related
            ucrCboCommandPackage.GetSetSelectedIndex = -1
            ucrInputRemoveObjects.SetName("")
            PreviewScript("")
        ElseIf e.TabPage Is tbPageExamples Then
            ucrCboExamplePackages.OnControlValueChanged()
        End If
    End Sub

    Private Sub PreviewScript(strNewScript As String)
        txtScript.Text = strNewScript & Environment.NewLine
        txtScript.SelectionStart = txtScript.Text.Length
        txtScript.ScrollToCaret()
        txtScript.Refresh()
    End Sub

    Private Sub ucrInputChooseFile_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputChooseFile.ControlContentsChanged, ucrChkOpenRFile.ControlContentsChanged
        UpdateScript()
        ucrInputChooseFile.Visible = ucrChkOpenRFile.Checked
    End Sub

    Private Sub rdoChooseFile_CheckedChanged(sender As Object, e As EventArgs) Handles rdoChooseFile.CheckedChanged
        UpdateScript()
    End Sub

    Private Sub UpdateScript()
        Dim strScript As String = ""
        Dim clsFileChooseFunction As New RFunction
        Dim clsReadRdsFunction As New RFunction

        If rdoChooseFile.Checked Then
            If Not ucrChkOpenRFile.Checked Then
                ' Only file choosing logic
                clsFileChooseFunction.SetRCommand("choose.files")
                Dim strAssignedScript As String = ""
                clsFileChooseFunction.SetAssignTo("filename")
                clsFileChooseFunction.ToScript(strScript:=strAssignedScript)
                strScript = "#Open file interactively" & Environment.NewLine & strAssignedScript
            ElseIf ucrChkOpenRFile.Checked AndAlso Not ucrInputChooseFile.IsEmpty Then
                ' File choosing and RDS file reading logic
                clsFileChooseFunction.SetRCommand("choose.files")
                Dim strAssignedScript As String = ""
                clsFileChooseFunction.SetAssignTo("filename")
                clsFileChooseFunction.ToScript(strScript:=strAssignedScript)
                strScript = "#Open R data file interactively" & Environment.NewLine & strAssignedScript

                clsReadRdsFunction.SetRCommand("readRDS")
                Dim strRdsAssignedScript As String = ""
                clsReadRdsFunction.SetAssignTo(ucrInputChooseFile.GetText)
                clsReadRdsFunction.AddParameter("file", "filename", bIncludeArgumentName:=False)
                clsReadRdsFunction.ToScript(strScript:=strRdsAssignedScript)
                Dim strRdScript As String = strRdsAssignedScript

                ' Combine scripts if applicable
                strScript &= strRdScript
            End If
        End If
        PreviewScript(strScript)
    End Sub
    Private Sub EnableHelp()
        cmdHelp.Enabled = rdoExampleData.Checked AndAlso lstExampleCollection.SelectedItems.Count > 0
    End Sub

    Private Sub ucrChkWindow_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkWindow.ControlContentsChanged
        Dim strScript As String = ""
        Dim clsWindowFunction As New RFunction

        If ucrChkWindow.Checked Then
            clsWindowFunction.SetRCommand("windows")
            clsWindowFunction.AddParameter("record", "TRUE", iPosition:=0)
            strScript = "#Recording multiple graphs" & Environment.NewLine & clsWindowFunction.ToScript()
        Else
            clsWindowFunction.SetRCommand("windows")
            clsWindowFunction.RemoveParameterByName("record")
            strScript = "#Open the R graph viewer" & Environment.NewLine & clsWindowFunction.ToScript()
        End If

        PreviewScript(strScript)
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim strPackageName As String = ucrCboExamplePackages.cboInput.SelectedItem
        Dim strTopic As String = lstExampleCollection.SelectedItems(0).Text
        If strPackageName <> "" AndAlso strTopic <> "" Then
            Dim frmMaximiseOutput As New frmMaximiseOutput
            frmMaximiseOutput.Show(strFileName:=clsFileUrlUtilities.GetHelpFileURL(strPackageName:=strPackageName, strTopic:=strTopic), bReplace:=False)
        End If
    End Sub

    Private Sub ucrPnlSaveDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSaveDataFrame.ControlValueChanged
        VisiilityOfControls()
    End Sub
    Private Sub VisiilityOfControls()
        ucrInputSaveRFile.SetVisible(False)
        ucrInputSaveDataFrame.SetVisible(False)
        ucrChkSaveDataFrameSingle.SetVisible(False)
        If rdoDataFrame.Checked Then
            ucrInputSaveDataFrame.SetVisible(True)
            ucrChkSaveDataFrameSingle.SetVisible(True)
            ucrInputSaveDataFrame.OnControlValueChanged()
            ucrChkSaveDataFrameSingle.OnControlValueChanged()
        ElseIf rdoFromRFile.Checked Then
            ucrInputSaveRFile.SetVisible(True)
            ucrInputSaveRFile.OnControlValueChanged()
        End If
    End Sub


End Class