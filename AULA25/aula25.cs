using System; 

class Aula25
{
    static void Main()
    {
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);
        
    }
    // pasagem por valor não altera a variavel chamada por ref sim
    static void dobrar(ref int valor) //ref serve para referenciar uma variavel fazendo elas terem menso endereco de memoria 
    {
        valor*=2;
    }
}