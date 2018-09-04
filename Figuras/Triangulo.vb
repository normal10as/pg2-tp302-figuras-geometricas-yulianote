Public Class Triangulo
    Inherits Figura
    Private _base As UShort
    Private _altura As UShort

    Sub New(nombre As String, base As UShort, altura As UShort)
        MyBase.New
        Me.Nombre = ""
    End Sub

    Public Property Base As UShort
        Get
            Return _base
        End Get
        Set(value As UShort)
            _base = Base
        End Set

    End Property

    Public Property Altura As UShort
        Get
            Return _base
        End Get
        Set(value As UShort)
            _altura = Altura
        End Set
    End Property

    Public Overrides Function calcularArea() As Single
        Return (Base * Altura) / 2
    End Function
End Class
