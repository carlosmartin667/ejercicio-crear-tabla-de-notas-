using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
  public class Persona
  {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool EsPersonaFisica { get; set; }
    public int CuitCuil { get; set; }

    public virtual int ObtenerTotal()
    {
      Id = 0;
      return Id;
    }
 }
}
