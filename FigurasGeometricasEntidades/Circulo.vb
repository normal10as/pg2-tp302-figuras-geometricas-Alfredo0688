Public Class Circulo
    Inherits Figura

    Private _radio As UShort


    Sub New(nombre As String, radio As UShort)
        MyBase.New(nombre)
        Me.Radio = radio
    End Sub


    Public Property Radio As UShort
        Get
            Return _Radio
        End Get
        Set(value As UShort)
            _Radio = value
        End Set
    End Property

    Public Overrides Function CalcularArea() As Single
        Return Math.PI * Radio ^ 2
    End Function
End Class