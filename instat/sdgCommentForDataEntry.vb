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
Public Class sdgCommentForDataEntry
    Private bUseSelectedPosition As Boolean = False
    Private strSelectedDataFrame As String = ""
    Private strSelectedRow As String = ""
    Private strSelectedColumn As String = ""
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public clsList As RFunction
    Public clsCommentsList As New RFunction
    Private clsSaveDataEntry As RFunction
    Private i As Integer = 0

    Private Sub sdgCommentForDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False
        autoTranslate(Me)
        SetRCodeForControls(bReset)
        If bUseSelectedPosition Then
            SetDefaultPosition()
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoCell)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoRow)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoColumn)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoDataFrame)

        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoCell, "column")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoCell, "row")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoRow, "row")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoColumn, "column")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoColumn, "row", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoRow, "column", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoDataFrame, "column", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoDataFrame, "row", False)


        ucrPnlCellRowColumnDataFrame.AddToLinkedControls(ucrReceiverColumn, {rdoCell, rdoColumn}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCellRowColumnDataFrame.AddToLinkedControls(ucrInputRow, {rdoCell, rdoRow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrInputRow.SetLinkedDisplayControl(lblRow)
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumn)

        ucrSelectorAddComment.SetParameter(New RParameter("data_name", 0))
        ucrSelectorAddComment.SetParameterIsString()

        ucrInputRow.SetParameter(New RParameter("row", iNewPosition:=1))
        ucrInputRow.SetValidationTypeAsNumeric()

        ucrReceiverColumn.Selector = ucrSelectorAddComment
        ucrReceiverColumn.SetParameter(New RParameter("column", iNewPosition:=2))
        ucrReceiverColumn.SetParameterIsString()

        ucrInputComment.SetParameter(New RParameter("comment", iNewPosition:=3))
    End Sub

    Private Sub SetDefaults()
        clsCommentsList = New RFunction
        clsList = New RFunction

        ucrSelectorAddComment.Reset()
        ucrInputComment.IsMultiline = True

        ucrReceiverColumn.SetMeAsReceiver()

        clsCommentsList.SetRCommand("list")

        clsList.SetRCommand("list")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, clsCommentsList, bReset)
    End Sub

    Private Sub SetDefaultPosition()
        ucrSelectorAddComment.SetDataframe(strSelectedDataFrame)
        ucrInputRow.SetName(strSelectedRow)
        If strSelectedColumn <> "" AndAlso strSelectedRow <> "" Then
            ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
            rdoCell.Checked = True
        ElseIf strSelectedColumn <> "" AndAlso strSelectedRow = "" Then
            ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
            rdoColumn.Checked = True
        ElseIf strSelectedColumn = "" AndAlso strSelectedRow <> "" Then
            rdoRow.Checked = True
        Else
            rdoDataFrame.Checked = True
        End If
        strSelectedDataFrame = ""
        strSelectedRow = ""
        strSelectedColumn = ""
        bUseSelectedPosition = False
    End Sub

    Public Sub SetRfunctions(clsNewSaveDataEntry As RFunction)
        clsSaveDataEntry = clsNewSaveDataEntry
        EnableDisableAddComment()
    End Sub

    Private Sub EnableDisableAddComment()
        cmdAddComment.Enabled = Not ucrInputComment.IsEmpty
    End Sub

    Public Sub SetPosition(strDataFrame As String, Optional strRow As String = "", Optional strColumn As String = "")
        strSelectedDataFrame = strDataFrame
        strSelectedRow = strRow
        strSelectedColumn = strColumn
        bUseSelectedPosition = True
    End Sub

    Private Sub ucrPnlCellRowColumnDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCellRowColumnDataFrame.ControlValueChanged
        ucrSelectorAddComment.ShowColumnSelector(rdoCell.Checked OrElse rdoColumn.Checked)
    End Sub

    Private Sub cmdAddComment_Click(sender As Object, e As EventArgs) Handles cmdAddComment.Click
        clsList.AddParameter("C" & i, clsRFunctionParameter:=clsCommentsList, iPosition:=i)
        i = i + 1
        Me.Close()
    End Sub

    Private Sub ucrInputComment_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputComment.ControlContentsChanged
        EnableDisableAddComment()
    End Sub

    Public Sub ClearComments()
        clsList.ClearParameters()
    End Sub
End Class