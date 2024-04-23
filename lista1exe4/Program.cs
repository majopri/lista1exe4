using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe4
{
    internal class Program
    {
        private static object consolie;

        public static object Consolie { get; private set; }

        static void Main(string[] args)
        {
            double baseTriangulo, alturaTriangulo, areaTriangulo;

            // solicita e lê a base do triangulo
            Console.WriteLine("Digite o valor da base do triangulo:");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());

            // solicita e lê a altura do triangulo
            Console.WriteLine("Digite o valor da altura do triangulo:");
            alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // calcula a área do 
            areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            //Exibe a área do triangulo
            Console.WriteLine("A área do triangulo é: " + areaTriangulo);

        }
    }
}
