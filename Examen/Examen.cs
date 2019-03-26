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

      string[] letras = new string[52] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U",
        "b", "c", "d",  "f", "g", "h", "i", "j", "k"
      , "l" , "m" , "n" , "p" , "q" , "r" , "s" , "t", "v", "w" , "y", "z",
        "B", "C", "D", "f", "G", "H", "I", "J", "K"
      , "L" , "M" , "N" , "P" , "Q" , "R" , "S" , "T", "V", "W" , "Y", "Z"
      };

      Random random = new Random();
      string randomString = " ";
      //var palabras = new List<int>();
      //while (palabras.Count < 1000)
      //{
      //  int Number = new Random().Next(1, 26);

      //  for (int j = 0; j < Number; j++)
      //  {
      //    randomString += letras[random.Next(1, 52)].ToString();
      //  }
      //  //Console.WriteLine(randomString);

      //  Console.WriteLine();
      //}

      //foreach (int palabra in palabras)
      //  Console.Write("{0} ", palabras);
      //Console.WriteLine();

      int randomNumber = random.Next(1, 26);
      //for (int i = 0; i < 100; i++)
      //{
      //  for (int j = 0; j < randomNumber; j++)
      //  {
      //    randomString += letras[random.Next(1, 52)].ToString();
      //    i++;
      //  }
      //  Console.WriteLine(randomString);
      //}
      Console.WriteLine(randomString);
      for (int j = 0; j < randomNumber; j++)
      {
        randomString += letras[random.Next(1, 52)].ToString();
    
      }
      Console.WriteLine("palabra generada aleatoriamente ");
      //stringArray + randomString;
      Console.WriteLine(randomString);

      Console.WriteLine();

      //invertir palabra 
      string PalabraInvertida = " ";
      for (int i = randomString.Length -1; i >= 0; i--)
      {
        PalabraInvertida += randomString[i];
      }
      Console.WriteLine("palabra escrita al revez");
      Console.WriteLine(PalabraInvertida);
    }
  }
}
