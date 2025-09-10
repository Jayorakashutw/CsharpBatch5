using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.Functions
{
    internal class Math_String
    {
        public void StringFunctions()
        {
            // to find the lenght of a string
            string s = "Jay prakash pathak";
            int l = s.Length;
            Console.WriteLine("Lenght of String is " + l);
            // to print each character of string
            foreach (char c in s)
            {
                Console.Write(c + " ");
            }

            // to compare two string
            string s1 = "Jay Prakash";
            string s2 = "jay prakash";
            int res = String.Compare(s1, s2);
            if (s1.CompareTo(s2) == 0)
            {
                Console.WriteLine("Both String are equal");
            }
            else
            {
                Console.WriteLine("String are not equal");
            }
            string[] s3 = { "Jay", "Prakash", "Pathak" };
            Console.WriteLine(s1.EndsWith("Prakash"));
            String result = String.Join(" , ", s3);
            Console.WriteLine("New String is " + result);

            Console.WriteLine("\n\nString in lower case   " + s1.ToLower());
            Console.WriteLine("String in lower case  " + s1.ToUpper());

        }
        public void MathFunction()
        {
            Console.WriteLine(Math.Max(25,54));//Maximum
            Console.WriteLine(Math.Min(25, 54));//minimum
            Console.WriteLine(Math.Sqrt(25));//square root
            Console.WriteLine(Math.Abs(-85)); //absolute - return absolute positive number
            Console.WriteLine(Math.Round(25.54)); // round to the nearest whole number
            Console.WriteLine(Math.Pow(25, 2)); //power
            Console.WriteLine(Math.Round(Math.PI,2)); //return PI value
        }
    }
}
