/*Construa um algoritmo que leia 5 valores inteiros e positivos e: 
Encontre o maior valor 
Encontre o menor valor 
Calcule a média dos números lidos*/

using System;
namespace atividade7
{
    class Program
    {
        static void Main (strring[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int maior = 0;
            int menor = 0;
            Console.WriteLine("Entre como o valor 1: ");
            a =  int.Parse(Console.ReadLine());
            Console.WriteLine("Entre como o valor 2: ");
            b =  int.Parse(Console.ReadLine());
            if(a>b)
            {
                maior = a;
                menor = b;
            }else if(a<b)
            {
                maior = b;
                menor = a;
            }
        }
    }
}