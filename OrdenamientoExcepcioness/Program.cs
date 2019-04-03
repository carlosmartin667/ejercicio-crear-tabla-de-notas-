using System;

namespace Ordenamiento
{
  class Program
  {
    static void Main(string[] args)
    {
      //array
      double[] Numeros = new double[10];
      double Num;
      double promedio = 0;
      double mayor = 0;
      double menor =0;
      Console.WriteLine("introducir 10 numeros");
      for (int i = 0; i < Numeros.Length; i++)
      {
        Console.Write("escriba numeros:");
        while (!double.TryParse(Console.ReadLine(), out Num))
        {
          Console.WriteLine("Le dije que escriba un numero");
          continue;
        }
  Numeros[i] = Num;
        Console.WriteLine("La Cantidad introducida es: " + Numeros[i]);  
        if (mayor <= Numeros[i])
        {
          mayor = Numeros[i];
        }
        promedio += Numeros[i];
      }
      Console.WriteLine();
      Console.WriteLine("los numeros MOSTRADOS DE forma inversa a la cual fueron cargados");
      Console.WriteLine();
      for (int i = Numeros.Length - 1; i >= 0; i--)
      {
        Console.WriteLine(" los numeros que existen son : " + Numeros[i]);
        for (int j = 0; j < Numeros.Length; j++)
        {
          if (Numeros[j] <= Numeros[i])
          {
            menor = Numeros[j];
          }
        }
      }
      Console.WriteLine();
      //numero mayor
      Console.WriteLine("el mayor es " + mayor);
      //numero menor
      Console.WriteLine();
      Console.WriteLine("el menor es " + menor);
      Console.WriteLine();
      //promedio es
      Console.WriteLine("el promedio es :" + promedio / Numeros.Length);
    }
  }
}
