using System;

namespace Exmen2
{
  class Program
  {
    static void Main(string[] args)
    {
      float Dinero;

      int[] BILLETES = new int[7];
      double[] MONEDAS = new double[5];

      string linea;
      Console.Write("Indica una cantidadtidad :");
      linea = Console.ReadLine();

      Dinero = float.Parse(linea);
      Console.WriteLine("La Cantidad introducida es: " + Dinero);

      if ((Dinero >= 500))
      {
        BILLETES[0] = ((int)Dinero / 500);
        Dinero = Dinero - (BILLETES[0] * 500);
      }
      if ((Dinero >= 200))
      {
        BILLETES[1] = ((int)Dinero / 200);
        Dinero = Dinero - (BILLETES[1] * 200);
      }
      if ((Dinero >= 100))
      {
        BILLETES[2] = ((int)Dinero / 100);
        Dinero = Dinero - (BILLETES[2] * 100);
      }
      if ((Dinero >= 50))
      {
        BILLETES[3] = ((int)Dinero / 50);
        Dinero = Dinero - (BILLETES[3] * 50);
      }
      if ((Dinero >= 20))
      {
        BILLETES[4] = ((int)Dinero / 20);
        Dinero = Dinero - (BILLETES[4] * 20);
      }
      if ((Dinero >= 10))
      {
        BILLETES[5] = ((int)Dinero / 10);
        Dinero = Dinero - (BILLETES[5] * 10);
      }
      if ((Dinero >= 5))
      {
        BILLETES[6] = ((int)Dinero / 5);
        Dinero = Dinero - (BILLETES[6] * 5);
      }

      if ((Dinero >= 0.5))
      {
        MONEDAS[0] = (int)(Dinero / 0.5);
        Dinero = Dinero - (float)(MONEDAS[0] * 0.5);
      }

      if ((Dinero >= 0.25))
      {
        MONEDAS[1] = (int)(Dinero / 0.25);
        Dinero = Dinero - (float)(MONEDAS[1] * 0.25);
      }
      if ((Dinero >= 0.1))
      {
        MONEDAS[2] = (int)(Dinero / 0.1);
        Dinero = Dinero - (float)(MONEDAS[2] * 0.1);
      }

      if ((Dinero >= 0.05))
      {
        MONEDAS[3] = (int)(Dinero / 0.05);
        Dinero = Dinero - (float)(MONEDAS[3] * 0.05);
      }
      if ((Dinero >= 0.01))
      {
        MONEDAS[4] = (int)Math.Round(Dinero / 0.01);
        Dinero = Dinero - (float)(MONEDAS[4] * 0.01);
      }

      Console.WriteLine("Billetes de 500: " + BILLETES[3]);
      Console.WriteLine("Billetes de 200: " + BILLETES[1]);
      Console.WriteLine("Billetes de 100: " + BILLETES[2]);
      Console.WriteLine("Billetes de 50 : " + BILLETES[3]);
      Console.WriteLine("Billetes de 20 : " + BILLETES[4]);
      Console.WriteLine("Billetes de 10 : " + BILLETES[5]);
      Console.WriteLine("Billetes de 5 : " + BILLETES[6]);

      Console.WriteLine("Monedas de 0,50 : " + MONEDAS[0]);
      Console.WriteLine("Monedas de 0,25 : " + MONEDAS[1]);
      Console.WriteLine("Monedas de 0,10 : " + MONEDAS[2]);
      Console.WriteLine("Monedas de 0,05 : " + MONEDAS[3]);
      Console.WriteLine("Monedas de 0,01 : " + MONEDAS[4]);
    }
  }
}
