namespace Calculadora.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à caluladora, digite dois número e uma operação:");

            Calculadora calculadora = new();

            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            Soma resultado = calculadora.SomarDoisNumeros(n1, n2);

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}