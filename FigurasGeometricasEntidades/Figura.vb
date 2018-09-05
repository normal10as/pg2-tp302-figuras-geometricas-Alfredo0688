Public MustInherit Class Figura

    Private _nombre As String

    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property


    Public MustOverride Function CalcularArea() As Single
End Class