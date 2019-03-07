namespace Calculadora
{
  public class Numero
  {
    private int _Numero1;
    private int _Numero2;
    private int resto;
    private int sum;

    public int Numero1
    {
      get { return _Numero1; }
      set { _Numero1 = value; }
    }

    public int Numero2
    {
      get { return _Numero2; }
      set { _Numero2 = value; }
    }

    public int Sumar()
    {
      return Numero1 + Numero2;
    }
   
    public string Restar()
    {
      if (Numero1 >= Numero2)

      {
        for (int res = Numero2; res < Numero1; res++)
        {
          resto++;
        }
        return resto.ToString();
      }

      else
      {
        for (int res = Numero1; res < Numero2; res++)
        {
          resto++;
        }

        return "-" + resto;
      }




    }

    public double Multiplicar()
    {
      for (int k = 0; k < Numero2; ++k)
      {
        sum += Numero1;
      }
      return sum;
    }
    public object Dividir()
    {
      for (int i = 0; i < Numero1; i = i + Numero2)
      {
        resto++;
      }
      return resto;
    }
  }
}
