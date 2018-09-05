Imports Entidades
Module CuadradoTest
    Sub Main()

        Dim cuadrado2 As New Cuadrado("Cuadrado2", 4)
        Console.WriteLine("El Nombre igresado es: " & cuadrado2.Nombre)
        Console.WriteLine("El Lado ingresado es: " & cuadrado2.Lado)
        Console.WriteLine("El Area del Cuadrado es: " & cuadrado2.CalcularArea())
        Console.WriteLine()

        Console.ReadKey()
    End Sub
End Module