using System;

class Aula23
{
    static void Main()
    {
        // metodos para vetores e matrizes
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[3, 5] { { 33, 33, 232, 32, 32 }, { 32, 32, 32, 32, 32 }, { 23, 32, 324, 44, 55 } };

        Random random = new Random(); // gera numeros aleatorios 
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50); // Next serve para limitar a tal numero ou dar um numero minimo 
                                         //       vetor1[i] = random.Next(50,100); min = 50 max = 100 

            Console.WriteLine(vetor1[i]);
        }

        // public static int BinarySearch(array,valor) retorno -1 n esta no array

        Console.WriteLine("BinarySearch");
        int procurando = 33;
        int pos = Array.BinarySearch(vetor1, procurando);
        if (pos >= 0)
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
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int i in vetor2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-------------------------------------------");


        // public static CopyTo(ar_destino, a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int i in vetor3)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-------------------------------------------");

        // public int GetLowerBound(dimensao);
        int menorIndiceVetor = vetor1.GetLowerBound(0);
        int menorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("o menor indice do vetor é {0} e da matriz é {1}", menorIndiceVetor, menorIndiceMatriz);
        Console.WriteLine("-------------------------------------------");

        // public int GetUpperBound(dimensao);
        int maiorIndiceVetor = vetor1.GetUpperBound(0);
        int maiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine("o maior indice do vetor é {0} e da matriz é {1}", maiorIndiceVetor, maiorIndiceMatriz);
        Console.WriteLine("-------------------------------------------");

        // public long GetLongLength(dimensao);
        long qtdeElementos = vetor1.GetLongLength(0);
        Console.WriteLine("A quantidade de elementos no vetor é {0}", qtdeElementos);
        Console.WriteLine("-------------------------------------------");

        //public object GetValue(long,indice)
        int valor1 = Convert.ToInt32(vetor1.GetValue(1));
        Console.WriteLine(valor1);
        Console.WriteLine("-------------------------------------------");

        // public static int IndexOf(array,valor)
        int indice1 = Array.IndexOf(vetor1, 23);
        Console.WriteLine(indice1);
        Console.WriteLine("-------------------------------------------");

        // public static int LastIndexOf(array,valor)
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine(indice1);
        Console.WriteLine("-------------------------------------------");

        // public static void Reverse(array)
        Array.Reverse(vetor1);
        foreach (int f in vetor1)
        {
            Console.WriteLine(f);
        }
        Console.WriteLine("-------------------------------------------");

        //public void SetValue(object valor, long pos)
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("vetor2");
        foreach (int f in vetor2)
        {
            Console.WriteLine(f);
        }
        Console.WriteLine("-------------------------------------------");

        //public static void Sort(array);

        Array.Sort(vetor1);
        foreach (int i in vetor1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-------------------------------------------");
    }
}