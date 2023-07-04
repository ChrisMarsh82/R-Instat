Public Class CheckboxSelector
    Inherits SingleElementControl

    Public Property Selected() As Boolean
        Get

            Return _selectedBoolean
        End Get
        Set(ByVal value As Boolean)
            _selectedBoolean = value
        End Set
    End Property

    Public Sub New(Optional defaultValue As Boolean = False)
        _selectedBoolean = defaultValue
    End Sub
End Class
