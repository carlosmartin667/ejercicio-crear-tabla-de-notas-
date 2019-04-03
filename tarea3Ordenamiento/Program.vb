Imports System
Module Numeros

  Sub Main()

    Dim a, b, c As Double

    Console.Write("Ingrese el cateto a ")

    a = Console.ReadLine

    Console.Write("Ingrese el cateto b ")

    b = Console.ReadLine

    c = hipotenusa(a, b)

    Console.WriteLine("La hipotenusa es " + CStr(c))

    Console.ReadLine()

  End Sub

  Private Function hipotenusa(ByVal a, ByVal b) As Double

    Dim c As Double

    c = Math.Sqrt(a ^ 2 + b ^ 2)

    Return c

  End Function

End Module
