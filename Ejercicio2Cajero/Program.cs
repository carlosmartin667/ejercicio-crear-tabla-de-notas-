using System;

namespace Exmen2
{
  class Program
  {
    static void Main(string[] args)
    {
      float Dinero;
      int C500, C200, C100, C50, C20, C10, C5, D50, D25, D10,D05, D01;

      int[] BILLETES = new int[7];
      double[] MONEDAS = new double[5];

      BILLETES[0] = 0;
      C200 = 0;
      C100 = 0;
      C50 = 0;
      C20 = 0;
      C10 = 0;
      C5 = 0;
     
      D50 = 0;
      D25 = 0;
      D10 = 0;
      D05 = 0;
      D01 = 0;

      string linea;
      Console.Write("Indica una cantidadtidad :");
      linea = Console.ReadLine();

      Dinero = float.Parse(linea);
      Console.WriteLine("La Cantidad introducida es: " + Dinero);

      if ((Dinero >= 500))
      {
        C500 = ((int)Dinero / 500);
        Dinero = Dinero - (C500 * 500);
      }
      if ((Dinero >= 200))
      {
        C200 = ((int)Dinero / 200);
        Dinero = Dinero - (C200 * 200);
      }
      if ((Dinero >= 100))
      {
        C100 = ((int)Dinero / 100);
        Dinero = Dinero - (C100 * 100);
      }
      if ((Dinero >= 50))
      {
        C50 = ((int)Dinero / 50);
        Dinero = Dinero - (C50 * 50);
      }
      if ((Dinero >= 20))
      {
        C20 = ((int)Dinero / 20);
        Dinero = Dinero - (C20 * 20);
      }
      if ((Dinero >= 10))
      {
        C10 = ((int)Dinero / 10);
        Dinero = Dinero - (C10 * 10);
      }
      if ((Dinero >= 5))
      {
        C5 = ((int)Dinero / 5);
        Dinero = Dinero - (C5 * 5);
      }
  
      if ((Dinero >= 0.5))
      {
        D50 = (int)(Dinero / 0.5);
        Dinero = Dinero - (float)(D50 * 0.5);
      }

      if ((Dinero >= 0.25))
      {
        D25 = (int)(Dinero / 0.25);
        Dinero = Dinero - (float)(D25 * 0.25);
      }
      if ((Dinero >= 0.1))
      {
        D10 = (int)(Dinero / 0.1);
        Dinero = Dinero - (float)(D10 * 0.1);
      }

      if ((Dinero >= 0.05))
      {
        D05 = (int)(Dinero / 0.05);
        Dinero = Dinero - (float)(D05 * 0.05);
      }
      if ((Dinero >= 0.01))
      {
        D01 = (int)Math.Round(Dinero / 0.01);
        Dinero = Dinero - (float)(D01 * 0.01);
      }

      Console.WriteLine("Billetes de 500: " + C500);
      Console.WriteLine("Billetes de 200: " + C200);
      Console.WriteLine("Billetes de 100: " + C100);
      Console.WriteLine("Billetes de 50 : " + C50);
      Console.WriteLine("Billetes de 20 : " + C20);
      Console.WriteLine("Billetes de 10 : " + C10);
      Console.WriteLine("Billetes de 5 : " + C5);

      Console.WriteLine("Monedas de 0,50 : " + D50);
      Console.WriteLine("Monedas de 0,25 : " + D25);
      Console.WriteLine("Monedas de 0,10 : " + D10);
      Console.WriteLine("Monedas de 0,05 : " + D05);
      Console.WriteLine("Monedas de 0,01 : " + D01);
    }
  }
}


namespace ContadorBilletes
{
  class Importe
  {
    static void Main(string[] args)
    {

      int CANTIDAD = 0;
      decimal iva = 0;
      string linea;
      Console.Write("DIGITE UNA IMPORTE :"); linea = Console.ReadLine();

      CANTIDAD = int.Parse(linea);
      double[] P3 = new double[12] { 500, 200, 100, 50, 20, 10, 5, 0.050, 0.025, 0.10, 0.005, 0.001 };
      int fila = CANTIDAD;

      if (CANTIDAD >= 500)
      {

        P3[0] = Convert.ToInt32(CANTIDAD / 500);
        iva = CANTIDAD - (Convert.ToDecimal(P3[0] * 500));

      }
      decimal VALOR = iva - Convert.ToDecimal(P3[0]);
      if (VALOR >= 200)
      {

        P3[1] = Convert.ToInt32(VALOR / 200);
        VALOR = VALOR - (Convert.ToInt32(P3[1] * 200));
      }
      Console.WriteLine("numero1: " + Convert.ToDecimal(P3[0]));
      Console.WriteLine("numero: " + VALOR);

    }
  }
}
