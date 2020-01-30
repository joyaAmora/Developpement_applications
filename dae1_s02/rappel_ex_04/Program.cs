using System;

namespace rappel_ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long total = 0; 
            int nb = 2;
            int Ctr = 0;
            Console.WriteLine("Voici le total des 500 nombres premiers ");
            while (Ctr < 500)
            {
                if (isPrime(nb))
                {
                    total += nb;
                    Ctr++;
                    nb++;
                    Console.WriteLine(total.ToString());
                }
                else
                {
                    nb++;
                }
            }

            Console.WriteLine(total.ToString());
        }
        public static bool isPrime(int nb)
        {
            int x = (int)Math.Floor(Math.Sqrt(nb));
            if(nb == 1)
            {
                return false;
            }
            else
            {
                if (nb == 2)
                {
                    return true;
                }
                else
                {
                    int i = 2;
                    while(i <= x)
                    {
                        if (nb % i == 0)
                            return false;
                        else
                        {
                            ++i;
                        }
                    }
                }
                return true;
            }
                
        }
    }
}
