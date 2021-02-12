using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.WriteLine("Digite seu nome: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("\nDigite seu sobrenome: ");
            p1.Sobrenome = Console.ReadLine();

            Console.WriteLine("\nInforme a sua idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("\n==============================");
            Console.WriteLine("\nNOME: {0}", p1.Nome);
            Console.WriteLine("\nSOBRENOME: {0}", p1.Sobrenome);
            Console.WriteLine("\nIDADE: {0}", p1.Idade);
            Console.WriteLine("\n==============================");
            Console.WriteLine("\n>>PRESSIONE QUALQUER TECLA");
            Console.ReadKey();
            
            Console.Clear();

            Console.WriteLine("{0}, vamos calcular a área de um retangulo!\n", p1.Nome);

            //INSTANCIANDO RETANGULO

            Retangulo r1 = new Retangulo();

            Console.WriteLine("\n\nInforme a LARGURA do retangulo: ");
            r1.AumentaLargura(double.Parse(Console.ReadLine()));

            Console.WriteLine("\n\nInforme a ALTURA do retangulo: ");
            r1.AumentaAltura(double.Parse(Console.ReadLine()));

            double area = r1.CalcularArea();

            Console.WriteLine("\nA LARGURA do retangulo é {0} e a ALTURA {1}.\n A AREA é: {2}", r1.largura, r1.altura, area);


            Console.ReadKey();

        }
    }
}
