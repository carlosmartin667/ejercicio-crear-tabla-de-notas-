Module tres

  Sub Main()
    Dim a, b, c, Mayor, Menor, iguales As Double

    Console.Write("Ingrese el Numero a ")
    a = Console.ReadLine
    Console.Write("Ingrese el Numero b ")
    b = Console.ReadLine
    Console.Write("Ingrese el Numero c ")
    c = Console.ReadLine
    Console.WriteLine()
    'sacar cual es mayor
    If a > b Then
      Mayor = a
    ElseIf b > a Then
      Mayor = b
    End If
    If Mayor > c Then
      Console.Write(" el numero mayor es: " + CStr(Mayor))
    ElseIf c > Mayor Then
      Console.Write(" el numero mayor es: " + CStr(c))
    End If
    Console.WriteLine()

    'sacar cual es menor
    If a <= b Then
      Menor = a
    ElseIf b <= a Then
      Menor = b
    End If
    If Menor <= c Then
      Console.Write(" el numero Menor es: " + CStr(Menor))
    ElseIf c <= Menor Then
      Console.Write(" el numero Menor es: " + CStr(c))
    End If
    Console.WriteLine()

    'son iguales
    If a = b Then
      iguales = a
    End If
    If iguales = c Then
      Console.Write(" Los numeros son Iguales ")
    End If
    Console.WriteLine()
  End Sub

End Module
