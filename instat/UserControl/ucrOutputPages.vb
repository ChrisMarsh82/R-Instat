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

''' <summary>
''' Holds all the output pages
''' </summary>
Public Class ucrOutputPages
    Private _outputLogger As OutputLogger
    Private _selectedOutputPage As ucrOutputPage
    Private _allOutputPages As List(Of ucrOutputPage)
    Private _clsInstatOptions As InstatOptions

    ''' <summary>
    ''' Holds options.
    ''' ToDo InstatOptions should be able to be accessed from anywhere
    ''' </summary>
    Public WriteOnly Property clsInstatOptions() As InstatOptions
        Set(ByVal value As InstatOptions)
            _clsInstatOptions = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _selectedOutputPage = ucrMainOutputPage
        _allOutputPages = New List(Of ucrOutputPage)
        EnableDisableTopButtons()
    End Sub

    ''' <summary>
    ''' Sets logger and attatches events
    ''' </summary>
    ''' <param name="outputLogger"></param>
    Public Sub SetLogger(outputLogger As OutputLogger)
        _outputLogger = outputLogger
        AddHandler _outputLogger.NewOutputAdded, AddressOf AddNewOutput
        AddHandler _outputLogger.NewOutputAddedToFilteredList, AddressOf AddNewOutputToTab
        AddHandler _outputLogger.NewFilteredListAdded, AddressOf AddNewTab
        AddHandler ucrMainOutputPage.RefreshContextButtons, AddressOf EnableDisableTopButtons
    End Sub

    Private Sub AddNewOutput(outputElement As OutputElement)
        ucrMainOutputPage.AddNewOutput(outputElement)
    End Sub

    Private Sub AddNewOutputToTab(outputElement As OutputElement, tabName As String)
        For Each outputPage In _allOutputPages
            If outputPage.Tag = tabName Then
                outputPage.AddNewOutput(outputElement)
                Exit For
            End If
        Next
    End Sub

    Private Sub AddNewTab(tabName As String)
        Dim tabPage As New TabPage With {
            .Text = tabName
        }
        Dim outputPage As New ucrOutputPage With {
            .Dock = DockStyle.Fill,
            .Tag = tabName,
            .CanReOrder = True,
            .CanDelete = True,
            .CanRename = True
        }
        tabPage.Controls.Add(outputPage)
        tabControl.TabPages.Add(tabPage)
        _allOutputPages.Add(outputPage)
        UpdateTabsInDropDown()
        AddHandler outputPage.RefreshContextButtons, AddressOf EnableDisableTopButtons
    End Sub

    Private Function SelectedTab() As String
        Return tabControl.SelectedTab.Text
    End Function

    Private Sub UpdateTabsInDropDown()
        tdbAddToExisting.DropDownItems.Clear()
        For Each list In _outputLogger.FilteredOutputs
            If list.Name <> SelectedTab() Then
                Dim toolStripButton As New ToolStripButton With {
                .Tag = list,
                .Text = list.Name
                }
                AddHandler toolStripButton.Click, AddressOf AddToExistingTab_Click
                tdbAddToExisting.DropDownItems.Add(toolStripButton)
            End If
        Next
    End Sub

    Private Sub EnableDisableTopButtons()
        If _selectedOutputPage.SelectedElements.Count > 0 Then
            tdbAddToExisting.Enabled = (tdbAddToExisting.DropDownItems.Count > 0)
            tbAddToNew.Enabled = True
            tbCopy.Enabled = True
            tbDelete.Enabled = _selectedOutputPage.CanDelete
            tbMoveDown.Enabled = _selectedOutputPage.CanReOrder
            tbMoveUp.Enabled = _selectedOutputPage.CanReOrder
        Else
            tdbAddToExisting.Enabled = False
            tbAddToNew.Enabled = False
            tbCopy.Enabled = False
            tbDelete.Enabled = False
            tbMoveDown.Enabled = False
            tbMoveUp.Enabled = False
        End If
        tbRename.Enabled = _selectedOutputPage.CanRename
    End Sub

    Private Sub AddToExistingTab_Click(sender As Object, e As EventArgs)
        For Each element In _selectedOutputPage.SelectedElements
            _outputLogger.AddOutputToFilteredList(element, CType(sender, ToolStripButton).Text)
        Next
        _selectedOutputPage.ClearAllCheckBoxes()
    End Sub

    Private Sub RefreshPage()
        _selectedOutputPage.ClearAllOutputs()
        For Each output In _outputLogger.GetFilteredList(SelectedTab).Output.OrderBy(Function(x) x.Id).ToList()
            _selectedOutputPage.AddNewOutput(output)
        Next
    End Sub

    Private Sub DeletePage()
        Dim tab As TabPage = tabControl.SelectedTab
        Dim tabName As String = SelectedTab()
        tabControl.TabPages.Remove(tab)
        tab.Dispose()
        Dim found As ucrOutputPage = Nothing
        For Each outputPage In _allOutputPages
            If outputPage.Tag = tabName Then
                found = outputPage
                Exit For
            End If
        Next
        _allOutputPages.Remove(found)
        _outputLogger.FilteredOutputs.Remove(_outputLogger.GetFilteredList(tabName))
        UpdateTabsInDropDown()
    End Sub

    Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        For Each control In tabControl.SelectedTab.Controls
            If TypeOf control Is ucrOutputPage Then
                _selectedOutputPage = control
            End If
        Next
        UpdateTabsInDropDown()
        EnableDisableTopButtons()
    End Sub

    Private Sub tbAddToNew_Click(sender As Object, e As EventArgs) Handles tbAddToNew.Click
        Dim strTabName As String = "New Tab"
        While Not _outputLogger.IsValidFilteredListName(strTabName)
            strTabName = strTabName + "1"
        End While
        For Each element In _selectedOutputPage.SelectedElements
            _outputLogger.AddOutputToFilteredList(element, strTabName)
        Next
        _selectedOutputPage.ClearAllCheckBoxes()
    End Sub

    Private Sub tbCopy_Click(sender As Object, e As EventArgs) Handles tbCopy.Click
        _selectedOutputPage.CopySelectedElementsToClipboard()
    End Sub

    Private Sub tbMoveUp_Click(sender As Object, e As EventArgs) Handles tbMoveUp.Click
        For Each element In _selectedOutputPage.SelectedElements
            _outputLogger.GetFilteredList(SelectedTab).MoveElementUp(element)
        Next
        RefreshPage()
    End Sub

    Private Sub tbMoveDown_Click(sender As Object, e As EventArgs) Handles tbMoveDown.Click
        For Each element In _selectedOutputPage.SelectedElements.OrderByDescending((Function(x) x.Id))
            _outputLogger.GetFilteredList(SelectedTab).MoveElementDown(element)
        Next
        RefreshPage()
    End Sub

    Private Sub tbDelete_Click(sender As Object, e As EventArgs) Handles tbDelete.Click
        For Each element In _selectedOutputPage.SelectedElements
            _outputLogger.DeleteOutputFromFilteredList(element, SelectedTab)
        Next
        If _outputLogger.GetFilteredList(SelectedTab).Output.Count < 1 Then
            DeletePage()
        Else
            RefreshPage()
        End If
    End Sub

    Private Sub RenameTextboxLeave(sender As Object, e As EventArgs)
        Dim unused = sender.dispose()
    End Sub

    Private Sub RenameTextboxKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If _outputLogger.IsValidFilteredListName(sender.Text) Then
                _outputLogger.GetFilteredList(SelectedTab).Name = sender.text
                For Each outputPage In _allOutputPages
                    If outputPage.Tag = SelectedTab() Then
                        outputPage.Tag = sender.text
                        Exit For
                    End If
                Next
                tabControl.SelectedTab.Text = sender.text
                UpdateTabsInDropDown()
            End If
            'Move focus from the textbox - this will make it dispose
            tabControl.SelectedTab.Focus()
        End If
    End Sub

    Private Sub tbRename_Click(sender As Object, e As EventArgs) Handles tbRename.Click
        Dim rectangle = tabControl.GetTabRect(tabControl.SelectedIndex())
        rectangle = tabControl.RectangleToScreen(rectangle)
        rectangle = tabControl.Parent.RectangleToClient(rectangle)
        Dim textbox = New TextBox With {
            .Font = tabControl.Font
        }
        AddHandler textbox.Leave, AddressOf RenameTextboxLeave
        AddHandler textbox.KeyDown, AddressOf RenameTextboxKeyDown
        textbox.SetBounds(rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height)
        Me.Controls.Add(textbox)
        textbox.BringToFront()
        textbox.Focus()
    End Sub

    Public Sub SaveTab()
        'Saves the content of the output window in RichTextFormat.
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Output Window"
            dlgSaveFile.Filter = "Rich Text Format (*.rtf)|*.rtf"
            dlgSaveFile.FileName = Path.GetFileName(SelectedTab)
            dlgSaveFile.InitialDirectory = _clsInstatOptions.strWorkingDirectory
            If DialogResult.OK = dlgSaveFile.ShowDialog() Then
                Try
                    _selectedOutputPage.Save(dlgSaveFile.FileName)
                Catch
                    MsgBox("Could not save the output window." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub tbSave_Click(sender As Object, e As EventArgs) Handles tbSave.Click
        SaveTab()
    End Sub

    Private Sub tabControl_DoubleClick(sender As Object, e As EventArgs) Handles tabControl.DoubleClick
        If _selectedOutputPage.CanRename Then
            tbRename_Click(sender, e)
        End If
    End Sub

End Class
