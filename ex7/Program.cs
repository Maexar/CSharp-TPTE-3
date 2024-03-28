using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Digite a base do retângulo: ");
            r.Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());

            CalcularPerimetro(r);



            Console.ReadLine();
        }

        static void CalcularPerimetro(Retangulo r)
        {
            double perimetro = 2 * (r.Base + r.Altura);
            Console.WriteLine($"O perímetro do retângulo é {perimetro}");
        }
        
    }
        
    public class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        
    }
}
