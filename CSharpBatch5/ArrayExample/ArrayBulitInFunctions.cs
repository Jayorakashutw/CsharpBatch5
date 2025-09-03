using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.ArrayExample
{
    internal class ArrayBuiltInFunctions
    {
        public void ArrayFunctionExample()
        {
            int[] arr = { 45, 85, 3, 65, 185, 6, 4, 25, 98, 7 };
            Console.WriteLine("Enter a number which you want to serach");
             int lenght=arr.Length; // to get the lenght of array
            Console.WriteLine("Lenght of an array is "+lenght);

            Console.WriteLine("\n Array Before Soring\n ");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Array.Sort(arr);
            Console.WriteLine("\nArray after Soring\n ");
            foreach(int i in arr)
            {
                Console.Write(i+"\t");
            }
          
            int result = Array.BinarySearch(arr, 185);
            Console.WriteLine("\n\nSearch Result is " + result);
           
            Array.Reverse(arr);
            Console.WriteLine("\nArray after Reversing\n ");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }

            int index= Array.IndexOf(arr, 7);
            Console.WriteLine("\n\nIndex of given number is " + index);

        }

    }
}
