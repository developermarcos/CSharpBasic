using System;

//Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir 
//quantos dias de vidaela possui. Considere sempre anos completos, e que um 
//ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
//um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

namespace DiasVida.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int quantidadeDiasAno = 365;
            char encerrarSistema;
            do
            {
                Console.Write("\n ----------------------------------");
                Console.WriteLine("Escolha \n (1) Calcular dias de vida. \n (2) Encerrar programa");
                encerrarSistema = Convert.ToChar(Console.ReadLine());
                if(encerrarSistema == '1')
                {
                    string nome;
                    Console.Write("Informe seu nome: ");
                    nome = Console.ReadLine();
                    int idade;
                    Console.Write("Informe sua idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}, você ja viveu {1} dias.",nome, (idade * quantidadeDiasAno).ToString());
                }
                else if(encerrarSistema == '2')
                {
                    Console.Write("Sistema será encerrado");
                }
                else
                {
                    Console.Write("Opção não encontrada, tente novamente.");
                }
            } while (encerrarSistema != '2');
        }
    }
}
