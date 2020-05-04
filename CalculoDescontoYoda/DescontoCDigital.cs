using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDescontoYoda
{
    class DescontoCDigital : Calculo
    {
        public double calcular(double precoBase)
        {
            double precoFinal = precoBase * 0.92;

            return precoFinal;
        }
    }
}
