using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string feels = "no";

            while (feels != "yes")
            {
                Console.WriteLine("Are you happy? [Yes/No]");
                feels = Console.ReadLine().ToLower();

            }

            Console.WriteLine("Yeah, me too :D");
            Console.ReadLine();

        }
    }
}
