Imports R_Dialogs

Public Class dataframeSelectorControl
    Private _dataFrameSelector As DataFrameSelector




    Public Sub Initialize(dataframeSelector As DataFrameSelector)
        _dataFrameSelector = dataframeSelector

        Dim bindingSource As New BindingSource
        bindingSource.DataSource = _dataFrameSelector
        cbDataframe.DataSource = _dataFrameSelector.DataFrames
        cbDataframe.DisplayMember = _dataFrameSelector.Selected
        cbDataframe.ValueMember = _dataFrameSelector.Selected
    End Sub
End Class
