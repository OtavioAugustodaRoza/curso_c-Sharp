using System;
// nao se pode ter construtor em classes static e todos seus membros devem ser static
static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n)
    {
        nome = n;
        energia = 100;
        vivo = true;
    }
    static public void info()
    {
        Console.WriteLine("Nome do jogaodr:{0}", nome);
        Console.WriteLine("energia do jogador:{0}", energia);
        Console.WriteLine("status de vida do jogador:{0}", vivo);
    }
}

class Inimigo
{
    public bool alerta;
    public string nome;

    public Inimigo(string n)
    {
        nome=n;
        alerta = false;
    }
    public void info()
    {

        Console.WriteLine("---------------------------------");
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
    }
}
class Aula31
{
    static void Main()
    {
        Jogador.iniciar("otavio");
        Jogador.info();

        Inimigo i1 = new Inimigo("ronaldo");
        i1.info();
    }
}