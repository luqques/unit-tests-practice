using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public interface ICalculo
    {
        public Task<Resultado> Calcular(int n1, int n2, char operacao)
        {
            switch (operacao)
            {
                case '+':
                    n1 + n2; 
                    break;
                case '-':
                    n1 - n2;
                    break;
                case '*':
                    return new Resultado(n1 * n2);
                    break;
                case '/':
                    return n1 / n2;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
