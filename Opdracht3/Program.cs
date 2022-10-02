using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                if(i * 7 <= 546)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
