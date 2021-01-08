using System;

namespace tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            string recebe = Console.ReadLine();
            string[] desafio = Console.ReadLine().Split(" ");
            int N = Int32.Parse(recebe);
            int A = int.Parse(desafio[0]);
            int B = int.Parse(desafio[1]);

            if (N >= 2 && N <= 100)
            {
                if (A >= 1 && B <= 100)
                {
                    if (N >= A + B)
                    {
                        Console.WriteLine("Farei hoje!");
                    }
                    else Console.WriteLine("Deixa para amanha!");
                }
            }
        }
    }
}