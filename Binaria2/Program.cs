using System;
using System.Collections.Generic;

namespace ordenbinario
{
  public class Program
  {
    static void Main(string[] args)
    {

      {

        {

          Console.WriteLine("1000 numeros");
          var numeros = new List<int>();

          while (numeros.Count < 1000)
          {

            int numeroAleatorio = new Random().Next(1, 3000);

            if (!numeros.Contains(numeroAleatorio))
            {
              numeros.Add(numeroAleatorio);
            }
          }
          const int n = 1000;

          int i, j, datoTemporal;

          Console.Write("Ordenando... ");
          for (i = 0; i < n - 1; i++)
          {
            for (j = i + 1; j < n; j++)
            {
              if (numeros[i] > numeros[j])
              {
                datoTemporal = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = datoTemporal;
              }
            }
          }

          foreach (int numero in numeros)
            Console.Write("{0} ", numero);
          Console.WriteLine();

          //pedimos un numero
          Console.WriteLine("Ingrese un numero entre 1 y 3000...");
          int num = int.Parse(Console.ReadLine());
          int valorBuscado = valorBuscado = num;
          Console.WriteLine("Buscando si aparece {0}...", valorBuscado);

          int limiteInferior = 0;
          int limiteSuperior = 999;
          bool terminado = false;

          while (!terminado)
          {
            int puntoMedio = limiteInferior + (limiteSuperior - limiteInferior) / 2;
            // Aviso de dónde buscamos
            Console.WriteLine("Buscando entre pos {0} y {1}, valores {2} y {3}," +
            " centro {4}:{5}",
            limiteInferior, limiteSuperior,
            numeros[limiteInferior], numeros[limiteSuperior],
            puntoMedio, numeros[puntoMedio]);
            // Compruebo si hemos acertado
            if (numeros[puntoMedio] == valorBuscado)
            {
              Console.WriteLine("Numero Encontrado...");
              terminado = true;
            }
            else if (limiteInferior == limiteSuperior - 1)
            {
              Console.WriteLine("No encontrado: este numero no existe en este contexto...");
              terminado = true;
            }

            // Si no hemos terminado, debemos seguir buscando en una mitad
            if (numeros[puntoMedio] < valorBuscado)
              limiteInferior = puntoMedio;
            else
              limiteSuperior = puntoMedio;
          }

        }
      }

    }
  }
}
