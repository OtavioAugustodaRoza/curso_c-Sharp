using System;

class Aula12
{
    static void Main()
    {
        float nota1,nota2,nota3,media;
        Console.Write("Escreva sua primeira nota:");
       nota1= float.Parse( Console.ReadLine());
        Console.Write("Escreva sua segunda nota:");
       nota2=  float.Parse( Console.ReadLine());
        Console.Write("Escreva sua terceira nota:");
       nota3= float.Parse( Console.ReadLine());

       media = (nota1+nota2+nota3) / 3;

       if(media >= 6)
        {
            Console.WriteLine("Sua média foi {0} e você passou de ano !!!",media);
        }
        else
        {
            Console.WriteLine("Sua média foi {0} e você não passou de ano.",media);
        }

    }
}