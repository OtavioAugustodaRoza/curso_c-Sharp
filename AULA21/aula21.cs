using System;

class Aula21
{
    static void Main()
    {
    //     int i = 0;

    //     // uma execução garantida

    //     do
    //     {
    //         Console.WriteLine(i);
    //         i++;
    //     } while (i>10);
    // }

    string senha = "123";
    string senhaUser;
    int tentativas=0;

        do
        {
            Console.Clear();
            Console.WriteLine("Digite sua senha");
            senhaUser = Console.ReadLine();
            tentativas++;
        }while(senhaUser != senha);

        Console.Clear();
        Console.Write("senha correta na tentativa {0}",tentativas);
   
   
   
   
   }
}