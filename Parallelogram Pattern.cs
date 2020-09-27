using System;

namespace Star_Pattern
{
    class ByDenisRafi
    {
        static void Main()
        {
            Console.Title = "Parallelogram Pattern";
            int size = 8;
            for (int row = 1; row <= size; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= size; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

