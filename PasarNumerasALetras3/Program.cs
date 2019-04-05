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
      double[] Numeros1digito = new double[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      double[] Numerosdigito = new double[5] { 11, 12, 13, 14, 15 };
      double[] Numeros2digito = new double[10] { 00,10, 20, 30, 40, 50, 60, 70, 80, 90 };
      double[] Numeros3digito = new double[10] { 000, 100, 200, 300, 400, 500, 600, 700, 800, 900 };
      double[] NumerosdigitoSinCrear = new double[1000];
      double dosdigito;

      //double[] Numeros3digito = new double[9] { 100, 200, 300, 400, 500, 600, 700, 800, 900 };
      string cien = "ciento";
      string mil = "mil";
      string[] Palabras1digito = new string[10] {  "  ","uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
      string[] Palabrasdigito = new string[5] { "once", "doce", "trece", "catorce", "quince" };
      string[] Palabras2digito = new string[10] {" ", "diez", "viente", "treinta", "cuarenta", "sincuenta", "sesenta", "setenta", "ochenta", "Noventa" };
    
        string[] Palabras3digito = new string[10] {" ", "ciento","docientos" ,"trecientos","cuatrociento","quinientos","seiescientos","setecientos","ochocientos","noveciento"} ;


      string[] Palabras2digitoSincrear = new string[1000];

      Console.Write("Indica una cantidadtidad que desa convertir :");
      linea = Console.ReadLine();
      Numero = float.Parse(linea);

      int n = 0;

      for (int x = 0; x < Numeros3digito.Length; x++)
      {
        for (int j = 0; j < Numeros2digito.Length; j++)
        {
          for (int i = 0; i < Numeros1digito.Length; i++)
          {
            NumerosdigitoSinCrear[n++] = Numeros3digito[x]+ Numeros2digito[j] + Numeros1digito[i];
          }
        }
      }
      int k = 0;
      string y = " y ";
      for (int x = 0; x < Palabras3digito.Length; x++)
      {
        for (int j = 0; j < Palabras2digito.Length; j++)
        {
          for (int i = 0; i < Palabras1digito.Length; i++)
          {
            Palabras2digitoSincrear[k++] = Palabras3digito[x]+" " +Palabras2digito[j] + y + Palabras1digito[i];
          }
        }
      }

      //---------------//
   
      if (Numero > 10 && Numero <= 15)
      {
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
