using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacionColecciones
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] cadena1 = new int[5] { 1 , 2 , 3 , 4 , 5};
      int[] cadena2 = new int[5] { 10, 20, 30, 40, 50 };
      int[] cadena3 = new int[5] { 100, 200, 300, 400, 500 };

      Console.WriteLine("coleccion de numeros: ");

      Console.WriteLine("coleccion de numeros de 1 digito:");
    
      foreach (int num in cadena1)
      {
        Console.WriteLine("{0}", num);
      }

      Console.WriteLine("coleccion de numeros de 2 digito:");
 
      foreach (int num in cadena2)
      {
        Console.WriteLine("{0}", num);
      }
      Console.WriteLine("coleccion de numeros de 3 digito:");
    
      foreach (int num in cadena3)
      {
        Console.WriteLine("{0}", num);
      }
     
      Console.WriteLine("combinacion:");

      //for (int i = 0; i < 3; i++)
      //{
      //  Console.WriteLine(cadena1[0] + "-" + cadena2[2] + "-" + cadena3 [4]);
      //}
      Console.WriteLine("lista de convinacion: " + cadena1[0] + "-" + cadena2[1] + "-" + cadena3[4]);
      Console.WriteLine("lista de convinacion: " + cadena1[1] + "-" + cadena2[2] + "-" + cadena3[2]);
      Console.WriteLine("lista de convinacion: " + cadena1[4] + "-" + cadena2[0] + "-" + cadena3[3]);


      Console.WriteLine("numeros de 1 digito sin  cobinar:");
      Console.WriteLine(/*cadena1[1] + "-"+ cadena1[2] +"-"+*/ cadena1[3] +"-"+ cadena1[2]  );
      Console.WriteLine("numeros de 2 digito sin cobinar:");
      Console.WriteLine(/*cadena2[1] + "-" + cadena2[0] + "-" +*/ cadena2[3] + "-" + cadena2[4] );
      Console.WriteLine("numeros de 3 digito sin cobinar:");
      Console.WriteLine(cadena3[1] + "-" /*+ cadena3[2] + "-" + cadena3[3] + "-"*/ + cadena3[0] );

      Console.WriteLine();
    }


  }
}
