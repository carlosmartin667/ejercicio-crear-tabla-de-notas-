using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
  class Empleados : Persona
  {
    public DateTime FechaIngreso { get; set; }
    public int NumeroLegajo { get; set; }
  }
}
