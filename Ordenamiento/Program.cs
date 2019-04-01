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
      int[] Numeros = new int[10];
      string linea;
      int promedio = 0;
      int mayor = 0;
      int menor = 0;
      for (int i = 0; i < 10; i++)
      {
        Console.Write("escriba 10 numeros:");
        linea = Console.ReadLine();
        Numeros[i] = int.Parse(linea);
        Console.WriteLine("La Cantidad introducida es: " + Numeros[i]);
      }

      Console.WriteLine("Los Numeros son");
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("La los numeros que existen son : " + Numeros[i]);
      }


      Console.WriteLine("los numeros MOSTRADOS DE forma inversa a la cual fueron cargados");
      Console.WriteLine();
      Console.WriteLine("La los numeros que existen son : " + Numeros[9]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[8]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[7]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[6]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[5]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[4]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[3]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[2]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[1]);
      Console.WriteLine("La los numeros que existen son : " + Numeros[0]);

      Console.WriteLine();
      //numero mayor
      for (int i = 0; i < 10; i++)
      {
        if (mayor <= Numeros[i])
        {
          mayor = Numeros[i];
   
        }
      }

      Console.WriteLine("el mayor es " + mayor);
      ////numero menor
      for (int i = 0; i < 10; i++)
      {
        if (menor >=Numeros[i])
        {
          menor = Numeros[i];
        }
      }
      Console.WriteLine();
      Console.WriteLine("el menor es " + menor);
      //promedio es
      for (int i = 0; i < 10; i++)
      {
        promedio +=  Numeros[i];
      }
      Console.WriteLine("el promedio es :" +promedio/10);

    }

  }
}
