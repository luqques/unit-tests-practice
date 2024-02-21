namespace Calculadora
{
    public class Soma
    {
        public decimal Resultado { get; set; }
        public Soma(int numero1, int numero2)
        {
            Resultado = numero1 + numero2;
        }
    }
}
