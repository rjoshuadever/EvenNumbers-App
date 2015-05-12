using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fizzBuzz = new int[100];

            for (int i = 0; i < 100; i++)
            {
                fizzBuzz[i] = (i + 1);
                //Console.WriteLine(fizzBuzz[i]);
            }

            for (int ii = 0; ii < fizzBuzz.Length; ii++)
            {
                if ((fizzBuzz[ii] % 5) == 0 && (fizzBuzz[ii] % 3) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((fizzBuzz[ii] % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if ((fizzBuzz[ii] % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(fizzBuzz[ii]);
                }
            }
            Console.ReadLine();




        }
    }
}


