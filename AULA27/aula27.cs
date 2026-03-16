using System; 

class Aula27
{
    static void Main()
    {
        soma(10,20,30);
        
    }
    // static void soma(int n1,int n2)
    // {
    //     int res = n1+n2;
    //     Console.WriteLine("a soma de {0} com {1} é {2}",n1 , n2 , res);
    // }
     static void soma(params int[]n)
      {
         int res = 0;
         if(n.Length < 1)
        {
            Console.WriteLine("nao existem valores a serem somados");
        } else if(n.Length < 2)
        {
            Console.WriteLine("valores insuficientes para soma");
        }
        else
        {
            for(int i =0; i < n.Length; i++)
            {
                res += n[i];
            }
            Console.WriteLine("a soma dos valores é {0}", res);
        }
   
      }
}