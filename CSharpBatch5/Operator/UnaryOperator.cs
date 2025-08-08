using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Operator
{
    public class UnaryOperator // incremental and decremental
    {
        int number = 77;
        public void Incremental()
        {
            Console.WriteLine("Orignal Number " + number);
            Console.WriteLine("Post Increment "+ number++);
            Console.WriteLine("Pre Increment "+ ++number);
        }
    }
}
