using System;
class Aula11
{
    static void Main()
    {
        // conversao implicita  (segura)
        // int n1 = 10;
        // float n2 = n1;

        // conversao explicita (erro) precisa de cast
        // float n1 = 10.2;
        // int n2 = n1;

        // cast sendo feito
        // float n1 = 10.2;
        // int n2 = (int)n1; type cast

        int v = 10;
        //long x =v;
        short x = (short)v;

        Console.WriteLine(x);



    }
}