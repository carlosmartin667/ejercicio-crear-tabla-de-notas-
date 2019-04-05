using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasarNumerosALetras2
{
  class Program
  {
    static void Main(string[] args)
    {

      string linea;

      double[] Numeros1digito = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      double[] Numerosdigito = new double[5] { 1,2,3 ,4,5 };
      double[] Numeros2digito = new double[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


      string[] Palabras1digito = new string[10] { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
      string[] Palabrasdigito = new string[5] { "once", "doce", "trece", "catorce", "quince" };
      string[] Palabras2digito = new string[9] { "diez", "viente", "treinta", "cuarenta", "sincuenta", "sesenta", "setenta", "ochenta", "Noventa" };
      string cien = "ciento";
      string mil = "mil";
      Console.Write("Indica una cantidadtidad que desa convertir :");
      linea = Console.ReadLine();
      double Numero = float.Parse(linea);

      double[] digitos = new double[linea.Length];
        for (int i = 0; i < linea.Length; i++)
      {
        digitos[i] = double.Parse(linea.Substring(i, 1));
        Console.WriteLine(digitos[i]);
      }

      string[] PalabraNumero = new string[digitos.Length];

      for (int j = 0; j < digitos.Length; j++)
      {

        for (int i = 0; i < Numeros2digito.Length; i++)
        {
          if (digitos[j] == Numeros2digito[i])
          {
            Console.WriteLine(Palabras2digito[i]);
          }
          if (Convert.ToInt32(digitos[j]) == Numeros2digito[i])
          {
            Console.WriteLine(Palabras2digito[i] + mil);
          }
          if (Convert.ToInt32(digitos[j]) == Numeros1digito[i])
          {
            Console.WriteLine(Palabras1digito[i] + cien + mil);
          }
        }

        for (int i = 0; i < Numeros1digito.Length; i++)
        {

          if (Convert.ToInt32(digitos[j]) == Numeros1digito[i])
          {
            Console.WriteLine(Palabras1digito[i] + cien);
          }
          if (digitos[j] == Numeros1digito[i])
          {
            Console.WriteLine(Palabras1digito[i]);

          }
          if (Convert.ToInt32(digitos[j]) == Numeros1digito[i])
          {
            Console.WriteLine(Palabras1digito[i] + mil);
          }

        }
      }
    }
  }
}
