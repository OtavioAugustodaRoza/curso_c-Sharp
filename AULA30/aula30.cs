using System;
 
public class Jogador
{
   public int energia ;
   public bool vivo ;

   public string nome;

// sobrecarga de construtor

   public Jogador()
    {
        nome = "Jogador";
        energia = 100;
        vivo = true;
        
    }
       public Jogador(string n, int e)
    {
        nome = n;
        energia = e;
        vivo = true;
    }

    public void info()
    {
        Console.WriteLine("Nome do jogaodr:{0}",nome);
        Console.WriteLine("energia do jogador:{0}",energia);
        Console.WriteLine("status de vida do jogador:{0}",vivo);
    }


// construtor
   public Jogador(string n)
    {
        nome = n;
        energia = 100;
        vivo = true;
    }
}
class Aula30
{
    static void Main()
    {
     Jogador j1 = new Jogador();           
     Jogador j2 = new Jogador("bruno");           
     Jogador j3 = new Jogador("messi",140);           
 

     j1.info();                   
     j2.info();                   
     j3.info();                   
                   
    }
}