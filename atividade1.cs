/*
João Papo-de-Pescador, homem de bem, comprou um microcomputador para 
controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de 
peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo 
(50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. João precisa que 
você faça programa que leia a variável P (peso de peixes) e verifique se há excesso. 
Se houver, gravar na variável E (Excesso) e na variável M o valor da multa que João 
deverá pagar. Caso contrário mostrar tais variáveis com o conteúdo ZERO.
*/
using System;
namespace atividade1
{
    class Program
    {
        static void Main (string[] args)
        {
            //DECLARAÇÃO DE VARIÁVEIS
            int P = 0;//variavel para armazenar o peso do pescado
            int E = 0;//variável para armazenar o excesso de peso
            int M = 0;// variável que recebera o valor da multa
            //CÓGIDO
            Console.WriteLine("Entre com o valor do pescado: ");//comando para instruir o usuario a entrar com os dados.
            P = Convert.ToInt32(Console.ReadLine());


        }
    } 
}
