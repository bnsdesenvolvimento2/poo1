using System;

namespace ContaCorrente
{
    public class ContaCorrente
    
    {
        public int numero;
        public string cliente;
        public float saldo;

        public void depositar(float valor)
        {
            saldo += valor;
        }

        public void sacar(float valor)
        {
            saldo -= valor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga o que você quer fazer");
        }
    }
}
