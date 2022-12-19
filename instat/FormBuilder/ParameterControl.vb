Public Class ParameterControl
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _control As ucrCore

    Public Sub New(name As String, control As ucrCore)
        _name = name
        _control = control
    End Sub

    Public Property Control() As ucrCore
        Get
            Return _control
        End Get
        Set(ByVal value As ucrCore)
            _control = value
        End Set
    End Property
End Class
