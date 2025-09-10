using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.ArrayExample
{
    internal class MultiArray
    {
        public void twoDarrayExample()
        {
            int[,] array = new int[2, 3];
          
            int r, c;
            Console.WriteLine("Enter value in Array");
             for(r=0;r<2;r++)
            {
                for (c = 0; c < 3; c++)
                {
                    array[r, c] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("Stored Value in Array");
            for (r = 0; r < 2; r++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write(array[r, c]+"\t");
                   
                }
                Console.WriteLine();
            }
        }

        public void TransposeMatrix()
        {
            int[,] array = new int[2, 3];
            int[,] transpose = new int[3, 2];
            int r, c;
            Console.WriteLine("Enter value in Array");
            for (r = 0; r < 2; r++)
            {
                for (c = 0; c < 3; c++)
                {
                    array[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Stored Value in Array");
            for (r = 0; r < 2; r++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write(array[r, c] + "\t");
                     transpose[c, r] = array[r, c];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Transpose in Array");
            for (r = 0; r < 3; r++)
            {
                for (c = 0; c < 2; c++)
                {
                    Console.Write(transpose[r, c] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
