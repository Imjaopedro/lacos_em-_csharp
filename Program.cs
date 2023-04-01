using System;

namespace altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double Altura_Francisco , Altura_Juca;
           int anos;
           Altura_Francisco = 1.5;
           Altura_Juca = 1.1;
           anos = 0;

          // Altura_Juca = 0.03//
          // fran = 0.02 //
        while (Altura_Juca < Altura_Francisco){
            Altura_Juca+=0.03;
            Altura_Francisco += 0.02;
            anos +=1;

        }
        Console.WriteLine($"Demorou {anos} anos");
        }
    }
}
