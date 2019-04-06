using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasarNumerasALetras4
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

      string[] Palabras2digitoSincrear = new string[10000000];

      Console.Write("Indica una cantidadtidad que desa convertir :");

      while (!double.TryParse(Console.ReadLine(), out Numero))
      {
        Console.WriteLine("Le dije que escriba un numero");
        continue;
      }
      //cuando el numero ingresado es negativo
      if (Numero < 0 )
      {
        Console.Write("menos ");
        Numero = -Numero;
  
      }
      if ( Numero == 0 || Numero == 100)
      {
        if (Numero == 0)
        {
          Console.WriteLine("cero");
        }
        if (Numero == 100)
        {
          Console.WriteLine("cien");
        }
      }



      //cargo el array tipo string asta el maximo permitido x este mismo.
      int k = 0;
      string y = " y ";
      //cargo el array si Numero pedido es mallor q 1000

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
      

      int exepcion = 0;
      int cantidadexepcion = 111;
      int cantidadexepcion2 = 116;


      for (int x = 1; x < 10; x++)
      {
        for (int i = cantidadexepcion; i < cantidadexepcion2; i++)
        {
          Palabras2digitoSincrear[i] = Palabras3digito[x] + " " + Palabrasdigito[exepcion++];
        }
        cantidadexepcion = cantidadexepcion + 100;
        cantidadexepcion2 = cantidadexepcion2 + 100;
        exepcion = exepcion - 5;
      }




      int NumerosGrandes = 0;
      if (Numero > 1000)
      {
        NumerosGrandes = (int)Numero / 1000;
        Numero = Numero - (NumerosGrandes * 1000);

   

      if (NumerosGrandes > 10 && NumerosGrandes <= 15  || NumerosGrandes == 100 )
      {
      
        if (NumerosGrandes == 100)
        {
          Console.WriteLine("cien" + mil);
        }
      
        for (int i = 0; i < Palabrasdigito.Length; i++)
        {
          if (NumerosGrandes == Numerosdigito[i])
          {
            Console.WriteLine(Palabrasdigito[i]);
          }
        }
      }
      else
      //imprime el valor escrito NUmero .
      {
        for (int i = 0; i < Palabras2digitoSincrear.Length; i++)
        {
          if (Palabras2digitoSincrear[NumerosGrandes] == Palabras2digitoSincrear[i])
          {
            Console.Write(Palabras2digitoSincrear[i] + mil+" ");
          }
        }
      }
      }



      if (Numero > 10 && Numero <= 15 )
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
      //imprime el valor escrito NUmero .
      {
        for (int i = 0; i < Palabras2digitoSincrear.Length; i++)
        {
          if (Palabras2digitoSincrear[(int)Numero] == Palabras2digitoSincrear[i])
          {
            Console.WriteLine(Palabras2digitoSincrear[i]);
          }
        }
      }
    }
  }
}
