using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
  class Program
  {
 
    class GenericList
    {
   
      static void Main()
      {
   
        string[] letras = new string[4] { "aaaa", "ecasd", "iasa", "oasd" };
    
        Random random = new Random();

        var palabras = new List<int>();

        int numeros = random.Next(0, 4);

        for (int i = 0; i < letras.Length; i++)
        {
          letras[i] = letras[numeros];
        }
        palabras.Sort();
        List<int> list1 = new List<int>();
        for (int i = 0; i < 4; i++)
        {


          Console.WriteLine("hola" +
            "");
          list1.Add(numeros);
        }
        list1.Add(numeros);
        List<string> list2 = new List<string>();
        list2.Add(letras[1]);

      }
    }
  }
}
