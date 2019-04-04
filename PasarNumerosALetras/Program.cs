using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasarNumerosALetras
{
  class Program
  {
    static void Main(string[] args)
    {
      double Numero;
      string linea;
      double[] Numeros1digito = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      double[] Numerosdigito = new double[5] { 11, 12, 13, 14, 15 };
      double[] Numeros2digito = new double[9] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
      double dosdigito;

      //double[] Numeros3digito = new double[9] { 100, 200, 300, 400, 500, 600, 700, 800, 900 };

      string[] Palabras1digito = new string[10] { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
      string[] Palabrasdigito = new string[5] { "once", "doce", "trece", "catorce", "quince" };
      string[] Palabras2digito = new string[9] { "diez", "viente", "treinta", "cuarenta", "sincuenta", "sesenta", "setenta", "ochenta", "Noventa" };
      string cien = "ciento";
      string mil = "mil";
      Console.Write("Indica una cantidadtidad que desa convertir :");
      linea = Console.ReadLine();
      Numero = float.Parse(linea);





      //nuero Numeros1digito
      for (int i = 0; i < Numeros1digito.Length; i++)
      {
        if (Numero == Numeros1digito[i])
        {
          Console.WriteLine(Palabras1digito[i]);
        }

      }
      //Numeros 2 digito
      if (Numero < 99 &&  Numero < 16)
      {
        for (int i = 0; i < Numerosdigito.Length; i++)
        {
          if (Numero == Numerosdigito[i])
          {
            Console.Write(Palabrasdigito[i]);
          }
          dosdigito = Numero / 10;
          if (Numero == Numeros1digito[i])
          {
            Console.WriteLine(Palabras1digito[i]);
          }
        }
      }
  

      for (int i = 0; i < Numeros2digito.Length; i++)
      {
        if (Numero == Numeros2digito[i])
        {
          Console.WriteLine(Palabras2digito[i]);
        }
      }

      if (Numero < 999 && Numero > 100)
      {
        double Numeros3digito = Numero / 100;
        for (int i = 0; i < Numeros1digito.Length; i++)
        {

          if (Convert.ToInt32(Numeros3digito) == Numeros1digito[i])
          {
            Console.WriteLine(Palabras1digito[i] + cien);
          }
        }
      }


      if (Numero <= 999999 && Numero > 1000)
      {
        double Numeros3digito = Numero / 1000;
        for (int i = 0; i < Numeros1digito.Length; i++)
        {
          if (Convert.ToInt32(Numeros3digito) == Numeros1digito[i])
          {
            Console.WriteLine(Palabras1digito[i] + mil);
          }
        }
        for (int i = 0; i < Numeros2digito.Length; i++)
        {

          if (Convert.ToInt32(Numeros3digito) == Numeros2digito[i])
          {
            Console.WriteLine(Palabras2digito[i] + mil);
          }
        }

        if (Numeros3digito <= 999 && Numeros3digito > 100)
        {
          Numeros3digito = Numeros3digito / 100;
          for (int i = 0; i < Numeros1digito.Length; i++)
          {
            if (Convert.ToInt32(Numeros3digito) == Numeros1digito[i])
            {
              Console.WriteLine(Palabras1digito[i] + cien+ mil);
            }
          }
        }
      }
    }
  }
}
