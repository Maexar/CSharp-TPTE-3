using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1 - Dólar para Real");
                Console.WriteLine("2 - Real para Dólar");
                Console.WriteLine("3 - Euro para Real");
                Console.WriteLine("4 - Real para Euro");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ConversorDeMoedas dolar = new ConversorDeMoedas();

                        Console.WriteLine("Digite a cotação do dólar: ");
                        dolar.Cotacao = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor em dólar: ");
                        double valorEmDolar = double.Parse(Console.ReadLine());

                        double valorEmReal = dolar.ConverterDolarParaReal(valorEmDolar);
                        Console.WriteLine($"O valor em real é {valorEmReal}");
                        break;

                    case 2:
                        ConversorDeMoedas real = new ConversorDeMoedas();

                        Console.WriteLine("Digite a cotação do dólar: ");
                        real.Cotacao = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor em real: ");
                        double valorEmReal2 = double.Parse(Console.ReadLine());

                        double valorEmDolar2 = real.ConverterRealParaDolar(valorEmReal2);
                        Console.WriteLine($"O valor em dólar é {valorEmDolar2}");
                        break;

                    case 3:
                        ConversorDeMoedas euro = new ConversorDeMoedas();

                        Console.WriteLine("Digite a cotação do euro: ");
                        euro.Cotacao = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor em euro: ");
                        double valorEmEuro = double.Parse(Console.ReadLine());

                        double valorEmReal3 = euro.ConverterEuroParaReal(valorEmEuro);
                        Console.WriteLine($"O valor em real é {valorEmReal3}");
                        break;

                    case 4: 
                        ConversorDeMoedas real2 = new ConversorDeMoedas();

                        Console.WriteLine("Digite a cotação do euro: ");
                        real2.Cotacao = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor em real: ");
                        double valorEmReal4 = double.Parse(Console.ReadLine());

                        double valorEmEuro2 = real2.ConverterRealParaEuro(valorEmReal4);
                        Console.WriteLine($"O valor em euro é {valorEmEuro2}");
                        break;

                    default:
                        if(opcao != 0) 
                        Console.WriteLine("Opção inválida");

                        break;
                }

                

            }while(opcao != 0);

        }

        
        
    }

    public class ConversorDeMoedas
    {
        public double Cotacao { get; set; }

        public double ConverterDolarParaReal(double valorEmDolar)
        {
            return valorEmDolar * Cotacao;
        }

        public double ConverterRealParaDolar(double valorEmReal)
        {
            return valorEmReal / Cotacao;
        }

        public double ConverterEuroParaReal(double valorEmEuro)
        {
            return valorEmEuro * Cotacao;
        }

        public double ConverterRealParaEuro(double valorEmReal)
        {
            return valorEmReal / Cotacao;
        }


    }
}
