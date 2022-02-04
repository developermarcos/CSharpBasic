using System;

//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
//Após o aumento,desconte 8% de impostos. Imprima o salário inicial, o salário
//com o aumento e o salário final.

namespace Salario.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double aumentoSalarial = 0.15;
            const double descontoSalarialImpostos = 0.08;
            char encerrarSistema;
            do
            {
                Console.Write("\n ----------------------------------");
                Console.WriteLine("Escolha \n (1) Informar o salário. \n (2) Encerrar programa");
                encerrarSistema = Convert.ToChar(Console.ReadLine());
                if (encerrarSistema == '1')
                {
                    double salario;
                    Console.Write("informe o salário: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Salário recalculado: {0}", (salario * aumentoSalarial + salario) - (salario * aumentoSalarial + salario) * descontoSalarialImpostos);
                }
                else if (encerrarSistema == '2')
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
