using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.ConditionalStatement
{
    internal class JumpStatement
    {
        public void NaturalNo()
        {
            int i= 1;

      Nat:

            Console.WriteLine(i);
            i++;
            if (i <= 10)
                goto Nat;
        }
        public void EvenNo()
        {
            int i = 2;

        Nat:

            Console.WriteLine(i);
            i=i+2;
            if (i <= 20)
                goto Nat;
        }
    }
}
