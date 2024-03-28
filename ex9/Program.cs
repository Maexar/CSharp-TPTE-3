using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("Digite o modelo do carro: ");
            c.Modelo = Console.ReadLine();

            Console.WriteLine("Digite o ano do carro: ");
            c.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do carro: ");
            c.Preco = double.Parse(Console.ReadLine());

            CalcularDesconto(c);

            Console.ReadLine();
        }

        static void CalcularDesconto(Carro c)
        {
            double desconto = 0;
            if (c.Ano < 2010)
            {
                desconto = 0.10;
            }
            else
            {
                desconto = 0.05;
            }

            double valorDesconto = c.Preco * desconto;
            Console.WriteLine($"O desconto é de {valorDesconto}");
        }
    }

    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
    }
}
