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
      int[] d1 = new int[5] { 1 , 2 , 3 , 4 , 5};
      int[] d2 = new int[5] { 10, 20, 30, 40, 50 };
      int[] d3 = new int[5] { 100, 200, 300, 400, 500 };

      Console.WriteLine("coleccion de numeros: ");

      Console.WriteLine("coleccion de numeros de 1 digito:");
    
      foreach (int num in d1)
      {
        Console.WriteLine("{0}", num);
      }

      Console.WriteLine("coleccion de numeros de 2 digito:");
 
      foreach (int num in d2)
      {
        Console.WriteLine("{0}", num);
      }
      Console.WriteLine("coleccion de numeros de 3 digito:");
    
      foreach (int num in d3)
      {
        Console.WriteLine("{0}", num);
      }
     
      Console.WriteLine("combinacion:");

      //for (int i = 0; i < 3; i++)
      //{
      //  Console.WriteLine(d1[0] + "-" + d2[2] + "-" + d3 [4]);
      //}
      Console.WriteLine("lista de convinacion: " + d1[0] + "-" + d2[1] + "-" + d3[4]);
      Console.WriteLine("lista de convinacion: " + d1[1] + "-" + d2[2] + "-" + d3[2]);
      Console.WriteLine("lista de convinacion: " + d1[4] + "-" + d2[0] + "-" + d3[3]);


      Console.WriteLine("numeros de 1 digito sin  cobinar:");
      Console.WriteLine(/*d1[1] + "-"+ d1[2] +"-"+*/ d1[3] +"-"+ d1[2]  );
      Console.WriteLine("numeros de 2 digito sin cobinar:");
      Console.WriteLine(/*d2[1] + "-" + d2[0] + "-" +*/ d2[3] + "-" + d2[4] );
      Console.WriteLine("numeros de 3 digito sin cobinar:");
      Console.WriteLine(d3[1] + "-" /*+ d3[2] + "-" + d3[3] + "-"*/ + d3[0] );

      Console.WriteLine();
    }


  }
}
