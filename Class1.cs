using System;

namespace Exercice_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("veuillez entrer un nombre   ");
            int nbr = Convert.ToInt32(Console.ReadLine());

            while (nbr != 0)
            {
                int pr = 2;
                while ((nbr % pr != 0) && (pr < Math.Sqrt(nbr)))
                {
                    pr++;
                }
                if (nbr % pr != 0)
                    Console.WriteLine(nbr + " c'est un nomnbre premier");
                else
                    Console.WriteLine(nbr + " ce n'est pas un nombre premeier");

                Console.Write("veuillez entrer un auttre nombre   ");
                nbr = Convert.ToInt32(Console.ReadLine());

            }
            if (nbr == 0)
            {
                Console.WriteLine("veuillez entrer un nombre different de 0");

            }

            Console.ReadKey();
        }
    }
}
