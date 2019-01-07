using System;
using System.Collections.Generic;

namespace commonElement
{
    class commonElement
    {
        static void Main(string[] args)
        {
            /// Here is a way to find common elements within 2 array and output the elements 
            /// to a new array
            int[] A = { 1, 3, 4, 6, 7, 9 };
            int[] B = {1, 2, 4, 5, 9, 10};
            common_element(A, B);
            Console.ReadLine();
        }

        static List<int> common_element(int[] A, int[] B)
        {
            List<int> res = new List<int>();
            int pointerA = 0;
            int pointerB = 0;

            while(pointerA != A.Length-1 && pointerB != B.Length-1)
            {
                if (A[pointerA] == B[pointerB])
                {
                    res.Add(A[pointerA]);
                    pointerA += 1;
                    Console.WriteLine($"two elements are the same, adding {A[pointerA]}...");
                    Console.WriteLine("Increasing pointerA to:");
                    Console.WriteLine(pointerA);
                    pointerB += 1;
                    Console.WriteLine("Increasing pointerB to:");
                    Console.WriteLine(pointerB);
                }
                else if (A[pointerA] > B[pointerB])
                {
                    pointerB += 1;
                    Console.WriteLine($"A={A[pointerA]} is greater than B={B[pointerB]}");
                    Console.WriteLine("Increasing pointerB to:");
                    Console.WriteLine(pointerB);
                }
                else
                {
                    pointerA += 1;
                    Console.WriteLine($"A={A[pointerA]} is less than B={B[pointerB]}");
                    Console.WriteLine("Increasing pointerA to:");
                    Console.WriteLine(pointerA);
                }
            }

            Console.WriteLine("Resulting common array is:");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            return res;
        }
    }
}
