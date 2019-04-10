Module Sumar1

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

    sumar = a + b + c + d + e
    Console.Write("la suma de  todo " + CStr(sumar))
    promedio = sumar / 5
    Console.Write("la suma de  todo " + CStr(promedio))

  End Sub

End Module
