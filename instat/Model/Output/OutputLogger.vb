' R- Instat
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

''' <summary>
''' Logging class to hold all scripts and outputs ran. 
''' Holds multiple lists of outputs
''' </summary>
Public Class OutputLogger
    Private _output As List(Of OutputElement)
    Private _lastScriptElement As OutputElement
    Private _filteredOutputs As List(Of OutputList)

    ''Output not used externally at the moment but will this will need to 
    ''change if we are to remove from the output list. 
    'Public ReadOnly Property Output As List(Of OutputElement)
    '    Get
    '        Return _output
    '    End Get
    'End Property

    ''' <summary>
    ''' Holds a list of outputs that can be edited
    ''' </summary>
    ''' <returns></returns>
    Public Property FilteredOutputs() As List(Of OutputList)
        Get
            Return _filteredOutputs
        End Get
        Set(ByVal value As List(Of OutputList))
            _filteredOutputs = value
        End Set
    End Property

    ''' <summary>
    ''' Event to show a new output as been added
    ''' </summary>
    ''' <param name="outputElement"></param>
    Public Event NewOutputAdded(outputElement As OutputElement)

    ''' <summary>
    ''' Event to show an output as been added to a new filtered list
    ''' </summary>
    ''' <param name="outputElement"></param>
    ''' <param name="listName"></param>
    Public Event NewOutputAddedToFilteredList(outputElement As OutputElement, listName As String)

    ''' <summary>
    ''' Event to show a new filtered list has been added
    ''' </summary>
    ''' <param name="listName"></param>
    Public Event NewFilteredListAdded(listName As String)

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        _output = New List(Of OutputElement)
        _filteredOutputs = New List(Of OutputList)
    End Sub

    ''' <summary>
    ''' Adds script to be displayed within the output
    ''' </summary>
    ''' <param name="script"></param>
    Public Sub AddRScript(script As String)
        'Always add new element to last element for each script
        'This will allow the output to atatch to the script later
        _lastScriptElement = New OutputElement
        _lastScriptElement.AddScript(script)
        _output.Add(_lastScriptElement)
        RaiseEvent NewOutputAdded(_lastScriptElement)
    End Sub

    ''' <summary>
    ''' Adds text output to be displayed within the output
    ''' </summary>
    ''' <param name="output"></param>
    Public Sub AddStringOutput(output As String)
        'Note this is always takes the last script added as corresponding script
        If _lastScriptElement Is Nothing Then
            Throw New Exception("Cannot find script to attach output to.")
        Else
            Dim outputElement As New OutputElement
            outputElement.AddStringOutputFromR(output, _lastScriptElement.FormatedRScript)
            RaiseEvent NewOutputAdded(outputElement)
        End If
    End Sub

    ''' <summary>
    ''' Adds image to be displayed within the output
    ''' </summary>
    ''' <param name="filename"></param>
    Public Sub AddImageOutput(filename As String)
        Dim image As Bitmap
        'Note this is always takes the last script added as corresponding script
        If _lastScriptElement Is Nothing Then
            Throw New Exception("Cannot find script to attach output to.")
        Else
            Using fs As New IO.FileStream(filename, IO.FileMode.Open)
                image = New Bitmap(Drawing.Image.FromStream(fs))
            End Using
            Dim outputElement As New OutputElement
            outputElement.AddImageOutputFromR(image, _lastScriptElement.FormatedRScript)
            RaiseEvent NewOutputAdded(outputElement)
        End If

    End Sub

    ''' <summary>
    ''' Returns the filtered list given the name. Will create the list if doesnt already exist.
    ''' </summary>
    ''' <param name="listName"></param>
    ''' <param name="create"></param>
    ''' <returns></returns>
    Public Function GetFilteredList(listName As String, Optional create As Boolean = True) As OutputList
        Dim filteredList As OutputList
        filteredList = _filteredOutputs.Where(Function(x) x.Name = listName).FirstOrDefault()
        If filteredList Is Nothing And create Then
            filteredList = New OutputList(listName)
            _filteredOutputs.Add(filteredList)
            RaiseEvent NewFilteredListAdded(listName)
        End If
        Return filteredList
    End Function

    ''' <summary>
    ''' Adds an output to the given filtered list
    ''' </summary>
    ''' <param name="outputElement"></param>
    ''' <param name="listName"></param>
    Public Sub AddOutputToFilteredList(outputElement As OutputElement, listName As String)
        Dim filteredList As OutputList
        filteredList = GetFilteredList(listName)
        outputElement.Id = filteredList.Output.Count + 1
        filteredList.Output.Add(outputElement)
        RaiseEvent NewOutputAddedToFilteredList(outputElement, listName)
    End Sub

    ''' <summary>
    ''' Checks to see if list name is a valid name for a filtered list
    ''' </summary>
    ''' <param name="listName"></param>
    ''' <returns></returns>
    Public Function IsValidFilteredListName(listName As String) As Boolean
        If Trim(listName) Is "" Then
            Return False
        End If
        If _filteredOutputs.Where(Function(x) x.Name = listName).Any() Then
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Deletes output from a filtered list
    ''' </summary>
    ''' <param name="outputElement"></param>
    ''' <param name="listName"></param>
    Public Sub DeleteOutputFromFilteredList(outputElement As OutputElement, listName As String)
        Dim filteredList As OutputList
        filteredList = GetFilteredList(listName, False)
        Dim elementId As Integer = outputElement.Id
        filteredList.Output.RemoveAll(Function(x) x.Id = elementId)
        For Each element In filteredList.Output.Where(Function(x) x.Id > elementId)
            element.Id -= 1
        Next
    End Sub

End Class
