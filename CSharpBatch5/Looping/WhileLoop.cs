using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Looping
{
    internal class WhileLoop
    {
        public void number()
        {
            int i = 1; // initilization

            while( i<=5) // condtion
            {
                Console.WriteLine(i);
                i++; // increment  so that i can increase from 1 to 5
            }
        }
    }
}
