Public Class Rectangulo
    Inherits Figura

    Private _base As UShort
    Private _altura As UShort


    Sub New(nombre As String, base As UShort, altura As UShort)
        MyBase.New(nombre)
        Me.Nombre = nombre
        Me.Base = base
        Me.Altura = altura
    End Sub

    Public Property Base As UShort
        Get
            Return _Base
        End Get
        Set(value As UShort)
            _Base = value
        End Set
    End Property

    Public Property Altura As UShort
        Get
            Return _Altura
        End Get
        Set(value As UShort)
            _Altura = value
        End Set
    End Property

    Public Overrides Function CalcularArea() As Single
        Return Base * Altura
    End Function
End Class