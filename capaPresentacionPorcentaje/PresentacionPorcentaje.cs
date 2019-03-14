using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacionPorcentaje
{
  class PresentacionPorcentaje
  {
    static void Main(string[] args)
    {
      var comprobante = new Comprobante();
      
    
      Console.WriteLine("FECHA QUE SE VENCE EL COMPROBANTE");
      Console.WriteLine("la fecha deve ingresar de la siguiente manera: año mes dia ej: 2000/02/10");
      Console.WriteLine("escriba la fecha");
      comprobante.FechaVencimiento = Convert.ToDateTime(Console.ReadLine());

      Console.WriteLine(comprobante.FechaVencimiento);
      Console.WriteLine();
      Console.WriteLine("FECHA QUE SE PAGA EL COMPROBANTE ");


      Console.WriteLine("la fecha deve ingresar de la siguiente manera: año mes dia ej: 2000/02/10");
      Console.WriteLine("escriba la fecha");
      comprobante.FechaPago = Convert.ToDateTime(Console.ReadLine());
      
      Console.WriteLine(comprobante.FechaPago);
      Console.WriteLine();
      
      int dias = (comprobante.FechaPago - comprobante.FechaVencimiento).Days;
      Console.WriteLine(dias);
      Console.WriteLine();

      Console.Write("Ingrese importe del comprobante : ");//Pedir numero 1
    
       comprobante.Importe = int.Parse(Console.ReadLine());//Leer numero ingresado
      Console.WriteLine("valor de comprbante es: " + comprobante.Importe);

      Console.WriteLine();

      var recargoServicio = new ReglaDeIntereses();
      var recargoCobrar = recargoServicio.CalcularRecargo(comprobante, dias); //Intanciar la clase
      

      Console.WriteLine("valor de comprobante con interes "+recargoCobrar);
    }

  }
}
