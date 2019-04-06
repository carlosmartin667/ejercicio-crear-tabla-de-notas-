using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasarNumerosALetras5
{
  class Program
  {
    static void Main(string[] args)
    {
      double Numero;
      string linea;
      double[] Numerosdigito = new double[5] { 11, 12, 13, 14, 15 };
      string mil = "mil";
      string[] Palabras1digito = new string[10] { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
      string[] Palabrasdigito = new string[5] { "once", "doce", "trece", "catorce", "quince" };
      string[] Palabras2digito = new string[10] { "", "diez", "viente", "treinta", "cuarenta", "sincuenta", "sesenta", "setenta", "ochenta", "Noventa" };

      string[] Palabras3digito = new string[10] { "", "ciento", "doscientos", "trecientos", "cuatrocientos", "quinientos", "seiescientos", "setecientos", "ochocientos", "novecientos" };

      string[] Palabras2digitoSincrear = new string[1000];

      Console.Write("Indica una cantidadtidad que desa convertir :");

      while (!double.TryParse(Console.ReadLine(), out Numero))
      {
        Console.WriteLine("Le dije que escriba un numero");
        continue;
        if (Numero < 0)
        {
          Console.Write("menos ");
          Numero = -Numero;
        }
      }
      int u = 0;
      int d = 0;
      int c = 0;
      int m = 0;
      int dm = 0;
      int cm = 0;
      int k = 0;
      //100mil para arriva
      if (Numero > 100000 && Numero < 1000000)
      {
        cm = (int)Numero / 100000;
        Numero = Numero - (cm * 100000);
      }
 
      //10mil para arriva
      if (Numero > 1000 && Numero < 10000)
      {
        dm = (int)Numero / 10000;
        Numero = Numero - (dm * 10000);
      }

      //mil para arriva
      if (Numero > 1000 && Numero < 10000)
      {
        m = (int)Numero / 1000;
        Numero = Numero - (m * 1000);
      }
      //100 para arriva
      if (Numero > 100 && Numero < 1000)
      {
        c = (int)Numero / 100;
        Numero = Numero - (c * 100);
      }
      //10 para arriva
      if (Numero > 16 && Numero < 100)
      {
        d = (int)Numero / 10;
        Numero = Numero - (c * 10);
        Console.Write(Palabras2digito[d]);
      }
      if (Numero > 10 && Numero < 16)
      {
        for (int i = 0; i < Numerosdigito.Length; i++)
        {
          if (Numero == Numerosdigito[i])
          {
            Console.Write(Palabrasdigito[i]);
          }
        }
      }

      if (Numero > 0 && Numero < 10)
      {
        u = (int)Numero ;
            Console.WriteLine(Palabras1digito[u]);
      }


      


    }
  }
}
