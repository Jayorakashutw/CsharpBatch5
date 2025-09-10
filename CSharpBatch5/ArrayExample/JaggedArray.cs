using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.ArrayExample
{
    internal class JaggedArray
    {
        public void JaggedArrayExample()
        {
            int[][] jarray = new int[3][];
            jarray[0] = new int[] { 1, 3, 5, 7, 8 };
            jarray[1] = new int[] {11, 13 };
            jarray[2] = new int[] { 25,36,25,365,14,25,365,25,32,356,42 };

            Console.WriteLine("Stored value of Jagged Array is Below");
            for (int i = 0; i < jarray.Length; i++)
            { 
              Console.WriteLine("Rows"+ (i+1) +" : ");
               for(int j=0; j < jarray[i].Length; j++)
                {
                    Console.Write(jarray[i][j]+"\t");
                }
                Console.WriteLine();
                
            }
        }
    }
}
