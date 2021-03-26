using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        /*1. Implemente uma função que verifica se um número inteiro pertence a um vetor de inteiros.
            A função retornará 1, caso o número pertença ao vetor e 0, caso contrário. 
            A função receberá como parâmetros o vetor, o número e o tamanho do vetor.

          2. Implemente uma função que verifica se um caracter pertence a um vetor de caracteres. 
            A função retornará 1,caso o caracter pertença ao vetor e 0, 
            caso contrário. A função receberá como parâmetros o vetor, o caracter e o tamanho do vetor.*/

        static void Main(string[] args)
        {
            Verifica v = new Verifica();

            int menu = 0;

            Console.WriteLine("1 - Verifica Numero inteiro");
            Console.WriteLine("2 - Verifica Caracter");
            Console.WriteLine("ENTER para fechar o programa");

            Console.Write("Digite o exercio para escolhido");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    {
                        int val = 0;
                        int[] vet = new int[5];

                        vet[0] = 8;
                        vet[1] = 6;
                        vet[2] = 26;
                        vet[3] = 7;
                        vet[4] = 15;

                        Console.Write("Digite o valor para testa: ");
                        val = int.Parse(Console.ReadLine());

                        Console.Write("TESTE: " + v.VerificaVal(vet, val));

                        Console.Read();

                        break;


                    }
                case 2:
                    {
                        char carac;
                        char[] vetCarac = { 'A', 'B', 'C', 'D', 'E', 'F' };

                        Console.Write("Digite um caracteristica para testar: ");
                        carac = Convert.ToChar(Console.ReadLine());

                        Console.Write("TESTE: " + v.VerificaCar(vetCarac, carac));

                        Console.Read();

                        break;

                    }

                default:
                    {
                        Console.Write("Nao tem a opção" + menu + "desejado");
                        break;

                    }
            }







        }


    }

    public class Verifica
    {


        public int VerificaVal(int[] vet, int val)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == val)
                {
                    return 1;
                }
            }
            return 0;
        }

        public int VerificaCar(char[] vet, char val)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == val)
                {
                    return 1;
                }
            }
            return 0;
        }
    }

}
