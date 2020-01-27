using System;

namespace rappel_ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1;
            int nb2;
            int total;
            string entry;
            Console.WriteLine("Entrez 2 nombres");
            entry = Console.ReadLine();
            nb1 = Convert.ToInt32(entry);
            entry = Console.ReadLine();
            nb2 = int.Parse(entry);

            Console.WriteLine("Quelle opération voulez-vous faire\nAddition A,\t Soustraction B");
            entry = Console.ReadLine();
            if(entry == "A")
            {
                total = nb1 + nb2;
                Console.WriteLine("Voici le total: "+ total);
            }
            else if (entry == "B")
            {
                total = nb1 - nb2;
                Console.WriteLine("Voici le total: " + total);
            }
            else
            {
                Console.WriteLine("Choix invalide");
            }




        }
    }
}
