using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Testemesa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o exercício desejado (6,7):");
            Console.WriteLine();
            Console.WriteLine("6. Exercício 6");
            Console.WriteLine("7. Exercício 7");

            int exercicio = int.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 6:
                    Console.WriteLine("Exercício 6.");
                    Exercicio6();
                    break;
                case 7:
                    Console.WriteLine("Exercício 7.");
                    Exercicio7();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.ReadLine();

        }

        static void Exercicio6()
        {
            //pede apenas os dados de valor inicial e taxa de juros
            Console.WriteLine("Vamos calcular o Rendimento Futuro para o período de 8 meses e 10 dias.");
            Console.WriteLine();
            Console.WriteLine("Informe o valor de inicial de investimento: ");
            double valorpresente = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a taxa de juros: ");
            double taxajuros = double.Parse(Console.ReadLine());
            Console.WriteLine();
            

            double i = taxajuros / 100; //i é a taxa de juros
            double mes = 8;
            int dias = 10;   

           
            double calculodias = (mes * 30 + dias) / 30; //calculo de dias e mês
            double valorfuturo = valorpresente * Math.Pow(1 + i, calculodias); //calculo do rendimento futuro

            double rendimento = Math.Round(valorfuturo, 2);

            Console.WriteLine($"O Rendimento Futuro do valor de R$ {valorpresente} e taxa de {i}, em um perído de 8 meses e 10 dias é de R$ {rendimento}");

            Console.ReadLine();

        }

        static void Exercicio7()
        {
            Console.WriteLine("Vamos calcular o rendimento em 8 meses, e o rendimento após o saque do 5º mês");    
            Console.WriteLine("Digite o valor inicial de investimento:");
            double valorpresente = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da taxa de juros:");
            double taxajuros = double.Parse(Console.ReadLine());

                
            double juros = taxajuros / 100;
            int mes = 8;


            Console.WriteLine("Valor Presente | Taxa de Juros | Período do Mês |   Rendimento   | Rendimento Líquido |    Saldo    | Saque");

            for (int i = 1; i <= mes; i++)
            {
                double rendimento = valorpresente * Math.Pow(1 + juros, i);
                double rendimentoliquido = rendimento - valorpresente;
                double saque = 0;
                double saldo = rendimento;

                 //comando if para verificar quanto o usuário quer sacar no 5º mês
                 if (i == 5) 
                 {
                    Console.WriteLine("Digite o valor do saque para o 5º mês: ");
                    double resgate = double.Parse(Console.ReadLine());

                    saque = resgate;
                    saldo = valorpresente + rendimentoliquido - saque;
                    valorpresente = saldo;
                 }
                    double rendaacumulada = Math.Round(saldo, 2);
                    double p = Math.Round(valorpresente, 2);

                    Console.WriteLine($"{"R$ " + p,14:C2} | {juros + " %",13} | {i + "º Mês",14} | {rendimento,14:C2} | {rendimentoliquido,18:C2} | {"R$ " + rendaacumulada,11:C2} | {"R$ " + saque,12}");
            }
                Console.ReadLine();

           
        }
    }
}
