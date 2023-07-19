using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the Array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            //input elements of the array
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter elements {i+1} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //sorting the array using the anonymous method
            Array.Sort(arr, delegate (int a, int b)
            {
                return a.CompareTo(b);
            });
            Console.WriteLine("Sorted Array in Ascending order : ");
            foreach(int num in arr)
            {
                Console.WriteLine(num + "");
            }
            Console.ReadLine();
        }
    }
}
