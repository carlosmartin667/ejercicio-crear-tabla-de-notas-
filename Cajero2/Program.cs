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

     // BILLETES CALCULO
      if ((Dinero >= BILLETESVALOR[0]))
      {
        BILLETES[0] = ((int)Dinero / BILLETESVALOR[0]);
        Dinero = Dinero - (BILLETES[0] * BILLETESVALOR[0]);
      }
      if ((Dinero >= BILLETESVALOR[1]))
      {
        BILLETES[1] = ((int)Dinero / BILLETESVALOR[1]);
        Dinero = Dinero - (BILLETES[1] * BILLETESVALOR[2]);
      }
      if ((Dinero >= BILLETESVALOR[2]))
      {
        BILLETES[2] = ((int)Dinero / BILLETESVALOR[2]);
        Dinero = Dinero - (BILLETES[2] * BILLETESVALOR[2]);
      }
      if ((Dinero >= BILLETESVALOR[3]))
      {
        BILLETES[3] = ((int)Dinero / BILLETESVALOR[3]);
        Dinero = Dinero - (BILLETES[3] * BILLETESVALOR[3]);
      }
      if ((Dinero >= BILLETESVALOR[4]))
      {
        BILLETES[4] = ((int)Dinero / BILLETESVALOR[4]);
        Dinero = Dinero - (BILLETES[4] * BILLETESVALOR[4]);
      }
      if ((Dinero >= BILLETESVALOR[5]))
      {
        BILLETES[5] = ((int)Dinero /  BILLETESVALOR[5]);
        Dinero = Dinero - (BILLETES[5] * BILLETESVALOR[5]);
      }
      if ((Dinero >= BILLETESVALOR[6]))
      {
        BILLETES[6] = ((int)Dinero / BILLETESVALOR[6]);
        Dinero = Dinero - (BILLETES[6] * BILLETESVALOR[6]);
      }
      //MONEDAS CALCULO
      if ((Dinero >= MONEDASVALOR[0]))
      {
        MONEDAS[0] = (int)(Dinero / MONEDASVALOR[0]);
        Dinero = Dinero - (float)(MONEDAS[0] * MONEDASVALOR[0]);
      }

      if ((Dinero >= MONEDASVALOR[1]))
      {
        MONEDAS[1] = (int)(Dinero / MONEDASVALOR[1]);
        Dinero = Dinero - (float)(MONEDAS[1]* MONEDASVALOR[1]);
      }
      if ((Dinero >= MONEDASVALOR[2]))
      {
        MONEDAS[2] = (int)(Dinero / MONEDASVALOR[2]);
        Dinero = Dinero - (float)(MONEDAS[2] * MONEDASVALOR[2]);
      }

      if ((Dinero >= MONEDASVALOR[3]))
      {
        MONEDAS[3] = (int)(Dinero / MONEDASVALOR[3]);
        Dinero = Dinero - (float)(MONEDAS[3] * MONEDASVALOR[3]);
      }
      if ((Dinero >= MONEDASVALOR[4]))
      {
        MONEDAS[4] = (int)Math.Round(Dinero / MONEDASVALOR[4]);
        Dinero = Dinero - (float)(MONEDAS[4] * MONEDASVALOR[4]);
      }

      Console.WriteLine("Billetes de 500: " + BILLETES[0]);
      Console.WriteLine("Billetes de 200: " + BILLETES[1]);
      Console.WriteLine("Billetes de 100: " + BILLETES[2]);
      Console.WriteLine("Billetes de 50 : " + BILLETES[3]);
      Console.WriteLine("Billetes de 20 : " + BILLETES[4]);
      Console.WriteLine("Billetes de 10 : " + BILLETES[5]);
      Console.WriteLine("Billetes de 5 : "  + BILLETES[6]);

      Console.WriteLine("Monedas de 0,50 : " + MONEDAS[0]);
      Console.WriteLine("Monedas de 0,25 : " + MONEDAS[1]);
      Console.WriteLine("Monedas de 0,10 : " + MONEDAS[2]);
      Console.WriteLine("Monedas de 0,05 : " + MONEDAS[3]);
      Console.WriteLine("Monedas de 0,01 : " + MONEDAS[4]);
    }
  }
}
