using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacionPorcentaje
{
   public class ReglaDeIntereses
  {
    decimal CalcularRecargo (Comprobante comprobante)
    {
      decimal recargo = 0;
      int dias = 0;
      int[,] arr4 = new int[dias, 100];
      for (int j = 0; j < dias; j++)
      {
        switch (j)
        {
          case 0:
            {
              recargo = comprobante.Importe;
            }
            break;
          case 1:
            {
              recargo = +comprobante.Importe % 110;
            }
            break;
          case 2:
            {
              recargo = comprobante.Importe % 150;
            }
            break;
          case 3:
            {
              recargo = comprobante.Importe % 210;
            }
            break;
          default:
            break;
        }
      }
     
      
  
    



      return recargo;
    }


  }
}
