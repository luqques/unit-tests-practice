using Moq;

namespace Calculadora.Testes
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            int n1 = 1;
            int n2 = 2;
            var soma = new Soma(n1, n2);

            Assert.Equal(soma, Calculadora.SomarDoisNumeros(n1, n2));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, Calculadora.Subtrair(10, 10));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, Calculadora.Multiplicar(10, 10));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, Calculadora.Dividir(10, 10));
        }
    }
}