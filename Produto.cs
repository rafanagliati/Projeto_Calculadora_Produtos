using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_001
{
    public class produto
    {
        public static double calcular(DateTime AquisicaoProduto, double ValorProduto)
        {
            double resultado = 0;
            try
            {
                int mes = AquisicaoProduto.Month;
                if (mes >= 1 && mes <= 7)
                {
                    resultado = ValorProduto - ValorProduto * 0.30;
                }
                else
                {
                    resultado = ValorProduto - ValorProduto * 0.50;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return resultado;
        }

        public static double calcularAcrescimo(string OrigemProduto, double ValorProduto)
        {
            double resultado = 0;
            try
            {
                switch (OrigemProduto) 
                {
                    case "1":
                        resultado = ValorProduto * 0.10;
                        break;
                    case "2":
                        resultado = ValorProduto * 0.20;
                        break;
                    case "3":
                        resultado = ValorProduto * 0.30;
                        break;
                    case "4":
                        resultado = ValorProduto * 0.40;
                        break;
                    case "5":
                        resultado = ValorProduto * 0.50;
                        break;
                                             

                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex); }

            return resultado;

        }
    }
}