using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaDatos;
using capaEntidad;
using System.Data;

namespace capaNegocios
{
    public class N_Empleados
    {
    D_Empleados objdatos = new D_Empleados();
    public DataTable N_listado()
    {
      return objdatos.D_listado();
    }

    }
}
