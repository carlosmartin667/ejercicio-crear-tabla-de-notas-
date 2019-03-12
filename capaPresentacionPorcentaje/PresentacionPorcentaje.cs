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


      int[] fecha = new int[90];





      DateTime fecha1 = new DateTime();
      Console.WriteLine("FECHA QUE SE VENCE EL COMPROBANTE");
      Console.WriteLine("la fecha deve ingresar de la siguiente manera: año mes dia ej: 2000/02/10");
      Console.WriteLine("escriba la fecha");
      fecha1 = Convert.ToDateTime(Console.ReadLine());

      Console.WriteLine(fecha1);

      Console.WriteLine("FECHA QUE SE PAGA EL COMPROBANTE ");

      DateTime fecha2 = new DateTime();
      Console.WriteLine("la fecha deve ingresar de la siguiente manera: año mes dia ej: 2000/02/10");
      Console.WriteLine("escriba la fecha");
      fecha2 = Convert.ToDateTime(Console.ReadLine());

      Console.WriteLine(fecha2);


     Console.WriteLine((fecha1 - fecha2).Days);



      Console.WriteLine(fecha);



      Console.ReadKey();
      //Console.WriteLine("Seleccione las fechas de vencimiento del comprobante:");
      //Console.WriteLine();
      //Console.WriteLine("1 valor del comprobante ");
      //Console.WriteLine("2 valor del comprobante  (15 dias despues de vencer )");
      //Console.WriteLine("3 valor del comprobante  (30 dias despues de vencer )");
      //Console.WriteLine("4 valor del comprobante  (45 dias despues de vencer )");
      //Console.WriteLine("5 valor del comprobante  (60 dias despues de vencer )");
      //Console.WriteLine();
      //Console.Write("VALOR DEL COMPROBANTE :1000 ");
      //Console.WriteLine();
      //Console.WriteLine("escriba 1 , 2 , 3 , 4 , 5 ");
      //String opcion = Console.ReadLine();
      //Console.WriteLine(  );

      //if (opcion.Equals("1") || opcion.Equals("2") || opcion.Equals("3") || opcion.Equals("4") || opcion.Equals("5"))
      //{
      //  ReglaDeIntereses ReglaDeIntereses = new ReglaDeIntereses();//Intanciar la clase

      //  int[,] dfghj = new int[5, 5];

      //  //ReglaDeIntereses.valor1 = int.Parse(Console.ReadLine());//Leer numero ingresado
      //  int valor1 = 10000;

      //  ReglaDeIntereses.valor1 = valor1;



      //  if (opcion.Equals("1"))
      //  {

      //    Console.WriteLine("valor del comprobante :" + ReglaDeIntereses.sinInteres());
      //  }
      //  if (opcion.Equals("2"))
      //  {
      //    Console.WriteLine("valor del comprobante  (15 dias despues de vencer ) :" + ReglaDeIntereses.interes1());
      //  }
      //  if (opcion.Equals("3"))
      //  {
      //    Console.WriteLine("valor del comprobante  (30 dias despues de vencer )" + ReglaDeIntereses.interes2());
      //  }
      //  if (opcion.Equals("4"))
      //  {
      //    Console.WriteLine("valor del comprobante  (45 dias despues de vencer )" + ReglaDeIntereses.interes3());
      //  }
      //  if (opcion.Equals("5"))
      //  {
      //    Console.WriteLine("valor del comprobante  (60 dias despues de vencer )" + ReglaDeIntereses.interes4());
      //  }
      //}

      //Console.ReadKey();
      //Console.WriteLine(" deseas continuar ");
      //Console.ReadLine();
      ////if (si)
      ////{
      ////  return
      ////}
      ////else
      ////{
      ////  Console.WriteLine();
      ////}
    }

  }
}
