using System;

namespace Exmen2
{
  class Program
  {
    static void Main(string[] args)
    {
      float Dinero;

      int[] BILLETES = new int[7];
      int[] BILLETESVALOR = new int[7] {500,200,100,50,20,10,5 };
      double[] MONEDAS = new double[5];
      double[] MONEDASVALOR = new double[5] {0.5 ,0.25,0.1,0.05,0.01 };
      string linea;
      Console.Write("Indica una cantidadtidad :");
      linea = Console.ReadLine();

      Dinero = float.Parse(linea);
      Console.WriteLine("La Cantidad introducida es: " + Dinero);
      for (int i = 0; i < 7; i++)
      {
        if ((Dinero >= BILLETESVALOR[i]))
        {
          BILLETES[i] = ((int)Dinero / BILLETESVALOR[i]);
          Dinero = Dinero - (BILLETES[i] * BILLETESVALOR[i]);
        }
      }

      //MONEDAS CALCULO

      for (int i = 0; i < 5; i++)
      {
        if ((Dinero >= MONEDASVALOR[i]))
        {
          MONEDAS[i] = (int)(Dinero / MONEDASVALOR[i]);
          Dinero = Dinero - (float)(MONEDAS[i] * MONEDASVALOR[i]);
        }
      }

      for (int i = 0; i < 7; i++)
      {
        Console.WriteLine("Billetes de {i }: " + BILLETES[i]);

      }
      //Console.WriteLine("Billetes de 500: " + BILLETES[0]);
      //Console.WriteLine("Billetes de 200: " + BILLETES[1]);
      //Console.WriteLine("Billetes de 100: " + BILLETES[2]);
      //Console.WriteLine("Billetes de 50 : " + BILLETES[3]);
      //Console.WriteLine("Billetes de 20 : " + BILLETES[4]);
      //Console.WriteLine("Billetes de 10 : " + BILLETES[5]);
      //Console.WriteLine("Billetes de 5 : "  + BILLETES[6]);

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Monedas de  : " + MONEDAS[i]);
      }


      Console.WriteLine("Monedas de 0,50 : " + MONEDAS[0]);
      Console.WriteLine("Monedas de 0,25 : " + MONEDAS[1]);
      Console.WriteLine("Monedas de 0,10 : " + MONEDAS[2]);
      Console.WriteLine("Monedas de 0,05 : " + MONEDAS[3]);
      Console.WriteLine("Monedas de 0,01 : " + MONEDAS[4]);
    }
  }
}
