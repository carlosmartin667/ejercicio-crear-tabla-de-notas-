using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacionPorcentaje
{
   public class ReglaDeIntereses
  {
  public decimal CalcularRecargo (Comprobante comprobante, int dias)
    {
      decimal recargo = 0;
      if (dias <=10)
      {
        recargo = comprobante.Importe;
        // Condition1 is true.
      }
      else if (dias <=20)
      {
        recargo = comprobante.Importe + comprobante.Importe % 10;
        // Condition1 is false and Condition2 is true.
      }
      else if (dias <= 30)
      {
        recargo = comprobante.Importe + comprobante.Importe % 20;
        // Condition1 is false and Condition2 is true.
      }
      else if (dias <= 40)
      {
        recargo = comprobante.Importe + (comprobante.Importe * Convert.ToDecimal(0.30));
        // Condition1 is false and Condition2 is true.
      }
      else if (dias <= 50)
      {
        recargo = comprobante.Importe + comprobante.Importe % 40;
        // Condition1 is false and Condition2 is true.
      }


      return recargo;
    }


  }
}
