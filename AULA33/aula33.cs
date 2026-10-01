using System;


class Jogador
{
    private int energia;
    private string nome;

    public Jogador(string nome)
    {
        this.nome = nome;
        energia=100;
    }
    public int getEnergia()
    {
        return energia;
    }
    public string getNome()
    {
        return nome;
    }
    public void setEnergia(int energia)
    {
        if (energia < 0)
        {
            if(this.energia+energia < 0)
            {
                energia = 0;
            }
            else
            {
                this.energia += energia;
            }
            
        }else if(energia > 0)
        {
             if(this.energia+energia > 100)
            {
                energia = 100;
            }
            else
            {
                this.energia += energia;
            }
            
        }
    }
}
class Aula33
{
    static void Main()
    {
        Jogador j1 = new Jogador("neymar");
        j1.setEnergia(-30);
        Console.WriteLine("nome: {0}",j1.getNome());
        Console.WriteLine("energia: {0}",j1.getEnergia());
        
    }
}