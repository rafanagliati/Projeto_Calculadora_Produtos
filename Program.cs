using Projeto_001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programa.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeProduto = "";
            DateTime dataValidade, AquisicaoProduto;
            string OrigemProduto = "";
            double ValorProduto = 0;
            int QuantidadeProduto = 0;

            Console.WriteLine("Informe o nome do produto:\n");
            NomeProduto = Console.ReadLine();

            Console.WriteLine("Informe a data de validade do produto (DD/MM/AAAA):\n");
            dataValidade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a origem do produto: \n 1 - Sudeste \n 2 - Centro-Oeste \n 3 - Norte \n 4 - Sul \n 5 - Nordeste \n");
            OrigemProduto = Console.ReadLine();

            Console.WriteLine($"Origem do produto: {OrigemProduto}");

            Console.WriteLine("Informe o valor do produto em reais (R$ xx,xx):\n");
            ValorProduto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira quantas unidades de produto foram adquiridas:\n");
            QuantidadeProduto = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe o mês e ano de aquisição do produto (MM/AAAA):\n");
            AquisicaoProduto = Convert.ToDateTime(Console.ReadLine());

            double resultadocalculo = produto.calcular(AquisicaoProduto, ValorProduto);
            Console.WriteLine($"O desconto aplicado em cada produto é: {resultadocalculo}");

            double resultadoacrescimo = produto.calcularAcrescimo(OrigemProduto, ValorProduto);
            Console.WriteLine($"O acrescimo aplicado em cada produto é: {resultadoacrescimo}");


        }

    }
}