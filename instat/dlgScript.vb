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
    Private dctOutputObjectTypes As New Dictionary(Of String, String)
    Private dctOutputObjectFormats As New Dictionary(Of String, String)

    Private Sub dlgScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            SetDefaults()
            bFirstload = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

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
        ' Library controls

        'todo. this combo box can be a custom package control in future. Its also needed in dlgHelpVignettes
        ucrCboLibPackage.SetParameter(New RParameter("package", 0))
        ucrCboLibPackage.SetItems(GetPackages(), bAddConditions:=True)
        ucrCboLibPackage.SetDropDownStyleAsNonEditable()

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


        ucrSaveData.SetLabelText("Save Graph")
        ucrSaveData.SetIsComboBox()
        ucrSaveData.SetDataFrameSelector(ucrDataFrameSaveOutputSelect)


        '--------------------------------
        'Get data controls

        ucrPnlGetData.AddRadioButton(rdoGetDataFrame)
        ucrPnlGetData.AddRadioButton(rdoGetColumn)
        ucrPnlGetData.AddRadioButton(rdoGetOutputObject)

        ucrDataFrameGetDF.SetLabelText("Get Data Frame:")

        ucrCboGetOutputObjectType.SetItems(dctOutputObjectTypes, bSetConditions:=False)
        ucrCboGetOutputObjectType.SetDropDownStyleAsNonEditable()
        ucrCboGetOutputObjectType.SetLinkedDisplayControl(lblGetObjectType)
        ucrCboGetOutputObjectType.GetSetSelectedIndex = 0

        ucrReceiverGetObject.Selector = ucrSelectorGetObject
        ucrReceiverGetObject.SetMeAsReceiver()
        ucrReceiverGetObject.bAutoFill = True
        ucrReceiverGetObject.SetLinkedDisplayControl(lblGetObject)

        '-------------------------------
        ' Hide base controls not supported in this dialog

        ucrBase.chkComment.Checked = False
        ucrBase.chkComment.Visible = False
        ucrBase.txtComment.Visible = False
        ucrBase.cmdOk.Visible = False

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

        'Finally controls
        ucrInputRemoveObjects.Reset()

        ' Save controls reset
        ucrSaveData.SetRCode(clsSaveDataFunction, True)
        ucrSaveData.Reset()
        rdoSaveDataFrame.Checked = True
        ucrDataFrameSaveOutputSelect.Reset()

        ' Get controls reset
        ucrSelectorGetObject.Reset()
        ucrCboGetOutputObjectType.GetSetSelectedIndex = 0
        ucrDataFrameGetDF.Reset()
        rdoGetDataFrame.Checked = True


        ' Library controls
        ucrCboLibPackage.GetSetSelectedIndex = 0


        'activate the selected tab to library tab
        tbFeatures.SelectedIndex = -1
        tbFeatures.SelectedTab = tbPageLibrary

    End Sub

    Private Sub ucrCboLibPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboLibPackage.ControlContentsChanged
        Dim clsLibraryFunction As New RFunction
        clsLibraryFunction.SetRCommand("library")
        clsLibraryFunction.AddParameter("package", Chr(34) & ucrCboLibPackage.GetText() & Chr(34))
        PreviewScript(clsLibraryFunction.ToScript)
    End Sub

    Private Sub ucrPnlGetData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGetData.ControlValueChanged
        ucrDataFrameGetDF.SetVisible(False)
        ucrCboGetOutputObjectType.SetVisible(False)
        ucrSelectorGetObject.SetVisible(False)
        ucrReceiverGetObject.SetVisible(False)
        PreviewScript("")
        If rdoGetDataFrame.Checked Then
            ucrDataFrameGetDF.SetVisible(True)
            ucrReceiverGetObject.SetVisible(False)
            ucrDataFrameGetDF.Reset()
        ElseIf rdoGetColumn.Checked Then
            ucrSelectorGetObject.SetVisible(True)
            ucrReceiverGetObject.SetVisible(True)
            SetupReceiverForGetData("Column", RObjectTypeLabel.Column)
        ElseIf rdoGetOutputObject.Checked Then
            ucrSelectorGetObject.SetVisible(True)
            ucrCboGetOutputObjectType.SetVisible(True)
            lblGetObject.Text = ucrCboGetOutputObjectType.GetText()
            ucrReceiverGetObject.SetVisible(True)
            SetupReceiverForGetData(ucrCboGetOutputObjectType.GetText(), dctOutputObjectTypes.Item(ucrCboGetOutputObjectType.GetText()))
        End If
    End Sub

    Private Sub SetupReceiverForGetData(strLabel As String, strDataType As String)
        ucrReceiverGetObject.Clear()
        lblGetObject.Text = strLabel & ":"
        ucrReceiverGetObject.SetSelectorHeading(strLabel)
        ucrReceiverGetObject.SetItemType(strDataType)
    End Sub

    Private Sub ucrDataFrameGet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameGetDF.ControlContentsChanged
        Dim strAssignedScript As String = ""
        ucrDataFrameGetDF.clsCurrDataFrame.Clone().ToScript(strAssignedScript)
        PreviewScript(strAssignedScript)
    End Sub

    Private Sub ucrInputGetObjectType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboGetOutputObjectType.ControlValueChanged
        If Not ucrCboGetOutputObjectType.IsEmpty() Then
            SetupReceiverForGetData(ucrCboGetOutputObjectType.GetText(), dctOutputObjectTypes.Item(ucrCboGetOutputObjectType.GetText()))
        End If
    End Sub

    Private Sub ucrReceiverGet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverGetObject.ControlContentsChanged
        Dim clsFunction As RFunction = ucrReceiverGetObject.GetVariables()
        Dim strAssignedScript As String = ""
        clsFunction.ToScript(strScript:=strAssignedScript)
        PreviewScript(strAssignedScript)
    End Sub

    Private Sub ucrPnlSaveData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSaveData.ControlValueChanged
        ucrDataFrameSaveOutputSelect.SetVisible(False)
        ucrCboSaveOutputObjectType.SetVisible(False)
        ucrCboSaveOutputObjectFormat.SetVisible(False)
        If rdoSaveDataFrame.Checked Then
            SetupSaveDataControl("Data Frame", RObjectTypeLabel.Dataframe, "")
        ElseIf rdoSaveColumn.Checked Then
            ucrDataFrameSaveOutputSelect.SetVisible(True)
            SetupSaveDataControl("Column", RObjectTypeLabel.Column, "")
        ElseIf rdoSaveOutputObject.Checked Then
            ucrDataFrameSaveOutputSelect.SetVisible(True)
            ucrCboSaveOutputObjectType.SetVisible(True)
            ucrCboSaveOutputObjectFormat.SetVisible(True)
            SetupSaveDataControl(ucrCboSaveOutputObjectType.GetText(), dctOutputObjectTypes.Item(ucrCboSaveOutputObjectType.GetText()), dctOutputObjectFormats.Item(ucrCboSaveOutputObjectFormat.GetText()))
        End If
    End Sub

    Private Sub ucrCboSaveOutputObjectTypee_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSaveOutputObjectType.ControlValueChanged, ucrCboSaveOutputObjectFormat.ControlValueChanged
        If Not ucrCboSaveOutputObjectType.IsEmpty() AndAlso Not ucrCboSaveOutputObjectFormat.IsEmpty() Then
            SetupSaveDataControl(ucrCboSaveOutputObjectType.GetText(), dctOutputObjectTypes.Item(ucrCboSaveOutputObjectType.GetText()), dctOutputObjectFormats.Item(ucrCboSaveOutputObjectFormat.GetText()))
        End If
    End Sub

    Private Sub SetupSaveDataControl(strLabel As String, strDataType As String, strFormat As String)

        ucrSaveData.SetSaveType(strDataType, strFormat)
        ucrSaveData.SetLabelText(strLabel)
        ucrSaveData.SetName("")

        'change location of the save control if it's the data frame option selected
        If strDataType = RObjectTypeLabel.Dataframe Then
            ucrSaveData.SetIsTextBox()
            ucrSaveData.Location = New Point(ucrSaveData.Location.X, ucrDataFrameSaveOutputSelect.Location.Y)
        Else
            ucrSaveData.SetIsComboBox()
            ucrSaveData.Location = If(strDataType = RObjectTypeLabel.Column,
                New Point(ucrSaveData.Location.X, ucrCboSaveOutputObjectType.Location.Y),
                New Point(ucrSaveData.Location.X, ucrCboSaveOutputObjectFormat.Location.Y + 33))
        End If

    End Sub

    Private Sub ucrSaveData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveData.ControlContentsChanged

        ' R code is not automatiucally updated by save control when control contents changed event is raised by the control
        ucrSaveData.UpdateRCode()

        Dim strAssignedScript As String = ""
        clsSaveDataFunction.Clone.ToScript(strScript:=strAssignedScript)
        PreviewScript(strAssignedScript)
    End Sub

    Private Sub ucrInputRemoveObject_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputRemoveObjects.ControlContentsChanged
        'create function to remove the objects added in the script
        Dim lstAssignToStrings As String() = ucrInputRemoveObjects.GetText().Split(",")
        Dim clsRemoveFunc As New RFunction
        Dim clsRemoveListFun As New RFunction
        clsRemoveFunc.SetRCommand("rm")
        clsRemoveListFun.SetRCommand("c")

        For i As Integer = 0 To lstAssignToStrings.Count - 1
            clsRemoveListFun.AddParameter(i, Chr(34) & lstAssignToStrings(i) & Chr(34), bIncludeArgumentName:=False)
        Next
        clsRemoveFunc.AddParameter("list", clsRFunctionParameter:=clsRemoveListFun)

        PreviewScript(clsRemoveFunc.ToScript())
    End Sub

    Private Sub txtScript_TextChanged(sender As Object, e As EventArgs) Handles txtScript.TextChanged
        ucrBase.clsRsyntax.SetCommandString(txtScript.Text)
        ucrBase.OKEnabled(txtScript.Text.Length > 0)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub PreviewScript(strNewScript As String)
        txtScript.Text = strNewScript.Trim() & Environment.NewLine
        txtScript.SelectionStart = txtScript.Text.Length
        txtScript.ScrollToCaret()
        txtScript.Refresh()
    End Sub

    Private Sub TbFeatures_Selected(sender As Object, e As TabControlEventArgs) Handles tbFeatures.Selected
        If e.TabPage Is tbPageLibrary Then
            ucrCboLibPackage.OnControlContentsChanged()
        ElseIf e.TabPage Is tbPageGetData Then
            rdoGetDataFrame.Checked = True
            ucrPnlGetData.OnControlValueChanged()
        ElseIf e.TabPage Is tbPageSaveData Then
            rdoSaveDataFrame.Checked = True
            ucrPnlSaveData.OnControlValueChanged()
        ElseIf e.TabPage Is tbPageFinally Then
            ucrInputRemoveObjects.OnControlContentsChanged()
        End If
    End Sub

End Class