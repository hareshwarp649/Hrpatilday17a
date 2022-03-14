using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserSort
{
    internal class RangePrime
    {
        public static void PrimeRange()
        {
            int num, end,i,j,flag;
            Console.WriteLine("Welcome Prime Number");
            Console.WriteLine("Enter the start Range");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end Range");
            end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Range Of prime number");
            for (i=num;i<end;i++)
            {
                    if (i == 1 || i == 0)
                        continue;
                    flag = 1;

                for (j = 2; j <= i / 2; j++)
                {

                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                    if (flag == 1)
                    
                Console.WriteLine( i);
                
            }
        }
    }
}
