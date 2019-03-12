using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacionPorcentaje
{
  class ReglaDeIntereses
  {


    private int _valor1;
    public int valor1
    {
      get { return _valor1; }
      set { _valor1 = value; }
    }
    public int sinInteres()
    {
      return (valor1 / 10000) *1000 ;
    }

    public int interes1()
    {
      return (valor1 / 10000) * 1015 ;
    }
    public int interes2()
    {
      return (valor1 / 10000) * 1030;
    }
    public int interes3()
    {
      return (valor1 / 10000) * 1045;
    }
    public int interes4()
    {
      return (valor1 / 10000) * 1060;
    }

  }
}
