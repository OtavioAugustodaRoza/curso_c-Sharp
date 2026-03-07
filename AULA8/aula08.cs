using System;

class Aula8
{
    static void Main()
    {

        // string nome;
        // Console.Write("Digite seu nome: ");
        // nome = Console.ReadLine();
        // Console.WriteLine("olá {0}" nome);

        int v1, v2, soma;

        Console.Write("digite o primeiro número:");
        v1 =int.Parse( Console.ReadLine());
        Console.Write("digite o segundo número:");
        v2 =Convert.ToInt32( Console.ReadLine());
        soma = v1+v2;
        Console.WriteLine("A soma de {0} e {1} é igual á {2}",v1,v2,soma);
    }
}