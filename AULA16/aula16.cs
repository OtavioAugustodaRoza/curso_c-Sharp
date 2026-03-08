using System;

class Aula16
{
    static void Main()
    {

        char escolha;
       

        inicio: //label
        Console.Clear();

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

        Console.WriteLine("Calcular outras notas? s/n");
        escolha =char.Parse(Console.ReadLine());
        
        if(escolha == 's' || escolha == 'S')
        {
            goto inicio; // goto volta pro label inicio
        }
        else
        {
            Console.Clear();
            Console.Write("Fim do programa");
        }

    }
}