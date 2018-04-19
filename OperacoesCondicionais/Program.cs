using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário in-line(em linha)

            /*
                Comentário in-block(em bloco)           
             
             */

             //Declaração da variavel da Operação. Ela será do tipo inteiro.
             int operacao;
             
             //Declaração das variaveis n1 e n2. Elas serão do tipo double.
            double n1, n2;

            /* 
            Para limpar a tela de comando a cada execução, utilizamos o comando Console.Clear(); Obs .: Clear -> Limpar
             */
             
             Console.Clear();
             Console.WriteLine("Escolha uma das operações abaixo: ");

             /*
             Para a exibição das opções de operação, vamos usar o comando Console.WriteLine e, nele useremos um 
             comando de quebra de linha \n(contra-barra n(new line)). Assim, as opções ficarão uma abaixo da outra.
             */
             Console.WriteLine("1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
             operacao = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite um numero: ");
             n1 = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite outro numero: ");
             n2 = double.Parse(Console.ReadLine());

             if(operacao==1)
             {
                 Console.WriteLine("O resultado da soma é: "+(n1+n2));

             }

             else if(operacao==2)
            {
                Console.WriteLine("O resultador da subtração é: "+(n1-n2));

            } 
            else if(operacao==3)
            {
                Console.WriteLine("O resultado da Multiplicação é:" +(n1*n2));

            }
            else if(operacao==4)
            {
                Console.WriteLine("O resultado da divissao é " +(n1/n2));

            }
            else
            {
                Console.WriteLine("Operação Invalida!");
            }


        }
    }
}
