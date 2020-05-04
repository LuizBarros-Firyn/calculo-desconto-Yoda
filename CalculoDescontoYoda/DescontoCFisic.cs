using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDescontoYoda
{
    class DescontoCFisic : Calculo
    {
        public double calcular(double precoBase)
        {
            double precoFinal = precoBase * 0.90;

            return precoFinal;
        }
    }
}
