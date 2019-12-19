using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class ONE
    {
        public void first()
        {
            int x = 0;
            for (int i = 0; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    x += i;
                }
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }

    }
}
