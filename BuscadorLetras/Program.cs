
using System;

class Example
{
  public static void Main()
  {
    string s1 = "HTML considera que los párrafos son bloques de texto. " +
          "Los navegadores hacen lo posible para adaptar el contenido de los párrafos a la ventana, " +
          "a menos que los atributos NOWRAP o NOBR estén explícitamente especificados ";
    string s2 ;
    Console.WriteLine("ESCRIBA LE LETRA  QUE QUIERE BUSCAR");
          s2 = Console.ReadLine();
    bool b = s1.Contains(s2);
    Console.WriteLine("'{0}' la letras esta'{1}': {2}",
                       s2, s1, b);
    if (b)
    {
      int index = s1.IndexOf(s2);
      if (index >= 0)
        Console.WriteLine("'{0} la posicision es {1}",
                          s2, index + 1);
    }
  }
}

