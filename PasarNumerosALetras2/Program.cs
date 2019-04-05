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
      double Numero;
      string linea;
      double[] Numerosdigito = new double[5] { 11, 12, 13, 14, 15 };
      string mil = "mil";
      string[] Palabras1digito = new string[10] { "  ", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
      string[] Palabrasdigito = new string[5] { "once", "doce", "trece", "catorce", "quince" };
      string[] Palabras2digito = new string[10] { " ", "diez", "viente", "treinta", "cuarenta", "sincuenta", "sesenta", "setenta", "ochenta", "Noventa" };
      string[] Palabras3digito = new string[10] { " ", "ciento", "docientos", "trecientos", "cuatrociento", "quinientos", "seiescientos", "setecientos", "ochocientos", "noveciento" };
      string[] Palabras4digito = Palabras1digito;
      string[] Palabras5digito = Palabras2digito;
      string[] Palabras6digito = Palabras3digito;
      string[] Palabras2digitoSincrear = new string[1000000];

      Console.Write("Indica una cantidadtidad que desa convertir :");


      linea = Console.ReadLine();
      double[] digitos = new double[linea.Length];
        for (int i = 0; i < linea.Length; i++)
      {
        digitos[i] = double.Parse(linea.Substring(i, 1));
        Console.WriteLine(digitos[i]);
      }

  

    }
    
  }
}
