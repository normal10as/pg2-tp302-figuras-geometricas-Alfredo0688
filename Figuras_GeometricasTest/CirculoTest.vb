Imports Entidades
Module CirculoTest
    Sub Main()

        Dim circulo2 As New Circulo("Circulo2", 4)
        Console.WriteLine("El Nombre igresado es: " & circulo2.Nombre)
        Console.WriteLine("El Radio ingresado es: " & circulo2.Radio)
        Console.WriteLine("El Area del Circulo es: " & circulo2.CalcularArea())
        Console.WriteLine()

        Console.ReadKey()
    End Sub
End Module