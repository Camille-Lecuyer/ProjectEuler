using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Three
    {
        void problem3()
        {
            long number = 600851475143;
            long div = 2;
            long maxFact;

            while (number != 0)
            {
                if (number % div != 0)
                {
                    div++;
                }
                else
                {
                    maxFact = number;
                    number = number / div;
                    if (number == 1)
                    {
                        Console.WriteLine(maxFact + " is the largest prime factor");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
