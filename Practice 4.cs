using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Practice_Set.Loops
{
    internal class Practice_4
    {
        private void Main(string[] args)
        {

            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                int square = (int)Math.Pow(2, i);
                sum += square;
            }

            Console.Write(sum);
        }
    }
}
