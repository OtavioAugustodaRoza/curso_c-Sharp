using System;

class Aula19
{
    static void Main()
    {
       // int[] x = new int[]{0,10,20,30,40,50,60,70,80,90,100};
        int[] x = new int[11];
  
        for (int i = 0;i < x.Length;i++)
        {
          //  Console.WriteLine(x[i]);
            x[i]=i;
        }
        for(int i = 0; i < x.Length; i++)
        {
            Console.WriteLine(x[i]);
        }
    }
}