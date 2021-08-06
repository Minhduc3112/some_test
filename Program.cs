using System;

namespace some_test
{
    class Program
    {
        static void Main(string[] args)
        {    
            do
            {
                Console.WriteLine("choose your case");
                string cases = Console.ReadLine();
                int n = int.Parse(cases);
                switch (n)
                {
                    case 1: Console.WriteLine("Minh duc");break;
                    case 2: Console.WriteLine("Minh 2"); break;
                    case 3: Console.WriteLine("Minh 3"); break;
                    case 4: Console.WriteLine("Minh 4"); break;
                    case 5: Console.WriteLine("Minh 5"); break;
                }
                Console.WriteLine("Do you want to continues ?");
                string choose = Console.ReadLine();
                if (choose == "y")
                {
                    continue;
                }
                if(choose == "n")
                {
                    Console.WriteLine("End");
                    break;
                }

            } while (true);
        }
    }
}
