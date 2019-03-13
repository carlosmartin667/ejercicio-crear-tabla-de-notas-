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
      int[] fecha = new int[90];
      int dias = (comprobante.FechaPago - comprobante.FechaVencimiento).Days;
      Console.WriteLine(dias);
      Console.WriteLine();

      Console.Write("Ingrese importe del comprobante : ");//Pedir numero 1
    
       comprobante.Importe = int.Parse(Console.ReadLine());//Leer numero ingresado
      Console.WriteLine("valor de comprbante es: " + comprobante.Importe);

      Console.WriteLine();

        ReglaDeIntereses ReglaDeIntereses = new ReglaDeIntereses();//Intanciar la clase

        int[,] dfghj = new int[5, 5];

        //ReglaDeIntereses.valor1 = int.Parse(Console.ReadLine());//Leer numero ingresado

      





        Console.WriteLine("valor del comprobante :" + ReglaDeIntereses.sinInteres());

        Console.WriteLine("valor del comprobante  (15 dias despues de vencer ) :" + ReglaDeIntereses.interes1());

        Console.WriteLine("valor del comprobante  (30 dias despues de vencer )" + ReglaDeIntereses.interes2());

        Console.WriteLine("valor del comprobante  (45 dias despues de vencer )" + ReglaDeIntereses.interes3());

        Console.WriteLine("valor del comprobante  (60 dias despues de vencer )" + ReglaDeIntereses.interes4());

      

    }

  }
}
