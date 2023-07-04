Imports R_Dialogs

Public Class columnSelectorControl
    Private _columnSelector As ColumnSelector
    Public Sub Initialize(columnSelector As ColumnSelector)
        _columnSelector = columnSelector

        Dim bindingSource As New BindingSource
        bindingSource.DataSource = _columnSelector
        lbColumns.DataSource = _columnSelector.Columns
        lbSelected.DataSource = _columnSelector.Selected
    End Sub

    Private Sub lbColumns_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbColumns.MouseDoubleClick
        lbSelected.Items.Add(lbColumns.SelectedItem)
    End Sub
End Class
