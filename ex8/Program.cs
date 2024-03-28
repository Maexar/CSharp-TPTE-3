using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário ganho por hora: ");
            f.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            f.HorasTrabalhadas = int.Parse(Console.ReadLine());

            CalcularSalarioTotal(f);

            Console.ReadLine();
        }

        static void CalcularSalarioTotal(Funcionario f)
        {
            double salarioTT = f.Salario * f.HorasTrabalhadas;
            Console.WriteLine($"O salário de {f.Nome} é {salarioTT}");
        }
    }

    public class Funcionario {         
        public string Nome { get; set; }   
        public double Salario { get; set; }
        public int HorasTrabalhadas { get; set; }
    }
}
