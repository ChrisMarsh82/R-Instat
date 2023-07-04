Imports R_Dialogs

Public Class DialogTemplate

    Private _linkedControl As OneVariableSummarise

    Public Sub Initalize(control As OneVariableSummarise) 'ToDo Should be generic
        _linkedControl = control
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        _linkedControl.PopulateScripts()
    End Sub


    Public Sub AddControl(control As Control, column As Integer, row As Integer, columnSpan As Integer, rowSpan As Integer)
        LayoutPanel.Controls.Add(control, column, row)
        control.Dock = DockStyle.Fill
        LayoutPanel.SetColumnSpan(control, columnSpan)
        LayoutPanel.SetRowSpan(control, rowSpan)
    End Sub
End Class