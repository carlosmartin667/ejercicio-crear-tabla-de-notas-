using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
  class Program
  {
    static void Main(string[] args)
    {
      //array
      double[] Numeros = new double[10];
      string linea;
      double promedio = 0;
      double mayor = 0;
      double menor = 0;
      double Num = 0;
      Console.WriteLine("escriba 10 NUMEROS");
      for (int i = 0; i < 10; i++)
      {
        if (!double.TryParse(Console.ReadLine(), out Num))
        {
          Console.WriteLine("Le dije que escriba un numero");
          return;
        }
        Numeros[i] = Num;
        Console.WriteLine("La Cantidad introducida es: " + Numeros[i]);
      }

      Console.WriteLine("Los Numeros son");
      for (int i = 0; i < Numeros.Length; i++)
      {
        Console.WriteLine("los numeros que existen son : " + Numeros[i]);
      }
  
      Console.WriteLine("los numeros MOSTRADOS DE forma inversa a la cual fueron cargados");
      Console.WriteLine();
      for (int i = Numeros.Length-1; i >= 0; i--)
      {

        Console.WriteLine(" los numeros que existen son : " + Numeros[i]);
      }
      Console.WriteLine();
      //numero mayor
      for (int i = 0; i < Numeros.Length; i++)
      {
        if (mayor <= Numeros[i])
        {
          mayor = Numeros[i];
   
        }
      }
      Console.WriteLine("el mayor es " + mayor);
      //numero menor
      for (int j = 9; j >= 0; j--)
      {

        for (int i = 0; i < Numeros.Length; i++)
        {
          if (Numeros[i] < Numeros[j])
          {
            menor = Numeros[i];
          }
        }
      }
      Console.WriteLine();
      Console.WriteLine("el menor es " + menor);
      Console.WriteLine();
      //promedio es
      for (int i = 0; i < Numeros.Length; i++)
      {
        promedio +=  Numeros[i];
      }
      Console.WriteLine("el promedio es :" +promedio / Numeros.Length);
    }
   
  }
}
