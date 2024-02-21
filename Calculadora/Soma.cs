using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Soma : ICalculo
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public char OperacaoSoma { get; set; }
        public Soma(int numero1, int numero2, char operacaoSoma)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            OperacaoSoma = operacaoSoma;
        }

        public Task<Resultado> Calcular(int n1, int n2, char operacao)
        {
            
        }
    }
}
