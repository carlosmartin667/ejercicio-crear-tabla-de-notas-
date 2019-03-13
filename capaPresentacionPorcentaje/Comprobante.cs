using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacionPorcentaje
{
  public class Comprobante
  {
    public string TipoDeComprobante { get; set; }
    public string Cliente { get; set; }
    public DateTime FechaEmicion { get; set; }
    public DateTime FechaVencimiento { get; set; }
    public DateTime FechaPago { get; set; }
    public string Detalles { get; set; }
    public decimal Importe { get; set; }
  }
}
