using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalproblems
{
    
        internal class PrimeNumbers
        {
            public static void Prime()
            {
                int flag = 0;
                Console.WriteLine("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 2)
                {
                    Console.WriteLine("Number is a prime number");
                }
                else
                {
                    Console.WriteLine("Number is not a prime number");
                }
                Console.ReadLine();
            }
        }
    }

