using System;

class Aula6
{
   static void Main()
    {
      //  int n1,n2,n3;
        //n1=10;
        //n2=20;
        //n3=30;

       // Console.WriteLine(n1 +", "+ n2+ ", " + n3);
       //carcteres de escape
       // Console.WriteLine("n1=\t{0}\nn2=\t{1}\nn3=\t{2}",n1,n2,n3); // \n = quebra de linha and \t da tabulação

       double valorCompra = 5.50;
       double valorVenda;
       double lucro = 0.1;
       string produto = "pastel";

       valorVenda=valorCompra+(valorCompra*lucro);

       Console.WriteLine("Produto.....:{0,15}",produto);
       Console.WriteLine("val.compra..:{0,15:c}",valorCompra);
       Console.WriteLine("lucro.......:{0,15:p}",lucro);
       Console.WriteLine("val.venda...:{0,15:c}",valorVenda);

    }
}