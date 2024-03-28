using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            int opcao;
            do
            {


                while (true)
                {
                    Console.WriteLine("1 - Cadastrar pessoa");
                    Console.WriteLine("2 - Imprimir dados");
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
                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Digite o nome: ");
                        pessoa.nome = Console.ReadLine();
                        Console.WriteLine("Digite a idade: ");
                        pessoa.idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a altura: ");
                        pessoa.altura = double.Parse(Console.ReadLine());
                        break;

                    case 2:
                        ImprimirDados(pessoa);
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente");
                        break;
                }







            } while (opcao != 0);

        }
            static void ImprimirDados(Pessoa pessoa)
        {
            Console.WriteLine("Nome: " + pessoa.nome);
            Console.WriteLine("Idade: " + pessoa.idade);
            Console.WriteLine("Altura: " + pessoa.altura);
        }

    }

    public class Pessoa
    {
        public string nome; 
        public int idade;
        public double altura;
     
    }

}
