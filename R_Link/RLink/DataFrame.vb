Public Class DataFrame
    Private ReadOnly _RDotNetDataFrame As RDotNet.DataFrame

    Public ReadOnly Property RowNames As String()
        Get
            Return _RDotNetDataFrame.RowNames
        End Get
    End Property

    Public ReadOnly Property ColumnCount As Integer
        Get
            Return _RDotNetDataFrame.ColumnCount
        End Get
    End Property

    Public ReadOnly Property RowCount As Integer
        Get
            Return _RDotNetDataFrame.RowCount
        End Get
    End Property

    Public ReadOnly Property Item(rowName As String, columnName As String) As Object
        Get
            Return _RDotNetDataFrame.Item(rowName, columnName)
        End Get
    End Property

    Public Sub New(rDotNetDataFrame As RDotNet.DataFrame)
        _RDotNetDataFrame = rDotNetDataFrame
    End Sub

End Class