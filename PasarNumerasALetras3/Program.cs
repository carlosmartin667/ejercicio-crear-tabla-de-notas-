using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasarNumerasALetras3
{
  class Program
  {
    static void Main(string[] args)
    {
      double Numero;
      string linea;
      double[] Numerosdigito = new double[5] { 11, 12, 13, 14, 15 };
      double[] NumerosdigitoSinCrear = new double[1000000];

      string mil = "mil";
      string[] Palabras1digito = new string[10] {  "  ","uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
      string[] Palabrasdigito = new string[5] { "once", "doce", "trece", "catorce", "quince" };
      string[] Palabras2digito = new string[10] {" ", "diez", "viente", "treinta", "cuarenta", "sincuenta", "sesenta", "setenta", "ochenta", "Noventa" };
      string[] Palabras3digito = new string[10] {" ", "ciento","docientos" ,"trecientos","cuatrociento","quinientos","seiescientos","setecientos","ochocientos","noveciento"} ;
      string[] Palabras4digito = Palabras1digito;
      string[] Palabras5digito =  Palabras2digito;
      string[] Palabras6digito =  Palabras3digito;
 string[] Palabras2digitoSincrear = new string[1000000];

      Console.Write("Indica una cantidadtidad que desa convertir :");
      linea = Console.ReadLine();
      Numero = float.Parse(linea);

      int n = 0;
      for (int i = 0; i < NumerosdigitoSinCrear.Length; i++)
      {
        NumerosdigitoSinCrear[i] = n++  ;
      }
      int k = 0;
      string y = " y ";
      if (Numero > 1000)
      {
        for (int a = 0; a < Palabras6digito.Length; a++)
        {
          for (int b = 0; b < Palabras5digito.Length; b++)
          {
            for (int z = 0; z < Palabras4digito.Length; z++)
            {
              for (int x = 0; x < Palabras3digito.Length; x++)
              {
                for (int j = 0; j < Palabras2digito.Length; j++)
                {
                  for (int i = 0; i < Palabras1digito.Length; i++)
                  {
                    Palabras2digitoSincrear[k++] = Palabras6digito[a] + " " + Palabras5digito[b] + " " + Palabras4digito[z] + mil + " " + Palabras3digito[x] + " " + Palabras2digito[j] + y + Palabras1digito[i];
                  }
                }
              }
            }
          }
        }
      }
      else
      {
        for (int x = 0; x < Palabras3digito.Length; x++)
        {
          for (int j = 0; j < Palabras2digito.Length; j++)
          {
            for (int i = 0; i < Palabras1digito.Length; i++)
            {
              Palabras2digitoSincrear[k++] = Palabras3digito[x] + " " + Palabras2digito[j] + y + Palabras1digito[i];
            }
          }
        }
      }

      if (Numero > 10 && Numero <= 15 || Numero==0 || Numero==100 || Numero == 100000)
      {
        if (Numero == 0)
        {
          Console.WriteLine("cero");
        }
        if (Numero == 100)
        {
          Console.WriteLine("cien");
        }
        if (Numero == 100000)
        {
          Console.WriteLine("cienMil");
        }
        for (int i = 0; i < Palabrasdigito.Length; i++)
        {
          if (Numero == Numerosdigito[i])
          {
            Console.WriteLine(Palabrasdigito[i]);
          }
        } 
      }
      else 
      {
        for (int i = 0; i < NumerosdigitoSinCrear.Length; i++)
        {
          if (Numero == NumerosdigitoSinCrear[i])
          {
            Console.WriteLine(Palabras2digitoSincrear[i]);
          }
        }
      }
    }
  }
}
