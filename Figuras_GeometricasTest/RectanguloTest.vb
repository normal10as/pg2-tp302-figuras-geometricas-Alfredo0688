Imports Entidades
Module RectanguloTest
    Sub Main()

        Dim rectangulo2 As New Rectangulo("Rectangulo2", 4, 6)
        Console.WriteLine("El Nombre igresado es: " & rectangulo2.Nombre)
        Console.WriteLine("La Base ingresada es: " & rectangulo2.Base)
        Console.WriteLine("La Altura ingresada es: " & rectangulo2.Altura)
        Console.WriteLine("El Area del Rectangulo es: " & rectangulo2.CalcularArea())
        Console.WriteLine()

        Console.ReadKey()
    End Sub
End Module