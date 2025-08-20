using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Looping
{
    internal class DoWhile
    {
        public void number()
        {
            int i = 10; // initilization

            do
            {
                Console.WriteLine(i);
                i++; // increment  so that i can increase from 1 to 5
            } while (i <= 5); //condition
        }
    }
}
