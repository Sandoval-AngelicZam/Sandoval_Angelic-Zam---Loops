using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Practice_Set.Loops
{
    internal class Practice_5
    {
        private void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 50; i++)
            {

                if (i % 2 != 0)
                {
                    sum++;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
