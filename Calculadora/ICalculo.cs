using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public interface ICalculo
    {
        public Resultado Calcular(int n1, int n2, char operacao);
    }
}
