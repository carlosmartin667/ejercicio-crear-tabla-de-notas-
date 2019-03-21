using System;


namespace BusquedaBinaria
{
  class Program
  {
    static void Main (string[]args)
    {
      int[] vector;
      vector = new int [1000];
      //genero numeros aleatorios

      Random aleatorio = new Random();
      for (int i = 0; i < 1000; i++)
      {
        vector[i] = Convert.ToInt16(aleatorio.Next(3000));
      }
      for (int i = 0; i < 1000; i++)
      {
        Console.WriteLine(vector[i]+" ");
      }
      Console.Read();
    }




    static void Main(string[] args)
    {
      Console.WriteLine("Matriz de 100 numeros (por ahora)");

      int posi = 0, posj = 0, mayor = 0;

      int[,] matriz = new int[10, 10];
      Random aleatorio = new Random();

      for (int i = 0; i < 10; i++)
        for (int j = 0; j < 10; j++)
        {
          matriz[i, j] = aleatorio.Next(0, 3000);
        }

      for (int i = 0; i < 10; i++)
      {
        for (int j = 0; j < 10; j++)
        {
          if (matriz[i, j] > mayor)
          {
            mayor = matriz[i, j];
            posi = i;
            posj = j;
          }

          Console.Write(matriz[i, j].ToString() + " ");
        }
        Console.WriteLine();

      }
    }
  }
}
