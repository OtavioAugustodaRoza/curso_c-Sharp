using System;

class Aula10
{  
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,sabado};
    static void Main()
    {
     //   DiasSemana ds = DiasSemana.Domingo;
     //   DiasSemana ds = (DiasSemana)3; //pegando quarta pelo indice
       int ds = (int)DiasSemana.Sexta; //pegando o indice de sexta

        Console.WriteLine(ds);
      
        
        
    }
}
