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

Imports R_Adapter2.R_Adapter.Constant
Imports R_Adapter2.R_Adapter.RLink
Imports R_Adapter2.R_Adapter.ScriptBuilder
Imports RDotNet

''' <summary>
''' Holds Column Meta Data for a single dataframe
''' </summary>
'''
Namespace R_Adapter.DataBook

    Public Class ColumnMetaData
        Private _strDataFrameName As String
        Private _scriptRunner As ScriptRunner = ScriptRunner.SingletonInstance()
        Private Property _clsColsMetadataDataFrame As RDotNet.DataFrame
        Private _hasChanged As Boolean

        ''' <summary>
        ''' holds the metadata change audit id
        ''' </summary>
        Public Property MetadataChangeAuditId As Integer

        ''' <summary>
        ''' Returns data for a given cell within the Column Meta data table
        ''' </summary>
        ''' <param name="iRowIndex"></param>
        ''' <param name="iColumnIndex"></param>
        ''' <returns></returns>
        Public ReadOnly Property Data(iRowIndex As Integer, iColumnIndex As Integer) As Object
            Get
                Return _clsColsMetadataDataFrame.Item(iRowIndex, iColumnIndex)
            End Get
        End Property

        ''' <summary>
        ''' Returns row name of a given row
        ''' </summary>
        ''' <param name="row"></param>
        ''' <returns></returns>
        Public ReadOnly Property strRowName(row As Integer) As String
            Get
                Return _clsColsMetadataDataFrame.RowNames(row)
            End Get
        End Property

        ''' <summary>
        ''' Returns total number of rows within the column metadata table
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property iRowCount As Integer
            Get
                Return _clsColsMetadataDataFrame.RowCount
            End Get
        End Property

        ''' <summary>
        ''' Returns the column name of a given column
        ''' </summary>
        ''' <param name="column"></param>
        ''' <returns></returns>
        Public ReadOnly Property strColumnName(column As Integer) As String
            Get
                Return _clsColsMetadataDataFrame.ColumnNames(column)
            End Get
        End Property

        ''' <summary>
        ''' Returns total number of columns within the column metadata table
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property iColumnCount As Integer
            Get
                Return _clsColsMetadataDataFrame.ColumnCount
            End Get
        End Property

        ''' <summary>
        ''' holds whether the dataframe is different from visual grid component
        ''' ToDo This is more ViewModel level not here where its stored
        ''' </summary>
        ''' <returns></returns>
        Public Property HasChanged() As Boolean
            Get
                Return _hasChanged
            End Get
            Set(value As Boolean)
                _hasChanged = value
            End Set
        End Property

        ''' <summary>
        ''' Creates new instance of a column metadata class
        ''' </summary>
        ''' <param name="rLink"></param>
        ''' <param name="strName"></param>
        Public Sub New(strName As String)
            _strDataFrameName = strName
            _hasChanged = True
        End Sub

        Private Function HasDataChanged() As Boolean
            Dim clsVariablesMetadataChanged As New RFunction
            clsVariablesMetadataChanged.SetDataBookCommand("get_variables_metadata_changed")
            clsVariablesMetadataChanged.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
            Return _scriptRunner.RunInternalScriptGetBoolean(clsVariablesMetadataChanged.ToScript())
        End Function

        ''' <summary>
        ''' Updates column Meta Data if data has changed
        ''' </summary>
        Public Sub RefreshData()
            'Need to check to see if dataframe exists due to the column meta data not changing when sheets are un-hidden
            If _clsColsMetadataDataFrame Is Nothing OrElse HasDataChanged() Then
                _clsColsMetadataDataFrame = GetColsMetadataFromRCommand()
                SetColsMetadataToNotChangedInR()

                'this change number should eventually come from R
                'once that is done;
                'HasDataChanged() should be re-implemeted
                'HasChanged property can be deleted
                'SetColsMetadataToNotChangedInR() can be deleted
                MetadataChangeAuditId += 1
            End If
        End Sub

        Private Function GetColsMetadataFromRCommand() As RDotNet.DataFrame
            Dim clsGetVariablesMetadata As New RFunction
            Dim expTemp As SymbolicExpression
            _hasChanged = True
            clsGetVariablesMetadata.SetDataBookCommand("get_variables_metadata")
            clsGetVariablesMetadata.AddParameter("convert_to_character", "TRUE")
            clsGetVariablesMetadata.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
            Return _scriptRunner.RunInternalScriptGetDataFrame(clsGetVariablesMetadata.ToScript())
        End Function

        Private Sub SetColsMetadataToNotChangedInR()
            Dim clsSetVariablesMetadataChanged As New RFunction
            clsSetVariablesMetadataChanged.SetDataBookCommand("set_variables_metadata_changed")
            clsSetVariablesMetadataChanged.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
            clsSetVariablesMetadataChanged.AddParameter("new_val", "FALSE")
            _scriptRunner.RunInternalScript(clsSetVariablesMetadataChanged.ToScript())
        End Sub

    End Class

End Namespace