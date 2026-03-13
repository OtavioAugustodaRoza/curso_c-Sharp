using System;

class Aula23
{
    static void Main()
    {
        // metodos para vetores e matrizes
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];

        Random random = new Random(); // gera numeros aleatorios 
        for(int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50); // Next serve para limitar a tal numero ou dar um numero minimo 
     //       vetor1[i] = random.Next(50,100); min = 50 max = 100 

            Console.WriteLine(vetor1[i]);
        }

        // public static int BinarySearch(array,valor) retorno -1 n esta no array

        Console.WriteLine("BinarySearch");
        int procurando =33;
        int pos = Array.BinarySearch(vetor1,procurando);
        if(pos >= 0)
        {
        Console.WriteLine("Valor {0} está na posição {1}", procurando, pos);
        }
        else
        {
        Console.WriteLine("Valor {0} não está na lista", procurando);
        }
        Console.WriteLine("-------------------------------------------");

    // public static void Copy(ar_origem, ar_destino, qtde_elementos);
    Console.WriteLine("Copy");
    Array.Copy(vetor1,vetor2,vetor1.Length);
    foreach(int i in vetor2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-------------------------------------------");


        // public static CopyTo(ar_destino, a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int i in vetor3)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-------------------------------------------");

        // public int GetLowerBound(dimensao);


    }
}