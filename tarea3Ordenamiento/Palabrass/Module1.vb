Module Module4

  Sub Main()
    Dim nro, millones, miles, unidades As Integer
    Dim txt As String

    Do While True
      txt = ""

      Console.Write("Ingese un valor entero entre 1 y 999: ")
      nro = Console.ReadLine

      If nro = -1 Then Exit Sub

      'Obtenemos millones, miles y unidades en bloques de 3 digitos.
      millones = Int(nro / 1000000)
      miles = Int((nro - millones * 1000000) / 1000)
      unidades = nro - millones * 1000000 - miles * 1000

      'Excepcion en el caso de que nro sea menor a un millón.
      If millones > 0 Then
        If millones = 1 Then
          txt = "un millon"
        Else
          txt = bloque(millones) + " millones"
        End If
      End If

      'filtro para grupo de miles mayor a 1
      If miles > 0 Then
        If miles = 1 Then
          txt = txt + " un mil"
        Else
          txt = txt + " " + bloque(miles) + " mil"
        End If
      End If

      'filtro para unidades mayor a uno.
      If unidades > 0 Then
        txt = txt + " " + bloque(unidades)
      End If

      Console.WriteLine(Trim(txt))

    Loop

  End Sub

  Function bloque(ByVal numero As Integer) As String

    Dim x, u1, d1, c1 As Integer
    Dim texto, u(29), d(9), c(9) As String

    u(1) = "uno"
    u(2) = "dos"
    u(3) = "tres"
    u(4) = "cuatro"
    u(5) = "cinco"
    u(6) = "seis"
    u(7) = "siete"
    u(8) = "ocho"
    u(9) = "nueve"
    u(10) = "diez"
    u(11) = "once"
    u(12) = "doce"
    u(13) = "trece"
    u(14) = "catorce"
    u(15) = "quince"
    u(16) = "dieciseis"
    u(17) = "diecisiete"
    u(18) = "dieciocho"
    u(19) = "diecinueve"
    u(20) = "veinte"
    u(21) = "veintiuno"
    u(22) = "veintidos"
    u(23) = "veintitres"
    u(24) = "veinticuatro"
    u(25) = "veinticinco"
    u(26) = "veintiseis"
    u(27) = "veintisiete"
    u(28) = "veintiocho"
    u(29) = "veintinueve"

    d(3) = "treinta"
    d(4) = "cuarenta"
    d(5) = "cincuenta"
    d(6) = "sesenta"
    d(7) = "setenta"
    d(8) = "ochenta"
    d(9) = "noventa"

    c(1) = "ciento"
    c(2) = "docientos"
    c(3) = "trescientos"
    c(4) = "cuatrocientos"
    c(5) = "quinientos"
    c(6) = "seiscientos"
    c(7) = "setecientos"
    c(8) = "ochocientos"
    c(9) = "novecientos"

    c1 = Int(numero / 100)
    d1 = Int((numero - c1 * 100) / 10)
    u1 = numero - c1 * 100 - d1 * 10

    texto = ""

    'Conformaciòn del texto de las centenas.
    texto = c(c1)

    'Tratamiento de la decena separando para el caso de menores a 30.
    If d1 < 3 Then
      texto = texto + " " + u(d1 * 10 + u1)
    Else
      If u1 > 0 Then
        texto = texto + " " + d(d1) + " y " + u(u1)
      Else
        texto = texto + " " + d(d1)
      End If
    End If

    'Excepcion al valor 100.
    If numero = 100 Then
      texto = "cien"
    End If

    Return Trim(texto)
    End Sub

End Module
