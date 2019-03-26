using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
  class Examen
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Primer examen");
      //generando los string
    
      string[] stringArray = new string[100];   

      string[] vocales = new string[5] { "a", "e", "i", "o", "u" };
      string[] vocalesMayuscula = new string[5] { "A", "E", "I", "O", "U" };
      string[] consonantes = new string[21]
      { "b", "c", "d",  "f", "g", "h", "i", "j", "k"
      , "l" , "m" , "n" , "p" , "q" , "r" , "s" , "t", "v", "w" , "y", "z"
      };
      string[] consonantesMayuscula = new string[21]
     { "B", "C", "D", "f", "G", "H", "I", "J", "K"
      , "L" , "M" , "N" , "P" , "Q" , "R" , "S" , "T", "V", "W" , "Y", "Z"
     };

      Random random = new Random();
      string randomString = " ";

      for (int i = 0; i < 10; i++)
      {
        randomString += consonantes[random.Next(1, 20)].ToString();
      }

      Console.WriteLine(randomString);

    }
  }
}
