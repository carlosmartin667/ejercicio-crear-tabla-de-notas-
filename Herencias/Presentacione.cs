using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
  class Presentacione
  {
    static void Main(string[] args)
    {
      Cliente cliente = new Cliente();
      Proveedor proveedor = new Proveedor();
      Empleado empleado = new Empleado();


      //Console.WriteLine("Escriba Nombre Del Empleado");
      //empleados.Nombre =Console.ReadLine();
      //Console.WriteLine();
      //Console.WriteLine("Escriba Aplleido Del Empleado");
      //empleados.Apellido = Console.ReadLine();
      //Console.WriteLine();
      //Console.WriteLine("Escriba fecha de nacimiento Del Empleado");
      //empleados.FechaNacimiento =Convert.ToDateTime(Console.ReadLine());
      //Console.WriteLine();
      //Console.WriteLine("Escriba CuitCuil Del Empleado");
      //empleados.CuitCuil =Convert.ToInt32(Console.ReadLine());

      
      Console.WriteLine(empleado.ObtenerTotal() );

    }
  }
}
