using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExplained
{
    delegate int NumberChanger(int n);

    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate delegates
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(TestDelegate.AddNum);
            NumberChanger nc2 = new NumberChanger(TestDelegate.MultiNum);

            nc = nc1;
            nc += nc2;

            //Calling multicast
            nc(5);
            Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());
            Console.ReadKey();
        }
    }
}
