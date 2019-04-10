using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
  class Proveedor : Persona
  {
    public string NombreComercial { get; set; }
    public DateTime FechaUltimaCompra { get; set; }
    public int TotalCompras { get; set; }


    public override int ObtenerTotal()
    {
      TotalCompras = 1000;
      return TotalCompras;
    }

  }
}
