Module Module1

  Sub Main()


    Dim a, b, c, d, e, sumar, promedio As Double

    Console.Write("Ingrese el Numero a ")
    a = Console.ReadLine
    Console.Write("Ingrese el Numero b ")
    b = Console.ReadLine
    Console.Write("Ingrese el Numero c ")
    c = Console.ReadLine
    Console.Write("Ingrese el Numero d ")
    d = Console.ReadLine
    Console.Write("Ingrese el Numero e ")
    e = Console.ReadLine
    Console.WriteLine()
    sumar = a + b + c + d + e
    Console.WriteLine("la suma de  todo " + CStr(sumar))
    Console.WriteLine()
    promedio = sumar / 5
    Console.WriteLine("el promedio " + CStr(promedio))
    Console.WriteLine()
  End Sub

End Module
