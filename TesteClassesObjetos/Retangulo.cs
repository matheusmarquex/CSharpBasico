using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClassesObjetos
{
    class Retangulo
    {
        public double largura = 0;
        public double altura = 0;

        public double CalcularArea()
        {
            return largura * altura;
        }

        public void AumentaLargura(double l)
        {
            largura += l;

        }

        public void AumentaAltura(double a)
        {
            altura += a;
        }

    }
}
