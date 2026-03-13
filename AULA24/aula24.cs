using System;

class Aula24
{
    static void Main()
    {
        ola();
       Console.WriteLine( soma(2,3));
        
    }
    //quando o metodo nao retorna nada ele pe void
    static void ola()
    {
        Console.WriteLine("ola mundo");
    }
    static int soma(int n1 , int n2)
    {
         int res = n1+n2;
         return res;
        // Console.WriteLine("a soma de {0} com {1} é {2}", n1,n2,res);
    }
}