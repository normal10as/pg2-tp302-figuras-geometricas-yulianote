Public Class Figura

    Private _nombre As String

    Sub New(nomre As String)
        _nombre = ""
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = Nombre
        End Set
    End Property

    Public Overridable Function calcularArea() As Single
        Return 0
    End Function
End Class
