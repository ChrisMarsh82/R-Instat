Public Class SingleElementControl
    Implements IControl
    'ToDo split this up and add another Interface??
    Protected _selected As String
    Protected _selectedBoolean As Boolean
    Protected _selectedInteger As Integer

    'ToDo should be done a bit different so each control can decide what makes it enabled/visible
    Public Function LinkedControlValue() As Boolean
        Return _selected
    End Function

    Public Function GetParameterWithQuotes() As String Implements IControl.GetParameterWithQuotes
        Return """" + _selected + """"
    End Function

    Public Function GetParameter() As String Implements IControl.GetParameter
        Return _selected
    End Function


    Private _visiblityControl As SingleElementControl
    Private _enabledControl As SingleElementControl
    Public ReadOnly Property Visible() As Boolean
        Get
            Return _visiblityControl.LinkedControlValue
        End Get
    End Property

    Public ReadOnly Property Enabled() As Boolean
        Get
            Return _enabledControl.LinkedControlValue
        End Get
    End Property

    Public Sub LinkVisiblityToControl(control As SingleElementControl)
        _visiblityControl = control
    End Sub

    Public Sub LinkEnabledToControl(control As SingleElementControl)
        _enabledControl = control
    End Sub
End Class
