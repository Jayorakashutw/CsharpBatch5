using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBatch5.ArrayExample
{
    public class SingleArray
    {
        int[] arr = new int[5]; // declear and allocation of size
        string[] name=new string[5];

        public void StoreNumber()
        {
            Console.WriteLine("Enter numbers to store in Array ");

            for(int i=0; i<arr.Length; i++) // Lenght - is used to retrive length of array
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Stored value in Array is below");

            foreach(int data in arr)
            {
                Console.Write(data+"\t");
            }
        }

        public void StoreName()
        {
            Console.WriteLine("Enter Name to store in Array ");

            for (int i = 0; i < name.Length; i++) // Lenght - is used to retrive length of array
            {
                name[i] = Console.ReadLine();
            }

            Console.WriteLine("Stored Name in Array is below");

            foreach (string data in name)
            {
                Console.Write(data + "\t");
            }
        }

        //wap for Linear Search 

        public void LinearSearch()
        {
            int[] arr = { 45,85,3,65,85,6,4,25,98,7};
            Console.WriteLine("Enter a number which you want to serach");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            for( i=0;i<arr.Length;i++)
            {
                if (arr[i]== num)
                {
                    Console.WriteLine("Value found at "+(i+1) +" Position");
                    break;
                }
            }
            if(i==arr.Length)
            {
                Console.WriteLine("Data not found");
            }
        }

        // Binary Search

        public void BinarySearch()
        {
            int[] arr = { 4,6,8,9,12,15,36,45,69,47,58,69,78,95};
            Console.WriteLine("Enter a number which you want to serach");
            int num = Convert.ToInt32(Console.ReadLine());
            int min = 0;
            int max = arr.Length - 1;
            int position = -1;
            while(min<=max)
            {
                int mid = (max + min) / 2;
                if (arr[mid] == num)
                {
                    position = mid;
                    break;
                }
                else if (arr[mid]<num)
                {
                    min = mid + 1;
                }
                else
                {
                    max=mid-1;
                }
            }
            if(position==-1)
            {
                Console.WriteLine("Value not found");
            }
            else
            {
                Console.WriteLine($"Element found at index {position}");
            }
           
        }

        // Bubble Sort
        public void BubbleSort()
        {
            int temp;
            int[] arr = { 45, 85, 3, 65, 85, 6, 4, 25, 98, 7 };
           Console.WriteLine("Array before Sorting");
           foreach( int num in arr)
           {
                Console.Write(num+"\t");
           }

           for(int i=0; i<arr.Length-1; i++)
            {
                for(int j=0; j<arr.Length-1-i;j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n\nArray After Sorting");
            foreach (int num in arr)
            {
                Console.Write(num + "\t");
            }
        }

        // Selection Sort
        public void SelectionSort()
        {
            int temp;
            int[] arr = { 45, 85, 3, 65, 85, 6, 4, 25, 98, 7 };
            Console.WriteLine("Array before Sorting");
            foreach (int num in arr)
            {
                Console.Write(num + "\t");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n\nArray After Sorting");
            foreach (int num in arr)
            {
                Console.Write(num + "\t");
            }
        }
        // WAP to display Only Even No
        public void OnlyEven()
        {
            int[] arr = { 45, 85, 3, 65, 85, 6, 4, 25, 98, 7 };
            Console.WriteLine("Even number in arrray is below");
           
           foreach(int num in arr)
            {
                if(num%2==0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        // WAP to display Only Even No Sum
        public void EvenSum()
        {
            int[] arr = { 45, 85, 3, 65, 85, 6, 4, 25, 98, 7 };
            Console.WriteLine("Even number in arrray is below");
            int sum = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + "\t");
                    sum =sum + num;
                }
            }
            Console.WriteLine("\n Sum of Even is "+sum);
        }

        // WAP to display Only Odd No
        public void OddNo()
        {
            int[] arr = { 45, 85, 3, 65, 85, 6, 4, 25, 98, 7 };
            Console.WriteLine("Even number in arrray is below");

            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + "\t");
                }
            }
        }

        // WAP to display Only Odd  No Sum
        public void OddSum()
        {
            int[] arr = { 45, 85, 3, 65, 85, 6, 4, 25, 98, 7 };
            Console.WriteLine("\n Even number in arrray is below");
            int sum = 0;
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + "\t");
                    sum = sum + num;
                }
            }
            Console.WriteLine("\n Sum of Odd is " + sum);
        }


        // WAP to display Only Prime No
        public void PrimeinArray()
        {
            int[] arr = { 45, 85, 3, 65, 85, 6, 4, 25, 98, 7 };
            Console.WriteLine("\n Even number in arrray is below");
            bool Isprime = true;
            foreach (int num in arr)
            {
               for(int i=2;i<num;i++)
                {
                    if(num % i == 0)
                    {
                        Isprime = false;
                        break;
                    }
                }
               if(Isprime)
                {
                    Console.Write(num+"\t");
                }
                Isprime = true;
            }
            
        }
    }
}
