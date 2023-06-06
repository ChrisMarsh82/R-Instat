

Imports R_Adapter2.R_Adapter.DataBook
Imports R_Adapter2.R_Adapter.ScriptBuilder

Public Class DataFrameSelector
    Inherits SingleElementControl
    Implements IRFunctionControl

    Private ReadOnly _databook As DataBook = DataBook.SingletonInstance()

    Private ReadOnly _dataFrames As List(Of String)

    Public Event SelectedDataFrameChanged(columns As List(Of String))

    Public Property Selected() As String
        Get
            Return _selected
        End Get
        Set(ByVal value As String)
            _selected = value
            RaiseEvent SelectedDataFrameChanged(GetColumns)
        End Set
    End Property

    Public Sub New()
        _dataFrames = New List(Of String)
        For Each DataFrame In _databook.DataFrames
            _dataFrames.Add(DataFrame.strName)
        Next
    End Sub

    Public ReadOnly Property DataFrames() As List(Of String)
        Get
            Return _dataFrames
        End Get
    End Property

    Private Function GetColumns() As List(Of String)
        Dim column As New List(Of String)
        For i = 0 To _databook.GetDataFrame(_selected).clsColumnMetaData.iColumnCount - 1
            column.Add(_databook.GetDataFrame(_selected).clsColumnMetaData.strColumnName(i))
        Next
        Return column
    End Function

    Public Function GetRFunction() As RFunction Implements IRFunctionControl.GetRFunction
        Dim rFunction As New RFunction
        rFunction.SetDataBookCommand("get_data_frame")
        rFunction.AddParameter("data_name", GetParameterWithQuotes)
        Return rFunction
    End Function
End Class
