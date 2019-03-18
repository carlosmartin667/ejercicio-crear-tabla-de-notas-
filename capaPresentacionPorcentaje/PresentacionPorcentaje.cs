using System;

namespace Comprobantes_
{
  class Program
  {
    static void Main(string[] args)
    {
      var comprobantes = new Comprobante();

      Console.WriteLine("Ingresar tipo de comprobante:");
      comprobantes.TipoDeComprobante = Convert.ToString(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("Tipo de Factura:" + comprobantes.TipoDeComprobante);

      Console.WriteLine();

      Console.WriteLine("Ingrese nombre del cliente");
      comprobantes.DatosDeCliente = Convert.ToString(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("Datos ingresados:" + comprobantes.DatosDeCliente);

      Console.WriteLine();

      Console.WriteLine("Ingrese apellido:");
      comprobantes.Detalle = Convert.ToString(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("Detalles:" + comprobantes.Detalle);

      System.Console.Clear();

      Console.WriteLine("Ingresar fecha de EMISION(ingresar dd mm aaaa)");
      comprobantes.FechaEmision = Convert.ToDateTime(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("fecha ingresada: " + comprobantes.FechaEmision);

      Console.WriteLine();

      Console.WriteLine("Ingresar fecha de PAGO(ingresar dd mm aaaa)");
      comprobantes.FechaPago = Convert.ToDateTime(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("fecha ingresada: " + comprobantes.FechaPago);


      int dias = (comprobantes.FechaPago - comprobantes.FechaEmision).Days;
      Console.WriteLine(dias);

      System.Console.Clear();

      Console.WriteLine("Ingrese monto:");
      comprobantes.Importe = Convert.ToDecimal(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("Monto ingresado:" + comprobantes.Importe);

      Console.WriteLine("Ingrese cada cuantos dias se aumenta el interes:");
      comprobantes.DiasPagar = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("cada : " + comprobantes.DiasPagar + " se le va aplicar un interes");

      Console.WriteLine("Ingrese interes:");
      comprobantes.Interes = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("Interes aplicado :" + comprobantes.Interes);

       comprobantes.DiasDeIncrementoDeInteres = (int) dias / (int)comprobantes.DiasPagar;
       comprobantes.InteresAumentado  = comprobantes.DiasDeIncrementoDeInteres * comprobantes.Interes;

      var recargoServicio = new ReglaDeCalculo();
      var recargoCobrar = recargoServicio.CalcularRecargo(comprobantes, dias);

      System.Console.Clear();

      //int[] a = new int[ dias];
      //int[] b = new int[(int)comprobantes.Interes];
      //int[] c = new int[(int)recargoCobrar];

      //for (int i = 0; i < comprobantes.InteresAumentado; i++)
      //{
      //  a[i] = i ;
      //}
      //for (int i = 0; i < comprobantes.InteresAumentado; i++)
      //{
      //  b[i] = i;
      //}
      //for (int i = 0; i < comprobantes.InteresAumentado; i++)
      //{
      //  Console.Write($"a[{i}] = {a[i]}");
      //  Console.Write($"b[{i}] = {b[i]}");
      //}
      //int menor = 0;

      //int[,] arr4 = new int[menor, 2];
      //for (int i = 0; i < menor; i++)
      //{
      //  for (int j = 0; j < 2; j++)
      //  {


      //    switch (j)
      //    {
      //      case 0:
      //        {
      //          arr4[i, j] = a[i];
      //        }
      //        break;
      //      case 1:
      //        {
      //          arr4[i, j] = b[i];
      //        }
      //        break;
      //      default:

      //        break;
      //    }
      //  }
      //}
      //    Console.WriteLine();
      //    Console.Write("dias donde se iva incrementando : [");
      //    for (int i = menor; i <= comprobantes.InteresAumentado; i++)
      //    {
      //      Console.Write(b[i] + " " + a[i] + " ");
      //    }
      //    Console.WriteLine("]");

        



      Console.WriteLine("Tipo de Factura:" + comprobantes.TipoDeComprobante);
      Console.WriteLine("Nombre del Cliente:" + comprobantes.DatosDeCliente);
      Console.WriteLine("Detalles de la Factura:" + comprobantes.Detalle);
      Console.WriteLine("fecha de Emision: " + comprobantes.FechaEmision);
      Console.WriteLine("fecha de Pago: " + comprobantes.FechaPago);
      Console.WriteLine("Valor de Factura:" + comprobantes.Importe);
      Console.WriteLine("cada " + comprobantes.DiasPagar + "dias aumenta un " + comprobantes.Interes + "%");
      Console.WriteLine("Dias pasados:" + dias);
      Console.WriteLine("Valor de la Factura con interes aplicado:" + recargoCobrar);
    }

  }
}
