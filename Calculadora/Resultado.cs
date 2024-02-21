using System.Numerics;

namespace Calculadora
{
    public class Resultado
    {
        public string msgError = "Resultado deve ser maior que zero!!";

        Resultado(int calculo)
        {
            if (calculo <= 0)
            {
                throw new Exception(msgError);
            }
        }

        Resultado(double resultado)
        {
            if (resultado <= 0)
            {
                throw new Exception(msgError);
            }
        }
    }
}