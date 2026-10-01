using System;


class Calculos
{
    public int v1;
    public int v2;

public Calculos(int v1, int v2)
     {
    //     this ESPECIFICA QUE V1 É REFERENCIA DO OBJETO CALCULOS E NÃO DO PARAMENTRO
        this.v1 = v1;
        this.v2 = v2;
    }
    public int Somar()
    {
        return v1 + v2;
    }
}
class Aula32
{
    static void Main()
    {
        Calculos C = new Calculos(10,2);
        Console.WriteLine(C.Somar());
        
    }
}