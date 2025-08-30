using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Practice_Set.Loops
{
    internal class Practice_03
    {
        private void Main(string[] args)
        {


            for (int i = 1; i <= 10; i++)
            {
                int exponent = (int)Math.Pow(2, i);
                Console.WriteLine(exponent);
            }
        }
    }
}
