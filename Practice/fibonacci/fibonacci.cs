using System;

namespace fibonacci
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            int n = 6;
            getFibSeq(n);
            Console.WriteLine(getFibSeq(n));
            Console.ReadLine();
        }

        static int getFibSeq(int element)
        {
            if (element >= 3)
            {
                //Console.WriteLine(getFibSeq(element - 1) + getFibSeq(element - 2));
                return getFibSeq(element - 1) + getFibSeq(element - 2);
            }
            else return 1;
        }
    }
}
