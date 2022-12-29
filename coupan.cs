using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalproblems
{
    public  class coupanNumber
        {
            public static void Coupon()
            {
                var numbers = "0123456789ABCDEFGHIJKLMNOPQRST";
                var array = new char[6];
                var random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = numbers[random.Next(numbers.Length)];
                }
                var finalString = new String(array);
                Console.WriteLine("The distinct coupon number is: " + finalString);
                Console.ReadLine();
            }
        }

    }
    

