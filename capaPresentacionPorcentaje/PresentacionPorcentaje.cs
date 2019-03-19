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

      //int[] FechasPagoNoDisponible = new int[dias];

      //for (int i =(int) comprobantes.DiasDeIncrementoDeInteres; i < recargoCobrar; i++)
      //{
      //  FechasPagoNoDisponible[i] =i;
      //}

      //for (int i = 0; i < recargoCobrar; i++)
      //{
      //  Console.WriteLine($"FechasPagoNoDisponible[{i + 1}] = {FechasPagoNoDisponible[i]}");
      //}

      Console.WriteLine();
      int[] a = new int[dias];

      //int[] b = new int[(int)comprobantes.Interes];
      //int[] d = new int[(int)comprobantes.InteresAumentado];


      //int[] c = new int[(int)recargoCobrar];
      //int[] e = new int[(int)comprobantes.Importe];

      for (int i = 0; i <= dias - 1; i++)
      {
        a[i] = i;
      }

      //for (int i = (int)comprobantes.Interes; i < comprobantes.InteresAumentado  ; i++)
      //{
      //  c[i] = i;
      //}

      //for (int i = (int) comprobantes.Importe; i < (int)recargoCobrar; i++)
      //{
      //  e[i] = i;
      //}


      for (int i = 0; i <= dias - 1; i++)
      {
        Console.WriteLine($"a[{i + 1}] = {a[i]}");
      }
      Console.WriteLine();

      //for (int i = 0; i <= comprobantes.InteresAumentado ; i++)
      //{
      //  Console.WriteLine($"c[{i + 1}] = {c[i]}");
      //}

      //Console.WriteLine();
      //for (int i = 0; i <= recargoCobrar; i++)
      //{
      //  Console.WriteLine($"e[{i + 1}] = {e[i]}");
      //}

      //Console.WriteLine();




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
