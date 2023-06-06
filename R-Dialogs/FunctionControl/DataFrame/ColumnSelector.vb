Imports R_Adapter2.R_Adapter.ScriptBuilder

Public Class ColumnSelector
    Inherits MultiElementControl
    Implements IRFunctionControl

    Private _dataframeSelector As DataFrameSelector
    Private _columns As List(Of String)

    Public Sub New(dataframeselector As DataFrameSelector)
        _dataframeSelector = dataframeselector
        AddHandler _dataframeSelector.SelectedDataFrameChanged, AddressOf UpdateColumns
    End Sub

    Public ReadOnly Property Columns() As List(Of String)
        Get
            Return _columns
        End Get
    End Property

    Public Property Selected() As List(Of String)
        Get
            Return _selected
        End Get
        Set(ByVal value As List(Of String))
            _selected = value
        End Set
    End Property


    Private Sub UpdateColumns(columns As List(Of String))
        _columns = columns
    End Sub

    Public Function GetRFunction() As RFunction Implements IRFunctionControl.GetRFunction
        Dim rFunction As New RFunction
        rFunction.SetDataBookCommand("get_columns_from_data")
        rFunction.AddParameter("data_name", _dataframeSelector.GetParameterWithQuotes)
        rFunction.AddParameter("col_names", GetParameterWithQuotes)
        Return rFunction
    End Function
End Class
