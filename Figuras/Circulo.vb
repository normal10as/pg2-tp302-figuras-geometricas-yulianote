Public Class Circulo
    Inherits Figura
    Private _radio As UShort

    Sub New(nombre As String, radio As UShort)
        MyBase.New(nombre)
        Me.Radio = radio
    End Sub

    Public Property Radio As UShort
        Get
            Return _radio
        End Get
        Set(value As UShort)
            _radio = Radio
        End Set
    End Property

    Public Overrides Function calcularArea() As Single
        Return 3.14 * Math.Pow(Radio, 2)
    End Function
End Class
