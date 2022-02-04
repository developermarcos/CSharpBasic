using System;

//A padaria Hotpão vende uma certa quantidade de pães franceses e uma
//quantidade de broas acada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$
//1,50. Ao final do dia, o dono quer saberquanto arrecadou com a venda dos pães 
//e broas (juntos), e quanto deve guardar numa conta depoupança (10% do total
//arrecadado). Você foi contratado para fazer os cálculos para o dono. Combase
//nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e
//depois calcularos dados solicitados.

namespace Padaria.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double custoPao = 0.12;
            const double custoBroa = 1.50;
            const double procentagemPoupança = 10.00;
            double quantidadePao, quantidadeBroa, valorPoupanca;
            int opcao = 0;
            do
            {
                Console.WriteLine("\n ------------------------------ ");
                Console.WriteLine("Opções:\n (1) Encerrar o sistema \n (2) Calcular arrecadamento e poupança");
                Console.Write("Opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                if(opcao == 2)
                {
                    Console.Write("Informe a quantidade de pães vendidos: ");
                    quantidadePao = Convert.ToDouble(Console.ReadLine());


                    Console.Write("Informe a quantidade de pãbroas vendidas: ");
                    quantidadeBroa= Convert.ToDouble(Console.ReadLine());

                    valorPoupanca = (quantidadePao*custoPao + quantidadeBroa*custoBroa) * procentagemPoupança / 100.00;

                    Console.WriteLine("Total faturamento pães: {0}", quantidadePao*custoPao);
                    Console.WriteLine("Total faturamento broas: {0}", quantidadeBroa*custoBroa);
                    Console.WriteLine("Total faturamento: {0}", (quantidadePao*custoPao + quantidadeBroa*custoBroa));
                    Console.WriteLine("Total para poupança: {0}", valorPoupanca);

                }
                else
                {
                    Console.WriteLine("Opção não encontrada");
                }
            } while (opcao != 1);
        }
    }
}
