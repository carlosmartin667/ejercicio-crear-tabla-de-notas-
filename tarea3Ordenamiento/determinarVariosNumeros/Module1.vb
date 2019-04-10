Module Sumar

  Sub Main()

    Dim cantidad, mayor, Menor, Iguales As Double
    Menor = 99999999999999999
    Console.Write("Ingrese la cantidad de numeros que quiere comprar: ")
    cantidad = Console.ReadLine
    Console.WriteLine()

    Dim num(cantidad) As Double

    For index = 0 To cantidad - 1
      Console.Write("Ingrese el Numero  ")
      num(index) = Console.ReadLine
      Console.WriteLine()
    Next

    For indexs = 0 To cantidad - 1
      If num(indexs) > mayor Then
        mayor = num(indexs)
      End If
    Next
    Console.Write("el numero mayor es : " + CStr(mayor))
    Console.WriteLine()

    For indexs = 0 To cantidad - 1
      If num(indexs) < Menor Then
        Menor = num(indexs)
      End If
    Next
    Console.Write("el numero mayor es : " + CStr(Menor))
    Console.WriteLine()

    For x = 0 To cantidad - 1
      For j = 0 To cantidad - 1
        If num(j) = num(x) Then
          Iguales = Iguales + 1
        End If
      Next
    Next
    Console.Write("la cantidad de numeros   que se repiten son : " + CStr(Iguales - cantidad))

    Console.WriteLine()

    If Iguales = cantidad Then
      Console.WriteLine("todo los numeros son iguales")

    End If
    Console.WriteLine()

  End Sub

End Module
