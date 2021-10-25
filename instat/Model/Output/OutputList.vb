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
''' List of output elements for R 
''' </summary>
Public Class OutputList
    Private _name As String
    Private _output As List(Of OutputElement)

    ''' <summary>
    ''' Name of list
    ''' </summary>
    ''' <returns></returns>
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    ''' <summary>
    ''' R output elements 
    ''' </summary>
    ''' <returns></returns>
    Public Property Output() As List(Of OutputElement)
        Get
            Return _output
        End Get
        Set(ByVal value As List(Of OutputElement))
            _output = value
        End Set
    End Property

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="name"></param>
    Public Sub New(name As String)
        _name = name
        _output = New List(Of OutputElement)
    End Sub

    ''' <summary>
    ''' Changes position of element - Up
    ''' </summary>
    ''' <param name="outputElement"></param>
    Public Sub MoveElementUp(outputElement As OutputElement)
        If outputElement.Id > 1 Then
            _output.Where(Function(x) x.Id = outputElement.Id - 1).First.Id = outputElement.Id
            outputElement.Id += -1
        End If
    End Sub

    ''' <summary>
    ''' Changes position of element - Down
    ''' </summary>
    ''' <param name="outputElement"></param>
    Public Sub MoveElementDown(outputElement As OutputElement)
        If outputElement.Id < _output.Count Then
            _output.Where(Function(x) x.Id = outputElement.Id + 1).First.Id = outputElement.Id
            outputElement.Id += 1
        End If
    End Sub

End Class