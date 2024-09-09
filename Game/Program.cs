using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key);
                //ConsoleKey.
                Console.WriteLine(key.ToString());
            } while (key != ConsoleKey.Escape);
        }
    }
}
