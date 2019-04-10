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
      double nro, millones, miles, unidades;
      string Numero;
      string txt = "";
      Console.Write("Ingese un valor entero entre 1 y 999: ");
      Numero = Console.ReadLine();
      nro = float.Parse(Numero);

      millones = Convert.ToInt32((nro / 1000000));
      miles = Convert.ToInt32((nro - millones * 1000000) / 1000);
      unidades = nro - millones * 1000000 - miles * 1000;

      if (millones > 0)
      {
        if (millones == 1)
        {
          txt = "un millon";
        }
        else
        {
          txt = millones + "millones";
        }
      }

      if (miles > 0)
      {
        if (miles == 1)
        {
          txt = txt + " un mil";
        }
        else
        {
          txt = txt + " " + miles + " mil";
        }
      }

      if (unidades > 0)
      {
        txt = txt + " " + unidades;
      }

      Console.WriteLine(txt);
    }

    int x, u1, d1, c1;
    string texto;
    string[] u = new string[30] { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "dies", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho ", "diecinueve", "veinte", "veintiuno", "veintidos", "veintitres", "veinticuatro", "veinticinco", "veintiseis", "veintisiete", "veintiocho", "veintinueve" };
    string[] d = new string[10]{"", "", "", "treinta", "cuarenta", "sincuenta", "sesenta", "setenta", "ochenta", "Noventa"};
    string[] c = new string[10] { "", "ciento", "doscientos", "trecientos", "cuatrocientos", "quinientos", "seiescientos", "setecientos", "ochocientos", "novecientos" };
  }
}
