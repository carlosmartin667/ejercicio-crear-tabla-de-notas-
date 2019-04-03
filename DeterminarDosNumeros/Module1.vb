Module Module1

  Sub Main()

    Dim a, b, Mayor, menor, igual As Double

    Console.Write("Ingrese el Numero a ")
    a = Console.ReadLine
    Console.Write("Ingrese el Numero b ")
    b = Console.ReadLine
    Console.WriteLine()
    'sacar cual es mayor

    If a > b Then
      Mayor = a
      Console.Write(" el numero mayor es: " + CStr(Mayor))
    ElseIf b > a Then
      Mayor = b
      Console.Write(" el numero mayor es: " + CStr(Mayor))
    End If

    'sacar cual es menor
    Console.WriteLine()
    If b < a Then
      menor = b
      Console.Write(" los numero menor es : " + CStr(menor))
    ElseIf a < b Then
      menor = a
      Console.Write(" los numero menor es : " + CStr(menor))
    End If

    Console.WriteLine()
    'numeros iguales
    If Mayor = menor Then
      igual = Mayor
      Console.Write(" los numeros son iguales ")
      Console.WriteLine()
    End If
  End Sub

End Module
