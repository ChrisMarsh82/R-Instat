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

Imports System.IO
Imports instat.Translations
Public Class dlgExportDataset
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction

    Private Sub dlgExportDataset_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()
        ucrInputExportFile.IsReadOnly = True
        ucrAvailableSheets.SetParameter(New RParameter("x", 0))
        ucrAvailableSheets.SetParameterIsRFunction()
        ucrAvailableSheets.SetText("Data Frame to Export:")

        ucrInputExportFile.SetParameter(New RParameter("file", 1))

        lblConfirmText.Text = "Click Ok to Confirm the Export"
        lblConfirmText.ForeColor = Color.Red
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrInputExportFile.SetName("")
        ucrAvailableSheets.Reset()
        clsDefaultFunction.SetPackageName("rio")
        clsDefaultFunction.SetRCommand("export")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrInputExportFile.IsEmpty AndAlso ucrAvailableSheets.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
        If Not ucrInputExportFile.IsEmpty() Then
            lblConfirmText.Show()
            ucrBase.OKEnabled(True)
        Else
            lblConfirmText.Hide()
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim strCurrentFilePathName As String = ucrInputExportFile.GetText()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Export File Dialog"
            dlgSave.Filter = "Comma separated file (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|TAB-separated data (*.tsv)|*.tsv|Pipe-separated data (*.psv)|*.psv|Feather r / Python interchange format (*.feather)|*.feather|Fixed-Width format data (*.fwf)|*.fwf|Serialized r objects (*.rds)|*.rds|Saved r objects (*.RData)|*.RData|JSON(*.json)|*.json|YAML(*.yml)|*.yml|Stata(*.dta)|*.dta|SPSS(*.sav)|*.sav|XBASE database files (*.dbf)|*.dbf| Weka Attribute - Relation File Format (*.arff)|*.arff|r syntax object (*.R)|*.R|Xml(*.xml)|*.xml|HTML(*.html)|*.html"
            If String.IsNullOrEmpty(strCurrentFilePathName) Then
                dlgSave.FileName = ucrAvailableSheets.strCurrDataFrame
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            Else
                dlgSave.FileName = Path.GetFileName(strCurrentFilePathName)
                dlgSave.InitialDirectory = Path.GetDirectoryName(strCurrentFilePathName)
            End If
            If dlgSave.ShowDialog = DialogResult.OK Then
                ucrInputExportFile.SetName(dlgSave.FileName.Replace("\", "/"))
                strCurrentFilePathName = dlgSave.FileName
            End If
        End Using
    End Sub

    Private Sub ucrInputExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputExportFile.ControlContentsChanged, ucrAvailableSheets.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrAvailableSheets_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrAvailableSheets.DataFrameChanged
        ucrInputExportFile.SetName("") 'clears the ucrinput contents. 
    End Sub
End Class