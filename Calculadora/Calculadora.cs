﻿namespace Calculadora
{
    public class Calculadora
    {
        public Soma Somar(int n1, int n2)
        {
            return new Soma(n1, n2, '+');
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}