Public Class TextSelector
    Inherits SingleElementControl


    Public Property Selected() As String
        Get
            Return _selected
        End Get
        Set(ByVal value As String)
            _selected = value
        End Set
    End Property

    Public Sub New(defaultText As String)
        _selected = defaultText
    End Sub


End Class
