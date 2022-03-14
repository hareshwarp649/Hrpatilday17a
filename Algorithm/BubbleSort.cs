using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserSort
{
    internal class BubbleSort
    {
        public static void SortBubble()
        {
            int[] sortarray ={ 12, 45, 85, 56, 25 };
            int n=5, i, j, val;   
            Console.WriteLine("Bubblesort Sort");
            Console.WriteLine("Initial Array is:");

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(sortarray[i] + "");
                Console.WriteLine("Enter the number\n");

            }
            for (j = 0; j <= sortarray.Length - 2; j++)
            {
               
                    for (i = 1; i <= sortarray.Length - 2; i++)
                    {
                    if (sortarray[i] > sortarray[i+1])
                    {
                        val = sortarray[i+1];
                        sortarray[i + 1] = sortarray[i];
                        sortarray[i] = val;
                       
                    }
                    
                }
            }
            Console.WriteLine("\n Sorted Array is :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(sortarray[i] + " ");
            }
        }
    }
}
