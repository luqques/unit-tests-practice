using System.Numerics;

namespace Calculadora
{
    public class Resultado
    {
        private string msgError = "Resultado deve ser maior que zero!!";

        Resultado(int resultado)
        {
            if (resultado <= 0)
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