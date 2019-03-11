using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] cadena1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
      int[] cadena2 = new int[4] { 20, 30, 40, 50 };
      int[] cadena3 = new int[8] { 100, 200, 300, 400, 500, 600, 700, 800 };

      int menor = 0;

      Console.Write("C1: [");
      foreach (var num in cadena1)
      {
        Console.Write(num + " ");
      }
      Console.WriteLine("]");

      Console.Write("C2: [");
      foreach (var num in cadena2)
      {
        Console.Write(num + " ");
      }
      Console.WriteLine("]");

      Console.Write("C3: [");
      foreach (var num in cadena3)
      {
        Console.Write(num + " ");
      }
      Console.WriteLine("]");

      if (menor == 0)
      {
        if (cadena1.Length <= cadena2.Length)
        {
          menor = cadena1.Length;
        }
        else
        {
          menor = cadena2.Length;
        }

        if (cadena3.Length < menor)
        {
          menor = cadena3.Length;
        }
      }

      int[,] arr4 = new int[menor, 3];
      for (int i = 0; i < menor; i++)
      {
        for (int j = 0; j < 3; j++)
        {
     
 
          switch (j)
          {
            case 0:
              {
                arr4[i, j] = cadena1[i];           
              }
              break;
            case 1:
              {
                arr4[i, j] = cadena2[i];
              }
              break;
            case 2:
              {
                arr4[i, j] = cadena3[i];
              }
              break;
            default:

              break;
          }

        }

      }
      Console.WriteLine();
      Console.WriteLine("Combinacion: ");
      for (int i = 0; i < menor; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          Console.Write(arr4[i, j] + " ");
        }
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.Write("C1 sin combinar: [");
      for (int i = menor; i < cadena1.Length; i++)
      {
        Console.Write(cadena1[i] + " ");
      }
      Console.WriteLine("]");

      Console.WriteLine();
      Console.Write("C2 sin combinar: [");
      for (int i = menor; i < cadena2.Length; i++)
      {
        Console.Write(cadena2[i] + " ");
      }
      Console.WriteLine("]");

      Console.WriteLine();
      Console.Write("C3 sin combinar: [");
      for (int i = menor; i < cadena3.Length; i++)
      {
        Console.Write(cadena3[i] + " ");
      }
      Console.WriteLine("]");
      Console.ReadKey();
    }
  }
}
