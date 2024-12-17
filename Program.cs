using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers seperated by spaces");
            string numinput = Console.ReadLine();  

            string[] breakUp = numinput.Split(' '); //Spilt by spaces
            int[] intArray = new int[breakUp.Length];
            
            for(int i = 0; i < breakUp.Length; i++)
            {
                intArray[i] = int.Parse(breakUp[i]);
            }

            Console.WriteLine();

            Sort(intArray);

            foreach(int i in intArray)
            {
                Console.Write($"{i} ");
            }
            
            
        }

        static void Sort(int[] a)
        {
            for (int h = a.Length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < a.Length; i++)
                {
                    int j = i;
                    int ai = a[i];
                    while (j >= h && a[j-h] > ai)
                    {
                        a[j] = a[j - h];
                        j -= h;
                    }
                    a[j] = ai;
                }
            }
        }



       













    }
}
