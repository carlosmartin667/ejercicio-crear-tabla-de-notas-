using System;

namespace Exmen2
{
  class Program
  {
    static void Main(string[] args)
    {
      float Dinero;
      //array
      int[] BILLETES = new int[7];
      int[] BILLETESVALOR = new int[7] {500,200,100,50,20,10,5 };
      double[] MONEDAS = new double[5];
      double[] MONEDASVALOR = new double[5] {0.5 ,0.25,0.1,0.05,0.01 };
      string linea;
      //pedir importe al usuario
      Console.Write("Indica una cantidadtidad :");
      linea = Console.ReadLine();
      Dinero = float.Parse(linea);
      Console.WriteLine("La Cantidad introducida es: " + Dinero);
      //BILLETES CALCULO
      for (int i = 0; i < 7; i++)
      {
        if ((Dinero >= BILLETESVALOR[i]))
        {
          BILLETES[i] = ((int)Dinero / BILLETESVALOR[i]);
          Dinero = Dinero - (BILLETES[i] * BILLETESVALOR[i]);
          Console.WriteLine("Billetes de " + BILLETESVALOR[i] + " = " + BILLETES[i]);
        }
      }
      //MONEDAS CALCULO
      for (int i = 0; i < 5; i++)
      {
        if ((Dinero >= MONEDASVALOR[i]))
        {
          MONEDAS[i] = (int)(Dinero / MONEDASVALOR[i]);
          Dinero = Dinero - (float)(MONEDAS[i] * MONEDASVALOR[i]);
          Console.WriteLine("Monedas de " + MONEDASVALOR[i] + " = " + MONEDAS[i]);
        }
      }
    }
  }
}
