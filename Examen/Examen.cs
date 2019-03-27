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

      string[] letrasMinusculas = new string[26]
      {
        "a", "e", "i", "o", "u", "b", "c", "d",  "f", "g", "h", "i", "j", "k"
      , "l" , "m" , "n" , "p" , "q" , "r" , "s" , "t", "v", "w" , "y", "z"
      };
      string[] letrasMayuscula = new string[26]
      {
        "A", "E", "I", "O", "U","B", "C", "D", "f", "G", "H", "I", "J", "K"
      , "L" , "M" , "N" , "P" , "Q" , "R" , "S" , "T", "V", "W" , "Y", "Z"
      };

      Random random = new Random();
      string randomString = "    ";
      var palabras = new List<int>();
      int num = 0; 
      while (num < 100)
      {
        int Number = new Random().Next(1, 20);

        for (int j = 0; j < Number; j++)
        {
          randomString = letras[random.Next(0, 52)].ToString();
          //stringArray[j] = letras[random.Next(0, 52)].ToString();
          for (int i = 0; i < 1; i++)
          {

            Console.Write(randomString);
          }
        }
        num++;
        Console.WriteLine();
      }

      int randomNumber = random.Next(1, 21);
     

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
