using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero3
{
  public class MetodoMonedas
  {
    public decimal CalcularMonedas(Atributos comprobante)
    {
      decimal monedas = 0;
      for (int i = 0; i < 5; i++)
      {
        if ((comprobante.Dinero >= comprobante.MONEDASVALOR[i]))
        {
          comprobante.MONEDAS[i] = (int)(comprobante.Dinero / comprobante.MONEDASVALOR[i]);
          comprobante.Dinero = comprobante.Dinero - (float)(comprobante.MONEDAS[i] * comprobante.MONEDASVALOR[i]);
          Console.WriteLine("Monedas de " + comprobante.MONEDASVALOR[i] + " = " + comprobante.MONEDAS[i]);
        }
      }
      return monedas;
    }

  }
}
