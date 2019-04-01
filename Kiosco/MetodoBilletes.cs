using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero3
{
  public class MetodoBilletes
  {
    public int CalcularBilletes (Atributos comprobante)
    {
      int billetes =0;
      for (int i = 0; i < 7; i++)
      {
        if ( (comprobante.Dinero >= comprobante.BILLETESVALOR[i]))
        {
          comprobante.BILLETES[i] = ((int)comprobante.Dinero / comprobante.BILLETESVALOR[i]);
          comprobante.Dinero = comprobante.Dinero - (comprobante.BILLETES[i] * comprobante.BILLETESVALOR[i]);
          Console.WriteLine("BILLETES de " + comprobante.BILLETESVALOR[i] + " = " + comprobante.BILLETES[i]);
        }
      }
      return billetes;
    }
  }
}
