Module Module1

  Sub Main()


    Dim nro, suma, c As Integer
      Dim promedio As Double

      Do While True
        Console.Write("Ingrese un valor: ")
        nro = Console.ReadLine()
        If nro = 0 Then
          Exit Do

        End If
        c = c + 1
        suma = suma + nro
      Loop
      promedio = suma / c
      Console.WriteLine("La suma es: " + CStr(suma))
      Console.WriteLine("El promedio es: " + CStr(promedio))


  End Sub

End Module
