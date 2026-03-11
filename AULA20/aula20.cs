using System;

class Aula20
{
    static void Main()
    {
        int[] num = new int[10];
        int contador = 0;

        // while (contador<=10)
        // {
        //     Console.WriteLine(contador);
        //     contador++;            
        // }
        // Console.WriteLine("fim do loop");
        
        while (contador<num.Length)
        {
            num[contador]=0;
            Console.WriteLine(num[contador])  ;     
            contador++;     
        }
        Console.WriteLine("fim do loop");
        
    }
}