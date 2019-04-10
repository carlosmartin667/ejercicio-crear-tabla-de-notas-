using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
  class Empleado : Persona
  {
    public DateTime FechaIngreso { get; set; }
    public int NumeroLegajo { get; set; }
    public int Sueldo { get; set; }


    public override int ObtenerTotal()
    {
      this.Sueldo = 1000;
      return Sueldo;
    }
  }
}
