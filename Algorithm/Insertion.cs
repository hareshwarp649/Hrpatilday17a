using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserSort
{
     class Insertion
    {
        public static void SortInsert() 
        { 

        int[] sortarray = new int[5] { 12, 45, 85, 56, 25 };
        int n = 5, i, j, val, flag;
        Console.WriteLine("Insertion Sort");
            Console.WriteLine("Initial Array is:");

            for (i= 0;i<n; i++)
            {
                Console.WriteLine(sortarray[i] + "");

            }
            for(i=1;i<n;i++)
            {
                val = sortarray[i];
                flag = 0;
                for(j=i-1;j>=0 && flag!=1;)
                {
                    if (val<sortarray[j])
                    {
                        sortarray[j + 1] = sortarray[j];
                        j--;
                        sortarray[j + 1] = val;


                    }
                    else flag = 1;
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
