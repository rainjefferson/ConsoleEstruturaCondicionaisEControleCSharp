using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEstruturaCondicionaisEControle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 6;
            #region Estruturas condicionais
            if (numero > 5)
            {
                Console.WriteLine("Numero maior que cinco!");
            }
            else
            {
                Console.WriteLine("Numero menor ou igual a cinco!");
            }            
            #endregion

            #region Operador ternário

            int numero2 = 7;
            // Condição ? true : false;
            string mensagem = numero2 > 5 ? "O numero é maior que cinco!" : "O numero é menor ou igual a cinco!";
            Console.WriteLine(mensagem);
            #endregion

            #region Estrutura de controle - Switch case
            int opc = 9;
          //string opc = "5";
          //dowble opc = 5.99;

            switch (opc)
            {
                default:
                    Console.WriteLine("Opção padrão");
                    break;
                case 1:
                    Console.WriteLine("Opção 1.");
                    break;
                case 2:
                    Console.WriteLine("Opção 2.");
                    break;
                case 3:
                    Console.WriteLine("Opção 3.");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Opção é 4 ou 5.");
                    break;
            }
            #endregion

            #region Estrutura de repetição
            // while
            int valor = 0;
            while (valor < 10)
            {
                Console.WriteLine("O valor é: " + valor);
                valor++;
            }

            valor = 0;
            // do..while
            // condição mesmo sendo falsa, executa ao menos uma vez
            do
            {
                Console.WriteLine("O valor é: " + valor);
                valor++;

            } while (valor < 10);

            // for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("O indice é: " + i);
            }

            // for com 2 variaveis de controle
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                Console.WriteLine("O indice é: " + i);
                Console.WriteLine("O jota é: " + j);
            }

            string[] nomes = { "Rafaela", "Jefferson", "Rain", "Papai", "Filha" };
            // foreach - executa uma iteração com uma coleção
            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            
            #endregion

            Console.ReadKey();
        }
    }
}
