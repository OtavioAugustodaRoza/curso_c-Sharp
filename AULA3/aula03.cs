using System;

class Aula03
{
    static void Main()
    {
        // tipos primitivos 
        byte n1=10; // 0 e 255
        int num=0;
        char letra='c';
        float valor=5.3f;
        string nome = "Otavio";

        int num1,num2,res;
        num1 = 2;
        num2 = 3;
        res = num1*num2;

        //tipo especial
        var aux=10;


       Console.WriteLine("valor da variavel: "+aux+" ...");
       Console.WriteLine("A mutiplicação de " +num1+ " mais " +num2+ " é igual a: " +res);
    }
}