using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class SecondProblem
    {
        public void result()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            int result = 0;
            for (int y = 2; list.ElementAt(list.Count - 1) <= 4000000; y++)
            {
                int x = list.ElementAt(y - 1) + list.ElementAt(y - 2);
                list.Add(x);
            }
            foreach (int s in list)
            {
                if (s % 2 == 0)
                {
                    result += s;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
