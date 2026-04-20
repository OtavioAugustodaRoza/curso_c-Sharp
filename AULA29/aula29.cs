using System; 

public class Jogador
{
   public int energia ;
   public bool vivo ;

   public string nome;


// construtor
   public Jogador(string n = "jogador")
    {
        nome = n;
        energia = 100;
        vivo = true;
    }
    // desconstrutor
    ~Jogador()
    {
        Console.WriteLine("jogador {0} foi destruido",nome);
    }


}
class Aula29
{
    static void Main()
    {
                
          Jogador j1 = new Jogador("claudio");
          Jogador j2 = new Jogador("josé");
          Jogador j3 = new Jogador();
        Console.WriteLine("digite o nome do jogador1");
          j1.nome = Console.ReadLine(); 
          j1.energia=50;
          Console.WriteLine("digite o nome do jogador2");
          j2.nome = Console.ReadLine(); 
          j2.energia=150;
          Console.WriteLine("digite o nome do jogador3");
          j3.nome = Console.ReadLine(); 
          j3.energia=100;
          Console.Clear();
          Console.WriteLine("energia do {1} = {0}", j1.energia,j1.nome);
          Console.WriteLine("energia do {1} = {0}", j2.energia, j2.nome);
          Console.WriteLine("energia do {1} = {0}", j3.energia,j3.nome);
    }
}