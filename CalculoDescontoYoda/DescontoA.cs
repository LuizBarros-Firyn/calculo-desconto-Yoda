using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDescontoYoda
{
    class DescontoA : Calculo
    {
        public double calcular(double precoBase)
        {
            double precoFinal = precoBase *0.70;

            return precoFinal;
        }
    }
}
