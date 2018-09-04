Public Class Cuadrado
    Inherits Figura
    Private _lado As UShort

    Sub New(nombre As String, lado As UShort)
        MyBase.New(nombre)
        Me.Lado = lado
    End Sub

    Public Property Lado As UShort
        Get
            Return _lado
        End Get
        Set(value As UShort)
            _lado = Lado
        End Set

    End Property


    Public Overrides Function calcularArea() As Single
        Return Lado * Lado
    End Function
End Class
