using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                while (true)
                {

                    Console.WriteLine("=== MENU ===");
                    Console.WriteLine("1 - Somar");
                    Console.WriteLine("2 - Subtrair");
                    Console.WriteLine("3 - Multiplicar");
                    Console.WriteLine("4 - Dividir");
                    Console.WriteLine("0 - Sair \n");

                    try
                    {
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Opção inválida. Tente novamente");

                    }


                }

                while (true)
                {
                    try
                    {
                        switch (opcao)
                        {
                            case 1:


                                Console.WriteLine("Digite o primeiro NÚMERO: ");
                                double a = double.Parse(Console.ReadLine());


                                Console.WriteLine("Digite o segundo NÚMERO: ");
                                double b = double.Parse(Console.ReadLine());


                                Calculadora calc = new Calculadora();
                                Console.WriteLine("Resultado: " + calc.Somar(a, b));
                                break;

                            case 2:
                                Console.WriteLine("Digite o primeiro número: ");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o segundo número: ");
                                b = double.Parse(Console.ReadLine());
                                calc = new Calculadora();
                                Console.WriteLine("Resultado: " + calc.Subtrair(a, b));
                                break;

                            case 3:
                                Console.WriteLine("Digite o primeiro número: ");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o segundo número: ");
                                b = double.Parse(Console.ReadLine());
                                calc = new Calculadora();
                                Console.WriteLine("Resultado: " + calc.Multiplicar(a, b));
                                break;
                            case 4:
                                Console.WriteLine("Digite o primeiro número: ");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o segundo número: ");
                                b = double.Parse(Console.ReadLine());
                                calc = new Calculadora();
                                Console.WriteLine("Resultado: " + calc.Dividir(a, b));
                                break;

                            case 0:
                                Console.WriteLine("Saindo...");
                                break;

                            default:
                                Console.WriteLine("Opção inválida. Tente novamente");
                                break;
                        }//switch

                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor Inválido, tente novamente.");
                    }
                        
                }//while(true)
            }while(opcao != 0); 

        }
    }

    public class Calculadora
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            return a / b;
        }
    }

}
