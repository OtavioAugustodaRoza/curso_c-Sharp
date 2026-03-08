using System;

class Aula18
{
    static void Main()
    {
        int[,] n = new int[3,5]; //tres linhas e 5 colunas da matriz
        int[,] num = new int[2,2]{{20,30},{90,80},{20,10}};

        n[0,0]=373;
        n[0,1]=363;
        n[0,2]=353;
        n[0,3]=343;
        n[0,4]=323;
       
  
        n[1,0]=373;
        n[1,1]=363;
        n[1,2]=353;
        n[1,3]=343;
        n[1,4]=323;
       
  
        n[2,0]=373;
        n[2,1]=363;
        n[2,2]=353;
        n[2,3]=343;
        n[2,4]=323;
       
  Console.WriteLine(n[1,2]);
      
    }
}