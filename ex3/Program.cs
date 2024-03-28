using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
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
                    Console.WriteLine("1 - Calcular área do triângulo");
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

                while(true)
                {
                    try
                    {
                        switch (opcao)
                        {
                            case 1:
                                Triangulo t = new Triangulo();
                                Console.WriteLine("Digite a base do triângulo: ");
                                t.Base = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite a altura do triângulo: ");
                                t.Altura = double.Parse(Console.ReadLine());

                                CalcularArea(t);
                                break;

                            default:
                                Console.WriteLine("Opcao inexistente, tente novamente");
                                break;

                        }
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor inválido. Tente novamente");
                    }
                }
              
                Console.WriteLine("Deseja Calcular outra área? (1 - Sim / 0 - Não)");   
                opcao = int.Parse(Console.ReadLine());
            }while(opcao != 0);

        }

        static void CalcularArea(Triangulo t)
        {
            double area = (t.Base * t.Altura) / 2;
            Console.WriteLine("Área do triângulo: " + area);
        }
    }

    public class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }


    }
}
