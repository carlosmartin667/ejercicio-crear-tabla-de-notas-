using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero3
{
  class Presentacion
  {
    static void Main(string[] args)
    {
      var atributos = new Atributos();
   
      //array
      atributos.BILLETES = new int[7];
      atributos.BILLETESVALOR = new int[7] { 500, 200, 100, 50, 20, 10, 5 };
      atributos.MONEDAS = new double[5];
      atributos.MONEDASVALOR = new double[5] { 0.5, 0.25, 0.1, 0.05, 0.01 };
 
      //pedir importe al usuario
      Console.Write("Indica una cantidadtidad :");
      atributos.linea = Console.ReadLine();
      atributos.Dinero = float.Parse(atributos.linea);
      Console.WriteLine("La Cantidad introducida es: " + atributos.Dinero);

      var mostrarBilletes = new MetodoBilletes();
      var imprimirBilletes = mostrarBilletes.CalcularBilletes(atributos);

      var mostrarMonedas = new MetodoMonedas();
      var imprimirMonedas = mostrarMonedas.CalcularMonedas(atributos);

    }
  }
}
