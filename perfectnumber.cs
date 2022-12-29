using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    

namespace logicprograms
    {
        internal class perfectnumber
        {
            public static void checkperfectnumber()
            {
                int n, i, sum;
                int mn, mx;
                Console.WriteLine("find the perfect numbers within a given number of set");
                Console.WriteLine("Input the starting range of number ");
                mn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the ending range of number ");
                mx = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("To perfect numbers withing the given range :");
                for (n = mn; n < mx; n++)
                {
                    i = 1;
                    sum = 0;
                    while (i < n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == n)
                        Console.Write("{0} ", n);
                }
            }
        }
    }












