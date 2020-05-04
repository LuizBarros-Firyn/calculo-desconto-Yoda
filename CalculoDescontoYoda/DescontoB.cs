using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDescontoYoda
{
    class DescontoB : Calculo
    {
        public double calcular(double precoBase)
        {
            double precoFinal = precoBase * 0.85;

            return precoFinal;
        }
    }
}
