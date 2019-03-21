using System;

namespace ordenbinario
{
  public class Program
  {
    static void Main(string[] args)
    {

      {

        {
          const int n = 1000;
          int[] datos = new int[n];
          int i, j, datoTemporal;

          // Primero generamos datos al azar
          Console.Write("Generando... ");
          Random r = new Random();
          for (i = 0; i < n; i++)
            datos[i] = r.Next(1, 3000);

          // Luego los ordenamos mediante burbuja
          Console.Write("Ordenando... ");
          for (i = 0; i < n - 1; i++)
          {
            for (j = i + 1; j < n; j++)
            {
              if (datos[i] > datos[j])
              {
                datoTemporal = datos[i];
                datos[i] = datos[j];
                datos[j] = datoTemporal;
              }
            }
          }

          foreach (int dato in datos)
            Console.Write("{0} ", dato);
          Console.WriteLine();

          //pedimos un numero
          Console.WriteLine("Ingrese un numero...");
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
            datos[limiteInferior], datos[limiteSuperior],
            puntoMedio, datos[puntoMedio]);
            // Compruebo si hemos acertado
            if (datos[puntoMedio] == valorBuscado)
            {
              Console.WriteLine("Encontrado!");
              terminado = true;
            }
            else if (limiteInferior == limiteSuperior - 1)
            {
              Console.WriteLine("No encontrado");
              terminado = true;
            }
            // Si no hemos terminado, debemos seguir buscando en una mitad
            if (datos[puntoMedio] < valorBuscado)
              limiteInferior = puntoMedio;
            else
              limiteSuperior = puntoMedio;
          }

        }
      }

    }
  }
}
