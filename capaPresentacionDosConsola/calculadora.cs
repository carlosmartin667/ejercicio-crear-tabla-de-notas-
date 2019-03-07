
using System;

namespace Calculadora
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Seleccione la operacion a realizar:\n1 - Sumar\n2 - Restar\n3 - Multiplicar\n4 - Dividir");

      String opcion = Console.ReadLine();

      if (opcion.Equals("1") || opcion.Equals("2") || opcion.Equals("3") || opcion.Equals("4"))
      {
        Numero Numero = new Numero();//Intanciar la clase

        Console.Write("Ingrese valor 1: ");//Pedir numero 1
        Numero.Numero1 = int.Parse(Console.ReadLine());//Leer numero ingresado

        Console.Write("Ingrese valor 2: ");//Pedir Numero 2
        Numero.Numero2 = int.Parse(Console.ReadLine());//Leer numero ingresado

        if (opcion.Equals("1"))
        {

          Console.WriteLine("El resultado es:" + Numero.Sumar());
        }
        if (opcion.Equals("2"))
        {
          Console.WriteLine("El resultado es:" + Numero.Restar());
        }
        if (opcion.Equals("3"))
        {
          Console.WriteLine("El resultado es:" + Numero.Multiplicar());
        }
        if (opcion.Equals("4"))
        {
          Console.WriteLine("El resultado es:" + Numero.Dividir());
        }
      }

      Console.ReadKey();
    }
  }
}
