using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserSort
{
    internal class MergeSort
    {
        public static void SortMerge(int[] arr, int a, int b, int c)
        {
            Console.WriteLine("Bubblesort Sort");
            Console.WriteLine("Initial Array is:");
            int[] arra = { 54, 89, 52, 12, 46, 25, 41, 35, 35 ,56};
            int n = 10, i, j, k;

            int n1 = b - a + 1;
            int n2 = c - b;
            int[] L = new int[n1];
            int[] R = new int[n1];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arra[i] + "");
                Console.WriteLine("Enter the number\n");

            }


            for (i = 0; i < n1; i++)
            {
                L[i] = arra[a + 1];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = arr[b + 1 + j];
            }
            i = 0;
            j = 0;
            k = a;
            while (i < n1 && j < 2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (i < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

             public void SortArra(int[] arr, int a, int c)
            {
                if (a < c)
                {
                    int b = (a + c) / 2;
                    SortArra(arr, a, b);
                    SortArra(arr, a + 1, c);
                    SortMerge(arr, a, b, c);
                }
            }
            
        
    }

}
