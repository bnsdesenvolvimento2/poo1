using System;

namespace Conta
{
    public class Conta
    {
    		public string nome;
    		public double valor;
    		public string dataVencimento;
    		public string dataPagamento;
    		
    		public Conta()
    		{
    			this.nome = "";
    			this.valor = 0;
    			this.dataVencimento = "";
    			this.DataPagamento = "";
    		}
    		
    		public Conta(string fnome, double fvalor)
    		{
    			this.nome = fnome;
    			this.valor = fvalor;
    		}
    		
    		public double RetornaSaldo()
    		{
    			return this.valor;
    		}
    		
    		public string RetornaNome()
    		{
    			return this.nome;
    		}
    		
    		public void DefineSaldo(double valor)
    		{
    			this.valor = valor;
    		}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
