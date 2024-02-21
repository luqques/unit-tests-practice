namespace Calculadora
{
    public class Calculadora
    {
        public Soma SomarDoisNumeros(int n1, int n2)
        {
            return new Soma(n1, n2);
        }

        public static Subtracao Subtrair(int n1, int n2)
        {
            return new Subtracao();
        }

        public static Multiplicacao Multiplicar(int n1, int n2)
        {
            return new Multiplicacao();
        }

        public static Divisao Dividir(int n1, int n2)
        {
            return new Divisao();
        }
    }
}