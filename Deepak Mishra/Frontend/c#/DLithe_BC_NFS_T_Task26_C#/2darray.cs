using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_task_26
{
    internal class _2darray
    {

        public class Example
        {
            public static void Main()
            {
                int[,] array = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0} ", array[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
    

