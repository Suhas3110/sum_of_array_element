using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_array_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[5];
            int sum = 0;
            Console.WriteLine("Enter the array Element");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of array Element");
            for(int i = 0;i < arr.Length; i++)
            {
                sum=sum+arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
