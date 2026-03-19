using System;

// se a classe não usa modifcador auto ela publica
public class Jogador
{
   public int energia = 100;
   public bool vivo = true;

}

class Aula28
{
    static void Main()
    {
        Jogador j1 = new Jogador(); // new reserva a memoria para o objeto

        Console.WriteLine(j1.energia);        
    }
}