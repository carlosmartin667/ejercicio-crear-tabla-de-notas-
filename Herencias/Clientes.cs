using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
  public class Clientes : Persona
  {
    public int TotalVentas { get; set; }
    public string EsClientePreferencial { get; set; }
    public int LimiteDeCuentaCorriente { get; set; }
  }
}
