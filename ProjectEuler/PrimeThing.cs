//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjectEuler
//{
//    class PrimeThing
//    {
//        void prime()
//        {
//            int number = 100;
//            HashSet<int> primeList = new HashSet<int>();
//            List<int> list = new List<int>();
//            List<int> tempList = new List<int>();

//            for (int i = 2; i < number; i++)
//            {
//                list.Add(i);
//                tempList.Add(i);
//            }

//            primeList.Add(2);
//            primeList.Add(3);
//            primeList.Add(5);

//            foreach (int x in list)
//            {
//                foreach (int s in primeList)
//                {
//                    if (x % s == 0)
//                    {
//                        tempList.Remove(x);
//                        break;
//                    }
//                }
//            }
//            foreach (int w in tempList)
//            {
//                Console.WriteLine(w);

//            }
//            Console.WriteLine(tempList.count);
//            Console.ReadKey();
//        }
//    }
//}
