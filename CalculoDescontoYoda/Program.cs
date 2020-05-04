using System;

namespace CalculoDescontoYoda
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoBase;
            double precoFinal;
            int isFisic;
            DescontoStrategy desconto;

            Console.Write("Digite o preco da compra com Livros, Revistas e Jogos de Tabuleiro: ");

            precoBase = Convert.ToDouble(Console.ReadLine());

            desconto = new DescontoStrategy(new DescontoA());

            precoFinal = desconto.valorCalculo(precoBase);

            Console.WriteLine("\nPreco final com o desconto A: " + precoFinal);

            Console.Write("\nDigite o preco da compra com Livros e Revistas Digitais: ");

            precoBase = Convert.ToDouble(Console.ReadLine());

            desconto = new DescontoStrategy(new DescontoB());

            precoFinal = desconto.valorCalculo(precoBase);

            Console.WriteLine("\nPreco final com o desconto B: " + precoFinal);

            Console.Write("\nDigite o preco da compra com Jogos de Video-Game: ");

            precoBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nO jogo e fisico ou digital? 1 para fisico, 2 para digital: ");

            isFisic = Convert.ToInt32(Console.ReadLine());

            if (isFisic == 1)
            {
                desconto = new DescontoStrategy(new DescontoCFisic());
            } 
            else
            {
                desconto = new DescontoStrategy(new DescontoCDigital());
            } 

            precoFinal = desconto.valorCalculo(precoBase);

            Console.WriteLine("\nPreco final com o desconto C: " + precoFinal);

            Console.WriteLine("\nMuito obrigado!");
        }
    }
}
