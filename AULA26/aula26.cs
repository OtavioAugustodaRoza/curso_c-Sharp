using System; 

class Aula26
{
    static void Main()
    {
        int rest;
        int dividendo = 10;
        int divisor =5;
       int quoc = divide(dividendo,divisor,out rest);
        Console.WriteLine("{0}/{1}:quociente={2} e resto={3}",dividendo,divisor,quoc,rest);
    }
    static int divide(int dividendo, int divisor,out int resto)
    {
        int quociente;
        quociente = dividendo/divisor;
        resto = dividendo%divisor;
        return quociente;
    }
    
 }