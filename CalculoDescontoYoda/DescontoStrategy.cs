using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDescontoYoda
{
    class DescontoStrategy
    {
        private Calculo calculo;
        public DescontoStrategy(Calculo calculo)
        {
            this.calculo = calculo;
        }

        public double valorCalculo(double preco)
        {
            return this.calculo.calcular(preco);
        }
    }
}
